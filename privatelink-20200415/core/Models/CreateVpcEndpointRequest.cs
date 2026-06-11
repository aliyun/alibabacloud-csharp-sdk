// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The IP version of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b>: IPv4 (default).</para>
        /// </description></item>
        /// <item><description><para><b>DualStack</b>: dual-stack.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To use the dual-stack feature, make sure that the associated endpoint service and the VPC in which the endpoint is created support the dual-stack feature.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>A client-generated token to ensure the idempotence of the request.</para>
        /// <para>You must generate a unique value for this token. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The bandwidth for a cross-region connection, in Mbps. This parameter applies only when the endpoint and endpoint service are in different regions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Default</b>: 1000 for cross-region connections within the Chinese mainland. In all other cases, the value is 100.</para>
        /// </description></item>
        /// <item><description><para><b>Minimum value</b>: 100.</para>
        /// </description></item>
        /// <item><description><para><b>Maximum value</b>: subject to your account\&quot;s quota. For more information, see <a href="https://help.aliyun.com/zh/privatelink/quotas-and-limits?spm=a2c4g.11174283.help-menu-search-120462.d_0">Quotas and limits</a>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To use this parameter, make sure that you are creating a cross-region endpoint.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CrossRegionBandwidth")]
        [Validation(Required=false)]
        public int? CrossRegionBandwidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run to check the request\&quot;s validity without committing the action. The system checks for required parameters, request format, and service limits. If the check passes, the <c>DryRunOperation</c> error code is returned. If it fails, an error message is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends the request. If the request is valid, the operation is performed and a 2xx HTTP status code is returned.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The description of the endpoint.</para>
        /// <para>The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my Endpoint.</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The name of the endpoint.</para>
        /// <para>The name must be 2 to 128 characters long, start with a letter or a Chinese character, and can contain digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The type of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Interface</b>: an interface endpoint. You can add Application Load Balancer (ALB), Classic Load Balancer (CLB), and Network Load Balancer (NLB) instances as service resources.</para>
        /// </description></item>
        /// <item><description><para><b>Reverse</b>: a reverse endpoint. You can add a VPC NAT Gateway as a service resource.</para>
        /// </description></item>
        /// <item><description><para><b>GatewayLoadBalancer</b>: a Gateway Load Balancer endpoint. You can add a Gateway Load Balancer (GWLB) as a service resource.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Services that support reverse endpoints are provided exclusively by Alibaba Cloud and its partners. You cannot create them by default. To request access, contact your account manager.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Interface</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The Resource Access Management (RAM) policy. For more information about the policy syntax, see <a href="https://help.aliyun.com/document_detail/93738.html">Basic elements of a policy</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;Version&quot;: &quot;1&quot;,
        ///   &quot;Statement&quot;: [
        ///     {
        ///       &quot;Effect&quot;: &quot;Allow&quot;,
        ///       &quot;Action&quot;: [
        ///         &quot;oss:List*&quot;,
        ///         &quot;oss:PutObject&quot;,
        ///         &quot;oss:GetObject&quot;
        ///       ],
        ///       &quot;Resource&quot;: [
        ///         &quot;acs:oss:oss-<em>:</em>:pvl-policy-test/policy-test.txt&quot;
        ///       ],
        ///       &quot;Principal&quot;: {
        ///         &quot;RAM&quot;: [
        ///           &quot;acs:ram::14199xxxxxx:*&quot;
        ///         ]
        ///       }
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable managed protection. This parameter is effective only for requests made with a Security Token Service (STS) token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables managed protection. After you enable managed protection, only the user who creates the endpoint can modify or delete it by using an STS token.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables managed protection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProtectedEnabled")]
        [Validation(Required=false)]
        public bool? ProtectedEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the region in which to create the endpoint.</para>
        /// <para>You can obtain the region ID by calling the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of security groups to associate with the endpoint ENI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-hp33bw6ynvm2yb0e****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the associated endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3xdsq46ael67lo****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the associated endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The ID of the region where the endpoint service is deployed. Defaults to the endpoint\&quot;s region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointRequestTag> Tag { get; set; }
        public class CreateVpcEndpointRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Virtual Private Cloud (VPC) where the endpoint will be created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-hp356stwkxg3fn2xe****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The list of zones for the endpoint.</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointRequestZone> Zone { get; set; }
        public class CreateVpcEndpointRequestZone : TeaModel {
            /// <summary>
            /// <para>The IPv6 address of the endpoint ENI in the specified zone.</para>
            /// <remarks>
            /// <para>This parameter is valid only when <c>AddressIpVersion</c> is set to <c>DualStack</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2408:4005:34d:<b><b>:a58b:62a3:6b55:</b></b></para>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch in the zone where the endpoint ENI will be created.
            /// You can specify up to 10 vSwitch IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-hp3uf6045ljdhd5zr****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone for the endpoint.</para>
            /// <para>You can specify up to 10 zone IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The IPv4 address of the endpoint ENI in the specified zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable zone affinity. If enabled, requests are routed to the endpoint in the same zone as the client. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables zone affinity.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables zone affinity.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// <para>The number of private IP addresses for the endpoint\&quot;s elastic network interface (ENI) in each zone. The value must be <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ZonePrivateIpAddressCount")]
        [Validation(Required=false)]
        public long? ZonePrivateIpAddressCount { get; set; }

    }

}
