﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using Windows.Storage.Streams;

namespace UWPShoutcastMSS.Streaming.Providers
{
    internal interface IAudioProvider
    {
        Task<Tuple<MediaStreamSample, uint>> ParseSampleAsync(ShoutcastStreamProcessor processor, DataReader socketReader, bool partial = false, byte[] partialBytes = null);

        uint GetSampleSize();

        uint HeaderLength { get; }

        StreamAudioFormat AudioFormat { get; }

        Task<ServerAudioInfo> GrabFrameInfoAsync(ShoutcastStreamProcessor processor, ServerAudioInfo serverSentInfo);
    }
}
