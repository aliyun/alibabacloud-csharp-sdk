// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b> (default)</description></item>
        /// <item><description><b>DualStack</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> An endpoint supports dual-stack if its associated endpoint service and VPC both support dual-stack.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
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
        /// <para>The description must be 2 to 256 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my Endpoint.</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The name of the endpoint.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The endpoint type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Interface</b> You can specify an Application Load Balancer (ALB) instance, a Classic Load Balancer (CLB) instance, or a Network Load Balancer (NLB) instance.</description></item>
        /// <item><description><b>Reverse</b> You can specify a Virtual Private Cloud (VPC) NAT gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Services that support reverse endpoints are provided by Alibaba Cloud or Alibaba Cloud partners. To create such a service on your own, contact your account manager.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Interface</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
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
        /// <para>Specifies whether to enable user authentication. This parameter is available in Security Token Service (STS) mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables user authentication. After user authentication is enabled, only the user who creates the endpoint can modify or delete the endpoint in STS mode.</description></item>
        /// <item><description><b>false</b> (default): disables user authentication.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProtectedEnabled")]
        [Validation(Required=false)]
        public bool? ProtectedEnabled { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of security groups that are associated with the endpoint elastic network interface (ENI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-hp33bw6ynvm2yb0e****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint service with which the endpoint is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3xdsq46ael67lo****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint service with which the endpoint is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointRequestTag> Tag { get; set; }
        public class CreateVpcEndpointRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag to add to the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag to add to the resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the endpoint belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-hp356stwkxg3fn2xe****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zones where the endpoint is deployed.</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointRequestZone> Zone { get; set; }
        public class CreateVpcEndpointRequestZone : TeaModel {
            /// <summary>
            /// <para>The IPv6 address of the zone where the endpoint is deployed.</para>
            /// <remarks>
            /// <para> You can specify this parameter only if AddressIpVersion is set to DualStack.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2408:4005:34d:<b><b>:a58b:62a3:6b55:</b></b></para>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch for which you want to create the endpoint elastic network interface (ENI) in the zone. You can specify up to 10 vSwitches.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-hp3uf6045ljdhd5zr****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the zone where the endpoint service is deployed.</para>
            /// <para>You can specify up to 10 zones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The IP address of the zone where the endpoint is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// <para>The number of private IP addresses that are assigned to an elastic network interface (ENI) in each zone. Set the value to <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ZonePrivateIpAddressCount")]
        [Validation(Required=false)]
        public long? ZonePrivateIpAddressCount { get; set; }

    }

}
