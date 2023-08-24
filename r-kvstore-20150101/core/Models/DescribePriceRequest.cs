// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribePriceRequest : TeaModel {
        /// <summary>
        /// The coupon code. Default value: youhuiquan_promotion_option_id_for_blank. This value indicates that no coupon code is available.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~61012~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// The actual price of the order.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// Specify the instance type. You must set InstanceClass or Capacity to specify the instance type. We recommend that you use InstanceClass to specify the instance type.
        /// 
        /// To view the instance type, perform the following steps:
        /// 
        /// 1\. In the [Overview](~~26350~~) topic, click the link in the **Reference** column corresponding to the instance type that you want to view.
        /// 
        /// 2\. In the instance type table of the page that appears, find the code corresponding to the instance type in the **InstanceClass** column.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The node type. Set the value to MASTER_SLAVE. This value indicates that the node type is master-replica.
        /// </summary>
        [NameInMap("ForceUpgrade")]
        [Validation(Required=false)]
        public bool? ForceUpgrade { get; set; }

        /// <summary>
        /// Specifies whether to forcefully change the configurations of the instance. Default value: true. Valid values:
        /// 
        /// *   **false**: The system forcefully changes the configurations.
        /// *   **true**: The system does not forcefully change the configurations.
        /// 
        /// >  Default value: **true**.
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// The subscription period. Unit: months. Valid values: **1**, 2, 3, 4, 5, 6, 7, 8, **9**, **12**, **24**, and **36**.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Unit: MB. You must set **InstanceClass** or **Capacity** to specify the instance type. We recommend that you use **InstanceClass** to specify the instance type.
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string Instances { get; set; }

        /// <summary>
        /// The discount amount of the order.
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        /// <summary>
        /// Indicates whether the coupon was selected.
        /// </summary>
        [NameInMap("OrderParamOut")]
        [Validation(Required=false)]
        public string OrderParamOut { get; set; }

        /// <summary>
        /// The service fees of the order.
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
        /// The extended information such as the promotional event ID and business information.
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public long? Period { get; set; }

        /// <summary>
        /// The currency used for payment. A value of CNY is used when the order was generated on the China site (aliyun.com), and a value of USD is used when the order was generated on the international site (alibabacloud.com).
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values:
        /// 
        /// *   **PostPaid**: pay-as-you-go
        /// *   **PrePaid**: subscription
        /// 
        /// >  Default value: **PostPaid**.
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
        /// The description of the coupon.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
