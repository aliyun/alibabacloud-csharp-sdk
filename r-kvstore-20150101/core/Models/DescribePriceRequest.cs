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
        /// The storage capacity of the instance. Unit: MB. You must specify one of the **InstanceClass** and **Capacity** parameters to specify the instance type. We recommend that you use **InstanceClass** to specify the instance type.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PostPaid**: pay-as-you-go
        /// *   **PrePaid**: subscription.
        /// 
        /// > The default value is **PostPaid**.
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
        /// *   **true**: does not forcefully change the configurations.
        /// 
        /// > The default value is **true**.
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// The instance type of the instance. You must specify one of the InstanceClass and Capacity parameters to specify the instance type. We recommend that you use InstanceClass to specify the instance type.
        /// 
        /// To query the instance type, perform the following steps:
        /// 
        /// 1.  In the [Overview](~~26350~~) topic, click the link in the **Reference** column corresponding to the instance type that you want to view.
        /// 2.  In the instance type table of the page that appears, find the instance type in the **InstanceClass** column.
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// A JSON string that contains multiple instances. For more information, see [Description of the Instances parameter in the DescribePrice API operation](~~161811~~).
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// The node type. Set the value to MASTER_SLAVE. This value indicates that the node type is master-replica.
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// Specifies whether to return parameters related to the order. Valid values:
        /// 
        /// *   **false**: does not return parameters related to the order.
        /// *   **true**: returns parameters related to the order.
        /// 
        /// > The default value is **false**.
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
        /// The number of instances that you want to purchase. Valid values: **1** to **30**.
        /// 
        /// > The default value is **1**.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61012~~) operation to query the most recent region list.
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
        /// The zone ID of the instance. You can call the [DescribeZones](~~94527~~) operation to query the most recent zone list.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
