// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryMediaDetailJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryMediaDetailJobListResponseBodyJobList JobList { get; set; }
        public class QueryMediaDetailJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryMediaDetailJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryMediaDetailJobListResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResult MediaDetailResult { get; set; }
                public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResult : TeaModel {
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("MediaDetailRecgResults")]
                    [Validation(Required=false)]
                    public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResults MediaDetailRecgResults { get; set; }
                    public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResults : TeaModel {
                        [NameInMap("MediaDetailRecgResult")]
                        [Validation(Required=false)]
                        public List<QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResult> MediaDetailRecgResult { get; set; }
                        public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResult : TeaModel {
                            public string Time { get; set; }
                            public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultSensitives Sensitives { get; set; }
                            public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultSensitives : TeaModel {
                                [NameInMap("Sensitive")]
                                [Validation(Required=false)]
                                public List<QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultSensitivesSensitive> Sensitive { get; set; }
                                public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultSensitivesSensitive : TeaModel {
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public string Score { get; set; }

                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Target")]
                                    [Validation(Required=false)]
                                    public string Target { get; set; }

                                }

                            }
                            public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultPoliticians Politicians { get; set; }
                            public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultPoliticians : TeaModel {
                                [NameInMap("Politician")]
                                [Validation(Required=false)]
                                public List<QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultPoliticiansPolitician> Politician { get; set; }
                                public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultPoliticiansPolitician : TeaModel {
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public string Score { get; set; }

                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Target")]
                                    [Validation(Required=false)]
                                    public string Target { get; set; }

                                }

                            }
                            public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultFrameTags FrameTags { get; set; }
                            public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultFrameTags : TeaModel {
                                [NameInMap("String")]
                                [Validation(Required=false)]
                                public List<string> String { get; set; }

                            }
                            public string ImageUrl { get; set; }
                            public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustoms Customs { get; set; }
                            public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustoms : TeaModel {
                                [NameInMap("Custom")]
                                [Validation(Required=false)]
                                public List<QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustomsCustom> Custom { get; set; }
                                public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustomsCustom : TeaModel {
                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Clips")]
                                    [Validation(Required=false)]
                                    public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustomsCustomClips Clips { get; set; }
                                    public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustomsCustomClips : TeaModel {
                                        [NameInMap("Clip")]
                                        [Validation(Required=false)]
                                        public List<QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustomsCustomClipsClip> Clip { get; set; }
                                        public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCustomsCustomClipsClip : TeaModel {
                                            public string EndTime { get; set; }
                                            public string MinScore { get; set; }
                                            public string StartTime { get; set; }
                                            public string AvgScore { get; set; }
                                            public string MaxScore { get; set; }
                                            public string EndTarget { get; set; }
                                            public string StartTarget { get; set; }
                                        }
                                    };

                                }

                            }
                            public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultFrameTagInfos FrameTagInfos { get; set; }
                            public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultFrameTagInfos : TeaModel {
                                [NameInMap("FrameTagInfo")]
                                [Validation(Required=false)]
                                public List<QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultFrameTagInfosFrameTagInfo> FrameTagInfo { get; set; }
                                public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultFrameTagInfosFrameTagInfo : TeaModel {
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public string Score { get; set; }

                                    [NameInMap("Category")]
                                    [Validation(Required=false)]
                                    public string Category { get; set; }

                                    [NameInMap("Tag")]
                                    [Validation(Required=false)]
                                    public string Tag { get; set; }

                                }

                            }
                            public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCelebrities Celebrities { get; set; }
                            public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCelebrities : TeaModel {
                                [NameInMap("Celebrity")]
                                [Validation(Required=false)]
                                public List<QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCelebritiesCelebrity> Celebrity { get; set; }
                                public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultMediaDetailRecgResultsMediaDetailRecgResultCelebritiesCelebrity : TeaModel {
                                    [NameInMap("Score")]
                                    [Validation(Required=false)]
                                    public string Score { get; set; }

                                    [NameInMap("Name")]
                                    [Validation(Required=false)]
                                    public string Name { get; set; }

                                    [NameInMap("Target")]
                                    [Validation(Required=false)]
                                    public string Target { get; set; }

                                }

                            }
                            public string OcrText { get; set; }
                        }
                    };

                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultTags Tags { get; set; }
                    public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailResultTags : TeaModel {
                        [NameInMap("String")]
                        [Validation(Required=false)]
                        public List<string> String { get; set; }
                    };

                }
                public string Message { get; set; }
                public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailConfig MediaDetailConfig { get; set; }
                public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailConfig : TeaModel {
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryMediaDetailJobListResponseBodyJobListJobMediaDetailConfigOutputFile OutputFile { get; set; }
                    public class QueryMediaDetailJobListResponseBodyJobListJobMediaDetailConfigOutputFile : TeaModel {
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                    };

                    [NameInMap("Scenario")]
                    [Validation(Required=false)]
                    public string Scenario { get; set; }

                    [NameInMap("DetailType")]
                    [Validation(Required=false)]
                    public string DetailType { get; set; }

                }
                public string PipelineId { get; set; }
                public QueryMediaDetailJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryMediaDetailJobListResponseBodyJobListJobInput : TeaModel {
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
                public string Id { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryMediaDetailJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryMediaDetailJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
