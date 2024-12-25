// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancersRequest : TeaModel {
        /// <summary>
        /// <para>The IP address that the CLB instance uses to provide services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        /// <summary>
        /// <para>The IP version that is used by the CLB instance. Valid values: <b>ipv4</b> and <b>ipv6</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>The network type of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>internet:</b> After an Internet-facing CLB instance is created, the system assigns a public IP address to the CLB instance. Then, the CLB instance can forward requests over the Internet.</description></item>
        /// <item><description><b>intranet:</b> After an internal-facing CLB instance is created, the system assigns a private IP address to the CLB instance. Then, the CLB instance can forward requests only over internal networks.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>intranet</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        /// <summary>
        /// <para>The metering method of Internet data transfer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>paybybandwidth:</b> pay-by-bandwidth.</description></item>
        /// <item><description><b>paybytraffic:</b> pay-by-data-transfer.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>paybytraffic</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the CLB instance.</para>
        /// <para>You can specify up to 10 IDs. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-bp1b6c719dfa****</para>
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// <para>The name of the CLB instance.</para>
        /// <para>The name must be 1 to 80 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// <para>You can specify up to 10 names. Separate multiple names with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("LoadBalancerName")]
        [Validation(Required=false)]
        public string LoadBalancerName { get; set; }

        /// <summary>
        /// <para>The status of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>inactive:</b> The CLB instance is disabled. CLB instances in the inactive state do not forward traffic.</description></item>
        /// <item><description><b>active:</b> The CLB instance runs as expected. By default, newly created CLB instances are in the <b>active</b> state.</description></item>
        /// <item><description><b>locked:</b> The CLB instance is locked. After a CLB instance expires, it is locked for seven days. A locked CLB instance cannot forward traffic and you cannot perform operations on the locked CLB instance. However, other settings such as the IP address are retained.</description></item>
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
        /// <para>The network type of the internal-facing CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>vpc:</b> VPC.</description></item>
        /// <item><description><b>classic:</b> classic network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: <b>1</b> to <b>100</b>.</para>
        /// <remarks>
        /// <para> If you specify the <b>PageSize</b> parameter, you must also specify the <b>PageNumber</b> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The billing method of the CLB instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Set the value to <b>PayOnDemand</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayOnDemand</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The ID of the region where the CLB instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/27584.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>rg-acfmxazb4p****</para>
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
        /// <para>The ID of the backend server that is added to the CLB instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vm-server-23****</para>
        /// </summary>
        [NameInMap("ServerId")]
        [Validation(Required=false)]
        public string ServerId { get; set; }

        /// <summary>
        /// <para>The private IP address of the backend server that is added to the CLB instance.</para>
        /// <para>You can specify multiple IP addresses. Separate multiple IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.102</para>
        /// </summary>
        [NameInMap("ServerIntranetAddress")]
        [Validation(Required=false)]
        public string ServerIntranetAddress { get; set; }

        /// <summary>
        /// <para>The ID of the secondary zone to which the CLB instance belongs.</para>
        /// <para>CLB instances on Alibaba Finance Cloud do not support cross-zone deployment.</para>
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
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancersRequestTag> Tag { get; set; }
        public class DescribeLoadBalancersRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key must be 1 to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be at most 128 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tags that are added to the CLB instance. The tags must be key-value pairs that are contained in a JSON dictionary.</para>
        /// <para>You can specify up to 10 tags in each call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;tagKey&quot;:&quot;Key1&quot;,&quot;tagValue&quot;:&quot;Value1&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp12mw1f8k3****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the CLB instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1aevy8sof****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
