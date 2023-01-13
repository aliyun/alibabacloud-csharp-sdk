// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeGeographicRegionMembershipResponseBody : TeaModel {
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
        /// The list of regions.
        /// </summary>
        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public DescribeGeographicRegionMembershipResponseBodyRegionIds RegionIds { get; set; }
        public class DescribeGeographicRegionMembershipResponseBodyRegionIds : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public List<DescribeGeographicRegionMembershipResponseBodyRegionIdsRegionId> RegionId { get; set; }
            public class DescribeGeographicRegionMembershipResponseBodyRegionIdsRegionId : TeaModel {
                /// <summary>
                /// The ID of the region.
                /// 
                /// You can call the [DescribeChildInstanceRegions](~~132080~~) operation to query the most recent region list.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

            }

        }

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
