// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClustersRequest : TeaModel {
        /// <summary>
        /// The description of the cluster.
        /// 
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description must be 2 to 256 characters in length
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The cluster IDs.
        /// 
        /// > You can specify the ID of one cluster or IDs of more clusters within the preceding region.
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// The state of the cluster. Valid values:
        /// 
        /// *   **Preparing**: The cluster is being prepared.
        /// *   **Creating**: The cluster is being created.
        /// *   **Restoring**: The cluster is being restored from a backup.
        /// *   **Running**: The cluster is running.
        /// *   **Deleting**: The cluster is being deleted.
        /// *   **ClassChanging**: The cluster specifications are being changed.
        /// *   **NetAddressCreating**: A network connection is being created.
        /// *   **NetAddressDeleting**: A network connection is being deleted.
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// The version of the cluster. Set the value to **3.0**.
        /// </summary>
        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values:
        /// 
        /// *   **30** (default)
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the clusters.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tags that are added to the cluster.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBClustersRequestTag> Tag { get; set; }
        public class DescribeDBClustersRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N that is added to the cluster. You can use tags to filter clusters. A tag is a key-value pair. You can specify up to 20 tags in one request. The letter N specifies the sequence number of each key-value pair and must be unique. The values of N must be consecutive integers that start from 1. Each value of `Tag.N.Key` is paired with a value of `Tag.N.Value`.
            /// 
            /// > The tag key can be up to 64 characters in length and cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that is added to the cluster. You can use tags to filter clusters. A tag is a key-value pair. You can specify up to 20 tags in one request. The letter N specifies the sequence number of each key-value pair and must be unique. The values of N must be consecutive integers that start from 1. Each value of `Tag.N.Key` is paired with a value of `Tag.N.Value`.
            /// 
            /// > The tag key can be up to 64 characters in length and cannot start with `aliyun`, `acs:`, `http://`, or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
