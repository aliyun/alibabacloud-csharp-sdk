// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// The mode in which IP addresses are allocated. Valid values:
        /// 
        /// *   **Fixed**: The ALB instance uses a static IP address.
        /// *   **Dynamic**: dynamically allocates an IP address to each zone of the ALB instance.
        /// </summary>
        [NameInMap("AddressAllocatedMode")]
        [Validation(Required=false)]
        public string AddressAllocatedMode { get; set; }

        /// <summary>
        /// The protocol version. Valid values:
        /// 
        /// *   **IPv4:** IPv4.
        /// *   **DualStack:** dual stack.
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// The type of the address of the ALB instance. Valid values:
        /// 
        /// *   **Internet:** The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. In this case, the ALB instance can be accessed over the Internet.
        /// *   **Intranet:** The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. In this case, the ALB instance can be accessed over the VPC in which the ALB instance is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can only contain ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system uses the value of **RequestId** as the value of **ClientToken**. The value of the **RequestId** parameter may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection. Default value: false. Valid values:
        /// 
        /// *   **true:** enables deletion protection.
        /// *   **false:** disables deletion protection.
        /// </summary>
        [NameInMap("DeletionProtectionEnabled")]
        [Validation(Required=false)]
        public bool? DeletionProtectionEnabled { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Default value: false. Valid values:
        /// 
        /// *   **true:** performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false:** performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The billing method of the ALB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class CreateLoadBalancerRequestLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// The ID of the Internet Shared Bandwidth instance that is associated with the Internet-facing ALB instance.
            /// </summary>
            [NameInMap("BandwidthPackageId")]
            [Validation(Required=false)]
            public string BandwidthPackageId { get; set; }

            /// <summary>
            /// The billing method of the ALB instance.
            /// 
            /// Set the value to **PostPay**, which specifies the pay-as-you-go billing method.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// The edition of the ALB instance. The features and billing rules vary based on the edition of the ALB instance. Valid values:
        /// 
        /// *   **Basic:** basic.
        /// *   **Standard:** standard.
        /// *   **StandardWithWaf:** WAF-enabled.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerEdition")]
        [Validation(Required=false)]
        public string LoadBalancerEdition { get; set; }

        /// <summary>
        /// The name of the ALB instance.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The configuration of the configuration read-only mode.
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class CreateLoadBalancerRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// The reason for enabling the configuration read-only mode. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The reason must start with a letter.
            /// 
            /// > This parameter takes effect only if `Status` is set to **ConsoleProtection**.
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// Specifies whether to enable the configuration read-only mode. Valid values:
            /// 
            /// *   **NonProtection**: disables the configuration read-only mode. In this case, you cannot specify ModificationProtectionReason. If you specify ModificationProtectionReason, the value of the parameter is cleared.
            /// *   **ConsoleProtection**: enables the configuration read-only mode. In this case, you can specify ModificationProtectionReason.
            /// 
            /// > If you set this parameter to **ConsoleProtection**, you cannot use the ALB console to modify instance configurations. However, you can call API operations to modify instance configurations.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerRequestTag : TeaModel {
            /// <summary>
            /// The tag key can be up to 128 characters in length, and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value can be up to 128 characters in length, and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) in which you want to create the ALB instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The zones and the vSwitches in the zones. You must specify at least two zones.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateLoadBalancerRequestZoneMappings : TeaModel {
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// The private IPv4 address. You must add at least two zones. You can add a maximum of 10 zones.
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// The vSwitch in the zone. You can specify only one vSwitch (subnet) in each zone of an ALB instance. You can specify up to 10 zones.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The zone ID of the ALB instance. You can specify up to 10 zones for an ALB instance.
            /// 
            /// You can call the [DescribeZones](https://help.aliyun.com/document_detail/36064.html) operation to query the most recent zone list.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
