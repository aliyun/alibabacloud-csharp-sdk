// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateLoadBalancerRequest : TeaModel {
        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ipv4</b> (default): IPv4.</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The IPv4 address type of the Network Load Balancing (NLB) instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The load balancing instance has a public IP address. The DNS domain name is resolved to the public IP address, so it can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The load balancing instance has only a private IP address. The DNS domain name is resolved to the private IP address, so it can be accessed only over the internal network of the VPC where the load balancing instance is deployed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>To enable IPv6 access over the Internet for a dual-stack Network Load Balancing (NLB) instance, invoke the <a href="https://help.aliyun.com/document_detail/445878.html">EnableLoadBalancerIpv6Internet</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The ID of the Internet Shared Bandwidth instance that is associated with the Internet-facing instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cbwp-bp1vevu8h3ieh****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The deletion protection configuration.</para>
        /// </summary>
        [NameInMap("DeletionProtectionConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestDeletionProtectionConfig DeletionProtectionConfig { get; set; }
        public class CreateLoadBalancerRequestDeletionProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The deletion protection status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b> (default): disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The reason for changing the deletion protection status. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Instance is running</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the instance. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The billing configuration of the Network Load Balancing (NLB) instance.</para>
        /// </summary>
        [NameInMap("LoadBalancerBillingConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestLoadBalancerBillingConfig LoadBalancerBillingConfig { get; set; }
        public class CreateLoadBalancerRequestLoadBalancerBillingConfig : TeaModel {
            /// <summary>
            /// <para>The billing method of the Network Load Balancing (NLB) instance.</para>
            /// <para>Valid value: <b>PostPay</b>, which indicates the pay-as-you-go billing method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PostPay</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

        }

        /// <summary>
        /// <para>The name of the Network Load Balancing (NLB) instance.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB1</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The type of load balancing. Valid value: <b>network</b>, which indicates Network Load Balancing (NLB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>network</para>
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// <para>The modification protection configuration.</para>
        /// </summary>
        [NameInMap("ModificationProtectionConfig")]
        [Validation(Required=false)]
        public CreateLoadBalancerRequestModificationProtectionConfig ModificationProtectionConfig { get; set; }
        public class CreateLoadBalancerRequestModificationProtectionConfig : TeaModel {
            /// <summary>
            /// <para>The reason for enabling modification protection. The reason must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
            /// <remarks>
            /// <para>This parameter is valid and takes effect only when <b>Status</b> is set to <b>ConsoleProtection</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Business protection period</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The modification protection status of the Network Load Balancing (NLB). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NonProtection</b>: modification protection is disabled. You cannot specify the <b>Reason</b> parameter. If you specify the <b>Reason</b> parameter, the configuration is cleared.</description></item>
            /// <item><description><b>ConsoleProtection</b>: console modification protection is enabled. You can specify the <b>Reason</b> parameter.</description></item>
            /// </list>
            /// <remarks>
            /// <para>If you set the value to <b>ConsoleProtection</b>, modification protection is enabled. You cannot modify the instance configurations in the load balancing console, but you can invoke API operations to modify the instance configurations.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ConsoleProtection</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the Network Load Balancing (NLB) instance. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query region IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestTag> Tag { get; set; }
        public class CreateLoadBalancerRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. The key can contain letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. The value can contain letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) where the Network Load Balancing (NLB) instance is deployed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1b49rqrybk45nio****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone and vSwitch mappings. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateLoadBalancerRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateLoadBalancerRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The EIP instance ID associated with the Internet-facing instance. Each zone corresponds to one EIP instance ID. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip-bp1aedxso6u80u0qf****</para>
            /// </summary>
            [NameInMap("AllocationId")]
            [Validation(Required=false)]
            public string AllocationId { get; set; }

            /// <summary>
            /// <para>The list of IPv4 local addresses. These are the addresses used by the NLB to interact with backend services.
            /// The number of addresses must be an even number, with a minimum of 2 and a maximum of 8.</para>
            /// </summary>
            [NameInMap("Ipv4LocalAddresses")]
            [Validation(Required=false)]
            public List<string> Ipv4LocalAddresses { get; set; }

            /// <summary>
            /// <para>The IPv6 VIP. This is the IPv6 address used by the NLB to provide services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2408:400a:d5:3080:b409:840a:ca:e8e5</para>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            /// <summary>
            /// <para>The list of IPv6 local addresses. These are the addresses used by the NLB to interact with backend services.
            /// The number of addresses must be an even number, with a minimum of 2 and a maximum of 8.</para>
            /// </summary>
            [NameInMap("Ipv6LocalAddresses")]
            [Validation(Required=false)]
            public List<string> Ipv6LocalAddresses { get; set; }

            /// <summary>
            /// <para>The private IPv4 virtual IP address (VIP). This is the private IPv4 address used by the NLB to provide services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.10.1</para>
            /// </summary>
            [NameInMap("PrivateIPv4Address")]
            [Validation(Required=false)]
            public string PrivateIPv4Address { get; set; }

            /// <summary>
            /// <para>The vSwitch that corresponds to the zone. You can use only one vSwitch and one subnet in each zone. You can add up to 10 zones.
            /// If the current region supports two or more zones, you must add at least two zones.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-sersdf****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the Network Load Balancing (NLB) instance is deployed. You can add up to 10 zones. If the current region supports two or more zones, you must add at least two zones.</para>
            /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/443890.html">DescribeZones</a> operation to query zone IDs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
