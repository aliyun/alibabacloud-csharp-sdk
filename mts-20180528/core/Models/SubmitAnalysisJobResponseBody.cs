// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20180528.Models
{
    public class SubmitAnalysisJobResponseBody : TeaModel {
        [NameInMap("AnalysisJob")]
        [Validation(Required=false)]
        public SubmitAnalysisJobResponseBodyAnalysisJob AnalysisJob { get; set; }
        public class SubmitAnalysisJobResponseBodyAnalysisJob : TeaModel {
            [NameInMap("AnalysisConfig")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfig AnalysisConfig { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfig : TeaModel {
                [NameInMap("PropertiesControl")]
                [Validation(Required=false)]
                public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControl PropertiesControl { get; set; }
                public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControl : TeaModel {
                    [NameInMap("Crop")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControlCrop Crop { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigPropertiesControlCrop : TeaModel {
                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        [NameInMap("Left")]
                        [Validation(Required=false)]
                        public string Left { get; set; }

                        [NameInMap("Mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public string Top { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                    [NameInMap("Deinterlace")]
                    [Validation(Required=false)]
                    public string Deinterlace { get; set; }

                }

                [NameInMap("QualityControl")]
                [Validation(Required=false)]
                public SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigQualityControl QualityControl { get; set; }
                public class SubmitAnalysisJobResponseBodyAnalysisJobAnalysisConfigQualityControl : TeaModel {
                    [NameInMap("MethodStreaming")]
                    [Validation(Required=false)]
                    public string MethodStreaming { get; set; }

                    [NameInMap("RateQuality")]
                    [Validation(Required=false)]
                    public string RateQuality { get; set; }

                }

            }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InputFile")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobInputFile InputFile { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobInputFile : TeaModel {
                [NameInMap("Bucket")]
                [Validation(Required=false)]
                public string Bucket { get; set; }

                [NameInMap("Location")]
                [Validation(Required=false)]
                public string Location { get; set; }

                [NameInMap("Object")]
                [Validation(Required=false)]
                public string Object { get; set; }

            }

            [NameInMap("MNSMessageResult")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobMNSMessageResult MNSMessageResult { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobMNSMessageResult : TeaModel {
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("MessageId")]
                [Validation(Required=false)]
                public string MessageId { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Percent")]
            [Validation(Required=false)]
            public long? Percent { get; set; }

            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("TemplateList")]
            [Validation(Required=false)]
            public SubmitAnalysisJobResponseBodyAnalysisJobTemplateList TemplateList { get; set; }
            public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateList : TeaModel {
                [NameInMap("Template")]
                [Validation(Required=false)]
                public List<SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplate> Template { get; set; }
                public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplate : TeaModel {
                    [NameInMap("Audio")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateAudio Audio { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateAudio : TeaModel {
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

                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        [NameInMap("Samplerate")]
                        [Validation(Required=false)]
                        public string Samplerate { get; set; }

                    }

                    [NameInMap("Container")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateContainer Container { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateContainer : TeaModel {
                        [NameInMap("Format")]
                        [Validation(Required=false)]
                        public string Format { get; set; }

                    }

                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("MuxConfig")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfig MuxConfig { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfig : TeaModel {
                        [NameInMap("Gif")]
                        [Validation(Required=false)]
                        public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigGif Gif { get; set; }
                        public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigGif : TeaModel {
                            [NameInMap("FinalDelay")]
                            [Validation(Required=false)]
                            public string FinalDelay { get; set; }

                            [NameInMap("Loop")]
                            [Validation(Required=false)]
                            public string Loop { get; set; }

                        }

                        [NameInMap("Segment")]
                        [Validation(Required=false)]
                        public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigSegment Segment { get; set; }
                        public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateMuxConfigSegment : TeaModel {
                            [NameInMap("Duration")]
                            [Validation(Required=false)]
                            public string Duration { get; set; }

                        }

                    }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("TransConfig")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateTransConfig TransConfig { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateTransConfig : TeaModel {
                        [NameInMap("TransMode")]
                        [Validation(Required=false)]
                        public string TransMode { get; set; }

                    }

                    [NameInMap("Video")]
                    [Validation(Required=false)]
                    public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideo Video { get; set; }
                    public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideo : TeaModel {
                        [NameInMap("Bitrate")]
                        [Validation(Required=false)]
                        public string Bitrate { get; set; }

                        [NameInMap("BitrateBnd")]
                        [Validation(Required=false)]
                        public SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideoBitrateBnd BitrateBnd { get; set; }
                        public class SubmitAnalysisJobResponseBodyAnalysisJobTemplateListTemplateVideoBitrateBnd : TeaModel {
                            [NameInMap("Max")]
                            [Validation(Required=false)]
                            public string Max { get; set; }

                            [NameInMap("Min")]
                            [Validation(Required=false)]
                            public string Min { get; set; }

                        }

                        [NameInMap("Bufsize")]
                        [Validation(Required=false)]
                        public string Bufsize { get; set; }

                        [NameInMap("Codec")]
                        [Validation(Required=false)]
                        public string Codec { get; set; }

                        [NameInMap("Crf")]
                        [Validation(Required=false)]
                        public string Crf { get; set; }

                        [NameInMap("Degrain")]
                        [Validation(Required=false)]
                        public string Degrain { get; set; }

                        [NameInMap("Fps")]
                        [Validation(Required=false)]
                        public string Fps { get; set; }

                        [NameInMap("Gop")]
                        [Validation(Required=false)]
                        public string Gop { get; set; }

                        [NameInMap("Height")]
                        [Validation(Required=false)]
                        public string Height { get; set; }

                        [NameInMap("Maxrate")]
                        [Validation(Required=false)]
                        public string Maxrate { get; set; }

                        [NameInMap("PixFmt")]
                        [Validation(Required=false)]
                        public string PixFmt { get; set; }

                        [NameInMap("Preset")]
                        [Validation(Required=false)]
                        public string Preset { get; set; }

                        [NameInMap("Profile")]
                        [Validation(Required=false)]
                        public string Profile { get; set; }

                        [NameInMap("Qscale")]
                        [Validation(Required=false)]
                        public string Qscale { get; set; }

                        [NameInMap("ScanMode")]
                        [Validation(Required=false)]
                        public string ScanMode { get; set; }

                        [NameInMap("Width")]
                        [Validation(Required=false)]
                        public string Width { get; set; }

                    }

                }

            }

            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
