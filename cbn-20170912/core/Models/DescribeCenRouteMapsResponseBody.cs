// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRouteMapsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("RouteMaps")]
        [Validation(Required=false)]
        public List<DescribeCenRouteMapsResponseBodyRouteMaps> RouteMaps { get; set; }
        public class DescribeCenRouteMapsResponseBodyRouteMaps : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("SourceInstanceIdsReverseMatch")]
            [Validation(Required=false)]
            public bool? SourceInstanceIdsReverseMatch { get; set; }

            [NameInMap("SourceRegionIds")]
            [Validation(Required=false)]
            public List<string> SourceRegionIds { get; set; }

            [NameInMap("MatchCommunitySet")]
            [Validation(Required=false)]
            public List<string> MatchCommunitySet { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            [NameInMap("CommunityOperateMode")]
            [Validation(Required=false)]
            public string CommunityOperateMode { get; set; }

            [NameInMap("PrependAsPath")]
            [Validation(Required=false)]
            public List<string> PrependAsPath { get; set; }

            [NameInMap("RouteTypes")]
            [Validation(Required=false)]
            public List<string> RouteTypes { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationInstanceIds")]
            [Validation(Required=false)]
            public List<string> DestinationInstanceIds { get; set; }

            [NameInMap("MatchAsns")]
            [Validation(Required=false)]
            public List<string> MatchAsns { get; set; }

            [NameInMap("DestinationInstanceIdsReverseMatch")]
            [Validation(Required=false)]
            public bool? DestinationInstanceIdsReverseMatch { get; set; }

            [NameInMap("OperateCommunitySet")]
            [Validation(Required=false)]
            public List<string> OperateCommunitySet { get; set; }

            [NameInMap("NextPriority")]
            [Validation(Required=false)]
            public int? NextPriority { get; set; }

            [NameInMap("RouteMapId")]
            [Validation(Required=false)]
            public string RouteMapId { get; set; }

            [NameInMap("TransmitDirection")]
            [Validation(Required=false)]
            public string TransmitDirection { get; set; }

            [NameInMap("SourceChildInstanceTypes")]
            [Validation(Required=false)]
            public List<string> SourceChildInstanceTypes { get; set; }

            [NameInMap("DestinationRouteTableIds")]
            [Validation(Required=false)]
            public List<string> DestinationRouteTableIds { get; set; }

            [NameInMap("SourceInstanceIds")]
            [Validation(Required=false)]
            public List<string> SourceInstanceIds { get; set; }

            [NameInMap("CenRegionId")]
            [Validation(Required=false)]
            public string CenRegionId { get; set; }

            [NameInMap("DestinationCidrBlocks")]
            [Validation(Required=false)]
            public List<string> DestinationCidrBlocks { get; set; }

            [NameInMap("CenId")]
            [Validation(Required=false)]
            public string CenId { get; set; }

            [NameInMap("SourceRouteTableIds")]
            [Validation(Required=false)]
            public List<string> SourceRouteTableIds { get; set; }

            [NameInMap("MapResult")]
            [Validation(Required=false)]
            public string MapResult { get; set; }

            [NameInMap("CommunityMatchMode")]
            [Validation(Required=false)]
            public string CommunityMatchMode { get; set; }

            [NameInMap("DestinationChildInstanceTypes")]
            [Validation(Required=false)]
            public List<string> DestinationChildInstanceTypes { get; set; }

            [NameInMap("AsPathMatchMode")]
            [Validation(Required=false)]
            public string AsPathMatchMode { get; set; }

            [NameInMap("Preference")]
            [Validation(Required=false)]
            public int? Preference { get; set; }

            [NameInMap("CidrMatchMode")]
            [Validation(Required=false)]
            public string CidrMatchMode { get; set; }

        }

    }

}
