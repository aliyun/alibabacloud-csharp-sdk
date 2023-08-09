// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceCountsGroupByResourceTypeResponseBody : TeaModel {
        /// <summary>
        /// The resource type by which the statistics are collected.
        /// </summary>
        [NameInMap("DiscoveredResourceCountsSummary")]
        [Validation(Required=false)]
        public List<GetAggregateResourceCountsGroupByResourceTypeResponseBodyDiscoveredResourceCountsSummary> DiscoveredResourceCountsSummary { get; set; }
        public class GetAggregateResourceCountsGroupByResourceTypeResponseBodyDiscoveredResourceCountsSummary : TeaModel {
            /// <summary>
            /// This parameter is expired. The resource type by which statistics are collected.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The total number of resources in the region.
            /// </summary>
            [NameInMap("ResourceCount")]
            [Validation(Required=false)]
            public long? ResourceCount { get; set; }

            /// <summary>
            /// The resource type by which statistics are collected.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
