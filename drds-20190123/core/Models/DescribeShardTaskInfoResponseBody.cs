// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeShardTaskInfoResponseBody : TeaModel {
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeShardTaskInfoResponseBodyData Data { get; set; }
        public class DescribeShardTaskInfoResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }
            [NameInMap("TargetTableName")]
            [Validation(Required=false)]
            public string TargetTableName { get; set; }
            [NameInMap("SourceTableName")]
            [Validation(Required=false)]
            public string SourceTableName { get; set; }
            [NameInMap("Full")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFull Full { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFull : TeaModel {
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

            }
            [NameInMap("FullCheck")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFullCheck FullCheck { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFullCheck : TeaModel {
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

            }
            [NameInMap("FullRevise")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFullRevise FullRevise { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFullRevise : TeaModel {
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

            }
            [NameInMap("Review")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataReview Review { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataReview : TeaModel {
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

            }
            [NameInMap("Increment")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataIncrement Increment { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataIncrement : TeaModel {
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public int? Delay { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }
        };

    }

}
