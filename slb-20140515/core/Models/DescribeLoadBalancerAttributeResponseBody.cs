// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The service IP address of the CLB instance.
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// The version of the IP address. Valid values: **ipv4** and **ipv6**.
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// The address type of the CLB instance.
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// The timestamp generated when the CLB instance is released.
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public long? AutoReleaseTime { get; set; }

        /// <summary>
        /// The backend servers of the CLB instance.
        /// </summary>
        [NameInMap("BackendServers")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyBackendServers BackendServers { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyBackendServers : TeaModel {
            [NameInMap("BackendServer")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerAttributeResponseBodyBackendServersBackendServer> BackendServer { get; set; }
            public class DescribeLoadBalancerAttributeResponseBodyBackendServersBackendServer : TeaModel {
                /// <summary>
                /// The description of the backend server.
                /// 
                /// > This parameter is not returned if Description is not set.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The backend server ID.
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// The ID of the elastic network interface (ENI) or elastic container instance.
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// The type of the backend server.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The weight of the backend server.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// The maximum bandwidth of the Internet-facing CLB instance that is billed on a pay-by-bandwidth basis.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The time when the CLB instance was created. The time is in the `YYYY-MM-DDThh:mm:ssZ` format.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The timestamp generated when the CA certificate is uploaded.
        /// </summary>
        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// Indicates whether deletion protection is enabled for the CLB instance.
        /// 
        /// Valid values: **on** and **off**.
        /// </summary>
        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// The time when the CLB instance expires.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The timestamp that indicates the expiration time of the CLB instance.
        /// </summary>
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        /// <summary>
        /// The metering method of the CLB instance. Valid values:
        /// 
        /// *   **PayBySpec** (default)
        /// *   **PayByCLCU**
        /// 
        /// > This parameter is available only on the China site and takes effect only when **PayType** is set to **PayOnDemand**.
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// The metering method of the Internet-facing CLB instance. Valid values:
        /// 
        /// *   **paybytraffic**
        /// *   **paybybandwidth**
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// The frontend port used by the CLB instance.
        /// </summary>
        [NameInMap("ListenerPorts")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyListenerPorts ListenerPorts { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPorts : TeaModel {
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public List<int?> ListenerPort { get; set; }

        }

        /// <summary>
        /// The ports or protocols of the listeners.
        /// </summary>
        [NameInMap("ListenerPortsAndProtocal")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocal ListenerPortsAndProtocal { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocal : TeaModel {
            [NameInMap("ListenerPortAndProtocal")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocalListenerPortAndProtocal> ListenerPortAndProtocal { get; set; }
            public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocalListenerPortAndProtocal : TeaModel {
                /// <summary>
                /// The frontend port that is used by the CLB instance.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// The frontend protocol that is used by the CLB instance.
                /// </summary>
                [NameInMap("ListenerProtocal")]
                [Validation(Required=false)]
                public string ListenerProtocal { get; set; }

            }

        }

        /// <summary>
        /// The ports or protocols of the listeners.
        /// </summary>
        [NameInMap("ListenerPortsAndProtocol")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocol ListenerPortsAndProtocol { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocol : TeaModel {
            [NameInMap("ListenerPortAndProtocol")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocolListenerPortAndProtocol> ListenerPortAndProtocol { get; set; }
            public class DescribeLoadBalancerAttributeResponseBodyListenerPortsAndProtocolListenerPortAndProtocol : TeaModel {
                /// <summary>
                /// Indicates whether the listener is enabled.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The destination listening port to which requests are forwarded. The port must be open and use HTTPS.
                /// </summary>
                [NameInMap("ForwardPort")]
                [Validation(Required=false)]
                public int? ForwardPort { get; set; }

                /// <summary>
                /// Indicates whether the listener is enabled.
                /// </summary>
                [NameInMap("ListenerForward")]
                [Validation(Required=false)]
                public string ListenerForward { get; set; }

                /// <summary>
                /// The frontend port that is used by the CLB instance.
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// The frontend protocol that is used by the CLB instance.
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

            }

        }

        /// <summary>
        /// The CLB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The name of the CLB instance.
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// The specification of the CLB instance.
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// The status of the CLB instance. Valid values:
        /// 
        /// *   **inactive**: The CLB instance is disabled. CLB instances in the inactive state do not forward traffic.
        /// *   **active**: The CLB instance is running as expected. Newly created CLB instances are in the **active** state by default.
        /// *   **locked**: The CLB instance is locked. CLB instances may be locked due to overdue payments or other reasons.
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// The ID of the primary zone to which the CLB instance belongs.
        /// </summary>
        [NameInMap("MasterZoneId")]
        [Validation(Required=false)]
        public string MasterZoneId { get; set; }

        /// <summary>
        /// The reason why the configuration read-only mode is enabled. The value is 1 to 80 characters in length. It starts with a letter and can contain digits, periods (.), underscores (_), and hyphens (-).
        /// 
        /// >  This parameter is valid only when **ModificationProtectionStatus** is set to **ConsoleProtection**.
        /// </summary>
        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        /// <summary>
        /// Indicates whether the configuration read-only mode is enabled. Valid values:
        /// 
        /// *   **NonProtection**: The configuration read-only mode is disabled. After you disable the configuration read-only mode, the value of **ModificationProtectionReason** is cleared.
        /// *   **ConsoleProtection**: The configuration read-only mode is enabled.
        /// 
        /// >  If this parameter is set to **ConsoleProtection**, you cannot modify instance configurations in the CLB console. However, you can modify instance configurations by calling API operations.
        /// </summary>
        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        /// <summary>
        /// The network type of the CLB instance.
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// The billing method of the CLB instance. Valid values:
        /// 
        /// *   Only **PayOnDemand** may be returned, which indicates the pay-as-you-go billing method.
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The region ID of the CLB instance.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The alias of the region to which the CLB instance belongs.
        /// </summary>
        [NameInMap("RegionIdAlias")]
        [Validation(Required=false)]
        public string RegionIdAlias { get; set; }

        /// <summary>
        /// The auto-renewal cycle. Valid values: **Year** and **Month**. Default value: Month.
        /// 
        /// >  This parameter is valid only if you create a subscription CLB instance on the Alibaba Cloud China site. In this case, **PayType** must be set to **PrePay** and **RenewalStatus** must be set to **AutoRenewal**.
        /// </summary>
        [NameInMap("RenewalCycUnit")]
        [Validation(Required=false)]
        public string RenewalCycUnit { get; set; }

        /// <summary>
        /// The auto-renewal duration. This parameter is valid only if **RenewalStatus** is set to **AutoRenewal**.
        /// 
        /// *   Valid values when **PeriodUnit** is set to **Year**: **1**, **2**, and **3**.
        /// 
        /// *   Valid values when **PeriodUnit** is set to **Month**: **1**, **2**, **3**, and **6**.
        /// 
        /// > This parameter is valid only when you create a subscription CLB instance on the Alibaba Cloud China site. In this case, the **PayType** parameter must be set to **PrePay**.
        /// </summary>
        [NameInMap("RenewalDuration")]
        [Validation(Required=false)]
        public int? RenewalDuration { get; set; }

        /// <summary>
        /// Indicates whether auto-renewal is enabled. Valid values:
        /// 
        /// *   **AutoRenewal**: Auto-renewal is enabled.
        /// 
        /// *   **Normal**: Auto-renewal is disabled. You must manually renew the CLB instance.
        /// 
        /// *   **NotRenewal**: The CLB instance will not be renewed upon expiration. If this value is returned, the system does not send notifications until three days before the expiration date.
        /// 
        ///     **
        /// 
        ///     **Note** This parameter is valid only when you create a subscription CLB instance on the Alibaba Cloud China site. In this case, **PayType** must be set to **PrePay**.
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the secondary zone to which the CLB instance belongs.
        /// </summary>
        [NameInMap("SlaveZoneId")]
        [Validation(Required=false)]
        public string SlaveZoneId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeLoadBalancerAttributeResponseBodyTags Tags { get; set; }
        public class DescribeLoadBalancerAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeLoadBalancerAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The tag key. Valid values of N: **1** to **20**. The tag key cannot be an empty string.
                /// 
                /// The tag key can be at most 64 characters in length, and cannot contain `http://` or `https://`. It must not start with `aliyun` or `acs:`.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value. Valid values of N: **1** to **20**. The tag value can be an empty string.
                /// 
                /// The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. The tag value cannot contain `http://` or `https://`.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The ID of the vSwitch to which the internal-facing CLB instance belongs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC) where the internal-facing CLB instance is deployed.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
