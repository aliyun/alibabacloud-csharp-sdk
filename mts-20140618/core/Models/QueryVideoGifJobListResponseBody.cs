// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryVideoGifJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("JobList")]
        [Validation(Required=false)]
        public QueryVideoGifJobListResponseBodyJobList JobList { get; set; }
        public class QueryVideoGifJobListResponseBodyJobList : TeaModel {
            [NameInMap("Job")]
            [Validation(Required=false)]
            public List<QueryVideoGifJobListResponseBodyJobListJob> Job { get; set; }
            public class QueryVideoGifJobListResponseBodyJobListJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public QueryVideoGifJobListResponseBodyJobListJobVideoGifResult VideoGifResult { get; set; }
                public class QueryVideoGifJobListResponseBodyJobListJobVideoGifResult : TeaModel {
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryVideoGifJobListResponseBodyJobListJobVideoGifResultOutputFile OutputFile { get; set; }
                    public class QueryVideoGifJobListResponseBodyJobListJobVideoGifResultOutputFile : TeaModel {
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
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public QueryVideoGifJobListResponseBodyJobListJobInput Input { get; set; }
                public class QueryVideoGifJobListResponseBodyJobListJobInput : TeaModel {
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
        public QueryVideoGifJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryVideoGifJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
