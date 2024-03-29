// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceCountsGroupByRegionResponseBody : TeaModel {
        /// <summary>
        /// The ID of the region by which statistics are collected.
        /// </summary>
        [NameInMap("DiscoveredResourceCountsSummary")]
        [Validation(Required=false)]
        public List<GetAggregateResourceCountsGroupByRegionResponseBodyDiscoveredResourceCountsSummary> DiscoveredResourceCountsSummary { get; set; }
        public class GetAggregateResourceCountsGroupByRegionResponseBodyDiscoveredResourceCountsSummary : TeaModel {
            /// <summary>
            /// The dimension by which statistics are collected.
            /// 
            /// >  In most cases, the `Region` parameter is returned instead of the GroupName parameter.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The ID of the region by which statistics are collected.
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The total number of resources in the region.
            /// </summary>
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public long? ResourceCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
