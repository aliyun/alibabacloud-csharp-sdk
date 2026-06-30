// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTableAssociationsRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token for the next query.</para>
        /// <list type="bullet">
        /// <item><description><para>You do not need to specify this parameter for the first query.</para>
        /// </description></item>
        /// <item><description><para>For a subsequent query, set this parameter to the <b>NextToken</b> value returned from the previous query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>a415****</para>
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
        /// <para>The status of the association.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Active</b>: The association is active.</para>
        /// </description></item>
        /// <item><description><para><b>Associating</b>: The association is being created.</para>
        /// </description></item>
        /// <item><description><para><b>Dissociating</b>: The association is being deleted.</para>
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
        /// <para>tr-attach-nls9fzkfat8934****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The ID of the next hop resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1h8vbrbcgohcju5****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentResourceId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentResourceId { get; set; }

        /// <summary>
        /// <para>The type of the next hop resource.</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: virtual private cloud (VPC).</para>
        /// </description></item>
        /// <item><description><para><b>VBR</b>: virtual border router (VBR).</para>
        /// </description></item>
        /// <item><description><para><b>TR</b>: transit router.</para>
        /// </description></item>
        /// <item><description><para><b>VPN</b>: VPN connection.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>vtb-bp1dudbh2d5na6b50****</para>
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
