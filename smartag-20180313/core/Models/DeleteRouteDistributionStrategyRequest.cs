// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DeleteRouteDistributionStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The destination CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.0/24</para>
        /// </summary>
        [NameInMap("DestCidrBlock")]
        [Validation(Required=false)]
        public string DestCidrBlock { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Smart Access Gateway (SAG) instance is deployed.</para>
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
        /// <para>The source of routes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Alibaba Cloud</b></para>
        /// <list type="bullet">
        /// <item><description><b>Virtual private cloud (VPC) IDs</b>: Routes that are learned from VPCs.</description></item>
        /// <item><description><b>Virtual border router (VBR) IDs</b>: Routes that are learned from VBRs.</description></item>
        /// <item><description><b>SAG instance IDs</b>: Routes that are learned from SAG instances.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>On-premises network</b></para>
        /// <list type="bullet">
        /// <item><description><b>STATIC</b>: Static routes that are specified in the SAG console.</description></item>
        /// <item><description><b>OSPF</b>: Routes that are learned through the Open Shortest Path First (OSPF) protocol.</description></item>
        /// <item><description><b>BGP</b>: Routes that are learned through Border Gateway Protocol (BGP).</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STATIC</para>
        /// </summary>
        [NameInMap("RouteSource")]
        [Validation(Required=false)]
        public string RouteSource { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-gyat6giidkvyk****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The type of the route source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cloud</b>: Alibaba Cloud</description></item>
        /// <item><description><b>local</b>: on-premises network</description></item>
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
