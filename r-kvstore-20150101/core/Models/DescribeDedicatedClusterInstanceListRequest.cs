// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeDedicatedClusterInstanceListRequest : TeaModel {
        /// <summary>
        /// The ID of the dedicated cluster. You can view the dedicated cluster ID on the Dedicated Clusters page in the ApsaraDB for MyBase console.
        /// 
        /// > Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The ID of the host in the dedicated cluster. You can call the [DescribeDedicatedHosts](https://help.aliyun.com/document_detail/200944.html) operation to query the host ID.
        /// 
        /// > Separate multiple IDs with commas (,).
        /// </summary>
        [NameInMap("DedicatedHostName")]
        [Validation(Required=false)]
        public string DedicatedHostName { get; set; }

        /// <summary>
        /// The database engine of the instance. Set the value to **Redis**.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The database engine version of the instance. Set the value to **5.0**.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > The instance must be created by using a dedicated cluster. For more information, see [What is ApsaraDB for MyBase?](https://help.aliyun.com/document_detail/141455.html)
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The network type of the instance. Valid values:
        /// 
        /// *   **0**: Internet
        /// *   **1**: classic network
        /// *   **2**: Virtual Private Cloud (VPC)
        /// </summary>
        [NameInMap("InstanceNetType")]
        [Validation(Required=false)]
        public string InstanceNetType { get; set; }

        /// <summary>
        /// The state of the instance. Valid values:
        /// 
        /// *   **0**: The instance is being created.
        /// *   **1**: The instance is running.
        /// *   **3**: The instance is being deleted.
        /// *   **5**: The configurations of the instance are being changed.
        /// *   **6**: The instance is being migrated.
        /// *   **7**: The instance is being restored from a backup.
        /// *   **8**: A master-replica switchover is in progress.
        /// *   **9**: Expired data of the instance is being deleted.
        /// </summary>
        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public int? InstanceStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of the page to return. The value must be an integer that is greater than **0**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **30**, **50**, and **100**. Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeZones](https://help.aliyun.com/document_detail/94527.html) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
