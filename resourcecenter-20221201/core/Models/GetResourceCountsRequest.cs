// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class GetResourceCountsRequest : TeaModel {
        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<GetResourceCountsRequestFilter> Filter { get; set; }
        public class GetResourceCountsRequestFilter : TeaModel {
            /// <summary>
            /// The key of the filter condition. For more information, see `Supported filter parameters`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The matching mode.
            /// 
            /// The value Equals indicates an equal match.
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
        /// The dimension by which resources are queried. Valid values:
        /// 
        /// *   ResourceType
        /// *   Region
        /// *   ResourceGroupId
        /// *   TagKey
        /// *   TagValue
        /// </summary>
        [NameInMap("GroupByKey")]
        [Validation(Required=false)]
        public string GroupByKey { get; set; }

    }

}
