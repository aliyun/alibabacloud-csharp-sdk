// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies the client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters and cannot exceed 64 characters in length.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies the description of the instance. The description must meet the following requirements:
        /// 
        /// *   The description cannot contain the prefix http:// or https://.
        /// *   The description must start with a letter or a Chinese character, and can contain uppercase and lowercase letters, Chinese characters, digits, underscores (\_), and hyphens (-).
        /// *   The description must be 2 to 256 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies the purchase duration of the subscription instance.
        /// 
        /// *   If the PricingCycle parameter is set to year, the value range of the Duration parameter is 1 to 3.
        /// *   If the PricingCycle parameter is set to month, the value range of the Duration parameter is 1 to 9.
        /// 
        /// >  This parameter only takes effect when the PayType parameter is set to drdsPre.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// Specifies the instance type of the instance. Valid values:
        /// 
        /// *   **drds.sn2.4c16g**: The instance is of the Starter Edition.
        /// *   **drds.sn2.8c32g**: The instance is of the Standard Edition
        /// *   **drds.sn2.16c64g**: The instance is of the Enterprise Edition.
        /// </summary>
        [NameInMap("InstanceSeries")]
        [Validation(Required=false)]
        public string InstanceSeries { get; set; }

        /// <summary>
        /// Specifies whether to enable automatic renewal. Valid values:
        /// 
        /// *   **true**: If the PricingCycle parameter is set to month, the subscription is automatically renewed for one month. If the PricingCycle parameter is set to year, the subscription is automatically renewed for one year.
        /// *   **false**: The auto-renewal feature is disabled for the instance.
        /// 
        /// >  This parameter only takes effect when the PayType parameter is set to drdsPre.
        /// </summary>
        [NameInMap("IsAutoRenew")]
        [Validation(Required=false)]
        public bool? IsAutoRenew { get; set; }

        /// <summary>
        /// Specifies the ID of the primary instance. This parameter is only required when you create a read-only instance.
        /// </summary>
        [NameInMap("MasterInstId")]
        [Validation(Required=false)]
        public string MasterInstId { get; set; }

        /// <summary>
        /// Specifies the MySQL version that is supported by the instance. Valid values:
        /// 
        /// *   **5**: The instance is fully compatible with MySQL 5.x. This value is the default value.
        /// *   **8**: The instance is fully compatible with MySQL 8.0.
        /// 
        /// >  This parameter only takes effect when you create a primary instance. By default, the MySQL version of the read-only instance is the same as that of the primary instance.
        /// </summary>
        [NameInMap("MySQLVersion")]
        [Validation(Required=false)]
        public int? MySQLVersion { get; set; }

        /// <summary>
        /// Specifies the billing method of the instance. Valid values:
        /// 
        /// *   **drdsPre**: The instance uses the subscription billing method.
        /// *   **drdsPost**: The instance uses the pay-as-you-go billing method.
        /// *   **drdsRo**: By default, the pay-as-you-go billing method is used when you create read-only instances.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// Specifies the unit of the subscription duration of the subscription instance. Valid values:
        /// 
        /// *   **year**: The unit of the subscription duration is year.
        /// *   **month**: The unit of the subscription duration is month.
        /// 
        /// >  This parameter is required if you set the PayType parameter to drdsPre.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// Specifies the number of instances to be created. You can set the value only to 1. The value specifies that you can create one instance each time.
        /// </summary>
        [NameInMap("Quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Specifies the region ID of the instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies the ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies the specification code of the instance. The value consists of the instance type and the specified instance specification. For example, you can set the value to drds.sn2.4c16g.8c32g.
        /// </summary>
        [NameInMap("Specification")]
        [Validation(Required=false)]
        public string Specification { get; set; }

        /// <summary>
        /// Specifies the type of the instance. Set the value to PRIVATE. The value PRIVATE specifies that the instance is a dedicated instance.
        /// 
        /// >  You can also set the value to 1 to specify that the instance is a dedicated instance.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// Specifies the ID of the VPC.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// Specifies the ID of the vSwitch.
        /// </summary>
        [NameInMap("VswitchId")]
        [Validation(Required=false)]
        public string VswitchId { get; set; }

        /// <summary>
        /// Specifies the zone ID of the instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// Specifies whether the instance is a high-availability instance.
        /// </summary>
        [NameInMap("isHa")]
        [Validation(Required=false)]
        public bool? IsHa { get; set; }

    }

}
