// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRouteMapsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RouteMaps")]
        [Validation(Required=false)]
        public DescribeCenRouteMapsResponseBodyRouteMaps RouteMaps { get; set; }
        public class DescribeCenRouteMapsResponseBodyRouteMaps : TeaModel {
            [NameInMap("RouteMap")]
            [Validation(Required=false)]
            public List<DescribeCenRouteMapsResponseBodyRouteMapsRouteMap> RouteMap { get; set; }
            public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMap : TeaModel {
                [NameInMap("AsPathMatchMode")]
                [Validation(Required=false)]
                public string AsPathMatchMode { get; set; }

                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                [NameInMap("CenRegionId")]
                [Validation(Required=false)]
                public string CenRegionId { get; set; }

                [NameInMap("CidrMatchMode")]
                [Validation(Required=false)]
                public string CidrMatchMode { get; set; }

                [NameInMap("CommunityMatchMode")]
                [Validation(Required=false)]
                public string CommunityMatchMode { get; set; }

                [NameInMap("CommunityOperateMode")]
                [Validation(Required=false)]
                public string CommunityOperateMode { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DestinationChildInstanceTypes")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationChildInstanceTypes DestinationChildInstanceTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationChildInstanceTypes : TeaModel {
                    [NameInMap("DestinationChildInstanceType")]
                    [Validation(Required=false)]
                    public List<string> DestinationChildInstanceType { get; set; }

                }

                [NameInMap("DestinationCidrBlocks")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationCidrBlocks DestinationCidrBlocks { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationCidrBlocks : TeaModel {
                    [NameInMap("DestinationCidrBlock")]
                    [Validation(Required=false)]
                    public List<string> DestinationCidrBlock { get; set; }

                }

                [NameInMap("DestinationInstanceIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationInstanceIds DestinationInstanceIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationInstanceIds : TeaModel {
                    [NameInMap("DestinationInstanceId")]
                    [Validation(Required=false)]
                    public List<string> DestinationInstanceId { get; set; }

                }

                [NameInMap("DestinationInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? DestinationInstanceIdsReverseMatch { get; set; }

                [NameInMap("DestinationRouteTableIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRouteTableIds DestinationRouteTableIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRouteTableIds : TeaModel {
                    [NameInMap("DestinationRouteTableId")]
                    [Validation(Required=false)]
                    public List<string> DestinationRouteTableId { get; set; }

                }

                [NameInMap("MapResult")]
                [Validation(Required=false)]
                public string MapResult { get; set; }

                [NameInMap("MatchAddressType")]
                [Validation(Required=false)]
                public string MatchAddressType { get; set; }

                [NameInMap("MatchAsns")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchAsns MatchAsns { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchAsns : TeaModel {
                    [NameInMap("MatchAsn")]
                    [Validation(Required=false)]
                    public List<string> MatchAsn { get; set; }

                }

                [NameInMap("MatchCommunitySet")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchCommunitySet MatchCommunitySet { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchCommunitySet : TeaModel {
                    [NameInMap("MatchCommunity")]
                    [Validation(Required=false)]
                    public List<string> MatchCommunity { get; set; }

                }

                [NameInMap("NextPriority")]
                [Validation(Required=false)]
                public int? NextPriority { get; set; }

                [NameInMap("OperateCommunitySet")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapOperateCommunitySet OperateCommunitySet { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapOperateCommunitySet : TeaModel {
                    [NameInMap("OperateCommunity")]
                    [Validation(Required=false)]
                    public List<string> OperateCommunity { get; set; }

                }

                [NameInMap("Preference")]
                [Validation(Required=false)]
                public int? Preference { get; set; }

                [NameInMap("PrependAsPath")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapPrependAsPath PrependAsPath { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapPrependAsPath : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("RouteMapId")]
                [Validation(Required=false)]
                public string RouteMapId { get; set; }

                [NameInMap("RouteTypes")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapRouteTypes RouteTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapRouteTypes : TeaModel {
                    [NameInMap("RouteType")]
                    [Validation(Required=false)]
                    public List<string> RouteType { get; set; }

                }

                [NameInMap("SourceChildInstanceTypes")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceChildInstanceTypes SourceChildInstanceTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceChildInstanceTypes : TeaModel {
                    [NameInMap("SourceChildInstanceType")]
                    [Validation(Required=false)]
                    public List<string> SourceChildInstanceType { get; set; }

                }

                [NameInMap("SourceInstanceIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceInstanceIds SourceInstanceIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceInstanceIds : TeaModel {
                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=false)]
                    public List<string> SourceInstanceId { get; set; }

                }

                [NameInMap("SourceInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? SourceInstanceIdsReverseMatch { get; set; }

                [NameInMap("SourceRegionIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRegionIds SourceRegionIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRegionIds : TeaModel {
                    [NameInMap("SourceRegionId")]
                    [Validation(Required=false)]
                    public List<string> SourceRegionId { get; set; }

                }

                [NameInMap("SourceRouteTableIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRouteTableIds SourceRouteTableIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRouteTableIds : TeaModel {
                    [NameInMap("SourceRouteTableId")]
                    [Validation(Required=false)]
                    public List<string> SourceRouteTableId { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TransitRouterRouteTableId")]
                [Validation(Required=false)]
                public string TransitRouterRouteTableId { get; set; }

                [NameInMap("TransmitDirection")]
                [Validation(Required=false)]
                public string TransmitDirection { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
