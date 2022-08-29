// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTranscodeJobsResponseBody : TeaModel {
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListTranscodeJobsResponseBodyJobs> Jobs { get; set; }
        public class ListTranscodeJobsResponseBodyJobs : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }

            [NameInMap("InputGroup")]
            [Validation(Required=false)]
            public List<ListTranscodeJobsResponseBodyJobsInputGroup> InputGroup { get; set; }
            public class ListTranscodeJobsResponseBodyJobsInputGroup : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("JobCount")]
            [Validation(Required=false)]
            public int? JobCount { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OutputGroup")]
            [Validation(Required=false)]
            public List<ListTranscodeJobsResponseBodyJobsOutputGroup> OutputGroup { get; set; }
            public class ListTranscodeJobsResponseBodyJobsOutputGroup : TeaModel {
                [NameInMap("Output")]
                [Validation(Required=false)]
                public ListTranscodeJobsResponseBodyJobsOutputGroupOutput Output { get; set; }
                public class ListTranscodeJobsResponseBodyJobsOutputGroupOutput : TeaModel {
                    [NameInMap("Media")]
                    [Validation(Required=false)]
                    public string Media { get; set; }
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }
                };

                [NameInMap("ProcessConfig")]
                [Validation(Required=false)]
                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfig ProcessConfig { get; set; }
                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfig : TeaModel {
                    [NameInMap("ImageWatermarks")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks> ImageWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarks : TeaModel {
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParams : TeaModel {
                            [NameInMap("Dx")]
                            [Validation(Required=false)]
                            public string Dx { get; set; }

                            [NameInMap("Dy")]
                            [Validation(Required=false)]
                            public string Dy { get; set; }

                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsFile File { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsFile : TeaModel {
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }
                            };

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("ReferPos")]
                            [Validation(Required=false)]
                            public string ReferPos { get; set; }

                            [NameInMap("Timeline")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline Timeline { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigImageWatermarksOverwriteParamsTimeline : TeaModel {
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }
                                [NameInMap("Start")]
                                [Validation(Required=false)]
                                public string Start { get; set; }
                            };

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                        }
                        public string TemplateId { get; set; }
                    }
                    [NameInMap("Subtitles")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles> Subtitles { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitles : TeaModel {
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParams : TeaModel {
                            [NameInMap("CharEnc")]
                            [Validation(Required=false)]
                            public string CharEnc { get; set; }

                            [NameInMap("File")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParamsFile File { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigSubtitlesOverwriteParamsFile : TeaModel {
                                [NameInMap("Media")]
                                [Validation(Required=false)]
                                public string Media { get; set; }
                                [NameInMap("Type")]
                                [Validation(Required=false)]
                                public string Type { get; set; }
                            };

                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }

                        }
                        public string TemplateId { get; set; }
                    }
                    [NameInMap("TextWatermarks")]
                    [Validation(Required=false)]
                    public List<ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks> TextWatermarks { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarks : TeaModel {
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTextWatermarksOverwriteParams : TeaModel {
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
                        public string TemplateId { get; set; }
                    }
                    [NameInMap("Transcode")]
                    [Validation(Required=false)]
                    public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscode Transcode { get; set; }
                    public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscode : TeaModel {
                        [NameInMap("OverwriteParams")]
                        [Validation(Required=false)]
                        public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParams OverwriteParams { get; set; }
                        public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParams : TeaModel {
                            [NameInMap("Audio")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudio Audio { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudio : TeaModel {
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
                                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume Volume { get; set; }
                                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsAudioVolume : TeaModel {
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
                                };

                            }
                            [NameInMap("Container")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsContainer Container { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsContainer : TeaModel {
                                [NameInMap("Format")]
                                [Validation(Required=false)]
                                public string Format { get; set; }

                            }
                            [NameInMap("MuxConfig")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig MuxConfig { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfig : TeaModel {
                                [NameInMap("Segment")]
                                [Validation(Required=false)]
                                public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment Segment { get; set; }
                                public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsMuxConfigSegment : TeaModel {
                                    [NameInMap("Duration")]
                                    [Validation(Required=false)]
                                    public string Duration { get; set; }
                                    [NameInMap("ForceSegTime")]
                                    [Validation(Required=false)]
                                    public string ForceSegTime { get; set; }
                                };

                            }
                            [NameInMap("Video")]
                            [Validation(Required=false)]
                            public ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsVideo Video { get; set; }
                            public class ListTranscodeJobsResponseBodyJobsOutputGroupProcessConfigTranscodeOverwriteParamsVideo : TeaModel {
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
                        };

                        [NameInMap("TemplateId")]
                        [Validation(Required=false)]
                        public string TemplateId { get; set; }

                    }
                };

            }

            [NameInMap("ParentJobId")]
            [Validation(Required=false)]
            public string ParentJobId { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public int? Percent { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ScheduleConfig")]
            [Validation(Required=false)]
            public ListTranscodeJobsResponseBodyJobsScheduleConfig ScheduleConfig { get; set; }
            public class ListTranscodeJobsResponseBodyJobsScheduleConfig : TeaModel {
                [NameInMap("PipelineId")]
                [Validation(Required=false)]
                public string PipelineId { get; set; }
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }
            };

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            [NameInMap("TriggerSource")]
            [Validation(Required=false)]
            public string TriggerSource { get; set; }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
