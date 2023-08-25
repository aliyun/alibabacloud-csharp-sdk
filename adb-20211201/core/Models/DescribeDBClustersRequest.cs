// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClustersRequest : TeaModel {
        /// <summary>
        /// The description of the cluster.
        /// 
        /// *   The description cannot start with `http://` or `https://`.
        /// *   The description must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// If you do not specify this parameter, the information of all clusters that reside in the specified region is returned.
        /// </summary>
        [NameInMap("DBClusterIds")]
        [Validation(Required=false)]
        public string DBClusterIds { get; set; }

        /// <summary>
        /// The state of the cluster. Valid values:
        /// 
        /// *   **Preparing**: The cluster is being prepared.
        /// *   **Creating**: The cluster is being created.
        /// *   **Running**: The cluster is running.
        /// *   **Deleting**: The cluster is being deleted.
        /// *   **Restoring**: The cluster is being restored from a backup.
        /// *   **ClassChanging**: The cluster specifications are being changed.
        /// *   **NetAddressCreating**: A network connection is being created.
        /// *   **NetAddressDeleting**: A network connection is being deleted.
        /// *   **NetAddressModifying**: A network connection is being modified.
        /// </summary>
        [NameInMap("DBClusterStatus")]
        [Validation(Required=false)]
        public string DBClusterStatus { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 30. Valid values:
        /// 
        /// *   **30**
        /// *   **50**
        /// *   **100**
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// >  You can call the [DescribeRegions](~~454314~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// 
        /// If you do not specify this parameter, the information of all resource groups in the cluster is returned.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDBClustersRequestTag> Tag { get; set; }
        public class DescribeDBClustersRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
