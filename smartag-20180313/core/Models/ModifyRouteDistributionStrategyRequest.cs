// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyRouteDistributionStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("DestCidrBlock")]
        [Validation(Required=false)]
        public string DestCidrBlock { get; set; }

        /// <summary>
        /// <para>The ID of the health check instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc-sztovuprqzgm50****</para>
        /// </summary>
        [NameInMap("HcInstanceId")]
        [Validation(Required=false)]
        public string HcInstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway (SAG) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The route advertisement policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>publish</b>: advertises routes.</description></item>
        /// <item><description><b>no_publish</b>: does not advertise routes.</description></item>
        /// <item><description><b>no_publish_and_publish_on_health_success</b>: routes are advertised only when they pass the health check.</description></item>
        /// <item><description><b>no_publish_and_publish_on_health_fail</b>: routes are advertised only when they fail the health check.</description></item>
        /// <item><description><b>publish_and_revoke_on_health_success</b>: advertised routes are withdrawn only when they pass the health check.</description></item>
        /// <item><description><b>publish_and_revoke_on_health_fail</b>: advertised routes are withdrawn only when they fail the health check.</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/163971.html">Configure health checks</a> and <a href="https://help.aliyun.com/document_detail/163973.html">Advertise routes</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>publish</para>
        /// </summary>
        [NameInMap("RouteDistribution")]
        [Validation(Required=false)]
        public string RouteDistribution { get; set; }

        /// <summary>
        /// <para>The source of routes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Alibaba Cloud-facing routes</b></para>
        /// <list type="bullet">
        /// <item><description><b>The ID of the Virtual Private Cloud (VPC)</b>: learns routes from the VPC network.</description></item>
        /// <item><description><b>The ID of the virtual border router (VBR)</b>: learns routes from the VBR.</description></item>
        /// <item><description><b>The ID of the SAG instance</b>: learns routes from the SAG instance.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>Private network-facing routes</b></para>
        /// <list type="bullet">
        /// <item><description><b>STATIC</b>: static routes specified in the SAG console.</description></item>
        /// <item><description><b>OSPF</b>: learns routes through the Open Shortest Path First (OSPF) protocol.</description></item>
        /// <item><description><b>BGP</b>: learns routes through Border Gateway Protocol (BGP).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OSPF</para>
        /// </summary>
        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-erx3qta5xg5zyq****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The type of the route source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud</b>: Alibaba Cloud-facing routes.</description></item>
        /// <item><description><b>local</b>: private network-facing routes.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>local</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
