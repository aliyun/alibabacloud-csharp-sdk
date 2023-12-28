// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeReplicaGroupDrillsResponseBody : TeaModel {
        /// <summary>
        /// The information of disaster recovery drills that were performed on the replication pair-consistent group.
        /// </summary>
        [NameInMap("Drills")]
        [Validation(Required=false)]
        public List<DescribeReplicaGroupDrillsResponseBodyDrills> Drills { get; set; }
        public class DescribeReplicaGroupDrillsResponseBodyDrills : TeaModel {
            /// <summary>
            /// The ID of the drill.
            /// </summary>
            [NameInMap("DrillId")]
            [Validation(Required=false)]
            public string DrillId { get; set; }

            /// <summary>
            /// The ID of the replication pair-consistent group.
            /// </summary>
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public string GroupId { get; set; }

            /// <summary>
            /// The information of replication pairs.
            /// </summary>
            [NameInMap("PairsInfo")]
            [Validation(Required=false)]
            public List<DescribeReplicaGroupDrillsResponseBodyDrillsPairsInfo> PairsInfo { get; set; }
            public class DescribeReplicaGroupDrillsResponseBodyDrillsPairsInfo : TeaModel {
                /// <summary>
                /// The ID of the drill disk.
                /// </summary>
                [NameInMap("DrillDiskId")]
                [Validation(Required=false)]
                public string DrillDiskId { get; set; }

                /// <summary>
                /// The status of the drill disk. Valid values:
                /// 
                /// *   created
                /// *   deleted
                /// *   creating
                /// *   deleting
                /// 
                /// >  This parameter can also display error code details if your drill disk fails to be created or deleted.
                /// </summary>
                [NameInMap("DrillDiskStatus")]
                [Validation(Required=false)]
                public string DrillDiskStatus { get; set; }

                /// <summary>
                /// The ID of the replication pair.
                /// </summary>
                [NameInMap("PairId")]
                [Validation(Required=false)]
                public string PairId { get; set; }

            }

            /// <summary>
            /// The recovery point of the drill. The value of this parameter is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("RecoverPoint")]
            [Validation(Required=false)]
            public long? RecoverPoint { get; set; }

            /// <summary>
            /// The beginning time of the drill. The value of this parameter is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("StartAt")]
            [Validation(Required=false)]
            public long? StartAt { get; set; }

            /// <summary>
            /// The status of the drill. Valid values:
            /// 
            /// *   execute_failed
            /// *   executed
            /// *   executing
            /// *   clear_failed
            /// *   clearing
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The error message that appears if the drill fails to be executed.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
