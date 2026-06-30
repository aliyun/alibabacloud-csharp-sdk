// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablePropagationsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. The default value is <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used to retrieve the next page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The status of the route propagation.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Active</b>: The propagation is active.</para>
        /// </description></item>
        /// <item><description><para><b>Enabling</b>: The propagation is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Disabling</b>: The propagation is being disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the network instance connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-vx6iwhjr1x1j78****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The ID of the network instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1h8vbrbcgohcju5****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentResourceId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentResourceId { get; set; }

        /// <summary>
        /// <para>The type of the network instance.</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: a virtual private cloud (VPC).</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: a virtual border router (VBR).</para>
        /// </description></item>
        /// <item><description><para><b>TR</b>: a transit router.</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: a VPN connection.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentResourceType")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentResourceType { get; set; }

        /// <summary>
        /// <para>The ID of the route table of the Enterprise Edition transit router.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1dudbh2d5na6b50****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
