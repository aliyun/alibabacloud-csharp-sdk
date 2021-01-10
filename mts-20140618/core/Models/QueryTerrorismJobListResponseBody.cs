// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryTerrorismJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TerrorismJobList")]
        [Validation(Required=false)]
        public QueryTerrorismJobListResponseBodyTerrorismJobList TerrorismJobList { get; set; }
        public class QueryTerrorismJobListResponseBodyTerrorismJobList : TeaModel {
            [NameInMap("TerrorismJob")]
            [Validation(Required=false)]
            public List<QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJob> TerrorismJob { get; set; }
            public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public string UserData { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResult CensorTerrorismResult { get; set; }
                public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResult : TeaModel {
                    [NameInMap("TerrorismTopList")]
                    [Validation(Required=false)]
                    public QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismTopList TerrorismTopList { get; set; }
                    public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismTopList : TeaModel {
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public List<QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismTopListTop> Top { get; set; }
                        public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismTopListTop : TeaModel {
                            public string Index { get; set; }
                            public string Score { get; set; }
                            public string Timestamp { get; set; }
                            public string Object { get; set; }
                            public string Label { get; set; }
                        }
                    };

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    [NameInMap("TerrorismCounterList")]
                    [Validation(Required=false)]
                    public QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismCounterList TerrorismCounterList { get; set; }
                    public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismCounterList : TeaModel {
                        [NameInMap("Counter")]
                        [Validation(Required=false)]
                        public List<QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismCounterListCounter> Counter { get; set; }
                        public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobCensorTerrorismResultTerrorismCounterListCounter : TeaModel {
                            public string Label { get; set; }
                            public int? Count { get; set; }
                        }
                    };

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                }
                public QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobTerrorismConfig TerrorismConfig { get; set; }
                public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobTerrorismConfig : TeaModel {
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobTerrorismConfigOutputFile OutputFile { get; set; }
                    public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobTerrorismConfigOutputFile : TeaModel {
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
                public string PipelineId { get; set; }
                public QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobInput Input { get; set; }
                public class QueryTerrorismJobListResponseBodyTerrorismJobListTerrorismJobInput : TeaModel {
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
        public QueryTerrorismJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryTerrorismJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

    }

}
