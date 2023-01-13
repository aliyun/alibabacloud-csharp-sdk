// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRegionDomainRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The array of routes.
        /// </summary>
        [NameInMap("CenRouteEntries")]
        [Validation(Required=false)]
        public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntries CenRouteEntries { get; set; }
        public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntries : TeaModel {
            [NameInMap("CenRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry> CenRouteEntry { get; set; }
            public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry : TeaModel {
                /// <summary>
                /// The AS paths of the routes.
                /// </summary>
                [NameInMap("AsPaths")]
                [Validation(Required=false)]
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths AsPaths { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }

                /// <summary>
                /// The route maps that the routes match in the outbound direction.
                /// </summary>
                [NameInMap("CenOutRouteMapRecords")]
                [Validation(Required=false)]
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecords CenOutRouteMapRecords { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecords : TeaModel {
                    [NameInMap("CenOutRouteMapRecord")]
                    [Validation(Required=false)]
                    public List<DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecordsCenOutRouteMapRecord> CenOutRouteMapRecord { get; set; }
                    public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenOutRouteMapRecordsCenOutRouteMapRecord : TeaModel {
                        /// <summary>
                        /// The ID of the region where the route map is applied.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The ID of the route map.
                        /// </summary>
                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }

                /// <summary>
                /// The route maps that the routes match in the inbound direction.
                /// </summary>
                [NameInMap("CenRouteMapRecords")]
                [Validation(Required=false)]
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords CenRouteMapRecords { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords : TeaModel {
                    [NameInMap("CenRouteMapRecord")]
                    [Validation(Required=false)]
                    public List<DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord> CenRouteMapRecord { get; set; }
                    public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord : TeaModel {
                        /// <summary>
                        /// The ID of the region where the route map is applied.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The ID of the route map.
                        /// </summary>
                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }

                /// <summary>
                /// The community attributes of the routes.
                /// </summary>
                [NameInMap("Communities")]
                [Validation(Required=false)]
                public DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities Communities { get; set; }
                public class DescribeCenRegionDomainRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities : TeaModel {
                    [NameInMap("Community")]
                    [Validation(Required=false)]
                    public List<string> Community { get; set; }

                }

                /// <summary>
                /// The destination CIDR block of the route.
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// The ID of the instance specified as the next hop in the route.
                /// </summary>
                [NameInMap("NextHopInstanceId")]
                [Validation(Required=false)]
                public string NextHopInstanceId { get; set; }

                /// <summary>
                /// The ID of the region where the network instance specified as the next hop in the route belongs.
                /// </summary>
                [NameInMap("NextHopRegionId")]
                [Validation(Required=false)]
                public string NextHopRegionId { get; set; }

                /// <summary>
                /// The type of the network instance specified as the next hop in the route. 
                /// 
                /// - **VPC**
                /// - **VBR**
                /// - **CCN**
                /// - **local_service**: system route. No next hop is specified.
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// The priority of the route. 
                /// 
                /// > A smaller value indicates a higher priority.
                /// </summary>
                [NameInMap("Preference")]
                [Validation(Required=false)]
                public int? Preference { get; set; }

                /// <summary>
                /// The status of the route. Valid values: 
                /// 
                /// - **Active**: The route is active.
                /// - **Candidate**: The route is a standby route.
                /// - **Rejected**: The route is rejected.
                /// - **Prohibited**: The route is prohibited.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// Whether the route can be advertised to other regions. Valid values: 
                /// 
                /// - **Active**: The route can be advertised to other regions.
                /// - **Prohibited**: The route cannot be advertised to other regions.
                /// </summary>
                [NameInMap("ToOtherRegionStatus")]
                [Validation(Required=false)]
                public string ToOtherRegionStatus { get; set; }

                /// <summary>
                /// The type of the route. Valid values: 
                /// 
                /// - **CEN**: route that is advertised through CEN
                /// - **Custom**: custom route
                /// - **System**: system route
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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

    }

}
