// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenErrorTimesInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ranking data of nodes on which errors occurred.
        /// </summary>
        [NameInMap("InstanceErrorRank")]
        [Validation(Required=false)]
        public TopTenErrorTimesInstanceResponseBodyInstanceErrorRank InstanceErrorRank { get; set; }
        public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRank : TeaModel {
            /// <summary>
            /// The ranking data of nodes on which errors occurred within the last month.
            /// </summary>
            [NameInMap("ErrorRank")]
            [Validation(Required=false)]
            public List<TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank : TeaModel {
                /// <summary>
                /// The number of errors that occurred on the node.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The node ID.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// The name of the node.
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account used by the node owner.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The type of the node. Valid values: 6 (Shell), 10 (ODPS SQL), 11 (ODPS MR), 23 (Data Integration), 24 (ODPS Script), 99 (zero load), 221 (PyODPS 2), 225 (ODPS Spark), 227 (EMR Hive), 228 (EMR Spark), 229 (EMR Spark SQL), 230 (EMR MR), 239 (OSS object inspection), 257 (EMR Shell), 258 (EMR Spark Shell), 259 (EMR Presto), 260 (EMR Impala), 900 (real-time synchronization), 1089 (cross-tenant collaboration), 1091 (Hologres development), 1093 (Hologres SQL), 1100 (assignment), and 1221 (PyODPS 3)
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public int? ProgramType { get; set; }

                /// <summary>
                /// The DataWorks workspace ID.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// The timestamp at which the rankings were updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
