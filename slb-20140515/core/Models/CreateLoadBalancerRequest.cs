// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// The private IP address of the CLB instance. The private IP address must belong to the destination CIDR block of the vSwitch.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The IP version that is used by the CLB instance. Valid values: **ipv4** and **ipv6**.
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// The network type of the CLB instance. Valid values:
        /// 
        /// *   **internet**: After an Internet-facing CLB instance is created, the system assigns a public IP address to the CLB instance. Then, the CLB instance can forward requests over the Internet.
        /// *   **intranet**: After an internal-facing CLB instance is created, the system assigns a private IP address to the CLB instance. Then, the CLB instance can forward requests only over the internal networks.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// Specifies whether to automatically pay for the subscription Internet-facing CLB instance. Valid values:
        /// 
        /// *   **true**: automatically pays for the CLB instance. After you call this operation, the system automatically completes the payment and creates the CLB instance.
        /// *   **false** (default): After you call the operation, the order is created but the payment is not completed. You can view the pending order in the console. The CLB instance will not be created until you complete the payment.
        /// 
        /// >  This parameter is supported only by subscription instances created on the Alibaba Cloud China site.
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// The maximum bandwidth of the listener. Unit: Mbit/s.
        /// 
        /// Valid values: **1** to **5120**. For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of the maximum bandwidth of all listeners cannot exceed the maximum bandwidth of the CLB instance.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests.
        /// 
        /// >  If you do not specify this parameter, the system uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to enable deletion protection for the CLB instance. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// The subscription duration of the Internet-facing CLB instance. Valid values:
        /// 
        /// *   If **PricingCycle** is set to **month**, the valid values are **1 to 9**.
        /// *   If **PricingCycle** is set to **year**, the valid values are **1 to 5**.
        /// 
        /// >  This parameter is supported only by subscription instances created on the Alibaba Cloud China site.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The metering method of the CLB instance. Valid values:
        /// 
        /// *   **PayBySpec** (default)
        /// *   **PayByCLCU**
        /// 
        /// >  This parameter is supported only by instances created on the Alibaba Cloud China site and only when **PayType** is set to **PayOnDemand**.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The metering method of the Internet-facing CLB instance. Valid values:
        /// 
        /// *   **paybytraffic** (default)
        /// 
        /// > If you set the value to **paybytraffic**, you do not need to specify **Bandwidth**. Even if you specify **Bandwidth**, the value does not take effect.
        /// 
        /// *   **paybybandwidth**: pay-by-bandwidth
        /// 
        /// >  If you set **PayType** to **PayOnDemand** and set **InstanceChargeType** to **PayByCLCU**, you must set InternetChargeType to **paybytraffic**.
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The CLB instance name.
        /// 
        /// The name must be 1 to 80 characters in length, and can contain digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter.
        /// 
        /// If you do not specify this parameter, the system automatically assigns a name to the CLB instance.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The specification of the CLB instance. Valid values:
        /// 
        /// *   **slb.s1.small**
        /// 
        /// *   **slb.s2.small**
        /// 
        /// *   **slb.s2.medium**
        /// 
        /// *   **slb.s3.small**
        /// 
        /// *   **slb.s3.medium**
        /// 
        /// *   **slb.s3.large**
        /// 
        ///     **
        /// 
        ///     **Note** If you do not specify this parameter, a shared-resource CLB instance is created. Shared-resource CLB instances are no longer available for purchase. Therefore, you must specify this parameter.
        /// 
        /// If **InstanceChargeType** is set to **PayByCLCU**, this parameter is invalid and you do not need to specify this parameter.
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// The ID of the primary zone to which the CLB instance belongs.
        /// 
        /// You can call the [DescribeZone](~~DescribeZone~~) operation to query the primary and secondary zones in the region where you want to create the CLB instance.
        /// </summary>
        [NameInMap("MasterZoneId")]
        [Validation(Required=false)]
        public string MasterZoneId { get; set; }

        /// <summary>
        /// The reason for enabling the configuration read-only mode. The reason must be 1 to 80 characters in length. It must start with a letter and can contain letters, digits, periods (.), underscores (\_), and hyphens (-).
        /// 
        /// >  This parameter takes effect only when **ModificationProtectionStatus** is set to **ConsoleProtection**.
        /// </summary>
        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        /// <summary>
        /// Specifies whether to enable the configuration read-only mode. Valid values:
        /// 
        /// *   **NonProtection**: disables the configuration read-only mode. After you disable the configuration read-only mode, the value of **ModificationProtectionReason** is cleared.
        /// *   **ConsoleProtection**: enables the configuration read-only mode.
        /// 
        /// >  If you set this parameter to **ConsoleProtection**, you cannot modify instance configurations in the CLB console. However, you can modify instance configurations by calling API operations.
        /// </summary>
        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The billing method of the CLB instance. Set the value to
        /// 
        /// **PayOnDemand**, which specifies the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The billing cycle of the subscription Internet-facing CLB instance. Valid values:
        /// 
        /// *   **month**
        /// *   **year**
        /// 
        /// >  This parameter is supported only by subscription instances created on the Alibaba Cloud China site.
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// The region ID of the CLB instance.
        /// 
        /// You can call the [DescribeRegions](~~DescribeRegions~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// The ID of the secondary zone to which the CLB instance belongs.
        /// 
        /// You can call the [DescribeZone](~~DescribeZone~~) operation to query the primary and secondary zones in the region where you want to create the CLB instance.
        /// </summary>
        [NameInMap("SlaveZoneId")]
        [Validation(Required=false)]
        public string SlaveZoneId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the bastion host. Valid values of N: **1 to 20**. The tag key cannot be an empty string.
            /// 
            /// The tag key can be at most 64 characters in length, and cannot contain `http://` or `https://`. It must not start with `aliyun` or `acs:`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. Valid values of N: **1 to 20**. The tag value can be an empty string.
            /// 
            /// The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch to which the CLB instance belongs.
        /// 
        /// If you want to deploy the CLB instance in a VPC, this parameter is required. If this parameter is specified, **AddessType** is set to **intranet** by default.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) to which the CLB instance belongs.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
