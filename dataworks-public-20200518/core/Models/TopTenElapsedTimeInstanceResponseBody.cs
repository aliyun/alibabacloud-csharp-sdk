// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenElapsedTimeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ranking records of instance execution durations.</para>
        /// </summary>
        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=false)]
        public TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank : TeaModel {
            /// <summary>
            /// <para>The ranking data of instance execution durations.</para>
            /// </summary>
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=false)]
            public List<TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                /// <summary>
                /// <para>The business date when the instance was run.</para>
                /// <para>The value is a 13-digit number, such as <c>1600963200000</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600963200000</para>
                /// </summary>
                [NameInMap("BusinessDate")]
                [Validation(Required=false)]
                public long? BusinessDate { get; set; }

                /// <summary>
                /// <para>The execution duration of the instance, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("Consumed")]
                [Validation(Required=false)]
                public long? Consumed { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>95279527</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node name</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID of the node owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795279527</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The type of the node.
                /// Common types include:
                /// 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (Virtual node), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object check), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (Real-time synchronization), 1089 (Cross-tenant node), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (Assignment node), and 1221 (PyODPS 3).</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public int? ProgramType { get; set; }

            }

            /// <summary>
            /// <para>The timestamp when the ranking of instance execution durations was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600963200000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID. You can use this ID to troubleshoot issues when an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6347364dadsfadf****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
