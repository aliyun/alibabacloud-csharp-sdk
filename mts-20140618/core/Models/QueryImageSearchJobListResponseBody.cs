// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryImageSearchJobListResponseBody : TeaModel {
        [NameInMap("ImageSearchJobList")]
        [Validation(Required=false)]
        public QueryImageSearchJobListResponseBodyImageSearchJobList ImageSearchJobList { get; set; }
        public class QueryImageSearchJobListResponseBodyImageSearchJobList : TeaModel {
            [NameInMap("ImageSearchJob")]
            [Validation(Required=false)]
            public List<QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJob> ImageSearchJob { get; set; }
            public class QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJob : TeaModel {
                public string CreationTime { get; set; }
                public string FinishTime { get; set; }
                public QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobResult Result { get; set; }
                public class QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobResult : TeaModel {
                    [NameInMap("ImageSearchShots")]
                    [Validation(Required=false)]
                    public QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobResultImageSearchShots ImageSearchShots { get; set; }
                    public class QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobResultImageSearchShots : TeaModel {
                        [NameInMap("ImageSearchShots")]
                        [Validation(Required=false)]
                        public List<QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobResultImageSearchShotsImageSearchShots> ImageSearchShots { get; set; }
                        public class QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobResultImageSearchShotsImageSearchShots : TeaModel {
                            public string MatchedFrame { get; set; }
                            public string MatchedTimestamp { get; set; }
                            public string Similarity { get; set; }
                        }
                    };

                }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobInputImage InputImage { get; set; }
                public class QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobInputImage : TeaModel {
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
                public QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobInputVideo InputVideo { get; set; }
                public class QueryImageSearchJobListResponseBodyImageSearchJobListImageSearchJobInputVideo : TeaModel {
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
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryImageSearchJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryImageSearchJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
