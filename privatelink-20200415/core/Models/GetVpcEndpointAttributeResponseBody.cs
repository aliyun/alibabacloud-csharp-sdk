// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class GetVpcEndpointAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The protocol. Valid values:</para>
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
        /// <para>The bandwidth of the endpoint connection. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The state of the endpoint connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Pending</b>: The connection is being modified.</description></item>
        /// <item><description><b>Connecting</b>: The connection is being established.</description></item>
        /// <item><description><b>Connected</b>: The connection is established.</description></item>
        /// <item><description><b>Disconnecting</b>: The endpoint is being disconnected from the endpoint service.</description></item>
        /// <item><description><b>Disconnected</b>: The endpoint is disconnected from the endpoint service.</description></item>
        /// <item><description><b>Deleting</b>: The connection is being deleted.</description></item>
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
        /// <para>The service state of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The endpoint runs as expected.</description></item>
        /// <item><description><b>FinancialLocked</b>: The endpoint is locked due to overdue payments.</description></item>
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
        /// <para>The domain name of the endpoint.</para>
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
        /// <para>The state of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Creating</b>: The endpoint is being created.</description></item>
        /// <item><description><b>Active</b>: The endpoint is available.</description></item>
        /// <item><description><b>Pending</b>: The endpoint is being modified.</description></item>
        /// <item><description><b>Deleting</b>: The endpoint is being deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("EndpointStatus")]
        [Validation(Required=false)]
        public string EndpointStatus { get; set; }

        /// <summary>
        /// <para>The type of the endpoint.</para>
        /// <para><b>Interface</b> is returned. The value indicates the interface endpoint with which the Classic Load Balancer (CLB) instances are associated.</para>
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
        /// <item><description><b>Endpoint</b>: the service consumer.</description></item>
        /// <item><description><b>EndpointService</b>: the service provider.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Endpoint</para>
        /// </summary>
        [NameInMap("Payer")]
        [Validation(Required=false)]
        public string Payer { get; set; }

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
        /// <item><description><b>true</b>: The endpoint and the endpoint service belong to the same Alibaba Cloud account.</description></item>
        /// <item><description><b>false</b>: The endpoint and the endpoint service do not belong to the same Alibaba Cloud account.</description></item>
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
        /// <para>The ID of the virtual private cloud (VPC) to which the endpoint belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-fdfhkjafhjvcvdjf****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain name of the nearest endpoint that is associated with the endpoint service is resolved first. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

        /// <summary>
        /// <para>The number of private IP addresses that are assigned to an elastic network interface (ENI) in each zone. Only <b>1</b> is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ZonePrivateIpAddressCount")]
        [Validation(Required=false)]
        public long? ZonePrivateIpAddressCount { get; set; }

    }

}
