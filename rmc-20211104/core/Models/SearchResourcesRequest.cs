// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RMC20211104.Models
{
    public class SearchResourcesRequest : TeaModel {
        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<SearchResourcesRequestFilter> Filter { get; set; }
        public class SearchResourcesRequestFilter : TeaModel {
            /// <summary>
            /// The key of the filter condition. Valid values:
            /// 
            /// *   ResourceType: resource type
            /// *   RegionId: region ID
            /// *   ResourceId: resource ID
            /// *   ResourceGroupId: resource group ID
            /// *   ResourceName: resource name
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The matching method. Set the value to Equals. This value indicates that resources that match the filter conditions are queried.
            /// </summary>
            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            /// <summary>
            /// The values of the filter condition.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The maximum number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to initiate the next request.
        /// 
        /// If the total number of entries returned for the current request exceeds the value of the `MaxResults` parameter, the entries are truncated. In this case, you can use the token to initiate another request and obtain the remaining entries.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The method that is used to sort the entries.
        /// </summary>
        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public SearchResourcesRequestSortCriterion SortCriterion { get; set; }
        public class SearchResourcesRequestSortCriterion : TeaModel {
            /// <summary>
            /// The attribute based on which the entries are sorted.
            /// 
            /// The value `CreateTime` indicates the creation time of resources.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The order in which the entries are sorted. Valid values:
            /// 
            /// *   ASC: The entries are sorted in ascending order. This value is the default value.
            /// *   DESC: The entries are sorted in descending order.
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

        }

    }

}
