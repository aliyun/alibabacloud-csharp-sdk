// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeShardTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates the data that is returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeShardTaskInfoResponseBodyData Data { get; set; }
        public class DescribeShardTaskInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates the number of remaining days before the tasks to shard tables or convert tables expire.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public string Expired { get; set; }

            /// <summary>
            /// <para>Indicates information about full migration tasks.</para>
            /// </summary>
            [NameInMap("Full")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFull Full { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFull : TeaModel {
                /// <summary>
                /// <para>Indicates the number of remaining days before the tasks expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// <para>Indicates the progress of the tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>Indicates the start time when the tasks are performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-16 15:11:53</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Indicates the number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <para>Indicates the number of transactions processed by the database per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// <para>Indicates information about full check tasks.</para>
            /// </summary>
            [NameInMap("FullCheck")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFullCheck FullCheck { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFullCheck : TeaModel {
                /// <summary>
                /// <para>Indicates the number of remaining days before the tasks expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// <para>Indicates the progress of the tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>Indicates the start time when the tasks are performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-16 15:12:53</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Indicates the number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <para>Indicates the number of transactions processed by the database per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// <para>Indicates information about full correction tasks.</para>
            /// </summary>
            [NameInMap("FullRevise")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataFullRevise FullRevise { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataFullRevise : TeaModel {
                /// <summary>
                /// <para>Indicates the number of remaining days before the tasks expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// <para>Indicates the progress of the tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>Indicates the start time when the tasks are performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-16 15:12:53</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Indicates the number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <para>Indicates the number of transactions processed by the database per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// <para>Indicates information about incremental data synchronization.</para>
            /// </summary>
            [NameInMap("Increment")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataIncrement Increment { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataIncrement : TeaModel {
                /// <summary>
                /// <para>Indicates the latency of the incremental data synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1568617906</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public int? Delay { get; set; }

                /// <summary>
                /// <para>Indicates the start time when the incremental data synchronization is performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-16 15:12:53</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Indicates the number of transactions processed by the database per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// <para>Indicates the incremental data synchronization progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>Indicates check tasks.</para>
            /// </summary>
            [NameInMap("Review")]
            [Validation(Required=false)]
            public DescribeShardTaskInfoResponseBodyDataReview Review { get; set; }
            public class DescribeShardTaskInfoResponseBodyDataReview : TeaModel {
                /// <summary>
                /// <para>Indicates the number of remaining days before the tasks expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Expired")]
                [Validation(Required=false)]
                public int? Expired { get; set; }

                /// <summary>
                /// <para>Indicates the progress of the tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                /// <summary>
                /// <para>Indicates the start time when the tasks are performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-09-16 15:12:53</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Indicates the number of tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Total")]
                [Validation(Required=false)]
                public int? Total { get; set; }

                /// <summary>
                /// <para>Indicates the number of transactions processed by the database per second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Tps")]
                [Validation(Required=false)]
                public int? Tps { get; set; }

            }

            /// <summary>
            /// <para>Indicates the name of the table that you convert or shard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a1</para>
            /// </summary>
            [NameInMap("SourceTableName")]
            [Validation(Required=false)]
            public string SourceTableName { get; set; }

            /// <summary>
            /// <para>Indicates the current stage of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// <para>Indicates the state of the tasks to shard tables or convert tables.</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates the name of the table after you convert or shard the table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2</para>
            /// </summary>
            [NameInMap("TargetTableName")]
            [Validation(Required=false)]
            public string TargetTableName { get; set; }

        }

        /// <summary>
        /// <para>Indicates the unique ID of the request. If the request fails, provide this ID for technical support to troubleshoot the failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D64DE5944A1E541E0CB908A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
