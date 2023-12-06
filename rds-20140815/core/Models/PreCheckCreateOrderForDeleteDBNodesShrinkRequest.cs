// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class PreCheckCreateOrderForDeleteDBNodesShrinkRequest : TeaModel {
        /// <summary>
        /// Specifies whether to automatically complete the payment. Valid values:
        /// 
        /// 1.  **true**: automatically completes the payment. You must make sure that your account balance is sufficient.
        /// 2.  **false**: does not automatically complete the payment. An unpaid order is generated.
        /// 
        /// >  The default value is true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.
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
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the generated token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The commodity code. Valid value:
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
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The node IDs.
        /// </summary>
        [NameInMap("DBNodeId")]
        [Validation(Required=false)]
        public string DBNodeIdShrink { get; set; }

        /// <summary>
        /// The major engine version of the destination instance. The value of this parameter varies based on the value of **Engine**.
        /// 
        /// *   Valid values when Engine is set to MySQL: **5.5, 5.6, 5.7, and 8.0**
        /// *   Valid values when Engine is set to SQLServer: **2008r2, 08r2\_ent_ha, 2012, 2012\_ent_ha, 2012\_std_ha, 2012\_web, 2014\_std_ha, 2016\_ent_ha, 2016\_std_ha, 2016\_web, 2017\_std_ha, 2017\_ent, 2019\_std_ha, and 2019\_ent**
        /// *   Valid values when Engine is set to PostgreSQL: **10.0, 11.0, 12.0, 13.0, 14.0, and 15.0**
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// The type of the database node. Valid value:
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The zone ID.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
