// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetDiscoveredResourceCountsGroupByRegionResponseBody : TeaModel {
        /// <summary>
        /// The statistics on the resources.
        /// </summary>
        [NameInMap("DiscoveredResourceCountsSummary")]
        [Validation(Required=false)]
        public List<GetDiscoveredResourceCountsGroupByRegionResponseBodyDiscoveredResourceCountsSummary> DiscoveredResourceCountsSummary { get; set; }
        public class GetDiscoveredResourceCountsGroupByRegionResponseBodyDiscoveredResourceCountsSummary : TeaModel {
            /// <summary>
            /// The dimension by which statistics are collected.
            /// 
            /// >  In most cases, the `Region` parameter instead of the GroupName parameter is returned.
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
            /// The total number of resources.
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
