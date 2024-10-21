// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRegionDomainRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of route entries.</para>
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
                /// <para>The AS paths of the route.</para>
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
                /// <para>The routing policy that the routes match in the outbound direction.</para>
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
                        /// <para>The ID of the region where the routing policy is applied.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ccn-cn-shanghai</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the routing policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cenrmap-dbarzidzp7ek4k****</para>
                        /// </summary>
                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The routing policy that the routes match in the inbound direction.</para>
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
                        /// <para>The ID of the region where the routing policy is applied.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The ID of the routing policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cenrmap-cz5axczdxb7yfu****</para>
                        /// </summary>
                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The communities of the route.</para>
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
                /// <para>The destination CIDR block of the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.0/24</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The ID of the instance specified as the next hop in the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1j8728mm6pweeod****</para>
                /// </summary>
                [NameInMap("NextHopInstanceId")]
                [Validation(Required=false)]
                public string NextHopInstanceId { get; set; }

                /// <summary>
                /// <para>The ID of the region to which the network instance specified as the next hop in the route belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("NextHopRegionId")]
                [Validation(Required=false)]
                public string NextHopRegionId { get; set; }

                /// <summary>
                /// <para>The type of the instance specified as the next hop in the route. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b>: virtual private cloud (VPC)</description></item>
                /// <item><description><b>VBR</b>: virtual border router (VBR)</description></item>
                /// <item><description><b>CCN</b>: Cloud Connect Network (CCN) instance</description></item>
                /// <item><description><b>local_service</b>: system route. No next hop is specified.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>The route priority.</para>
                /// <para>A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Preference")]
                [Validation(Required=false)]
                public int? Preference { get; set; }

                /// <summary>
                /// <para>The route status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b>: available</description></item>
                /// <item><description><b>Candidate</b>: standby</description></item>
                /// <item><description><b>Rejected</b>: rejected</description></item>
                /// <item><description><b>Prohibited</b>: prohibited</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Indicates whether the route can be advertised to other regions. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b>: The route can be advertised to other regions.</description></item>
                /// <item><description><b>Prohibited</b>: The route cannot be advertised to other regions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("ToOtherRegionStatus")]
                [Validation(Required=false)]
                public string ToOtherRegionStatus { get; set; }

                /// <summary>
                /// <para>The route type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CEN</b>: route that is advertised through CEN</description></item>
                /// <item><description><b>Custom</b>: custom route</description></item>
                /// <item><description><b>System</b>: system route</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CEN</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>004E99FB-E996-5777-888E-BA1D8F215407</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
