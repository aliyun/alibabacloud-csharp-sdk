// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeShardTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// Indicates the data that is returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeShardTaskInfoResponseBodyData Data { get; set; }
        public class DescribeShardTaskInfoResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates the number of remaining days before the tasks to shard tables or convert tables expire.
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            /// <summary>
            /// Indicates information about full migration tasks.
            /// </summary>
            [NameInMap("Full")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFull Full { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFull : TeaModel {
                /// <summary>
                /// Indicates the number of remaining days before the tasks expire.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// Indicates the progress of the tasks.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// Indicates the start time when the tasks are performed.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// Indicates the number of tasks.
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// Indicates the number of transactions processed by the database per second.
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// Indicates information about full check tasks.
            /// </summary>
            [NameInMap("FullCheck")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFullCheck FullCheck { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFullCheck : TeaModel {
                /// <summary>
                /// Indicates the number of remaining days before the tasks expire.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// Indicates the progress of the tasks.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// Indicates the start time when the tasks are performed.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// Indicates the number of tasks.
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// Indicates the number of transactions processed by the database per second.
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// Indicates information about full correction tasks.
            /// </summary>
            [NameInMap("FullRevise")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFullRevise FullRevise { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFullRevise : TeaModel {
                /// <summary>
                /// Indicates the number of remaining days before the tasks expire.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// Indicates the progress of the tasks.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// Indicates the start time when the tasks are performed.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// Indicates the number of tasks.
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// Indicates the number of transactions processed by the database per second.
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// Indicates information about incremental data synchronization.
            /// </summary>
            [NameInMap("Increment")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataIncrement Increment { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataIncrement : TeaModel {
                /// <summary>
                /// Indicates the latency of the incremental data synchronization.
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public int? Delay { get; set; }

                /// <summary>
                /// Indicates the start time when the incremental data synchronization is performed.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// Indicates the number of transactions processed by the database per second.
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// Indicates the incremental data synchronization progress.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// Indicates check tasks.
            /// </summary>
            [NameInMap("Review")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataReview Review { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataReview : TeaModel {
                /// <summary>
                /// Indicates the number of remaining days before the tasks expire.
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// Indicates the progress of the tasks.
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// Indicates the start time when the tasks are performed.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// Indicates the number of tasks.
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// Indicates the number of transactions processed by the database per second.
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// Indicates the name of the table that you convert or shard.
            /// </summary>
            [NameInMap("SourceTableName")]
            [Validation(Required=false)]
            public string SourceTableName { get; set; }

            /// <summary>
            /// Indicates the current stage of the task.
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// Indicates the state of the tasks to shard tables or convert tables.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// Indicates the name of the table after you convert or shard the table.
            /// </summary>
            [NameInMap("TargetTableName")]
            [Validation(Required=false)]
            public string TargetTableName { get; set; }

        }

        /// <summary>
        /// Indicates the unique ID of the request. If the request fails, provide this ID for technical support to troubleshoot the failure.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
