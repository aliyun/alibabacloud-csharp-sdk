// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTableAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
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
        /// <item><description><para>If this parameter is not returned, it indicates that no more results are to be returned.</para>
        /// </description></item>
        /// <item><description><para>If a value is returned for this parameter, the value is the token that is used for the next query.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>a415****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F6B1D9AB-176D-4399-801D-8BC576F4EB0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>A list of forwarding associations.</para>
        /// </summary>
        [NameInMap("TransitRouterAssociations")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTableAssociationsResponseBodyTransitRouterAssociations> TransitRouterAssociations { get; set; }
        public class ListTransitRouterRouteTableAssociationsResponseBodyTransitRouterAssociations : TeaModel {
            /// <summary>
            /// <para>The ID of the next hop resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1h8vbrbcgohcju5****</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

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
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the association.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Active</b>: The association is active.</para>
            /// </description></item>
            /// <item><description><para><b>Associating</b>: The association is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Dissociating</b>: The association is being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>Deleted</b>: The association is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Associating</para>
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

}
