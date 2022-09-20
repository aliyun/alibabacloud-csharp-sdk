// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeBgpGroupsResponseBody : TeaModel {
        [NameInMap("BgpGroups")]
        [Validation(Required=false)]
        public DescribeBgpGroupsResponseBodyBgpGroups BgpGroups { get; set; }
        public class DescribeBgpGroupsResponseBodyBgpGroups : TeaModel {
            [NameInMap("BgpGroup")]
            [Validation(Required=false)]
            public List<DescribeBgpGroupsResponseBodyBgpGroupsBgpGroup> BgpGroup { get; set; }
            public class DescribeBgpGroupsResponseBodyBgpGroupsBgpGroup : TeaModel {
                [NameInMap("AuthKey")]
                [Validation(Required=false)]
                public string AuthKey { get; set; }

                [NameInMap("BgpGroupId")]
                [Validation(Required=false)]
                public string BgpGroupId { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Hold")]
                [Validation(Required=false)]
                public string Hold { get; set; }

                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                [NameInMap("IsFake")]
                [Validation(Required=false)]
                public string IsFake { get; set; }

                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public string Keepalive { get; set; }

                [NameInMap("LocalAsn")]
                [Validation(Required=false)]
                public string LocalAsn { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PeerAsn")]
                [Validation(Required=false)]
                public string PeerAsn { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("RouteLimit")]
                [Validation(Required=false)]
                public string RouteLimit { get; set; }

                [NameInMap("RouterId")]
                [Validation(Required=false)]
                public string RouterId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
