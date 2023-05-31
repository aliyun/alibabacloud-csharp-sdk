// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemRuleAggregationTypesResponseBody : TeaModel {
        /// <summary>
        /// An array that consists of the aggregation types.
        /// </summary>
        [NameInMap("AggregationTypeList")]
        [Validation(Required=false)]
        public List<ListSystemRuleAggregationTypesResponseBodyAggregationTypeList> AggregationTypeList { get; set; }
        public class ListSystemRuleAggregationTypesResponseBodyAggregationTypeList : TeaModel {
            /// <summary>
            /// The ID of the aggregation type.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// The name of the aggregation type.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
