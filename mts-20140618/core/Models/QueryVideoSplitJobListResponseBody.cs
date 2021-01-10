// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryVideoSplitJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryVideoSplitJobListResponseBodyJobList JobList { get; set; }
        public class QueryVideoSplitJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryVideoSplitJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryVideoSplitJobListResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public QueryVideoSplitJobListResponseBodyJobListJobVideoSplitResult VideoSplitResult { get; set; }
                public class QueryVideoSplitJobListResponseBodyJobListJobVideoSplitResult : TeaModel {
                    [NameInMap("VideoSplitList")]
                    [Validation(Required=false)]
                    public QueryVideoSplitJobListResponseBodyJobListJobVideoSplitResultVideoSplitList VideoSplitList { get; set; }
                    public class QueryVideoSplitJobListResponseBodyJobListJobVideoSplitResultVideoSplitList : TeaModel {
                        [NameInMap("VideoSplit")]
                        [Validation(Required=false)]
                        public List<QueryVideoSplitJobListResponseBodyJobListJobVideoSplitResultVideoSplitListVideoSplit> VideoSplit { get; set; }
                        public class QueryVideoSplitJobListResponseBodyJobListJobVideoSplitResultVideoSplitListVideoSplit : TeaModel {
                            public string EndTime { get; set; }
                            public string StartTime { get; set; }
                            public string Path { get; set; }
                        }
                    };

                }
                public string PipelineId { get; set; }
                public QueryVideoSplitJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryVideoSplitJobListResponseBodyJobListJobInput : TeaModel {
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
        public QueryVideoSplitJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryVideoSplitJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
