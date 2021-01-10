// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryAnalysisJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AnalysisJobList")]
        [Validation(Required=false)]
        public QueryAnalysisJobListResponseBodyAnalysisJobList AnalysisJobList { get; set; }
        public class QueryAnalysisJobListResponseBodyAnalysisJobList : TeaModel {
            [NameInMap("AnalysisJob")]
            [Validation(Required=false)]
            public List<QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJob> AnalysisJob { get; set; }
            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJob : TeaModel {
                public string CreationTime { get; set; }
                public long? Percent { get; set; }
                public string State { get; set; }
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfig AnalysisConfig { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfig : TeaModel {
                    [NameInMap("QualityControl")]
                    [Validation(Required=false)]
                    public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigQualityControl QualityControl { get; set; }
                    public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigQualityControl : TeaModel {
                        [NameInMap("MethodStreaming")]
                        [Validation(Required=false)]
                        public string MethodStreaming { get; set; }
                        [NameInMap("RateQuality")]
                        [Validation(Required=false)]
                        public string RateQuality { get; set; }
                    };

                    [NameInMap("PropertiesControl")]
                    [Validation(Required=false)]
                    public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControl PropertiesControl { get; set; }
                    public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControl : TeaModel {
                        [NameInMap("Deinterlace")]
                        [Validation(Required=false)]
                        public string Deinterlace { get; set; }
                        [NameInMap("Crop")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControlCrop Crop { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobAnalysisConfigPropertiesControlCrop : TeaModel {
                            [NameInMap("Top")]
                            [Validation(Required=false)]
                            public string Top { get; set; }

                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }

                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }

                            [NameInMap("Left")]
                            [Validation(Required=false)]
                            public string Left { get; set; }

                            [NameInMap("Mode")]
                            [Validation(Required=false)]
                            public string Mode { get; set; }

                        }
                    };

                }
                public string Message { get; set; }
                public string Priority { get; set; }
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobMNSMessageResult MNSMessageResult { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobMNSMessageResult : TeaModel {
                    [NameInMap("MessageId")]
                    [Validation(Required=false)]
                    public string MessageId { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                }
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateList TemplateList { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateList : TeaModel {
                    [NameInMap("Template")]
                    [Validation(Required=false)]
                    public List<QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplate> Template { get; set; }
                    public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplate : TeaModel {
                        [NameInMap("Video")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideo Video { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideo : TeaModel {
                            [NameInMap("Bufsize")]
                            [Validation(Required=false)]
                            public string Bufsize { get; set; }
                            [NameInMap("Degrain")]
                            [Validation(Required=false)]
                            public string Degrain { get; set; }
                            [NameInMap("BitrateBnd")]
                            [Validation(Required=false)]
                            public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideoBitrateBnd BitrateBnd { get; set; }
                            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateVideoBitrateBnd : TeaModel {
                                [NameInMap("Max")]
                                [Validation(Required=false)]
                                public string Max { get; set; }

                                [NameInMap("Min")]
                                [Validation(Required=false)]
                                public string Min { get; set; }

                            }
                            [NameInMap("PixFmt")]
                            [Validation(Required=false)]
                            public string PixFmt { get; set; }
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }
                            [NameInMap("Height")]
                            [Validation(Required=false)]
                            public string Height { get; set; }
                            [NameInMap("Qscale")]
                            [Validation(Required=false)]
                            public string Qscale { get; set; }
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }
                            [NameInMap("Maxrate")]
                            [Validation(Required=false)]
                            public string Maxrate { get; set; }
                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }
                            [NameInMap("Crf")]
                            [Validation(Required=false)]
                            public string Crf { get; set; }
                            [NameInMap("Gop")]
                            [Validation(Required=false)]
                            public string Gop { get; set; }
                            [NameInMap("Width")]
                            [Validation(Required=false)]
                            public string Width { get; set; }
                            [NameInMap("Fps")]
                            [Validation(Required=false)]
                            public string Fps { get; set; }
                            [NameInMap("Preset")]
                            [Validation(Required=false)]
                            public string Preset { get; set; }
                            [NameInMap("ScanMode")]
                            [Validation(Required=false)]
                            public string ScanMode { get; set; }
                        };

                        [NameInMap("TransConfig")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateTransConfig TransConfig { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateTransConfig : TeaModel {
                            [NameInMap("TransMode")]
                            [Validation(Required=false)]
                            public string TransMode { get; set; }
                        };

                        [NameInMap("State")]
                        [Validation(Required=false)]
                        public string State { get; set; }

                        [NameInMap("MuxConfig")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfig MuxConfig { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfig : TeaModel {
                            [NameInMap("Gif")]
                            [Validation(Required=false)]
                            public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigGif Gif { get; set; }
                            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigGif : TeaModel {
                                [NameInMap("FinalDelay")]
                                [Validation(Required=false)]
                                public string FinalDelay { get; set; }

                                [NameInMap("Loop")]
                                [Validation(Required=false)]
                                public string Loop { get; set; }

                            }
                            [NameInMap("Segment")]
                            [Validation(Required=false)]
                            public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigSegment Segment { get; set; }
                            public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateMuxConfigSegment : TeaModel {
                                [NameInMap("Duration")]
                                [Validation(Required=false)]
                                public string Duration { get; set; }

                            }
                        };

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Audio")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateAudio Audio { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateAudio : TeaModel {
                            [NameInMap("Profile")]
                            [Validation(Required=false)]
                            public string Profile { get; set; }
                            [NameInMap("Codec")]
                            [Validation(Required=false)]
                            public string Codec { get; set; }
                            [NameInMap("Samplerate")]
                            [Validation(Required=false)]
                            public string Samplerate { get; set; }
                            [NameInMap("Qscale")]
                            [Validation(Required=false)]
                            public string Qscale { get; set; }
                            [NameInMap("Channels")]
                            [Validation(Required=false)]
                            public string Channels { get; set; }
                            [NameInMap("Bitrate")]
                            [Validation(Required=false)]
                            public string Bitrate { get; set; }
                        };

                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        [NameInMap("Container")]
                        [Validation(Required=false)]
                        public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateContainer Container { get; set; }
                        public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobTemplateListTemplateContainer : TeaModel {
                            [NameInMap("Format")]
                            [Validation(Required=false)]
                            public string Format { get; set; }
                        };

                    }

                }
                public string UserData { get; set; }
                public string Code { get; set; }
                public QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobInputFile InputFile { get; set; }
                public class QueryAnalysisJobListResponseBodyAnalysisJobListAnalysisJobInputFile : TeaModel {
                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }
                public string PipelineId { get; set; }
                public string Id { get; set; }
            }
        };

        [NameInMap("NonExistAnalysisJobIds")]
        [Validation(Required=false)]
        public QueryAnalysisJobListResponseBodyNonExistAnalysisJobIds NonExistAnalysisJobIds { get; set; }
        public class QueryAnalysisJobListResponseBodyNonExistAnalysisJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
