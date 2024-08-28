// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// The extended information such as the promotional event ID and business information.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: MB. This parameter is used only to query ApsaraDB for Redis Community Edition instances that are deployed in classic mode. We recommend that you use the **InstanceClass** parameter to specify an exact instance type.
        /// 
        /// >  If you specify the **InstanceClass** parameter, you do not need to specify the Capacity parameter.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PostPaid** (default): pay-as-you-go
        /// *   **PrePaid**: subscription
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The coupon code. Default value: youhuiquan_promotion_option_id_for_blank. This value indicates that no coupon code is available.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// Specifies whether to forcefully change the configurations of the instance. Valid values:
        /// 
        /// *   **false**: forcefully changes the configurations.
        /// *   **true** (default): does not forcefully change the configurations.
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// The instance type.
        /// 
        /// **To view the instance type, perform the following steps:**
        /// 
        /// 1.  In the [Overview](https://help.aliyun.com/document_detail/26350.html) topic, click the link in the **Reference** column corresponding to the instance type that you want to view.
        /// 2.  In the instance type table of the page that appears, find the instance type in the **InstanceClass** column.
        /// 
        /// When you query cloud-native cluster instances, you must set this parameter to one of the following values and use the Instances parameter to specify the instance type that you want to query.
        /// 
        /// *   ApsaraDB for Redis cluster instances: redis.cluster.sharding.common.ce
        /// *   Tair DRAM-based cluster instances: tair.rdb.cluster.sharding.common
        /// *   Tair persistent memory-based cluster instances: tair.scm.cluster.sharding.common.ce
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  This parameter is required when the **OrderType** parameter is set to **UPGRADE** or **RENEW**.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// A JSON string that contains information about one or more cloud-native cluster instances. For more information, see the "Additional description of the Instances parameter" section of this topic.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// The node type. Valid values:
        /// 
        /// *   **STAND_ALONE**: standalone
        /// *   **MASTER_SLAVE** (default): high availability (master-replica)
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// Specifies whether to return parameters related to the order. Valid values:
        /// 
        /// *   **false** (default)
        /// *   **true**
        /// </summary>
        [NameInMap("OrderParamOut")]
        [Validation(Required=false)]
        public string OrderParamOut { get; set; }

        /// <summary>
        /// The order type. Valid values:
        /// 
        /// *   **BUY**: The order is used to purchase instances.
        /// *   **UPGRADE**: The order is used to change the configurations of instances.
        /// *   **RENEW**: The order is used to renew instances.
        /// *   **CONVERT**: The order is used to change the billing methods of instances.
        /// 
        /// This parameter is required.
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
        /// The subscription duration. Unit: months. Valid values: **1**, 2, 3, 4, 5, 6, 7, 8, **9**, **12**, **24**, and **36**.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// The number of instances that you want to purchase. Valid values: **1** to **30**. Default value: **1**.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/61012.html) operation to query the most recent region list.
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

        [NameInMap("ShardCount")]
        [Validation(Required=false)]
        public int? ShardCount { get; set; }

        /// <summary>
        /// The zone ID of the instance. You can call the [DescribeZones](https://help.aliyun.com/document_detail/94527.html) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
