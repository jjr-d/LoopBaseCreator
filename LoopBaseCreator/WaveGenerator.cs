//-----------------------------------------------------
// WaveGenerator.cs
// A structure that wraps a wave file, generates 
//   audio data and saves it to a file
//
// Copyright (c) 2009 Dan Waters
// This code is provided AS-IS and is written by me,
// with no endorsement from Microsoft.
//-----------------------------------------------------

// Amended by Dan Jackson

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WaveFun
{
    /// <summary>
    /// Possible example waves to generate
    /// </summary>
    public enum WaveExampleType
    {
        ExampleSineWave = 0,
    }

    /// <summary>
    /// Wraps a WAV file struture and auto-generates some canned waveforms.
    /// </summary>
    public class WaveGenerator
    {
        // Header, Format, Data chunks
        WaveHeader header;
        WaveFormatChunk format;
        WaveDataChunk data;
        InfoChunk info;

        /// <summary>
        /// Initializes the object and generates a wave.
        /// </summary>
        /// <param name="type">The type of wave to generate</param>
        public WaveGenerator(WaveExampleType type, double freq, uint seconds)
        {
            // Init chunks
            header = new WaveHeader();
            format = new WaveFormatChunk();
            data = new WaveDataChunk();

            // Fill the data array with sample data
            switch (type)
            {
                case WaveExampleType.ExampleSineWave:

                    // Number of samples = sample rate * channels * bytes per sample
                    uint numSamples = format.dwSamplesPerSec * format.wChannels * seconds;

                    // Initialize the 16-bit array
                    data.shortArray = new short[numSamples];

                    int amplitude = 32760;  // Max amplitude for 16-bit audio

                    // The "angle" used in the function, adjusted for the number of channels and sample rate.
                    // This value is like the period of the wave.
                    double t = (Math.PI * 2 * freq) / (format.dwSamplesPerSec * format.wChannels);

                    for (uint i = 0; i < numSamples - 1; i++)
                    {
                        // Fill with a simple sine wave at max amplitude
                        for (int channel = 0; channel < format.wChannels; channel++)
                        {
                            data.shortArray[i + channel] = Convert.ToInt16(amplitude * Math.Sin(t * i));
                        }
                    }

                    // Calculate data chunk size in bytes
                    data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));

                    break;
            }
        }

        // JJR: create empty wav
        public WaveGenerator(uint sampleCount, string infoText)
        {
            // Init chunks
            header = new WaveHeader();
            format = new WaveFormatChunk();
            data = new WaveDataChunk();
            info = new InfoChunk(infoText);

            // Fill the data array with sample data

            uint numSamples = sampleCount;

            // Initialize the 16-bit array; default initialization to 0.
            data.shortArray = new short[numSamples];

            // Calculate data chunk size in bytes
            data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
        }

        /// <summary>
        /// Saves the current wave data to the specified file.
        /// </summary>
        /// <param name="filePath"></param>
        public void Save(string filePath)
        {
            // Create a file (it always overwrites)
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                Save(fileStream);
            }
        }

        public void Save(Stream stream)
        {
            // Use BinaryWriter to write the bytes to the file
            //using (var writer = new SafeBinaryWriter(stream))
            using (var writer = new BinaryWriter(stream))
            {
                // Write the header
                writer.Write(header.sGroupID.ToCharArray());
                writer.Write(header.dwFileLength);
                writer.Write(header.sRiffType.ToCharArray());

                if (info != null)
                {
                    // Write the info chunk
                    writer.Write(info.sChunkId.ToCharArray());
                    writer.Write(info.dwChunkSize);
                    writer.Write(info.infoText.ToCharArray());
                }

                // Write the format chunk
                writer.Write(format.sChunkID.ToCharArray());
                writer.Write(format.dwChunkSize);
                writer.Write(format.wFormatTag);
                writer.Write(format.wChannels);
                writer.Write(format.dwSamplesPerSec);
                writer.Write(format.dwAvgBytesPerSec);
                writer.Write(format.wBlockAlign);
                writer.Write(format.wBitsPerSample);

                // Write the data chunk
                writer.Write(data.sChunkID.ToCharArray());
                writer.Write(data.dwChunkSize);
                foreach (short dataPoint in data.shortArray)
                {
                    writer.Write(dataPoint);
                }

                // Fix file size in the header now that we know it.
                writer.Seek(4, SeekOrigin.Begin);
                uint filesize = (uint)writer.BaseStream.Length;
                writer.Write(filesize - 8);

            }
        }
    }
}
