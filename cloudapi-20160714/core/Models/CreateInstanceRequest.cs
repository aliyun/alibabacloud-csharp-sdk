// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateInstanceRequest : TeaModel {
        /// <summary>
        /// Whether to automatically pay when renewing. Value:
        /// 
        /// - True: Automatic payment. Please ensure that your account has sufficient balance.
        /// - False: Console manual payment. The specific operation is to log in to the console, select Expenses in the upper right corner, enter the Expense Center, and find the target order in Order Management to make payment.
        /// 
        /// Default value: False.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The billing method of the instance. Valid values: PostPaid (pay-as-you-go) and PrePaid (subscription).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// The subscription duration of the instance.
        /// 
        /// *   If PricingCycle is set to **Month**, set this parameter to an integer ranges from **1** to **9**.
        /// *   If PricingCycle is set to **Year**, set this parameter to an integer ranges from **1** to **3**.
        /// 
        /// >  This parameter is valid and required only if the ChargeType parameter is set to **PrePaid**.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The HTTPS policy.
        /// </summary>
        [NameInMap("HttpsPolicy")]
        [Validation(Required=false)]
        public string HttpsPolicy { get; set; }

        /// <summary>
        /// The CIDR block of the VPC integration instance.
        /// 
        /// *   192.168.0.0/16
        /// *   172.16.0.0/12
        /// 
        /// **
        /// 
        /// **Warning** The VPC integration instance is connected to the specified CIDR block. Plan your CIDR block carefully to prevent overlaps with the private IP addresses of cloud services.
        /// 
        /// >  This parameter is in invitational preview and not available for public use.
        /// </summary>
        [NameInMap("InstanceCidr")]
        [Validation(Required=false)]
        public string InstanceCidr { get; set; }

        /// <summary>
        /// Instance Name
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// Instance specifications
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// The type of the dedicated instance. Valid values:
        /// 
        /// *   vpc_connect: a VPC integration instance
        /// *   normal: a conventional dedicated instance
        /// 
        /// >  This parameter is in invitational preview and not available for public use.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The unit of the subscription duration of the subscription instance. Valid values:
        /// 
        /// *   **year**
        /// *   **month**
        /// 
        /// >  This parameter is required if the ChargeType parameter is set to Prepaid.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The tags that you want to add to the instance.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestTag> Tag { get; set; }
        public class CreateInstanceRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Passwords are used to prevent duplicate requests from being submitted, please do not reuse them.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// The ID of the user\\"s VPC to be connected by the VPC integration instance.
        /// 
        /// >  This parameter is in invitational preview and not available for public use.
        /// </summary>
        [NameInMap("UserVpcId")]
        [Validation(Required=false)]
        public string UserVpcId { get; set; }

        /// <summary>
        /// The zone in which you want to create the instance. This parameter is required for a conventional dedicated instance and optional for a virtual private cloud (VPC) integration instance.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// The network information when the instance is a VPC integration instance, such as the zone, vSwitch, and security group.
        /// 
        /// >  This parameter is in invitational preview and not available for public use.
        /// </summary>
        [NameInMap("ZoneVSwitchSecurityGroup")]
        [Validation(Required=false)]
        public List<CreateInstanceRequestZoneVSwitchSecurityGroup> ZoneVSwitchSecurityGroup { get; set; }
        public class CreateInstanceRequestZoneVSwitchSecurityGroup : TeaModel {
            /// <summary>
            /// The IPv4 CIDR block for the vSwitch.
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// The ID of the security group. Services in the same security group can access each other.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The zone ID.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
