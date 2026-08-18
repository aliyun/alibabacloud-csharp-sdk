// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class UpdateVpcEndpointServiceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The list of remote regions to add for the endpoint service.</para>
        /// </summary>
        [NameInMap("AddSupportedRegionSet")]
        [Validation(Required=false)]
        public List<string> AddSupportedRegionSet { get; set; }

        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IPv4</b>: IPv4.</description></item>
        /// <item><description><b>DualStack</b>: dual-stack.<remarks>
        /// <para>Currently, only endpoint services whose backend resource type is NLB or GWLB support setting the IP address protocol to DualStack.</para>
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
        /// <item><description><para><b>true</b>: automatically accepts endpoint connections.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not automatically accept endpoint connections.</para>
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
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>ClientToken</b> parameter supports only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The default bandwidth limit. Default value: <b>3072</b>. Unit: Mbit/s.</para>
        /// <para>Valid values: <b>100</b> to <b>10240</b>.</para>
        /// <remarks>
        /// <para>Settings for the default bandwidth limit are supported when the service resource is a Classic Load Balancer (CLB) instance or an Application Load Balancer (ALB) instance. When the service resource is a Network Load Balancer (NLB) instance, the connection bandwidth cannot be configured.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3072</para>
        /// </summary>
        [NameInMap("ConnectBandwidth")]
        [Validation(Required=false)]
        public int? ConnectBandwidth { get; set; }

        /// <summary>
        /// <para>The list of remote regions to remove from the endpoint service.</para>
        /// </summary>
        [NameInMap("DeleteSupportedRegionSet")]
        [Validation(Required=false)]
        public List<string> DeleteSupportedRegionSet { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, an HTTP 2xx status code is returned and the resource attributes are modified.</para>
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
        /// <para>The region ID of the endpoint service.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The ID of the endpoint service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epsrv-hp3vpx8yqxblby3i****</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>Specifies whether the endpoint service supports IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): no.</para>
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
        /// <para>Specifies whether to resolve the domain name of the endpoint that is connected to the endpoint service to the nearest access point. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): yes.</description></item>
        /// <item><description><b>false</b>: no.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ZoneAffinityEnabled")]
        [Validation(Required=false)]
        public bool? ZoneAffinityEnabled { get; set; }

    }

}
