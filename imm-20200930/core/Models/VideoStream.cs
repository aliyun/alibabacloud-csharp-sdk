// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoStream : TeaModel {
        [NameInMap("AverageFrameRate")]
        [Validation(Required=false)]
        public string AverageFrameRate { get; set; }

        [NameInMap("BitDepth")]
        [Validation(Required=false)]
        public long? BitDepth { get; set; }

        [NameInMap("Bitrate")]
        [Validation(Required=false)]
        public long? Bitrate { get; set; }

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

        [NameInMap("ColorPrimaries")]
        [Validation(Required=false)]
        public string ColorPrimaries { get; set; }

        [NameInMap("ColorRange")]
        [Validation(Required=false)]
        public string ColorRange { get; set; }

        [NameInMap("ColorSpace")]
        [Validation(Required=false)]
        public string ColorSpace { get; set; }

        [NameInMap("ColorTransfer")]
        [Validation(Required=false)]
        public string ColorTransfer { get; set; }

        [NameInMap("DisplayAspectRatio")]
        [Validation(Required=false)]
        public string DisplayAspectRatio { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public double? Duration { get; set; }

        [NameInMap("FrameCount")]
        [Validation(Required=false)]
        public long? FrameCount { get; set; }

        [NameInMap("FrameRate")]
        [Validation(Required=false)]
        public string FrameRate { get; set; }

        [NameInMap("HasBFrames")]
        [Validation(Required=false)]
        public long? HasBFrames { get; set; }

        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public long? Index { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public long? Level { get; set; }

        [NameInMap("PixelFormat")]
        [Validation(Required=false)]
        public string PixelFormat { get; set; }

        [NameInMap("Profile")]
        [Validation(Required=false)]
        public string Profile { get; set; }

        [NameInMap("Rotate")]
        [Validation(Required=false)]
        public string Rotate { get; set; }

        [NameInMap("SampleAspectRatio")]
        [Validation(Required=false)]
        public string SampleAspectRatio { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public double? StartTime { get; set; }

        [NameInMap("TimeBase")]
        [Validation(Required=false)]
        public string TimeBase { get; set; }

        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
