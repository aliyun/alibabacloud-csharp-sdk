// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemRuleAggregationTypesResponseBody : TeaModel {
        [NameInMap("AggregationTypeList")]
        [Validation(Required=false)]
        public List<ListSystemRuleAggregationTypesResponseBodyAggregationTypeList> AggregationTypeList { get; set; }
        public class ListSystemRuleAggregationTypesResponseBodyAggregationTypeList : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
