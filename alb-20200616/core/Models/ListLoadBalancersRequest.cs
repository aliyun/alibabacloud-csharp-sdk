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
        /// <item><description><b>IPv4</b></description></item>
        /// <item><description><b>DualStack</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The network type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. In this case, the ALB instance can be accessed over the VPC where the ALB instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alb-95qnr2itwu9orb****.cn-hangzhou.alb.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DNSName")]
        [Validation(Required=false)]
        public string DNSName { get; set; }

        /// <summary>
        /// <para>The type of IPv6 address that is used by the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Internet</b>: The ALB instance uses a public IP address. The domain name of the ALB instance is resolved to the public IP address. Therefore, the ALB instance can be accessed over the Internet.</description></item>
        /// <item><description><b>Intranet</b>: The ALB instance uses a private IP address. The domain name of the ALB instance is resolved to the private IP address. Therefore, the ALB instance can be accessed over the VPC in which the ALB instance is deployed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("Ipv6AddressType")]
        [Validation(Required=false)]
        public string Ipv6AddressType { get; set; }

        /// <summary>
        /// <para>The service status of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Abnormal</b></description></item>
        /// <item><description><b>Normal</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("LoadBalancerBussinessStatus")]
        [Validation(Required=false)]
        public string LoadBalancerBussinessStatus { get; set; }

        /// <summary>
        /// <para>The instance IDs. You can specify at most 20 ALB instance IDs.</para>
        /// </summary>
        [NameInMap("LoadBalancerIds")]
        [Validation(Required=false)]
        public List<string> LoadBalancerIds { get; set; }

        /// <summary>
        /// <para>The instance names. You can specify at most 10 instance names.</para>
        /// </summary>
        [NameInMap("LoadBalancerNames")]
        [Validation(Required=false)]
        public List<string> LoadBalancerNames { get; set; }

        /// <summary>
        /// <para>The status of the ALB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inactive</b>: The ALB instance is disabled. The listeners do not forward traffic.</description></item>
        /// <item><description><b>Active</b>: The ALB instance is running.</description></item>
        /// <item><description><b>Provisioning</b>: The ALB instance is being created.</description></item>
        /// <item><description><b>Configuring</b>: The ALB instance is being modified.</description></item>
        /// <item><description><b>CreateFailed</b>: The system failed to create the ALB instance. In this case, you are not charged for the ALB instance. You can only delete the ALB instance. By default, the system deletes the ALB instances that are in the CreateFailed state within the last day.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("LoadBalancerStatus")]
        [Validation(Required=false)]
        public string LoadBalancerStatus { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
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
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of <b>NextToken</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The billing method of the ALB instance. Set the value to</para>
        /// <para><b>PostPay</b>, which specifies the pay-as-you-go billing method. This is the default value.</para>
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
        /// <para>The tags added to the ALB instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListLoadBalancersRequestTag> Tag { get; set; }
        public class ListLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KeyTest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alueTest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the ALB instance belongs. You can specify at most 10 VPC IDs.</para>
        /// </summary>
        [NameInMap("VpcIds")]
        [Validation(Required=false)]
        public List<string> VpcIds { get; set; }

        /// <summary>
        /// <para>The ID of the zone where the ALB instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/189196.html">DescribeZones</a> operation to query zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
