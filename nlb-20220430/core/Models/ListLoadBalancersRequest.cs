// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ipv4</b>: IPv4.</description></item>
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
        /// <para>The IPv4 address type of the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The load balancing instance has a public IP address. The DNS domain name is resolved to the public IP address. Therefore, the instance is accessible over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The load balancing instance has only a private IP address. The DNS domain name is resolved to the private IP address. Therefore, the instance is accessible only within the internal network environment of the VPC where the load balancing instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The DNS domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlb-wb7r6dlwetvt5j****.cn-hangzhou.nlb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        /// <summary>
        /// <para>The IPv6 address type of the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The load balancing instance has a public IP address. The DNS domain name is resolved to the public IP address. Therefore, the instance is accessible over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The load balancing instance has only a private IP address. The DNS domain name is resolved to the private IP address. Therefore, the instance is accessible only within the internal network environment of the VPC where the load balancing instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// <para>The business status of the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal</b>: The instance is in an abnormal state.</description></item>
        /// <item><description><b>Normal</b>: The instance is in a normal state.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("LoadBalancerBusinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBusinessStatus { get; set; }

        /// <summary>
        /// <para>The IDs of the NLB instances. You can query up to 20 instances at a time.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The names of the NLB instances. You can query up to 20 instance names at a time.</para>
        /// </summary>
        [NameInMap("LoadBalancerNames")]
        [Validation(Required=false)]
        public List<string> LoadBalancerNames { get; set; }

        /// <summary>
        /// <para>The status of the NLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inactive</b>: The instance is stopped. Listeners of the instance no longer forward traffic.</description></item>
        /// <item><description><b>Active</b>: The instance is running.</description></item>
        /// <item><description><b>Provisioning</b>: The instance is being created.</description></item>
        /// <item><description><b>Configuring</b>: Upgrade/Downgrade in progress.</description></item>
        /// <item><description><b>Deleting</b>: The instance is being deleted.</description></item>
        /// <item><description><b>Deleted</b>: The instance is deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The type of load balancing. Only <b>network</b> is returned, which indicates Network Load Balancer (NLB).</para>
        /// 
        /// <b>Example:</b>
        /// <para>network</para>
        /// </summary>
        [NameInMap("LoadBalancerType")]
        [Validation(Required=false)]
        public string LoadBalancerType { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If this is the first request or no next request exists, you do not need to specify this parameter.</description></item>
        /// <item><description>If a next request exists, set the value to the NextToken value returned in the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the NLB instance. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The labels of the NLB instance.</para>
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
            /// <para>ValueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VPC ID of the NLB instance. You can query up to 10 VPC IDs at a time.</para>
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

        /// <summary>
        /// <para>The zone name. You can call the <a href="https://help.aliyun.com/document_detail/443890.html">DescribeZones</a> operation to query zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
