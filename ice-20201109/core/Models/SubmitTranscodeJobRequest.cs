// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitTranscodeJobRequest : TeaModel {
        [NameInMap("InputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestInputGroup> InputGroup { get; set; }
        public class SubmitTranscodeJobRequestInputGroup : TeaModel {
            [NameInMap("InputUrl")]
            [Validation(Required=false)]
            public string InputUrl { get; set; }

            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OutputGroup")]
        [Validation(Required=false)]
        public List<SubmitTranscodeJobRequestOutputGroup> OutputGroup { get; set; }
        public class SubmitTranscodeJobRequestOutputGroup : TeaModel {
            [NameInMap("Output")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupOutput Output { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupOutput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("OutputUrl")]
                [Validation(Required=false)]
                public string OutputUrl { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("ProcessConfig")]
            [Validation(Required=false)]
            public SubmitTranscodeJobRequestOutputGroupProcessConfig ProcessConfig { get; set; }
            public class SubmitTranscodeJobRequestOutputGroupProcessConfig : TeaModel {
                [NameInMap("CombineConfigs")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigCombineConfigs> CombineConfigs { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigCombineConfigs : TeaModel {
                    [NameInMap("AudioIndex")]
                    [Validation(Required=false)]
                    public string AudioIndex { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public double? Duration { get; set; }

                    [NameInMap("Start")]
                    [Validation(Required=false)]
                    public double? Start { get; set; }

                    [NameInMap("VideoIndex")]
                    [Validation(Required=false)]
                    public string VideoIndex { get; set; }

                }

                [NameInMap("Encryption")]
                [Validation(Required=false)]
                public SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption Encryption { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigEncryption : TeaModel {
                    [NameInMap("CipherText")]
                    [Validation(Required=false)]
                    public string CipherText { get; set; }

                    [NameInMap("DecryptKeyUri")]
                    [Validation(Required=false)]
                    public string DecryptKeyUri { get; set; }

                    [NameInMap("EncryptType")]
                    [Validation(Required=false)]
                    public string EncryptType { get; set; }

                    [NameInMap("KeyServiceType")]
                    [Validation(Required=false)]
                    public string KeyServiceType { get; set; }

                }

                [NameInMap("ImageWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarks : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                        [NameInMap("Dx")]
                        [Validation(Required=false)]
                        public string Dx { get; set; }

                        [NameInMap("Dy")]
                        [Validation(Required=false)]
                        public string Dy { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                            [NameInMap("Media")]
                            [Validation(Required=false)]
                            public string Media { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        [NameInMap("ReferPos")]
                        [Validation(Required=false)]
                        public string ReferPos { get; set; }

                        [NameInMap("Timeline")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                            [NameInMap("Start")]
                            [Validation(Required=false)]
                            public string Start { get; set; }

                        }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

                [NameInMap("IsInheritTags")]
                [Validation(Required=false)]
                public bool? IsInheritTags { get; set; }

                [NameInMap("Subtitles")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitles : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
                        [NameInMap("CharEnc")]
                        [Validation(Required=false)]
                        public string CharEnc { get; set; }

                        [NameInMap("File")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                            [NameInMap("Media")]
                            [Validation(Required=false)]
                            public string Media { get; set; }

                            [NameInMap("Type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

                [NameInMap("TextWatermarks")]
                [Validation(Required=false)]
                public List<SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarks : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
                        [NameInMap("Adaptive")]
                        [Validation(Required=false)]
                        public string Adaptive { get; set; }

                        [NameInMap("BorderColor")]
                        [Validation(Required=false)]
                        public string BorderColor { get; set; }

                        [NameInMap("BorderWidth")]
                        [Validation(Required=false)]
                        public int? BorderWidth { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("FontAlpha")]
                        [Validation(Required=false)]
                        public string FontAlpha { get; set; }

                        [NameInMap("FontColor")]
                        [Validation(Required=false)]
                        public string FontColor { get; set; }

                        [NameInMap("FontName")]
                        [Validation(Required=false)]
                        public string FontName { get; set; }

                        [NameInMap("FontSize")]
                        [Validation(Required=false)]
                        public int? FontSize { get; set; }

                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public string Left { get; set; }

                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public string Top { get; set; }

                    }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

                [NameInMap("Transcode")]
                [Validation(Required=false)]
                public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode Transcode { get; set; }
                public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscode : TeaModel {
                    [NameInMap("OverwriteParams")]
                    [Validation(Required=false)]
                    public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                    public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }

                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }

                            [NameInMap("Volume")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
                                [NameInMap("IntegratedLoudnessTarget")]
                                [Validation(Required=false)]
                                public string IntegratedLoudnessTarget { get; set; }

                                [NameInMap("LoudnessRangeTarget")]
                                [Validation(Required=false)]
                                public string LoudnessRangeTarget { get; set; }

                                [NameInMap("Method")]
                                [Validation(Required=false)]
                                public string Method { get; set; }

                                [NameInMap("TruePeak")]
                                [Validation(Required=false)]
                                public string TruePeak { get; set; }

                            }

                        }

                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }

                        [NameInMap("MuxConfig")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                            public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                                [NameInMap("ForceSegTime")]
                                [Validation(Required=false)]
                                public string ForceSegTime { get; set; }

                            }

                        }

                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public Dictionary<string, string> Tags { get; set; }

                        [NameInMap("TransConfig")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig TransConfig { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsTransConfig : TeaModel {
                            [NameInMap("AdjDarMethod")]
                            [Validation(Required=false)]
                            public string AdjDarMethod { get; set; }

                            [NameInMap("IsCheckAudioBitrate")]
                            [Validation(Required=false)]
                            public string IsCheckAudioBitrate { get; set; }

                            [NameInMap("IsCheckAudioBitrateFail")]
                            [Validation(Required=false)]
                            public string IsCheckAudioBitrateFail { get; set; }

                            [NameInMap("IsCheckReso")]
                            [Validation(Required=false)]
                            public string IsCheckReso { get; set; }

                            [NameInMap("IsCheckResoFail")]
                            [Validation(Required=false)]
                            public string IsCheckResoFail { get; set; }

                            [NameInMap("IsCheckVideoBitrate")]
                            [Validation(Required=false)]
                            public string IsCheckVideoBitrate { get; set; }

                            [NameInMap("IsCheckVideoBitrateFail")]
                            [Validation(Required=false)]
                            public string IsCheckVideoBitrateFail { get; set; }

                            [NameInMap("TransMode")]
                            [Validation(Required=false)]
                            public string TransMode { get; set; }

                        }

                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                        public class SubmitTranscodeJobRequestOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
                            [NameInMap("AbrMax")]
                            [Validation(Required=false)]
                            public string AbrMax { get; set; }

                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }

                            [NameInMap("Bufsize")]
                            [Validation(Required=false)]
                            public string Bufsize { get; set; }

                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }

                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }

                            [NameInMap("Crop")]
                            [Validation(Required=false)]
                            public string Crop { get; set; }

                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }

                            [NameInMap("Gop")]
                            [Validation(Required=false)]
                            public string Gop { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("LongShortMode")]
                            [Validation(Required=false)]
                            public string LongShortMode { get; set; }

                            [NameInMap("Maxrate")]
                            [Validation(Required=false)]
                            public string Maxrate { get; set; }

                            [NameInMap("Pad")]
                            [Validation(Required=false)]
                            public string Pad { get; set; }

                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }

                            [NameInMap("Preset")]
                            [Validation(Required=false)]
                            public string Preset { get; set; }

                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }

                            [NameInMap("Remove")]
                            [Validation(Required=false)]
                            public string Remove { get; set; }

                            [NameInMap("ScanMode")]
                            [Validation(Required=false)]
                            public string ScanMode { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }

                    }

                    [NameInMap("TemplateId")]
                    [Validation(Required=false)]
                    public string TemplateId { get; set; }

                }

            }

        }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitTranscodeJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitTranscodeJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
