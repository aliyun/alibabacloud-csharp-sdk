// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenElapsedTimeInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ranking record of the running durations of the instances.</para>
        /// </summary>
        [NameInMap("InstanceConsumeTimeRank")]
        [Validation(Required=false)]
        public TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank InstanceConsumeTimeRank { get; set; }
        public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRank : TeaModel {
            /// <summary>
            /// <para>The ranking data of the running durations of the instances.</para>
            /// </summary>
            [NameInMap("ConsumeTimeRank")]
            [Validation(Required=false)]
            public List<TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank> ConsumeTimeRank { get; set; }
            public class TopTenElapsedTimeInstanceResponseBodyInstanceConsumeTimeRankConsumeTimeRank : TeaModel {
                /// <summary>
                /// <para>The data timestamp of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1600963200000</para>
                /// </summary>
                [NameInMap("BusinessDate")]
                [Validation(Required=false)]
                public long? BusinessDate { get; set; }

                /// <summary>
                /// <para>The run time length of the instance. Unit: seconds.</para>
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
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9527</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The name of the node.</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used by the node owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795279527</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The type of the node. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3)</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public int? ProgramType { get; set; }

            }

            /// <summary>
            /// <para>The timestamp at which the ranking of the running durations of the instances was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1600963200000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6347364dadsfadf****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
