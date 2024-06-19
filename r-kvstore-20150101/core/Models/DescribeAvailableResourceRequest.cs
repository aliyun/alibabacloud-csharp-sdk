// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeAvailableResourceRequest : TeaModel {
        /// <summary>
        /// The display language of the response. Default value: zh-CN. Valid values:
        /// 
        /// *   **zh-CN**: Chinese
        /// *   **en-US**: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The category of the instance. Valid values:
        /// 
        /// *   **Redis**
        /// *   **Memcache**
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PrePaid**: subscription
        /// *   **PostPaid**: pay-as-you-go
        /// 
        /// > The default value is **PrePaid**.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// > This parameter is available and required only if the **OrderType** parameter is set to **UPGRADE** or **DOWNGRADE**.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The edition of the instance. Valid values:
        /// 
        /// *   **professional**: Standard Edition. This edition supports the standalone, master-replica, read /write splitting, and cluster architectures and provides high scalability.
        /// </summary>
        [NameInMap("InstanceScene")]
        [Validation(Required=false)]
        public string InstanceScene { get; set; }

        /// <summary>
        /// The ID of the data node for which you want to query available resources that can be created. You can call the [DescribeLogicInstanceTopology](https://help.aliyun.com/document_detail/94665.html) operation to query the ID of the data node. Remove the number sign (`#`) and the content that follows the number sign. For example, retain only r-bp10noxlhcoim2\\*\\*\\*\\*-db-0.
        /// 
        /// > Before you specify this parameter, you must set the **InstanceId** parameter to the ID of an instance that uses the cluster or read/write splitting architecture.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The type of the order. Default value: BUY. Valid values:
        /// 
        /// *   **BUY**: orders that are newly created
        /// *   **UPGRADE**: orders that are used to upgrade instances
        /// *   **DOWNGRADE**: orders that are used to downgrade instances
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The series of the instance. Valid values:
        /// 
        /// *   **Local**: classic ApsaraDB for Redis Community Edition instance or classic ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance
        /// *   **Tair_rdb**: cloud-native ApsaraDB for Redis Enhanced Edition (Tair) DRAM-based instance
        /// *   **Tair_scm**: ApsaraDB for Redis Enhanced Edition (Tair) persistent memory-optimized instance
        /// *   **Tair_essd**: ESSD-based instance
        /// *   **OnECS**: cloud-native ApsaraDB for Redis Community Edition instance
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs. You can call the [ListResourceGroups](https://help.aliyun.com/document_detail/158855.html) operation to query the IDs of resource groups.
        /// 
        /// > You can also query the IDs of resource groups in the Resource Management console. For more information, see [View basic information about a resource group](https://help.aliyun.com/document_detail/151181.html).
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
