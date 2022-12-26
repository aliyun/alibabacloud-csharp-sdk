// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemAggregationRulesResponseBody : TeaModel {
        [NameInMap("AggregationList")]
        [Validation(Required=false)]
        public List<ListSystemAggregationRulesResponseBodyAggregationList> AggregationList { get; set; }
        public class ListSystemAggregationRulesResponseBodyAggregationList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RuleCount")]
            [Validation(Required=false)]
            public int? RuleCount { get; set; }

        }

        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSystemAggregationRulesResponseBodyPageInfo PageInfo { get; set; }
        public class ListSystemAggregationRulesResponseBodyPageInfo : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
