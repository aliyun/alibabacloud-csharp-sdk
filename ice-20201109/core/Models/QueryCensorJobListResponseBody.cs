// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QueryCensorJobListResponseBody : TeaModel {
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public QueryCensorJobListResponseBodyJobs Jobs { get; set; }
        public class QueryCensorJobListResponseBodyJobs : TeaModel {
            [NameInMap("CensorJob")]
            [Validation(Required=false)]
            public List<QueryCensorJobListResponseBodyJobsCensorJob> CensorJob { get; set; }
            public class QueryCensorJobListResponseBodyJobsCensorJob : TeaModel {
                public string BarrageCensorResult { get; set; }
                public QueryCensorJobListResponseBodyJobsCensorJobCensorConfig CensorConfig { get; set; }
                public class QueryCensorJobListResponseBodyJobsCensorJobCensorConfig : TeaModel {
                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyJobsCensorJobCensorConfigOutputFile OutputFile { get; set; }
                    public class QueryCensorJobListResponseBodyJobsCensorJobCensorConfigOutputFile : TeaModel {
                        [NameInMap("Bucket")]
                        [Validation(Required=false)]
                        public string Bucket { get; set; }
                        [NameInMap("Location")]
                        [Validation(Required=false)]
                        public string Location { get; set; }
                        [NameInMap("Object")]
                        [Validation(Required=false)]
                        public string Object { get; set; }
                    };

                    [NameInMap("SaveType")]
                    [Validation(Required=false)]
                    public string SaveType { get; set; }

                    [NameInMap("Scenes")]
                    [Validation(Required=false)]
                    public string Scenes { get; set; }

                }
                public QueryCensorJobListResponseBodyJobsCensorJobCensorPornResult CensorPornResult { get; set; }
                public class QueryCensorJobListResponseBodyJobsCensorJobCensorPornResult : TeaModel {
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    [NameInMap("PornCounterList")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornCounterList PornCounterList { get; set; }
                    public class QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornCounterList : TeaModel {
                        [NameInMap("Counter")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornCounterListCounter> Counter { get; set; }
                        public class QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornCounterListCounter : TeaModel {
                            public int? Count { get; set; }
                            public string Label { get; set; }
                        }
                    };

                    [NameInMap("PornTopList")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornTopList PornTopList { get; set; }
                    public class QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornTopList : TeaModel {
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornTopListTop> Top { get; set; }
                        public class QueryCensorJobListResponseBodyJobsCensorJobCensorPornResultPornTopListTop : TeaModel {
                            public string Index { get; set; }
                            public string Label { get; set; }
                            public string Object { get; set; }
                            public string Score { get; set; }
                            public string Timestamp { get; set; }
                        }
                    };

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }
                public QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResult CensorTerrorismResult { get; set; }
                public class QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResult : TeaModel {
                    [NameInMap("AverageScore")]
                    [Validation(Required=false)]
                    public string AverageScore { get; set; }

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("MaxScore")]
                    [Validation(Required=false)]
                    public string MaxScore { get; set; }

                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                    [NameInMap("TerrorismCounterList")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismCounterList TerrorismCounterList { get; set; }
                    public class QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismCounterList : TeaModel {
                        [NameInMap("Counter")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismCounterListCounter> Counter { get; set; }
                        public class QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismCounterListCounter : TeaModel {
                            public int? Count { get; set; }
                            public string Label { get; set; }
                        }
                    };

                    [NameInMap("TerrorismTopList")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismTopList TerrorismTopList { get; set; }
                    public class QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismTopList : TeaModel {
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismTopListTop> Top { get; set; }
                        public class QueryCensorJobListResponseBodyJobsCensorJobCensorTerrorismResultTerrorismTopListTop : TeaModel {
                            public string Index { get; set; }
                            public string Label { get; set; }
                            public string Object { get; set; }
                            public string Score { get; set; }
                            public string Timestamp { get; set; }
                        }
                    };

                }
                public string Code { get; set; }
                public string CreationTime { get; set; }
                public string DescCensorResult { get; set; }
                public string Id { get; set; }
                public QueryCensorJobListResponseBodyJobsCensorJobImageCensorResults ImageCensorResults { get; set; }
                public class QueryCensorJobListResponseBodyJobsCensorJobImageCensorResults : TeaModel {
                    [NameInMap("ImageCensorResult")]
                    [Validation(Required=false)]
                    public List<QueryCensorJobListResponseBodyJobsCensorJobImageCensorResultsImageCensorResult> ImageCensorResult { get; set; }
                    public class QueryCensorJobListResponseBodyJobsCensorJobImageCensorResultsImageCensorResult : TeaModel {
                        [NameInMap("ImageBucket")]
                        [Validation(Required=false)]
                        public string ImageBucket { get; set; }

                        [NameInMap("ImageLocation")]
                        [Validation(Required=false)]
                        public string ImageLocation { get; set; }

                        [NameInMap("ImageObject")]
                        [Validation(Required=false)]
                        public string ImageObject { get; set; }

                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public string Result { get; set; }

                    }

                }
                public QueryCensorJobListResponseBodyJobsCensorJobInput Input { get; set; }
                public class QueryCensorJobListResponseBodyJobsCensorJobInput : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public string Location { get; set; }

                    [NameInMap("Object")]
                    [Validation(Required=false)]
                    public string Object { get; set; }

                }
                public string Message { get; set; }
                public string PipelineId { get; set; }
                public string ResultSaveObject { get; set; }
                public string State { get; set; }
                public string TitleCensorResult { get; set; }
                public string UserData { get; set; }
            }
        };

        [NameInMap("NonExistIds")]
        [Validation(Required=false)]
        public QueryCensorJobListResponseBodyNonExistIds NonExistIds { get; set; }
        public class QueryCensorJobListResponseBodyNonExistIds : TeaModel {
            [NameInMap("String")]
            [Validation(Required=false)]
            public List<string> String { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
