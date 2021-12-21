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
                public string AsPathMatchMode { get; set; }
                public string CenId { get; set; }
                public string CenRegionId { get; set; }
                public string CidrMatchMode { get; set; }
                public string CommunityMatchMode { get; set; }
                public string CommunityOperateMode { get; set; }
                public string Description { get; set; }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationChildInstanceTypes DestinationChildInstanceTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationChildInstanceTypes : TeaModel {
                    [NameInMap("DestinationChildInstanceType")]
                    [Validation(Required=false)]
                    public List<string> DestinationChildInstanceType { get; set; }

                }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationCidrBlocks DestinationCidrBlocks { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationCidrBlocks : TeaModel {
                    [NameInMap("DestinationCidrBlock")]
                    [Validation(Required=false)]
                    public List<string> DestinationCidrBlock { get; set; }

                }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationInstanceIds DestinationInstanceIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationInstanceIds : TeaModel {
                    [NameInMap("DestinationInstanceId")]
                    [Validation(Required=false)]
                    public List<string> DestinationInstanceId { get; set; }

                }
                public bool? DestinationInstanceIdsReverseMatch { get; set; }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRouteTableIds DestinationRouteTableIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRouteTableIds : TeaModel {
                    [NameInMap("DestinationRouteTableId")]
                    [Validation(Required=false)]
                    public List<string> DestinationRouteTableId { get; set; }

                }
                public string MapResult { get; set; }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchAsns MatchAsns { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchAsns : TeaModel {
                    [NameInMap("MatchAsn")]
                    [Validation(Required=false)]
                    public List<string> MatchAsn { get; set; }

                }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchCommunitySet MatchCommunitySet { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchCommunitySet : TeaModel {
                    [NameInMap("MatchCommunity")]
                    [Validation(Required=false)]
                    public List<string> MatchCommunity { get; set; }

                }
                public int? NextPriority { get; set; }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapOperateCommunitySet OperateCommunitySet { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapOperateCommunitySet : TeaModel {
                    [NameInMap("OperateCommunity")]
                    [Validation(Required=false)]
                    public List<string> OperateCommunity { get; set; }

                }
                public int? Preference { get; set; }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapPrependAsPath PrependAsPath { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapPrependAsPath : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }
                public int? Priority { get; set; }
                public string RouteMapId { get; set; }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapRouteTypes RouteTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapRouteTypes : TeaModel {
                    [NameInMap("RouteType")]
                    [Validation(Required=false)]
                    public List<string> RouteType { get; set; }

                }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceChildInstanceTypes SourceChildInstanceTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceChildInstanceTypes : TeaModel {
                    [NameInMap("SourceChildInstanceType")]
                    [Validation(Required=false)]
                    public List<string> SourceChildInstanceType { get; set; }

                }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceInstanceIds SourceInstanceIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceInstanceIds : TeaModel {
                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=false)]
                    public List<string> SourceInstanceId { get; set; }

                }
                public bool? SourceInstanceIdsReverseMatch { get; set; }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRegionIds SourceRegionIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRegionIds : TeaModel {
                    [NameInMap("SourceRegionId")]
                    [Validation(Required=false)]
                    public List<string> SourceRegionId { get; set; }

                }
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRouteTableIds SourceRouteTableIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRouteTableIds : TeaModel {
                    [NameInMap("SourceRouteTableId")]
                    [Validation(Required=false)]
                    public List<string> SourceRouteTableId { get; set; }

                }
                public string Status { get; set; }
                public string TransmitDirection { get; set; }
            }
        };

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
