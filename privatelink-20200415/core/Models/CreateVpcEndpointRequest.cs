// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cross-region bandwidth value. This parameter is required only when the endpoint and the endpoint service are in different regions. Unit: Mbps. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CrossRegionBandwidth")]
        [Validation(Required=false)]
        public int? CrossRegionBandwidth { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The description of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my Endpoint.</para>
        /// </summary>
        [NameInMap("EndpointDescription")]
        [Validation(Required=false)]
        public string EndpointDescription { get; set; }

        /// <summary>
        /// <para>The name of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("EndpointName")]
        [Validation(Required=false)]
        public string EndpointName { get; set; }

        /// <summary>
        /// <para>The endpoint type. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>Interface</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The RAM access policy. For more information about the policy definition, see <a href="https://help.aliyun.com/document_detail/93738.html">Policy elements</a>.</para>
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
        /// <para>Specifies whether to enable managed protection. This parameter takes effect only when the request is made by using Security Token Service (STS). Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ProtectedEnabled")]
        [Validation(Required=false)]
        public bool? ProtectedEnabled { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint.</para>
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
        /// <para>The security groups that are associated with the endpoint elastic network interface (ENI).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-hp33bw6ynvm2yb0e****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public List<string> SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The endpoint service that is associated with the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3xdsq46ael67lo****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint service that is associated with the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint service. The default value is the current region, which is the region where you create an endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
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
        /// <para>The VPC to which the endpoint belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-hp356stwkxg3fn2xe****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The endpoint zones.</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointRequestZone> Zone { get; set; }
        public class CreateVpcEndpointRequestZone : TeaModel {
            /// <summary>
            /// <para>The IPv6 address of the endpoint elastic network interface (ENI) in the specified endpoint zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2408:4005:34d:<b><b>:a58b:62a3:6b55:</b></b></para>
            /// </summary>
            [NameInMap("Ipv6Address")]
            [Validation(Required=false)]
            public string Ipv6Address { get; set; }

            /// <summary>
            /// <para>The vSwitch in the zone where you want to create an endpoint elastic network interface (ENI).</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-hp3uf6045ljdhd5zr****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            /// <summary>
            /// <para>The IPv4 address of the endpoint elastic network interface (ENI) in the specified endpoint zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to support zone affinity for the endpoint domain name when connecting to the service. Valid values:</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// <para>The number of private IP addresses for the ENI in each zone. Set the value to <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ZonePrivateIpAddressCount")]
        [Validation(Required=false)]
        public long? ZonePrivateIpAddressCount { get; set; }

    }

}
