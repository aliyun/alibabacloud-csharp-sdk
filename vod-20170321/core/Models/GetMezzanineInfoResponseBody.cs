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
                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("ChannelLayout")]
                [Validation(Required=false)]
                public string ChannelLayout { get; set; }

                [NameInMap("Channels")]
                [Validation(Required=false)]
                public string Channels { get; set; }

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
                public string Duration { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                [NameInMap("NumFrames")]
                [Validation(Required=false)]
                public string NumFrames { get; set; }

                [NameInMap("SampleFmt")]
                [Validation(Required=false)]
                public string SampleFmt { get; set; }

                [NameInMap("SampleRate")]
                [Validation(Required=false)]
                public string SampleRate { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Timebase")]
                [Validation(Required=false)]
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
                [NameInMap("AvgFPS")]
                [Validation(Required=false)]
                public string AvgFPS { get; set; }

                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

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

                [NameInMap("Dar")]
                [Validation(Required=false)]
                public string Dar { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                [NameInMap("HasBFrames")]
                [Validation(Required=false)]
                public string HasBFrames { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public string Height { get; set; }

                [NameInMap("Index")]
                [Validation(Required=false)]
                public string Index { get; set; }

                [NameInMap("Lang")]
                [Validation(Required=false)]
                public string Lang { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("NumFrames")]
                [Validation(Required=false)]
                public string NumFrames { get; set; }

                [NameInMap("PixFmt")]
                [Validation(Required=false)]
                public string PixFmt { get; set; }

                [NameInMap("Profile")]
                [Validation(Required=false)]
                public string Profile { get; set; }

                [NameInMap("Rotate")]
                [Validation(Required=false)]
                public string Rotate { get; set; }

                [NameInMap("Sar")]
                [Validation(Required=false)]
                public string Sar { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Timebase")]
                [Validation(Required=false)]
                public string Timebase { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public string Width { get; set; }

            }

            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
