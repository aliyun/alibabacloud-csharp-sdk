// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AudioStream : TeaModel {
        /// <summary>
        /// Bitrate
        /// </summary>
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        /// <summary>
        /// ChannelLayout
        /// </summary>
        [NameInMap("ChannelLayout")]
        [Validation(Required=false)]
        public string ChannelLayout { get; set; }

        /// <summary>
        /// Channels
        /// </summary>
        [NameInMap("Channels")]
        [Validation(Required=false)]
        public long? Channels { get; set; }

        /// <summary>
        /// CodecLongName
        /// </summary>
        [NameInMap("CodecLongName")]
        [Validation(Required=false)]
        public string CodecLongName { get; set; }

        /// <summary>
        /// CodecName
        /// </summary>
        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        /// <summary>
        /// CodecTag
        /// </summary>
        [NameInMap("CodecTag")]
        [Validation(Required=false)]
        public string CodecTag { get; set; }

        /// <summary>
        /// CodecTagString
        /// </summary>
        [NameInMap("CodecTagString")]
        [Validation(Required=false)]
        public string CodecTagString { get; set; }

        /// <summary>
        /// CodecTimeBase
        /// </summary>
        [NameInMap("CodecTimeBase")]
        [Validation(Required=false)]
        public string CodecTimeBase { get; set; }

        /// <summary>
        /// Duration
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        /// <summary>
        /// FrameCount
        /// </summary>
        [NameInMap("FrameCount")]
        [Validation(Required=false)]
        public long? FrameCount { get; set; }

        /// <summary>
        /// Index
        /// </summary>
        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// Lyric
        /// </summary>
        [NameInMap("Lyric")]
        [Validation(Required=false)]
        public string Lyric { get; set; }

        /// <summary>
        /// SampleFormat
        /// </summary>
        [NameInMap("SampleFormat")]
        [Validation(Required=false)]
        public string SampleFormat { get; set; }

        /// <summary>
        /// SampleRate
        /// </summary>
        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public long? SampleRate { get; set; }

        /// <summary>
        /// StartTime
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        /// <summary>
        /// TimeBase
        /// </summary>
        [NameInMap("TimeBase")]
        [Validation(Required=false)]
        public string TimeBase { get; set; }

    }

}
