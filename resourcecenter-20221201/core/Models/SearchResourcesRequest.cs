// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceCenter20221201.Models
{
    public class SearchResourcesRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<SearchResourcesRequestFilter> Filter { get; set; }
        public class SearchResourcesRequestFilter : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("MatchType")]
            [Validation(Required=false)]
            public string MatchType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SortCriterion")]
        [Validation(Required=false)]
        public SearchResourcesRequestSortCriterion SortCriterion { get; set; }
        public class SearchResourcesRequestSortCriterion : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

        }

    }

}
