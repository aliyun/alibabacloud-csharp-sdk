// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryPornJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PornJobList")]
        [Validation(Required=false)]
        public QueryPornJobListResponseBodyPornJobList PornJobList { get; set; }
        public class QueryPornJobListResponseBodyPornJobList : TeaModel {
            [NameInMap("PornJob")]
            [Validation(Required=false)]
            public List<QueryPornJobListResponseBodyPornJobListPornJob> PornJob { get; set; }
            public class QueryPornJobListResponseBodyPornJobListPornJob : TeaModel {
                public string CreationTime { get; set; }
                public QueryPornJobListResponseBodyPornJobListPornJobPornConfig PornConfig { get; set; }
                public class QueryPornJobListResponseBodyPornJobListPornJobPornConfig : TeaModel {
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryPornJobListResponseBodyPornJobListPornJobPornConfigOutputFile OutputFile { get; set; }
                    public class QueryPornJobListResponseBodyPornJobListPornJobPornConfigOutputFile : TeaModel {
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

                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public QueryPornJobListResponseBodyPornJobListPornJobCensorPornResult CensorPornResult { get; set; }
                public class QueryPornJobListResponseBodyPornJobListPornJobCensorPornResult : TeaModel {
                    [NameInMap("PornCounterList")]
                    [Validation(Required=false)]
                    public QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornCounterList PornCounterList { get; set; }
                    public class QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornCounterList : TeaModel {
                        [NameInMap("Counter")]
                        [Validation(Required=false)]
                        public List<QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornCounterListCounter> Counter { get; set; }
                        public class QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornCounterListCounter : TeaModel {
                            public string Label { get; set; }
                            public int? Count { get; set; }
                        }
                    };

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    [NameInMap("PornTopList")]
                    [Validation(Required=false)]
                    public QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornTopList PornTopList { get; set; }
                    public class QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornTopList : TeaModel {
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public List<QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornTopListTop> Top { get; set; }
                        public class QueryPornJobListResponseBodyPornJobListPornJobCensorPornResultPornTopListTop : TeaModel {
                            public string Index { get; set; }
                            public string Score { get; set; }
                            public string Timestamp { get; set; }
                            public string Object { get; set; }
                            public string Label { get; set; }
                        }
                    };

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                }
                public string PipelineId { get; set; }
                public QueryPornJobListResponseBodyPornJobListPornJobInput Input { get; set; }
                public class QueryPornJobListResponseBodyPornJobListPornJobInput : TeaModel {
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
        public QueryPornJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryPornJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
