// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateOrderForCreateDBNodesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically complete the payment. Valid values:
        /// 
        /// *   **true**: automatically completes the payment. You must make sure that your account balance is sufficient.
        /// *   **false**: does not automatically complete the payment. An unpaid order is generated.
        /// 
        /// >  Default value: true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The additional business information about the instance.
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The commodity code of the instance. Valid values:
        /// 
        /// *   **bards**: The instance is a pay-as-you-go primary instance.
        /// *   **rds**: The instance is a subscription primary instance.
        /// *   **rords**: The instance is a pay-as-you-go read-only instance.
        /// *   **rds_rordspre_public_cn**: The instance is a subscription read-only instance.
        /// *   **bards_intl**: The instance is a pay-as-you-go primary instance.
        /// *   **rds_intl**: The instance is a subscription primary instance.
        /// *   **rords_intl**: The instance is a pay-as-you-go read-only instance.
        /// *   **rds_rordspre_public_intl**: The instance is a subscription read-only instance.
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// The instance ID. You can call the [DescribeDBInstances](~~610396~~) operation to query the ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The details about the node.
        /// </summary>
        [NameInMap("DBNode")]
        [Validation(Required=false)]
        public List<CreateOrderForCreateDBNodesRequestDBNode> DBNode { get; set; }
        public class CreateOrderForCreateDBNodesRequestDBNode : TeaModel {
            /// <summary>
            /// The specification information of the node.
            /// </summary>
            [NameInMap("classCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            [NameInMap("vswId")]
            [Validation(Required=false)]
            public string VswId { get; set; }

            /// <summary>
            /// The zone ID of the node.
            /// </summary>
            [NameInMap("zoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// The database engine version of the instance. Valid values:
        /// 
        /// If the instance runs **MySQL**, set this parameter to **5.5**, **5.6**, **5.7**, or **8.0**.
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The type of the database node. Valid values:
        /// 
        /// *   **Master**: the primary node
        /// *   **Slave**: the secondary node
        /// </summary>
        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public string NodeType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The coupon code.
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~26243~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource of the instance.
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

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
        /// The zone ID of the host. You can call the [DescribeRegions](~~26243~~) operation to query the zone ID of the host.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
