// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateFlowLogRequest : TeaModel {
        /// <summary>
        /// <para>The sampling interval of the flow log. Unit: minutes. Valid values: <b>1</b>, <b>5</b>, and <b>10</b> (default).</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("AggregationInterval")]
        [Validation(Required=false)]
        public int? AggregationInterval { get; set; }

        /// <summary>
        /// <para>The description of the flow log.</para>
        /// <para>The description must be 1 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my Flowlog.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the flow log.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// <para>The IP version of the traffic captured by the flow log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        [NameInMap("LogFormat")]
        [Validation(Required=false)]
        public string LogFormat { get; set; }

        /// <summary>
        /// <para>The name of the Log Service Logstore that is used to store the captured traffic.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FlowLogStore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The name of the Log Service project that is used to manage the captured traffic.</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FlowLogProject</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The region ID of the flow log. You can call the <a href="https://help.aliyun.com/document_detail/448570.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazdjdhd****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the resource whose traffic you want to capture.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eni-askldfas****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of the resource whose traffic you want to catch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>NetworkInterface</b>: elastic network interfaces (ENIs), which act as a network interface controller (NIC).</para>
        /// </description></item>
        /// <item><description><para><b>VSwitch</b>: all elastic network interfaces (ENIs) in the vSwitch.</para>
        /// </description></item>
        /// <item><description><para><b>VPC</b>: all elastic network interfaces (ENIs) in the virtual private cloud (VPC).</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NetworkInterface</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags of the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFlowLogRequestTag> Tag { get; set; }
        public class CreateFlowLogRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. If you specify this parameter, do not enter an empty string.</para>
            /// <para>A tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. If you specify this parameter, you can enter an empty string.</para>
            /// <para>A tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The traffic path to catch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b> (default): catches all traffic.</description></item>
        /// <item><description><b>internetGateway</b>: catches traffic to access the Internet.</description></item>
        /// <item><description><b>natGateway</b>: catches traffic through NAT gateways.</description></item>
        /// <item><description><b>vpnGateway</b>: catches traffic through VPN gateways.</description></item>
        /// <item><description><b>transitRouter</b>: catches traffic through TR.</description></item>
        /// <item><description><b>gatewayEndpoint</b>: catches traffic through gateway endpoints to access cloud services.</description></item>
        /// <item><description><b>vbr</b>: catches traffic through the border router (VBR) to access Express Connect circuits.</description></item>
        /// <item><description><b>ecr</b>: catches traffic through the Express Connect Router (ECR).</description></item>
        /// <item><description><b>ipv4Gateway</b>: catches traffic to access the Internet through IPv4 gateways.</description></item>
        /// <item><description><b>gatewayLoadBalancerEndpoint</b>: catches traffic through the Gateway Load Balancer endpoint (GWLBe).</description></item>
        /// </list>
        /// </summary>
        [NameInMap("TrafficPath")]
        [Validation(Required=false)]
        public List<string> TrafficPath { get; set; }

        /// <summary>
        /// <para>The traffic type to catch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>All</b>: all traffic.</para>
        /// </description></item>
        /// <item><description><para><b>Allow</b>: traffic allowed by access control.</para>
        /// </description></item>
        /// <item><description><para><b>Drop</b>: traffic that access control rules deny.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("TrafficType")]
        [Validation(Required=false)]
        public string TrafficType { get; set; }

    }

}
