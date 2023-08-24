// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class EnableAdditionalBandwidthRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: true. Valid values:
        /// 
        /// *   **true**: enables automatic payment. Make sure that you have sufficient balance within your account.
        /// *   **false**: disables automatic payment. If automatic payment is disabled, you must perform the following steps to complete the payment in the ApsaraDB for Redis console: In the top navigation bar, choose **Expenses** > **Renewal Management**. In the left-side navigation pane, click **Orders**. On the **Orders** page, find the order and complete the payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// Specifies whether to enable auto-renewal. Valid values:
        /// 
        /// *   **true**: enables auto-renewal.
        /// *   **false**: disables auto-renewal. This is the default value.
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// The auto-renewal cycle based on which ApsaraDB for Redis automatically renews the purchased bandwidth. Unit: months. Valid values: **1**, **2**, **3**, **4**, **5**, **6**, **7**, **8**, **9**, **12**, **24**, **36**, and **60**.
        /// 
        /// > * This parameter takes effect and must be specified only when you set the **AutoRenew** parameter to **true**.
        /// > * You cannot query the auto-renewal cycle by calling an API operation. To obtain the auto-renewal cycle, you can perform the following procedure: In the top navigation bar of the ApsaraDB for Redis console, choose **Expenses** > **Renewal Management**. On the page that appears, enter the ID of the instance and the `-bw` suffix in the **Instance ID** field. Example: r-bp1zxszhcgatnx****-bw.
        /// </summary>
        [NameInMap("AutoRenewPeriod")]
        [Validation(Required=false)]
        public int? AutoRenewPeriod { get; set; }

        /// <summary>
        /// The amount of bandwidth that you want to purchase. Unit: MB/s. The value of this parameter must be an integer that is greater than or equal to **0**. You can set this parameter to a value that is up to two times the default bandwidth that is supported by the instance type. For example, if the default bandwidth that is supported by the instance type is 10 MB/s, you can set this parameter to a value within the range of **0** to **20**.
        /// 
        /// > * You call the [DescribeRoleZoneInfo](~~190794~~) operation to query the default bandwidth that is supported by an instance type. In the response, the default bandwidth is indicated by the **DefaultBandWidth** parameter. For more information about instance types, see [Overview](~~26350~~).
        /// > * If you specify multiple data shard IDs in the **NodeId** parameter, you must specify the amount of bandwidth that you want to purchase for each specified data shard in the Bandwidth parameter. The bandwidth values that you specify in the Bandwidth parameter must be in the same sequence as the data shard IDs that you specify in the NodeId parameter. In addition, you must separate the bandwidth values with commas (,).
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// The billing method of the bandwidth instance. Default value: PostPaid. Valid values:
        /// 
        /// - PrePaid: subscription
        /// - PostPaid: pay-as-you-go
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The coupon ID.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The ID of the instance. You can call the [DescribeInstances](~~60933~~) operation to query the IDs of instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the data shard for which you want to purchase a specific amount of bandwidth. You can call the [DescribeLogicInstanceTopology](~~94665~~) operation to query the IDs of the data shards in an instance. If you specify multiple data shard IDs, separate the data shard IDs with commas (,). You can also set this parameter to **All**, which specifies all the data shards of the instance.
        /// 
        /// > This parameter is available and required only if the instance is a [cluster master-replica](~~52228~~) or [read/write splitting](~~62870~~) instance.
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// The validity period of the bandwidth that you purchase. Unit: day. Valid values: **1**, **2**, **3**, **7**, **14**, **30**, **60**, **90**, **180**, **365**, **730**, **1095**, and **1825**.
        /// 
        /// > If you want to continue using the purchased bandwidth after the specified period of time elapses, you must call the [RenewAdditionalBandwidth](~~211199~~) operation to submit a renewal order.
        /// </summary>
        [NameInMap("OrderTimeLength")]
        [Validation(Required=false)]
        public string OrderTimeLength { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// The source of the operation. This parameter is used only for internal maintenance. You do not need to specify this parameter.
        /// </summary>
        [NameInMap("SourceBiz")]
        [Validation(Required=false)]
        public string SourceBiz { get; set; }

    }

}
