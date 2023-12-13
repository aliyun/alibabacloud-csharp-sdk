// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyDBInstanceSpecRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable automatic payment. Default value: true. Valid values:
        /// 
        /// *   **true**: enables automatic payment. Make sure that your Alibaba Cloud account has a sufficient balance.
        /// *   **false**: disables automatic payment. You can perform the following operations to pay for the instance: Log on to the ApsaraDB for MongoDB console. In the upper-right corner of the page, choose **Expenses** > **User Center**. In the left-side navigation pane, choose **Order Management** > **Order**. On the **Orders for Services** tab, find the order and pay for the order.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The business information.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The coupon code. Default value: `youhuiquan_promotion_option_id_for_blank`.
        /// </summary>
        [NameInMap("CouponNo")]
        [Validation(Required=false)]
        public string CouponNo { get; set; }

        /// <summary>
        /// The instance type. For more information, see [Instance types](~~57141~~). You can also call the [DescribeAvailableResource](~~149719~~) operation to view instance types.
        /// 
        /// > You must specify at least one of the DBInstanceClass and **DBInstanceStorage** parameters.
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The storage capacity of the instance. Valid values: 10 to 3000. The value must be a multiple of 10. Unit: GB. The values that can be specified for this parameter are subject to the instance types. For more information, see [Instance types](~~57141~~).
        /// 
        /// > 
        /// 
        /// *   You must specify at least one of the DBInstanceStorage and **DBInstanceClass** parameters.
        /// 
        /// *   Storage capacity can be scaled down only for pay-as-you-go replica set instances. The new storage capacity you specify must be greater than the used storage capacity.
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public string DBInstanceStorage { get; set; }

        /// <summary>
        /// The time when the changed configurations take effect. Default value: Immediately. Valid values:
        /// 
        /// *   **Immediately**: The configurations immediately take effect.
        /// *   **MaintainTime**: The configurations take effect during the maintenance window of the instance.
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// Additional parameter
        /// </summary>
        [NameInMap("ExtraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// The type of the configuration change. Default value: DOWNGRADE. Valid values:
        /// 
        /// *   **UPGRADE**
        /// *   **DOWNGRADE**
        /// 
        /// > This parameter can be configured only when the billing method of the instance is subscription.
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
        /// The number of read-only nodes. Valid values: **0** to **5**.
        /// 
        /// If your instance has only **Classic Network** and **VPC** endpoints, you must apply for a public endpoint or release the classic network endpoint for the instance before you can change the **Read-only Nodes** value.
        /// 
        /// > You can go to the **Database Connections** page to view the types of networks that are enabled.
        /// </summary>
        [NameInMap("ReadonlyReplicas")]
        [Validation(Required=false)]
        public string ReadonlyReplicas { get; set; }

        /// <summary>
        /// The number of nodes in the instance.
        /// 
        /// *   Valid values of replica set instances: **3**, **5**, and **7**
        /// *   Valid values of standalone instances: **1**
        /// 
        /// > This parameter is not required for a serverless instance which is only available on the China site (aliyun.com).
        /// </summary>
        [NameInMap("ReplicationFactor")]
        [Validation(Required=false)]
        public string ReplicationFactor { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
