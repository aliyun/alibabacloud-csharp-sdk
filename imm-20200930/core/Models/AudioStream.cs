// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AudioStream : TeaModel {
        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

        [NameInMap("ChannelLayout")]
        [Validation(Required=false)]
        public string ChannelLayout { get; set; }

        [NameInMap("Channels")]
        [Validation(Required=false)]
        public long? Channels { get; set; }

        [NameInMap("CodecLongName")]
        [Validation(Required=false)]
        public string CodecLongName { get; set; }

        [NameInMap("CodecName")]
        [Validation(Required=false)]
        public string CodecName { get; set; }

        [NameInMap("CodecTag")]
        [Validation(Required=false)]
        public string CodecTag { get; set; }

        [NameInMap("CodecTagString")]
        [Validation(Required=false)]
        public string CodecTagString { get; set; }

        [NameInMap("CodecTimeBase")]
        [Validation(Required=false)]
        public string CodecTimeBase { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        [NameInMap("FrameCount")]
        [Validation(Required=false)]
        public long? FrameCount { get; set; }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Lyric")]
        [Validation(Required=false)]
        public string Lyric { get; set; }

        [NameInMap("SampleFormat")]
        [Validation(Required=false)]
        public string SampleFormat { get; set; }

        [NameInMap("SampleRate")]
        [Validation(Required=false)]
        public long? SampleRate { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        [NameInMap("TimeBase")]
        [Validation(Required=false)]
        public string TimeBase { get; set; }

    }

}
