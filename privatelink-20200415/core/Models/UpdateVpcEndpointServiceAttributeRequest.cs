// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Privatelink20200415.Models
{
    public class UpdateVpcEndpointServiceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The remote regions to add to the list of supported regions.</para>
        /// </summary>
        [NameInMap("AddSupportedRegionSet")]
        [Validation(Required=false)]
        public List<string> AddSupportedRegionSet { get; set; }

        /// <summary>
        /// <para>The IP version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>IPv4</b>: IPv4.</para>
        /// </description></item>
        /// <item><description><para><b>DualStack</b>: dual-stack.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Only endpoint services that use an NLB or GWLB instance as the service resource support the <b>DualStack</b> IP version.</para>
        /// </remarks>
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
        /// <para>A client-generated token that ensures the idempotence of the request.</para>
        /// <para>Your client must generate a unique token for each request. <b>ClientToken</b> can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe637760</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The default maximum connection bandwidth. The default value is <b>3072</b>. Unit: Mbps.</para>
        /// <para>Valid values: <b>100</b> to <b>10240</b>.</para>
        /// <remarks>
        /// <para>You can set this parameter only if the service resource is a CLB or ALB instance, but not an NLB instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3072</para>
        /// </summary>
        [NameInMap("ConnectBandwidth")]
        [Validation(Required=false)]
        public int? ConnectBandwidth { get; set; }

        /// <summary>
        /// <para>The remote regions to remove from the list of supported regions.</para>
        /// </summary>
        [NameInMap("DeleteSupportedRegionSet")]
        [Validation(Required=false)]
        public List<string> DeleteSupportedRegionSet { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, the system returns an error message. If the request passes the dry run, the system returns the <c>DryRunOperation</c> error code.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. If the request passes the check, the system returns a 2xx HTTP status code and performs the operation.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/120468.html">DescribeRegions</a> operation to get the region ID.</para>
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
        /// <para>Specifies whether to enable IPv6 for the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables IPv6.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Disables IPv6.</para>
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
        /// <para>Specifies whether to enable zone affinity for the endpoint service. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b> (default): Enables zone affinity.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables zone affinity.</para>
        /// </description></item>
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
