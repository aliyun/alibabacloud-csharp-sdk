// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The service IP address of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.XX.XX.6</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The version of the IP address. Valid values: <b>ipv4</b> and <b>ipv6</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The address type of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the CLB instance is released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1513947075000</para>
        /// </summary>
        [NameInMap("AutoReleaseTime")]
        [Validation(Required=false)]
        public long? AutoReleaseTime { get; set; }

        /// <summary>
        /// <para>The backend servers of the CLB instance.</para>
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
                /// <para>The description of the backend server.</para>
                /// <remarks>
                /// <para>This parameter is not returned if Description is not set.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>backend server description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The backend server ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-2zej4lxhjoq1icu*****</para>
                /// </summary>
                [NameInMap("ServerId")]
                [Validation(Required=false)]
                public string ServerId { get; set; }

                /// <summary>
                /// <para>The ID of the elastic network interface (ENI) or elastic container instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.XX.XX.11</para>
                /// </summary>
                [NameInMap("ServerIp")]
                [Validation(Required=false)]
                public string ServerIp { get; set; }

                /// <summary>
                /// <para>The type of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The weight of the backend server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>90</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum bandwidth of the Internet-facing CLB instance that is billed on a pay-by-bandwidth basis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The time when the CLB instance was created. The time is in the <c>YYYY-MM-DDThh:mm:ssZ</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-08-31T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The timestamp generated when the CA certificate is uploaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1504147745000</para>
        /// </summary>
        [NameInMap("CreateTimeStamp")]
        [Validation(Required=false)]
        public long? CreateTimeStamp { get; set; }

        /// <summary>
        /// <para>Indicates whether deletion protection is enabled for the CLB instance.</para>
        /// <para>Valid values: <b>on</b> and <b>off</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>off</para>
        /// </summary>
        [NameInMap("DeleteProtection")]
        [Validation(Required=false)]
        public string DeleteProtection { get; set; }

        /// <summary>
        /// <para>The time when the CLB instance expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-08T16:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The timestamp that indicates the expiration time of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32493801600000</para>
        /// </summary>
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        /// <summary>
        /// <para>The metering method of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayBySpec</b> (default)</description></item>
        /// <item><description><b>PayByCLCU</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only on the China site and takes effect only when <b>PayType</b> is set to <b>PayOnDemand</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayBySpec</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The metering method of the Internet-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>paybytraffic</b></description></item>
        /// <item><description><b>paybybandwidth</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>paybytraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The frontend port used by the CLB instance.</para>
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
        /// <para>The ports or protocols of the listeners.</para>
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
                /// <para>The frontend port that is used by the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// <para>The frontend protocol that is used by the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("ListenerProtocal")]
                [Validation(Required=false)]
                public string ListenerProtocal { get; set; }

            }

        }

        /// <summary>
        /// <para>The ports or protocols of the listeners.</para>
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
                /// <para>Indicates whether the listener is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Listener Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The destination listening port to which requests are forwarded. The port must be open and use HTTPS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>443</para>
                /// </summary>
                [NameInMap("ForwardPort")]
                [Validation(Required=false)]
                public int? ForwardPort { get; set; }

                /// <summary>
                /// <para>Indicates whether the listener is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("ListenerForward")]
                [Validation(Required=false)]
                public string ListenerForward { get; set; }

                /// <summary>
                /// <para>The frontend port that is used by the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenerPort")]
                [Validation(Required=false)]
                public int? ListenerPort { get; set; }

                /// <summary>
                /// <para>The frontend protocol that is used by the CLB instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>https</para>
                /// </summary>
                [NameInMap("ListenerProtocol")]
                [Validation(Required=false)]
                public string ListenerProtocol { get; set; }

            }

        }

        /// <summary>
        /// <para>The CLB instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719dfa08ex****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-instance-test</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The specification of the CLB instance.</para>
        /// <remarks>
        /// <para> Pay-as-you-go CLB instances are not subject to specifications. By default, <b>slb.lcu.elastic</b> is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s1.small</para>
        /// </summary>
        [NameInMap("LoadBalancerSpec")]
        [Validation(Required=false)]
        public string LoadBalancerSpec { get; set; }

        /// <summary>
        /// <para>The status of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inactive</b>: The CLB instance is disabled. CLB instances in the inactive state do not forward traffic.</description></item>
        /// <item><description><b>active</b>: The CLB instance is running as expected. Newly created CLB instances are in the <b>active</b> state by default.</description></item>
        /// <item><description><b>locked</b>: The CLB instance is locked. CLB instances may be locked due to overdue payments or other reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The ID of the primary zone to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("MasterZoneId")]
        [Validation(Required=false)]
        public string MasterZoneId { get; set; }

        /// <summary>
        /// <para>The reason why the configuration read-only mode is enabled. The value is 1 to 80 characters in length. It starts with a letter and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <remarks>
        /// <para> This parameter is valid only when <b>ModificationProtectionStatus</b> is set to <b>ConsoleProtection</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Managed instance</para>
        /// </summary>
        [NameInMap("ModificationProtectionReason")]
        [Validation(Required=false)]
        public string ModificationProtectionReason { get; set; }

        /// <summary>
        /// <para>Indicates whether the configuration read-only mode is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NonProtection</b>: The configuration read-only mode is disabled. After you disable the configuration read-only mode, the value of <b>ModificationProtectionReason</b> is cleared.</description></item>
        /// <item><description><b>ConsoleProtection</b>: The configuration read-only mode is enabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If this parameter is set to <b>ConsoleProtection</b>, you cannot modify instance configurations in the CLB console. However, you can modify instance configurations by calling API operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ConsoleProtection</para>
        /// </summary>
        [NameInMap("ModificationProtectionStatus")]
        [Validation(Required=false)]
        public string ModificationProtectionStatus { get; set; }

        /// <summary>
        /// <para>The network type of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The billing method of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Only <b>PayOnDemand</b> may be returned, which indicates the pay-as-you-go billing method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayOnDemand</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID of the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The alias of the region to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hangzhou</para>
        /// </summary>
        [NameInMap("RegionIdAlias")]
        [Validation(Required=false)]
        public string RegionIdAlias { get; set; }

        /// <summary>
        /// <para>The auto-renewal cycle. Valid values: <b>Year</b> and <b>Month</b>. Default value: Month.</para>
        /// <remarks>
        /// <para> This parameter is valid only if you create a subscription CLB instance on the Alibaba Cloud China site. In this case, <b>PayType</b> must be set to <b>PrePay</b> and <b>RenewalStatus</b> must be set to <b>AutoRenewal</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("RenewalCycUnit")]
        [Validation(Required=false)]
        public string RenewalCycUnit { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. This parameter is valid only if <b>RenewalStatus</b> is set to <b>AutoRenewal</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>Valid values when <b>PeriodUnit</b> is set to <b>Year</b>: <b>1</b>~<b>5</b>.</para>
        /// </description></item>
        /// <item><description><para>Valid values when <b>PeriodUnit</b> is set to <b>Month</b>: <b>1</b>~ <b>9</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when you create a subscription CLB instance on the Alibaba Cloud China site. In this case, the <b>PayType</b> parameter must be set to <b>PrePay</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RenewalDuration")]
        [Validation(Required=false)]
        public int? RenewalDuration { get; set; }

        /// <summary>
        /// <para>Indicates whether auto-renewal is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>AutoRenewal</b>: Auto-renewal is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: Auto-renewal is disabled. You must manually renew the CLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>NotRenewal</b>: The CLB instance will not be renewed upon expiration. If this value is returned, the system does not send notifications until three days before the expiration date.</para>
        /// <para>**</para>
        /// <para><b>Note</b> This parameter is valid only when you create a subscription CLB instance on the Alibaba Cloud China site. In this case, <b>PayType</b> must be set to <b>PrePay</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AutoRenewal</para>
        /// </summary>
        [NameInMap("RenewalStatus")]
        [Validation(Required=false)]
        public string RenewalStatus { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("SlaveZoneId")]
        [Validation(Required=false)]
        public string SlaveZoneId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
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
                /// <para>The tag key. Valid values of N: <b>1</b> to <b>20</b>. The tag key cannot be an empty string.</para>
                /// <para>The tag key can be at most 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It must not start with <c>aliyun</c> or <c>acs:</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value. Valid values of N: <b>1</b> to <b>20</b>. The tag value can be an empty string.</para>
                /// <para>The tag value can be up to 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the vSwitch to which the internal-facing CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-255ecrwq5****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where the internal-facing CLB instance is deployed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-25dvzy9f8****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
