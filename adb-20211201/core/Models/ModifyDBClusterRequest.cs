// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyDBClusterRequest : TeaModel {
        /// <summary>
        /// The reserved computing resources. Unit: ACUs. Valid values: 0 to 4096. The value must be in increments of 16 ACUs. Each ACU is approximately equal to 1 core and 4 GB memory.
        /// 
        /// >  This parameter must be specified with a unit.
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public string ComputeResource { get; set; }

        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether to allocate all reserved computing resources to the user_default resource group. Valid values:
        /// 
        /// *   true (default)
        /// *   false
        /// </summary>
        [NameInMap("EnableDefaultResourcePool")]
        [Validation(Required=false)]
        public bool? EnableDefaultResourcePool { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the cluster.
        /// 
        /// >  You can call the [DescribeRegions](https://help.aliyun.com/document_detail/454314.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ReservedNodeCount")]
        [Validation(Required=false)]
        public int? ReservedNodeCount { get; set; }

        [NameInMap("ReservedNodeSize")]
        [Validation(Required=false)]
        public string ReservedNodeSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The reserved storage resources. Unit: ACUs. Valid values: 0 to 2064. The value must be in increments of 24 ACUs. Each ACU is approximately equal to 1 core and 4 GB memory.
        /// 
        /// >  This parameter must be specified with a unit.
        /// </summary>
        [NameInMap("StorageResource")]
        [Validation(Required=false)]
        public string StorageResource { get; set; }

    }

}
