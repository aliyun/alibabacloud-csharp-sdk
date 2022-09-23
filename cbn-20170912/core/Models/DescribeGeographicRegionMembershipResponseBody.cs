// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGeographicRegionMembershipResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public DescribeGeographicRegionMembershipResponseBodyRegionIds RegionIds { get; set; }
        public class DescribeGeographicRegionMembershipResponseBodyRegionIds : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public List<DescribeGeographicRegionMembershipResponseBodyRegionIdsRegionId> RegionId { get; set; }
            public class DescribeGeographicRegionMembershipResponseBodyRegionIdsRegionId : TeaModel {
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
