// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class CreateVpcEndpointServiceRequest : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4 (default).</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.<remarks>
        /// <para>Only endpoint services whose backend resource type is nlb or gwlb support the DualStack IP address protocol. If the endpoint service supports dual-stack, the backend resources must also support dual-stack.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>IPv4</para>
        /// </summary>
        [NameInMap("AddressIpVersion")]
        [Validation(Required=false)]
        public string AddressIpVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically accept endpoint connections. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: automatically accept endpoint connections.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): do not automatically accept endpoint connections.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoAcceptEnabled")]
        [Validation(Required=false)]
        public bool? AutoAcceptEnabled { get; set; }

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
        /// <item><description><para><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</para>
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
        /// <para>The payer. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Endpoint</b>: service consumer.</para>
        /// </description></item>
        /// <item><description><para><b>EndpointService</b>: service provider.</para>
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
        /// <para>The region ID of the endpoint service.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/469325.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-huhehaote</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service resources of the endpoint service. You can add up to 10 resources during creation. After creation, you can add more resources by adding service resources to the endpoint.</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointServiceRequestResource> Resource { get; set; }
        public class CreateVpcEndpointServiceRequestResource : TeaModel {
            /// <summary>
            /// <para>The ID of the service resource to add to the endpoint service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-hp32z1wp5peaoox2q****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The EPS resource type to add to the endpoint service. You can add up to 20 service resources to an endpoint service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>slb</b>: Classic Load Balancer (CLB).</para>
            /// </description></item>
            /// <item><description><para><b>alb</b>: Application Load Balancer (ALB).</para>
            /// </description></item>
            /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB).</para>
            /// </description></item>
            /// <item><description><para><b>gwlb</b>: Gateway Load Balancer (GWLB).</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>slb</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote-a</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

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
        /// <para>The description of the endpoint service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is my EndpointService.</para>
        /// </summary>
        [NameInMap("ServiceDescription")]
        [Validation(Required=false)]
        public string ServiceDescription { get; set; }

        /// <summary>
        /// <para>The EPS resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>slb</b>: Classic Load Balancer (CLB).</para>
        /// </description></item>
        /// <item><description><para><b>alb</b>: Application Load Balancer (ALB).</para>
        /// </description></item>
        /// <item><description><para><b>nlb</b>: Network Load Balancer (NLB).</para>
        /// </description></item>
        /// <item><description><para><b>gwlb</b>: Gateway Load Balancer (GWLB).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Access to TCPSSL listeners of NLB is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>slb</para>
        /// </summary>
        [NameInMap("ServiceResourceType")]
        [Validation(Required=false)]
        public string ServiceResourceType { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether the endpoint service supports IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: supported.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ServiceSupportIPv6")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? ServiceSupportIPv6 { get; set; }

        /// <summary>
        /// <para>The list of regions supported by the endpoint service. Service consumers can initiate endpoint connections from the regions in the list.</para>
        /// </summary>
        [NameInMap("SupportedRegionList")]
        [Validation(Required=false)]
        public List<string> SupportedRegionList { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVpcEndpointServiceRequestTag> Tag { get; set; }
        public class CreateVpcEndpointServiceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the instance. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the instance. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to support zone affinity for the endpoint domain name of the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: supported.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): not supported.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
