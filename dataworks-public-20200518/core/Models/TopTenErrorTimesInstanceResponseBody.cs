// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class TopTenErrorTimesInstanceResponseBody : TeaModel {
        /// <summary>
        /// The ranking of nodes on which errors occur.
        /// </summary>
        [NameInMap("InstanceErrorRank")]
        [Validation(Required=false)]
        public TopTenErrorTimesInstanceResponseBodyInstanceErrorRank InstanceErrorRank { get; set; }
        public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRank : TeaModel {
            /// <summary>
            /// The ranking of nodes on which errors occur within the last month.
            /// </summary>
            [NameInMap("ErrorRank")]
            [Validation(Required=false)]
            public List<TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank> ErrorRank { get; set; }
            public class TopTenErrorTimesInstanceResponseBodyInstanceErrorRankErrorRank : TeaModel {
                /// <summary>
                /// The number of errors that occur on the node.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// The ID of the node.
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
                /// The user identifier (UID) of the Alibaba Cloud account used by the owner of the node.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The type of the node.
                /// 
                /// Valid values:
                /// 
                /// 6 (Shell node), 10 (ODPS SQL node), 11 (ODPS MR node), 23 (Data Integration node), 24 (ODPS Script node), 99 (zero load node), 221 (PyODPS 2 node), 225 (ODPS Spark node), 227 (EMR Hive node), 228 (EMR Spark node), 229 (EMR Spark SQL node), 230 (EMR MR node), 239 (OSS object inspection node), 257 (EMR Shell node), 258 (EMR Spark Shell node), 259 (EMR Presto node), 260 (EMR Impala node), 900 (real-time data synchronization node), 1089 (cross-tenant collaboration node), 1091 (Hologres development node), 1093 (Hologres SQL node), 1100 (assignment node), and 1221 (PyODPS 3 node).
                /// </summary>
                [NameInMap("ProgramType")]
                [Validation(Required=false)]
                public int? ProgramType { get; set; }

                /// <summary>
                /// The ID of the DataWorks workspace.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

            }

            /// <summary>
            /// The time when the ranking was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// The ID of the request. You can use the ID to troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
