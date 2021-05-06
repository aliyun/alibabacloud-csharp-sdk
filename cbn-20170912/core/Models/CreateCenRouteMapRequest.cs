// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenRouteMapRequest : TeaModel {
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

        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        [NameInMap("CenRegionId")]
        [Validation(Required=false)]
        public string CenRegionId { get; set; }

        [NameInMap("TransmitDirection")]
        [Validation(Required=false)]
        public string TransmitDirection { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("MapResult")]
        [Validation(Required=false)]
        public string MapResult { get; set; }

        [NameInMap("NextPriority")]
        [Validation(Required=false)]
        public int? NextPriority { get; set; }

        [NameInMap("CidrMatchMode")]
        [Validation(Required=false)]
        public string CidrMatchMode { get; set; }

        [NameInMap("AsPathMatchMode")]
        [Validation(Required=false)]
        public string AsPathMatchMode { get; set; }

        [NameInMap("CommunityMatchMode")]
        [Validation(Required=false)]
        public string CommunityMatchMode { get; set; }

        [NameInMap("CommunityOperateMode")]
        [Validation(Required=false)]
        public string CommunityOperateMode { get; set; }

        [NameInMap("Preference")]
        [Validation(Required=false)]
        public int? Preference { get; set; }

        [NameInMap("SourceInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? SourceInstanceIdsReverseMatch { get; set; }

        [NameInMap("DestinationInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? DestinationInstanceIdsReverseMatch { get; set; }

        [NameInMap("SourceInstanceIds")]
        [Validation(Required=false)]
        public List<string> SourceInstanceIds { get; set; }

        [NameInMap("DestinationInstanceIds")]
        [Validation(Required=false)]
        public List<string> DestinationInstanceIds { get; set; }

        [NameInMap("SourceRouteTableIds")]
        [Validation(Required=false)]
        public List<string> SourceRouteTableIds { get; set; }

        [NameInMap("DestinationRouteTableIds")]
        [Validation(Required=false)]
        public List<string> DestinationRouteTableIds { get; set; }

        [NameInMap("SourceRegionIds")]
        [Validation(Required=false)]
        public List<string> SourceRegionIds { get; set; }

        [NameInMap("SourceChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> SourceChildInstanceTypes { get; set; }

        [NameInMap("DestinationChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> DestinationChildInstanceTypes { get; set; }

        [NameInMap("DestinationCidrBlocks")]
        [Validation(Required=false)]
        public List<string> DestinationCidrBlocks { get; set; }

        [NameInMap("RouteTypes")]
        [Validation(Required=false)]
        public List<string> RouteTypes { get; set; }

        [NameInMap("MatchAsns")]
        [Validation(Required=false)]
        public List<int?> MatchAsns { get; set; }

        [NameInMap("MatchCommunitySet")]
        [Validation(Required=false)]
        public List<string> MatchCommunitySet { get; set; }

        [NameInMap("OperateCommunitySet")]
        [Validation(Required=false)]
        public List<string> OperateCommunitySet { get; set; }

        [NameInMap("PrependAsPath")]
        [Validation(Required=false)]
        public List<int?> PrependAsPath { get; set; }

    }

}
