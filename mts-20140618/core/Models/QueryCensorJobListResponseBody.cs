// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryCensorJobListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CensorJobList")]
        [Validation(Required=false)]
        public QueryCensorJobListResponseBodyCensorJobList CensorJobList { get; set; }
        public class QueryCensorJobListResponseBodyCensorJobList : TeaModel {
            [NameInMap("CensorJob")]
            [Validation(Required=false)]
            public List<QueryCensorJobListResponseBodyCensorJobListCensorJob> CensorJob { get; set; }
            public class QueryCensorJobListResponseBodyCensorJobListCensorJob : TeaModel {
                public string CreationTime { get; set; }
                public string State { get; set; }
                public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResult CensorTerrorismResult { get; set; }
                public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResult : TeaModel {
                    [NameInMap("TerrorismTopList")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismTopList TerrorismTopList { get; set; }
                    public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismTopList : TeaModel {
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismTopListTop> Top { get; set; }
                        public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismTopListTop : TeaModel {
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
                    public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismCounterList TerrorismCounterList { get; set; }
                    public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismCounterList : TeaModel {
                        [NameInMap("Counter")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismCounterListCounter> Counter { get; set; }
                        public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorTerrorismResultTerrorismCounterListCounter : TeaModel {
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
                public QueryCensorJobListResponseBodyCensorJobListCensorJobImageCensorResults ImageCensorResults { get; set; }
                public class QueryCensorJobListResponseBodyCensorJobListCensorJobImageCensorResults : TeaModel {
                    [NameInMap("ImageCensorResult")]
                    [Validation(Required=false)]
                    public List<QueryCensorJobListResponseBodyCensorJobListCensorJobImageCensorResultsImageCensorResult> ImageCensorResult { get; set; }
                    public class QueryCensorJobListResponseBodyCensorJobListCensorJobImageCensorResultsImageCensorResult : TeaModel {
                        [NameInMap("ImageBucket")]
                        [Validation(Required=false)]
                        public string ImageBucket { get; set; }

                        [NameInMap("Result")]
                        [Validation(Required=false)]
                        public string Result { get; set; }

                        [NameInMap("ImageLocation")]
                        [Validation(Required=false)]
                        public string ImageLocation { get; set; }

                        [NameInMap("ImageObject")]
                        [Validation(Required=false)]
                        public string ImageObject { get; set; }

                    }

                }
                public string TitleCensorResult { get; set; }
                public string Message { get; set; }
                public QueryCensorJobListResponseBodyCensorJobListCensorJobInput Input { get; set; }
                public class QueryCensorJobListResponseBodyCensorJobListCensorJobInput : TeaModel {
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
                public string BarrageCensorResult { get; set; }
                public string DescCensorResult { get; set; }
                public string ResultSaveObject { get; set; }
                public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorConfig CensorConfig { get; set; }
                public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorConfig : TeaModel {
                    [NameInMap("Interval")]
                    [Validation(Required=false)]
                    public string Interval { get; set; }

                    [NameInMap("SaveType")]
                    [Validation(Required=false)]
                    public string SaveType { get; set; }

                    [NameInMap("OutputFile")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorConfigOutputFile OutputFile { get; set; }
                    public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorConfigOutputFile : TeaModel {
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

                    [NameInMap("Scenes")]
                    [Validation(Required=false)]
                    public string Scenes { get; set; }

                    [NameInMap("BizType")]
                    [Validation(Required=false)]
                    public string BizType { get; set; }

                }
                public string UserData { get; set; }
                public string Code { get; set; }
                public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResult CensorPornResult { get; set; }
                public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResult : TeaModel {
                    [NameInMap("PornCounterList")]
                    [Validation(Required=false)]
                    public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornCounterList PornCounterList { get; set; }
                    public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornCounterList : TeaModel {
                        [NameInMap("Counter")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornCounterListCounter> Counter { get; set; }
                        public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornCounterListCounter : TeaModel {
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
                    public QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornTopList PornTopList { get; set; }
                    public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornTopList : TeaModel {
                        [NameInMap("Top")]
                        [Validation(Required=false)]
                        public List<QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornTopListTop> Top { get; set; }
                        public class QueryCensorJobListResponseBodyCensorJobListCensorJobCensorPornResultPornTopListTop : TeaModel {
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
                public string Id { get; set; }
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

    }

}
