// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeBackupClientsShrinkRequest : TeaModel {
        /// <summary>
        /// The IDs of HBR clients.
        /// </summary>
        [NameInMap("ClientIds")]
        [Validation(Required=false)]
        public string ClientIdsShrink { get; set; }

        /// <summary>
        /// The type of the HBR client. Valid values:
        /// 
        /// *   **ECS_CLIENT**: HBR client for Elastic Compute Service (ECS) file backup
        /// *   **CONTAINER_CLIENT**: HBR client for container backup
        /// </summary>
        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public string ClientType { get; set; }

        /// <summary>
        /// The ID of the cluster for the backup.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

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
        /// The ID of the source Alibaba Cloud account that authorizes the current Alibaba Cloud account to back up data across Alibaba Cloud accounts.
        /// </summary>
        [NameInMap("CrossAccountUserId")]
        [Validation(Required=false)]
        public long? CrossAccountUserId { get; set; }

        /// <summary>
        /// The IDs of ECS instances.
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIdsShrink { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from page 1. Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 99. Default value: 10.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeBackupClientsShrinkRequestTag> Tag { get; set; }
        public class DescribeBackupClientsShrinkRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the backup vault. Valid values of N: 1 to 20.
            /// 
            /// *   The tag key cannot start with `aliyun` or `acs:`.
            /// *   The tag key cannot contain `http://` or `https://`.
            /// *   The tag key cannot be an empty string.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the backup vault. Valid values of N: 1 to 20.
            /// 
            /// *   The tag value cannot start with `aliyun` or `acs:`.
            /// *   The tag value cannot contain `http://` or `https://`.
            /// *   The tag value cannot be an empty string.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
