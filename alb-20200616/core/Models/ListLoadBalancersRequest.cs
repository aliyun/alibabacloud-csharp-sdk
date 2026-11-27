// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4.</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The address type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Internet</b>: The load balancing has a public IP address. The DNS domain name is parsed to the public IP address, so it can be accessed in the public network environment.</para>
        /// </description></item>
        /// <item><description><para><b>Intranet</b>: The load balancing has only a private IP address. The DNS domain name is parsed to the private IP address, so it can only be accessed in the internal network environment of the VPC where the load balancing resides.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The DNS domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-95qnr2itwu9orb****.cn-hangzhou.alb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        /// <summary>
        /// <para>The IPv6 address type of the application load balancing instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Internet</b>: The load balancing has a public IP address. The DNS domain name is parsed to the public IP address, so it can be accessed in the public network environment.</para>
        /// </description></item>
        /// <item><description><para><b>Intranet</b>: The load balancing has only a private IP address. The DNS domain name is parsed to the private IP address, so it can only be accessed in the internal network environment of the VPC where the load balancing resides.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// <para>The business status of the application load balancing instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Abnormal</b>: Abnormal.</para>
        /// </description></item>
        /// <item><description><para><b>Normal</b>: Normal.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("LoadBalancerBussinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBussinessStatus { get; set; }

        /// <summary>
        /// <para>The IDs of the instances. You can specify up to 20 application load balancing instance IDs.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The names of the instances. You can specify up to 10 instance names.</para>
        /// </summary>
        [NameInMap("LoadBalancerNames")]
        [Validation(Required=false)]
        public List<string> LoadBalancerNames { get; set; }

        /// <summary>
        /// <para>The instance status of the application load balancing instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Inactive</b>: The instance is stopped and listeners no longer forward traffic.</para>
        /// </description></item>
        /// <item><description><para><b>Active</b>: The instance is running.</para>
        /// </description></item>
        /// <item><description><para><b>Provisioning</b>: The instance is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Configuring</b>: Upgrade/Downgrade in progress.</para>
        /// </description></item>
        /// <item><description><para><b>CreateFailed</b>: The instance failed to be created. In this case, no fees are generated and the instance can only be deleted. By default, the system cleans up instances that failed to be created within the last 24 hours.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The number of entries to return per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Leave this parameter empty for the first query or when no next query is required.</description></item>
        /// <item><description>If a next query is required, set the value to the <b>NextToken</b> value returned in the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <para><b>PostPay</b> (default value): pay-as-you-go billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance label.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListLoadBalancersRequestTag> Tag { get; set; }
        public class ListLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The IDs of the VPCs to which the application load balancing instances belong. You can specify up to 10 VPC IDs.</para>
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

        /// <summary>
        /// <para>The ID of the active zone where the application load balancing instance resides.</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> operation to query the active zone information corresponding to the active zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
