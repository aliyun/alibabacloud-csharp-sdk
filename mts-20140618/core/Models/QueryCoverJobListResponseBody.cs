// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryCoverJobListResponseBody : TeaModel {
        [NameInMap("CoverJobList")]
        [Validation(Required=false)]
        public QueryCoverJobListResponseBodyCoverJobList CoverJobList { get; set; }
        public class QueryCoverJobListResponseBodyCoverJobList : TeaModel {
            [NameInMap("CoverJob")]
            [Validation(Required=false)]
            public List<QueryCoverJobListResponseBodyCoverJobListCoverJob> CoverJob { get; set; }
            public class QueryCoverJobListResponseBodyCoverJobListCoverJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public QueryCoverJobListResponseBodyCoverJobListCoverJobCoverImageList CoverImageList { get; set; }
                public class QueryCoverJobListResponseBodyCoverJobListCoverJobCoverImageList : TeaModel {
                    [NameInMap("CoverImage")]
                    [Validation(Required=false)]
                    public List<QueryCoverJobListResponseBodyCoverJobListCoverJobCoverImageListCoverImage> CoverImage { get; set; }
                    public class QueryCoverJobListResponseBodyCoverJobListCoverJobCoverImageListCoverImage : TeaModel {
                        [NameInMap("Time")]
                        [Validation(Required=false)]
                        public string Time { get; set; }

                        [NameInMap("Score")]
                        [Validation(Required=false)]
                        public string Score { get; set; }

                        [NameInMap("Url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public QueryCoverJobListResponseBodyCoverJobListCoverJobInput Input { get; set; }
                public class QueryCoverJobListResponseBodyCoverJobListCoverJobInput : TeaModel {
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
                public QueryCoverJobListResponseBodyCoverJobListCoverJobCoverConfig CoverConfig { get; set; }
                public class QueryCoverJobListResponseBodyCoverJobListCoverJobCoverConfig : TeaModel {
                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryCoverJobListResponseBodyCoverJobListCoverJobCoverConfigOutputFile OutputFile { get; set; }
                    public class QueryCoverJobListResponseBodyCoverJobListCoverJobCoverConfigOutputFile : TeaModel {
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
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryCoverJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryCoverJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
