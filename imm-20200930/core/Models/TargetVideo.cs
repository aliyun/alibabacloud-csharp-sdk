// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class TargetVideo : TeaModel {
        [NameInMap("DisableVideo")]
        [Validation(Required=false)]
        public bool? DisableVideo { get; set; }

        [NameInMap("FilterVideo")]
        [Validation(Required=false)]
        public TargetVideoFilterVideo FilterVideo { get; set; }
        public class TargetVideoFilterVideo : TeaModel {
            [NameInMap("Delogos")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoDelogos> Delogos { get; set; }
            public class TargetVideoFilterVideoDelogos : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                [NameInMap("Dy")]
                [Validation(Required=false)]
                public float? Dy { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public double? StartTime { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

            }

            [NameInMap("Desensitization")]
            [Validation(Required=false)]
            public TargetVideoFilterVideoDesensitization Desensitization { get; set; }
            public class TargetVideoFilterVideoDesensitization : TeaModel {
                [NameInMap("Face")]
                [Validation(Required=false)]
                public TargetVideoFilterVideoDesensitizationFace Face { get; set; }
                public class TargetVideoFilterVideoDesensitizationFace : TeaModel {
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                }

                [NameInMap("LicensePlate")]
                [Validation(Required=false)]
                public TargetVideoFilterVideoDesensitizationLicensePlate LicensePlate { get; set; }
                public class TargetVideoFilterVideoDesensitizationLicensePlate : TeaModel {
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    [NameInMap("MinSize")]
                    [Validation(Required=false)]
                    public int? MinSize { get; set; }

                }

            }

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            [NameInMap("Watermarks")]
            [Validation(Required=false)]
            public List<TargetVideoFilterVideoWatermarks> Watermarks { get; set; }
            public class TargetVideoFilterVideoWatermarks : TeaModel {
                [NameInMap("BorderColor")]
                [Validation(Required=false)]
                public string BorderColor { get; set; }

                [NameInMap("BorderWidth")]
                [Validation(Required=false)]
                public int? BorderWidth { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                [NameInMap("Dx")]
                [Validation(Required=false)]
                public float? Dx { get; set; }

                [NameInMap("Dy")]
                [Validation(Required=false)]
                public float? Dy { get; set; }

                [NameInMap("FontApha")]
                [Validation(Required=false)]
                public float? FontApha { get; set; }

                [NameInMap("FontColor")]
                [Validation(Required=false)]
                public string FontColor { get; set; }

                [NameInMap("FontName")]
                [Validation(Required=false)]
                public string FontName { get; set; }

                [NameInMap("FontSize")]
                [Validation(Required=false)]
                public int? FontSize { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public float? Height { get; set; }

                [NameInMap("ReferPos")]
                [Validation(Required=false)]
                public string ReferPos { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public double? StartTime { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public float? Width { get; set; }

            }

        }

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public List<int?> Stream { get; set; }

        [NameInMap("TranscodeVideo")]
        [Validation(Required=false)]
        public TargetVideoTranscodeVideo TranscodeVideo { get; set; }
        public class TargetVideoTranscodeVideo : TeaModel {
            [NameInMap("AdaptiveResolutionDirection")]
            [Validation(Required=false)]
            public bool? AdaptiveResolutionDirection { get; set; }

            [NameInMap("BFrames")]
            [Validation(Required=false)]
            public int? BFrames { get; set; }

            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public int? Bitrate { get; set; }

            [NameInMap("BitrateOption")]
            [Validation(Required=false)]
            public string BitrateOption { get; set; }

            [NameInMap("BufferSize")]
            [Validation(Required=false)]
            public int? BufferSize { get; set; }

            [NameInMap("CRF")]
            [Validation(Required=false)]
            public float? CRF { get; set; }

            [NameInMap("Codec")]
            [Validation(Required=false)]
            public string Codec { get; set; }

            [NameInMap("FrameRate")]
            [Validation(Required=false)]
            public float? FrameRate { get; set; }

            [NameInMap("FrameRateOption")]
            [Validation(Required=false)]
            public string FrameRateOption { get; set; }

            [NameInMap("GOPSize")]
            [Validation(Required=false)]
            public int? GOPSize { get; set; }

            [NameInMap("MaxBitrate")]
            [Validation(Required=false)]
            public int? MaxBitrate { get; set; }

            [NameInMap("PixelFormat")]
            [Validation(Required=false)]
            public string PixelFormat { get; set; }

            [NameInMap("Refs")]
            [Validation(Required=false)]
            public int? Refs { get; set; }

            [NameInMap("Resolution")]
            [Validation(Required=false)]
            public string Resolution { get; set; }

            [NameInMap("ResolutionOption")]
            [Validation(Required=false)]
            public string ResolutionOption { get; set; }

            [NameInMap("Rotation")]
            [Validation(Required=false)]
            public int? Rotation { get; set; }

            [NameInMap("ScaleType")]
            [Validation(Required=false)]
            public string ScaleType { get; set; }

            [NameInMap("VideoSlim")]
            [Validation(Required=false)]
            public int? VideoSlim { get; set; }

        }

    }

}
