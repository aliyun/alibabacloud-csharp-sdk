// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTableAssociationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of route association relationships.</para>
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
            /// <para>The type of the next hop resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VPC</b>: virtual private cloud (VPC) instance.</description></item>
            /// <item><description><b>VBR</b>: virtual border router (VBR) instance.</description></item>
            /// <item><description><b>TR</b>: transit router instance.</description></item>
            /// <item><description><b>VPN</b>: VPN connection.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the route association. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Active</b>: active.</description></item>
            /// <item><description><b>Associating</b>: being associated.</description></item>
            /// <item><description><b>Dissociating</b>: being dissociated.</description></item>
            /// <item><description><b>Deleted</b>: deleted.</description></item>
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
            /// <para>The ID of the Enterprise Edition transit router route table.</para>
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
