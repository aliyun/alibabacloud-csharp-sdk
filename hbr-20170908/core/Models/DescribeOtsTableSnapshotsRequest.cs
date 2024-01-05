// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeOtsTableSnapshotsRequest : TeaModel {
        /// <summary>
        /// The name of the RAM role that is created within the source Alibaba Cloud account and assigned to the current Alibaba Cloud account to authorize the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountRoleName")]
        [Validation(Required=false)]
        public string CrossAccountRoleName { get; set; }

        /// <summary>
        /// Specifies whether data is backed up within the same Alibaba Cloud account or across Alibaba Cloud accounts. Valid values:
        /// 
        /// *   SELF_ACCOUNT: Data is backed up within the same Alibaba Cloud account.
        /// *   CROSS_ACCOUNT: Data is backed up across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountType")]
        [Validation(Required=false)]
        public string CrossAccountType { get; set; }

        /// <summary>
        /// The UID of the source account used for cross-account backup.
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// The end time of the backup. The value must be a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The maximum number of rows that you want the current query to return.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The token that is required to obtain the next page of backup snapshots.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The Tablestore instances that are backed up.
        /// </summary>
        [NameInMap("OtsInstances")]
        [Validation(Required=false)]
        public List<DescribeOtsTableSnapshotsRequestOtsInstances> OtsInstances { get; set; }
        public class DescribeOtsTableSnapshotsRequestOtsInstances : TeaModel {
            /// <summary>
            /// The name of the Tablestore instance.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The names of the tables in the Tablestore instance.
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public List<string> TableNames { get; set; }

        }

        /// <summary>
        /// The snapshot IDs.
        /// </summary>
        [NameInMap("SnapshotIds")]
        [Validation(Required=false)]
        public List<string> SnapshotIds { get; set; }

        /// <summary>
        /// The start time of the backup. The value must be a UNIX timestamp. Unit: milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
