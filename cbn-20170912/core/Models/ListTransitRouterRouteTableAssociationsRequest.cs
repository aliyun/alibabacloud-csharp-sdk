// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTableAssociationsRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Default value: **50**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If this is your first query or no subsequent query is to be sent, ignore this parameter.
        /// *   If a next query is to be sent, set the value to the value of **NextToken** that is returned from the last call.
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
        /// The status of the associated forwarding correlation. Valid values:
        /// 
        /// *   **Active**: The associated forwarding correlation is available.
        /// *   **Associating**: The associated forwarding correlation is being created.
        /// *   **Dissociating**: The associated forwarding correlation is being deleted.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The ID of the network instance connection.
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// The ID of the next hop.
        /// </summary>
        [NameInMap("TransitRouterAttachmentResourceId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentResourceId { get; set; }

        /// <summary>
        /// The type of next hop. Valid values:
        /// 
        /// *   **VPC**: virtual private cloud (VPC)
        /// *   **VBR**: virtual border router (VBR)
        /// *   **TR**: transit router
        /// *   **VPN**: VPN attachment
        /// </summary>
        [NameInMap("TransitRouterAttachmentResourceType")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentResourceType { get; set; }

        /// <summary>
        /// The ID of the route table of the Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
