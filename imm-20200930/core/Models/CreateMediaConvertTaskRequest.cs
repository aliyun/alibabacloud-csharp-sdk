// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CreateMediaConvertTaskRequest : TeaModel {
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("NotifyEndpoint")]
        [Validation(Required=false)]
        public string NotifyEndpoint { get; set; }

        [NameInMap("NotifyTopicName")]
        [Validation(Required=false)]
        public string NotifyTopicName { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestSources> Sources { get; set; }
        public class CreateMediaConvertTaskRequestSources : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public float? StartTime { get; set; }

            [NameInMap("Subtitles")]
            [Validation(Required=false)]
            public List<CreateMediaConvertTaskRequestSourcesSubtitles> Subtitles { get; set; }
            public class CreateMediaConvertTaskRequestSourcesSubtitles : TeaModel {
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                [NameInMap("TimeOffset")]
                [Validation(Required=false)]
                public float? TimeOffset { get; set; }

                [NameInMap("URI")]
                [Validation(Required=false)]
                public string URI { get; set; }

            }

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

        [NameInMap("Targets")]
        [Validation(Required=false)]
        public List<CreateMediaConvertTaskRequestTargets> Targets { get; set; }
        public class CreateMediaConvertTaskRequestTargets : TeaModel {
            [NameInMap("Audio")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsAudio Audio { get; set; }
            public class CreateMediaConvertTaskRequestTargetsAudio : TeaModel {
                [NameInMap("DisableAudio")]
                [Validation(Required=false)]
                public bool? DisableAudio { get; set; }
                [NameInMap("FilterAudio")]
                [Validation(Required=false)]
                public CreateMediaConvertTaskRequestTargetsAudioFilterAudio FilterAudio { get; set; }
                public class CreateMediaConvertTaskRequestTargetsAudioFilterAudio : TeaModel {
                    [NameInMap("Mixing")]
                    [Validation(Required=false)]
                    public bool? Mixing { get; set; }

                }
                [NameInMap("TranscodeAudio")]
                [Validation(Required=false)]
                public CreateMediaConvertTaskRequestTargetsAudioTranscodeAudio TranscodeAudio { get; set; }
                public class CreateMediaConvertTaskRequestTargetsAudioTranscodeAudio : TeaModel {
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public int? Bitrate { get; set; }

                    [NameInMap("BitrateOption")]
                    [Validation(Required=false)]
                    public string BitrateOption { get; set; }

                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public int? Channel { get; set; }

                    [NameInMap("Codec")]
                    [Validation(Required=false)]
                    public string Codec { get; set; }

                    [NameInMap("Quality")]
                    [Validation(Required=false)]
                    public int? Quality { get; set; }

                    [NameInMap("SampleRate")]
                    [Validation(Required=false)]
                    public int? SampleRate { get; set; }

                    [NameInMap("SampleRateOption")]
                    [Validation(Required=false)]
                    public string SampleRateOption { get; set; }

                }
            };

            [NameInMap("Container")]
            [Validation(Required=false)]
            public string Container { get; set; }

            [NameInMap("Image")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsImage Image { get; set; }
            public class CreateMediaConvertTaskRequestTargetsImage : TeaModel {
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public List<CreateMediaConvertTaskRequestTargetsImageSnapshots> Snapshots { get; set; }
                public class CreateMediaConvertTaskRequestTargetsImageSnapshots : TeaModel {
                    public string Format { get; set; }
                    public int? Height { get; set; }
                    public float? Interval { get; set; }
                    public int? Number { get; set; }
                    public string ScaleType { get; set; }
                    public float? StartTime { get; set; }
                    public string URI { get; set; }
                    public int? Width { get; set; }
                }
                [NameInMap("Sprites")]
                [Validation(Required=false)]
                public List<CreateMediaConvertTaskRequestTargetsImageSprites> Sprites { get; set; }
                public class CreateMediaConvertTaskRequestTargetsImageSprites : TeaModel {
                    public string Format { get; set; }
                    public float? Interval { get; set; }
                    public int? Margin { get; set; }
                    public int? Number { get; set; }
                    public int? Pad { get; set; }
                    public float? ScaleHeight { get; set; }
                    public string ScaleType { get; set; }
                    public float? ScaleWidth { get; set; }
                    public float? StartTime { get; set; }
                    public int? TileHeight { get; set; }
                    public int? TileWidth { get; set; }
                    public string URI { get; set; }
                }
            };

            [NameInMap("Preset")]
            [Validation(Required=false)]
            public PresetReference Preset { get; set; }

            [NameInMap("Segment")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsSegment Segment { get; set; }
            public class CreateMediaConvertTaskRequestTargetsSegment : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }
                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }
                [NameInMap("StartNumber")]
                [Validation(Required=false)]
                public int? StartNumber { get; set; }
            };

            [NameInMap("Speed")]
            [Validation(Required=false)]
            public float? Speed { get; set; }

            [NameInMap("Subtitle")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsSubtitle Subtitle { get; set; }
            public class CreateMediaConvertTaskRequestTargetsSubtitle : TeaModel {
                [NameInMap("DisableSubtitle")]
                [Validation(Required=false)]
                public bool? DisableSubtitle { get; set; }
                [NameInMap("ExtractSubtitle")]
                [Validation(Required=false)]
                public CreateMediaConvertTaskRequestTargetsSubtitleExtractSubtitle ExtractSubtitle { get; set; }
                public class CreateMediaConvertTaskRequestTargetsSubtitleExtractSubtitle : TeaModel {
                    [NameInMap("Format")]
                    [Validation(Required=false)]
                    public string Format { get; set; }

                    [NameInMap("URI")]
                    [Validation(Required=false)]
                    public string URI { get; set; }

                }
            };

            [NameInMap("URI")]
            [Validation(Required=false)]
            public string URI { get; set; }

            [NameInMap("Video")]
            [Validation(Required=false)]
            public CreateMediaConvertTaskRequestTargetsVideo Video { get; set; }
            public class CreateMediaConvertTaskRequestTargetsVideo : TeaModel {
                [NameInMap("DisableVideo")]
                [Validation(Required=false)]
                public bool? DisableVideo { get; set; }
                [NameInMap("FilterVideo")]
                [Validation(Required=false)]
                public CreateMediaConvertTaskRequestTargetsVideoFilterVideo FilterVideo { get; set; }
                public class CreateMediaConvertTaskRequestTargetsVideoFilterVideo : TeaModel {
                    [NameInMap("Delogos")]
                    [Validation(Required=false)]
                    public List<CreateMediaConvertTaskRequestTargetsVideoFilterVideoDelogos> Delogos { get; set; }
                    public class CreateMediaConvertTaskRequestTargetsVideoFilterVideoDelogos : TeaModel {
                        [NameInMap("Durtion")]
                        [Validation(Required=false)]
                        public float? Durtion { get; set; }

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
                        public float? StartTime { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public float? Width { get; set; }

                    }

                    [NameInMap("Watermarks")]
                    [Validation(Required=false)]
                    public List<CreateMediaConvertTaskRequestTargetsVideoFilterVideoWatermarks> Watermarks { get; set; }
                    public class CreateMediaConvertTaskRequestTargetsVideoFilterVideoWatermarks : TeaModel {
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
                        public float? Duration { get; set; }

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
                        public float? StartTime { get; set; }

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
                [NameInMap("TranscodeVideo")]
                [Validation(Required=false)]
                public CreateMediaConvertTaskRequestTargetsVideoTranscodeVideo TranscodeVideo { get; set; }
                public class CreateMediaConvertTaskRequestTargetsVideoTranscodeVideo : TeaModel {
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

                }
            };

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
