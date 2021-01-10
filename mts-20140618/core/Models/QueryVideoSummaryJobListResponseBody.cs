// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryVideoSummaryJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryVideoSummaryJobListResponseBodyJobList JobList { get; set; }
        public class QueryVideoSummaryJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryVideoSummaryJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryVideoSummaryJobListResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResult VideoSummaryResult { get; set; }
                public class QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResult : TeaModel {
                    [NameInMap("VideoSummaryList")]
                    [Validation(Required=false)]
                    public QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResultVideoSummaryList VideoSummaryList { get; set; }
                    public class QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResultVideoSummaryList : TeaModel {
                        [NameInMap("VideoSummary")]
                        [Validation(Required=false)]
                        public List<QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResultVideoSummaryListVideoSummary> VideoSummary { get; set; }
                        public class QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResultVideoSummaryListVideoSummary : TeaModel {
                            public string EndTime { get; set; }
                            public string StartTime { get; set; }
                        }
                    };

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResultOutputFile OutputFile { get; set; }
                    public class QueryVideoSummaryJobListResponseBodyJobListJobVideoSummaryResultOutputFile : TeaModel {
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

                }
                public string PipelineId { get; set; }
                public QueryVideoSummaryJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryVideoSummaryJobListResponseBodyJobListJobInput : TeaModel {
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
        public QueryVideoSummaryJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryVideoSummaryJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
