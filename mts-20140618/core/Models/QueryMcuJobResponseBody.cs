// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMcuJobResponseBody : TeaModel {
        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public QueryMcuJobResponseBodyNonExistJobIds NonExistJobIds { get; set; }
        public class QueryMcuJobResponseBodyNonExistJobIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobResult")]
        [Validation(Required=false)]
        public QueryMcuJobResponseBodyJobResult JobResult { get; set; }
        public class QueryMcuJobResponseBodyJobResult : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryMcuJobResponseBodyJobResultJob> Job { get; set; }
            public class QueryMcuJobResponseBodyJobResultJob : TeaModel {
                public QueryMcuJobResponseBodyJobResultJobTagResult TagResult { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobTagResult : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<QueryMcuJobResponseBodyJobResultJobTagResultTag> Tag { get; set; }
                    public class QueryMcuJobResponseBodyJobResultJobTagResultTag : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                        [NameInMap("ImageUrl")]
                        [Validation(Required=false)]
                        public string ImageUrl { get; set; }

                        [NameInMap("FrameTagInfos")]
                        [Validation(Required=false)]
                        public QueryMcuJobResponseBodyJobResultJobTagResultTagFrameTagInfos FrameTagInfos { get; set; }
                        public class QueryMcuJobResponseBodyJobResultJobTagResultTagFrameTagInfos : TeaModel {
                            [NameInMap("FrameTagInfo")]
                            [Validation(Required=false)]
                            public List<QueryMcuJobResponseBodyJobResultJobTagResultTagFrameTagInfosFrameTagInfo> FrameTagInfo { get; set; }
                            public class QueryMcuJobResponseBodyJobResultJobTagResultTagFrameTagInfosFrameTagInfo : TeaModel {
                                public string Score { get; set; }
                                public string Category { get; set; }
                                public string Tag { get; set; }
                            }
                        };

                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                    }

                }
                public string JobId { get; set; }
                public QueryMcuJobResponseBodyJobResultJobOcrResult OcrResult { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobOcrResult : TeaModel {
                    [NameInMap("Ocr")]
                    [Validation(Required=false)]
                    public List<QueryMcuJobResponseBodyJobResultJobOcrResultOcr> Ocr { get; set; }
                    public class QueryMcuJobResponseBodyJobResultJobOcrResultOcr : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                        [NameInMap("ImageUrl")]
                        [Validation(Required=false)]
                        public string ImageUrl { get; set; }

                        [NameInMap("OcrText")]
                        [Validation(Required=false)]
                        public string OcrText { get; set; }

                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                    }

                }
                public string Template { get; set; }
                public string UserData { get; set; }
                public QueryMcuJobResponseBodyJobResultJobSubTaskInfo SubTaskInfo { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobSubTaskInfo : TeaModel {
                    [NameInMap("SubTask")]
                    [Validation(Required=false)]
                    public List<QueryMcuJobResponseBodyJobResultJobSubTaskInfoSubTask> SubTask { get; set; }
                    public class QueryMcuJobResponseBodyJobResultJobSubTaskInfoSubTask : TeaModel {
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Message")]
                        [Validation(Required=false)]
                        public string Message { get; set; }

                    }

                }
                public QueryMcuJobResponseBodyJobResultJobCategoryResult CategoryResult { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobCategoryResult : TeaModel {
                    [NameInMap("Categories")]
                    [Validation(Required=false)]
                    public QueryMcuJobResponseBodyJobResultJobCategoryResultCategories Categories { get; set; }
                    public class QueryMcuJobResponseBodyJobResultJobCategoryResultCategories : TeaModel {
                        [NameInMap("Category")]
                        [Validation(Required=false)]
                        public List<QueryMcuJobResponseBodyJobResultJobCategoryResultCategoriesCategory> Category { get; set; }
                        public class QueryMcuJobResponseBodyJobResultJobCategoryResultCategoriesCategory : TeaModel {
                            public string Score { get; set; }
                            public string Label { get; set; }
                        }
                    };

                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public string Details { get; set; }

                }
                public QueryMcuJobResponseBodyJobResultJobFaceResult FaceResult { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobFaceResult : TeaModel {
                    [NameInMap("Face")]
                    [Validation(Required=false)]
                    public List<QueryMcuJobResponseBodyJobResultJobFaceResultFace> Face { get; set; }
                    public class QueryMcuJobResponseBodyJobResultJobFaceResultFace : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                        [NameInMap("ImageUrl")]
                        [Validation(Required=false)]
                        public string ImageUrl { get; set; }

                        [NameInMap("Celebrities")]
                        [Validation(Required=false)]
                        public QueryMcuJobResponseBodyJobResultJobFaceResultFaceCelebrities Celebrities { get; set; }
                        public class QueryMcuJobResponseBodyJobResultJobFaceResultFaceCelebrities : TeaModel {
                            [NameInMap("Celebrity")]
                            [Validation(Required=false)]
                            public List<QueryMcuJobResponseBodyJobResultJobFaceResultFaceCelebritiesCelebrity> Celebrity { get; set; }
                            public class QueryMcuJobResponseBodyJobResultJobFaceResultFaceCelebritiesCelebrity : TeaModel {
                                public string Score { get; set; }
                                public string Name { get; set; }
                                public string Target { get; set; }
                            }
                        };

                        [NameInMap("ImageId")]
                        [Validation(Required=false)]
                        public string ImageId { get; set; }

                    }

                }
                public string TemplateId { get; set; }
                public QueryMcuJobResponseBodyJobResultJobInput Input { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobInput : TeaModel {
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
                public QueryMcuJobResponseBodyJobResultJobAsrResult AsrResult { get; set; }
                public class QueryMcuJobResponseBodyJobResultJobAsrResult : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    [NameInMap("AsrTextList")]
                    [Validation(Required=false)]
                    public QueryMcuJobResponseBodyJobResultJobAsrResultAsrTextList AsrTextList { get; set; }
                    public class QueryMcuJobResponseBodyJobResultJobAsrResultAsrTextList : TeaModel {
                        [NameInMap("AsrText")]
                        [Validation(Required=false)]
                        public List<QueryMcuJobResponseBodyJobResultJobAsrResultAsrTextListAsrText> AsrText { get; set; }
                        public class QueryMcuJobResponseBodyJobResultJobAsrResultAsrTextListAsrText : TeaModel {
                            public string EndTime { get; set; }
                            public int? StartTime { get; set; }
                            public string ChannelId { get; set; }
                            public string Text { get; set; }
                            public string SpeechRate { get; set; }
                        }
                    };

                }
            }
        };

    }

}
