// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// A list of route entries.
        /// </summary>
        [NameInMap("TransitRouterRouteEntries")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteEntriesResponseBodyTransitRouterRouteEntries> TransitRouterRouteEntries { get; set; }
        public class ListTransitRouterRouteEntriesResponseBodyTransitRouterRouteEntries : TeaModel {
            /// <summary>
            /// The time when the route entry was created.
            /// 
            /// The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.
            /// 
            /// >  This parameter is returned only for static routes.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Indicates whether the route can be managed. Valid values:
            /// 
            /// *   **true**: The route can be managed. You can delete the route.
            /// *   **false**: The route cannot be managed because it is automatically generated by the system.
            /// </summary>
            [NameInMap("OperationalMode")]
            [Validation(Required=false)]
            public bool? OperationalMode { get; set; }

            /// <summary>
            /// The route attributes.
            /// </summary>
            [NameInMap("PathAttributes")]
            [Validation(Required=false)]
            public ListTransitRouterRouteEntriesResponseBodyTransitRouterRouteEntriesPathAttributes PathAttributes { get; set; }
            public class ListTransitRouterRouteEntriesResponseBodyTransitRouterRouteEntriesPathAttributes : TeaModel {
                /// <summary>
                /// The route AS path.
                /// </summary>
                [NameInMap("AsPaths")]
                [Validation(Required=false)]
                public List<string> AsPaths { get; set; }

                /// <summary>
                /// The route community.
                /// </summary>
                [NameInMap("Communities")]
                [Validation(Required=false)]
                public List<string> Communities { get; set; }

                /// <summary>
                /// The source instance ID.
                /// </summary>
                [NameInMap("OriginInstanceId")]
                [Validation(Required=false)]
                public string OriginInstanceId { get; set; }

                /// <summary>
                /// The source instance type. Valid values:
                /// 
                /// *   **VPC**
                /// *   **VBR**
                /// *   **TR**
                /// *   **VPN**
                /// *   **CCN**
                /// </summary>
                [NameInMap("OriginInstanceType")]
                [Validation(Required=false)]
                public string OriginInstanceType { get; set; }

                /// <summary>
                /// The route type. Valid values:
                /// 
                /// *   **System**
                /// *   **Custom**
                /// *   **static**
                /// *   **BGP**
                /// *   **BlackHole**
                /// </summary>
                [NameInMap("OriginRouteType")]
                [Validation(Required=false)]
                public string OriginRouteType { get; set; }

                /// <summary>
                /// The route priority.
                /// 
                /// A smaller value indicates a higher priority.
                /// </summary>
                [NameInMap("Preference")]
                [Validation(Required=false)]
                public int? Preference { get; set; }

            }

            /// <summary>
            /// The prefix list ID.
            /// </summary>
            [NameInMap("PrefixListId")]
            [Validation(Required=false)]
            public string PrefixListId { get; set; }

            /// <summary>
            /// The route tag.
            /// 
            /// Only **PermitVbr** may be returned, which indicates that the route is advertised only to the route tables of the virtual border routers (VBRs) that are connected to the transit router.
            /// 
            /// >  This parameter is returned only for routes whose CIDR blocks are automatically generated by the system.
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// The route description.
            /// 
            /// >  This parameter is returned only for static routes.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryDescription")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryDescription { get; set; }

            /// <summary>
            /// The destination CIDR block of the route.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

            /// <summary>
            /// The route ID.
            /// 
            /// >  This parameter is returned only for static routes.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryId")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryId { get; set; }

            /// <summary>
            /// The route name.
            /// 
            /// >  This parameter is returned only for static routes.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryName")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryName { get; set; }

            /// <summary>
            /// The next hop ID. This parameter is not returned if the route is a blackhole route.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryNextHopId")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryNextHopId { get; set; }

            /// <summary>
            /// The next hop ID.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryNextHopResourceId")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryNextHopResourceId { get; set; }

            /// <summary>
            /// The next hop type. Valid values:
            /// 
            /// *   **VPC**
            /// *   **VBR**
            /// *   **TR**
            /// *   **VPN**
            /// </summary>
            [NameInMap("TransitRouterRouteEntryNextHopResourceType")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryNextHopResourceType { get; set; }

            /// <summary>
            /// The next hop type. Valid values:
            /// 
            /// *   **BlackHole**: a blackhole route. Packets destined for the destination CIDR block of the route are dropped.
            /// *   **Attachment**: a network instance connection. Packets destined for the destination CIDR block of the route are forwarded to the specified network instance connection.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryNextHopType")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryNextHopType { get; set; }

            /// <summary>
            /// The source instance ID.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryOriginResourceId")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryOriginResourceId { get; set; }

            /// <summary>
            /// The source instance type. Valid values:
            /// 
            /// *   **VPC**
            /// *   **VBR**
            /// *   **TR**
            /// *   **VPN**
            /// </summary>
            [NameInMap("TransitRouterRouteEntryOriginResourceType")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryOriginResourceType { get; set; }

            /// <summary>
            /// The route status. Valid values:
            /// 
            /// *   **Active**
            /// *   **Rejected**
            /// *   **Prohibited**
            /// *   **Standby**
            /// *   **Candidate**
            /// *   **Creating**
            /// *   **Deleting**
            /// </summary>
            [NameInMap("TransitRouterRouteEntryStatus")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryStatus { get; set; }

            /// <summary>
            /// The type of the route. Valid values:
            /// 
            /// *   **Static**: static routes.
            /// *   **Propagated**: automatically learned by the route table.
            /// </summary>
            [NameInMap("TransitRouterRouteEntryType")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryType { get; set; }

        }

    }

}
