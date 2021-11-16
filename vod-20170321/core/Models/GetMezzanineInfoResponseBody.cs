// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMezzanineInfoResponseBody : TeaModel {
        [NameInMap("Mezzanine")]
        [Validation(Required=false)]
        public GetMezzanineInfoResponseBodyMezzanine Mezzanine { get; set; }
        public class GetMezzanineInfoResponseBodyMezzanine : TeaModel {
            [NameInMap("AudioStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineAudioStreamList> AudioStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineAudioStreamList : TeaModel {
                public string Bitrate { get; set; }
                public string ChannelLayout { get; set; }
                public string Channels { get; set; }
                public string CodecLongName { get; set; }
                public string CodecName { get; set; }
                public string CodecTag { get; set; }
                public string CodecTagString { get; set; }
                public string CodecTimeBase { get; set; }
                public string Duration { get; set; }
                public string Index { get; set; }
                public string Lang { get; set; }
                public string NumFrames { get; set; }
                public string SampleFmt { get; set; }
                public string SampleRate { get; set; }
                public string StartTime { get; set; }
                public string Timebase { get; set; }
            }
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }
            [NameInMap("OutputType")]
            [Validation(Required=false)]
            public string OutputType { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }
            [NameInMap("VideoStreamList")]
            [Validation(Required=false)]
            public List<GetMezzanineInfoResponseBodyMezzanineVideoStreamList> VideoStreamList { get; set; }
            public class GetMezzanineInfoResponseBodyMezzanineVideoStreamList : TeaModel {
                public string AvgFPS { get; set; }
                public string Bitrate { get; set; }
                public string CodecLongName { get; set; }
                public string CodecName { get; set; }
                public string CodecTag { get; set; }
                public string CodecTagString { get; set; }
                public string CodecTimeBase { get; set; }
                public string Dar { get; set; }
                public string Duration { get; set; }
                public string Fps { get; set; }
                public string HDRType { get; set; }
                public string HasBFrames { get; set; }
                public string Height { get; set; }
                public string Index { get; set; }
                public string Lang { get; set; }
                public string Level { get; set; }
                public string NumFrames { get; set; }
                public string PixFmt { get; set; }
                public string Profile { get; set; }
                public string Rotate { get; set; }
                public string Sar { get; set; }
                public string StartTime { get; set; }
                public string Timebase { get; set; }
                public string Width { get; set; }
            }
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
