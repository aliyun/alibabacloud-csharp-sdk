// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
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
        /// <para>The bandwidth of the endpoint connection. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The endpoint connection status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Pending</b>: being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Connecting</b>: connecting.</para>
        /// </description></item>
        /// <item><description><para><b>Connected</b>: connected.</para>
        /// </description></item>
        /// <item><description><para><b>Disconnecting</b>: disconnecting.</para>
        /// </description></item>
        /// <item><description><para><b>Disconnected</b>: disconnected.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>ServiceDeleted</b>: the corresponding endpoint service has been deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Connected</para>
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// <para>The time when the endpoint was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-24T18:00:07Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The cross-region bandwidth of the endpoint. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CrossRegionBandwidth")]
        [Validation(Required=false)]
        public int? CrossRegionBandwidth { get; set; }

        /// <summary>
        /// <para>The business status of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Normal</b>: Normal.</para>
        /// </description></item>
        /// <item><description><para><b>FinancialLocked</b>: Financial lock.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("EndpointBusinessStatus")]
        [Validation(Required=false)]
        public string EndpointBusinessStatus { get; set; }

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
        /// <para>The endpoint domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****.epsrv-hp3xdsq46ael67lo****.cn-huhehaote.privatelink.aliyuncs.com</para>
        /// </summary>
        [NameInMap("EndpointDomain")]
        [Validation(Required=false)]
        public string EndpointDomain { get; set; }

        /// <summary>
        /// <para>The endpoint ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-hp33b2e43fays7s8****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

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
        /// <para>The status of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Creating</b>: being created.</para>
        /// </description></item>
        /// <item><description><para><b>Active</b>: available.</para>
        /// </description></item>
        /// <item><description><para><b>Pending</b>: being modified.</para>
        /// </description></item>
        /// <item><description><para><b>Deleting</b>: being deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("EndpointStatus")]
        [Validation(Required=false)]
        public string EndpointStatus { get; set; }

        /// <summary>
        /// <para>The endpoint type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Interface</b>: interface endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>Reverse</b>: reverse endpoint.</para>
        /// </description></item>
        /// <item><description><para><b>GatewayLoadBalancer</b>: Gateway Load Balancer endpoint (GWLBe).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Interface</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        /// <summary>
        /// <para>The payer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Endpoint</b>: the service consumer.</para>
        /// </description></item>
        /// <item><description><para><b>EndpointService</b>: the service provider.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint</para>
        /// </summary>
        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

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
        /// <para>Indicates whether managed protection is enabled. This parameter takes effect only when the STS calling method is used. Valid values:</para>
        /// <para><b>true</b>: enabled. After managed protection is enabled, only the same user who created the endpoint can modify or delete the endpoint by using STS.</para>
        /// <para><b>false</b>: disabled.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ProtectedEnabled")]
        [Validation(Required=false)]
        public bool? ProtectedEnabled { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8D8992C1-6712-423C-BAC5-E5E817484C6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmz7nocpei***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Indicates whether the endpoint and the endpoint service belong to the same Alibaba Cloud account. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The endpoint and the endpoint service belong to the same account.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The endpoint and the endpoint service belong to different accounts.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResourceOwner")]
        [Validation(Required=false)]
        public bool? ResourceOwner { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint service with which the endpoint is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The name of the endpoint service with which the endpoint is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>com.aliyuncs.privatelink.cn-huhehaote.epsrv-hp3xdsq46ael67lo****</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The region ID of the endpoint service with which the endpoint is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("ServiceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the endpoint belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-fdfhkjafhjvcvdjf****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Indicates whether zone affinity is enabled for the endpoint domain name to resolve to the connected service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// <para>The number of private IP addresses assigned to the endpoint elastic network interface (ENI) in each zone. The value is fixed to <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ZonePrivateIpAddressCount")]
        [Validation(Required=false)]
        public long? ZonePrivateIpAddressCount { get; set; }

    }

}
