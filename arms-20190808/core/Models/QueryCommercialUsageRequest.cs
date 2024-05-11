// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryCommercialUsageRequest : TeaModel {
        [NameInMap("AdvancedFilters")]
        [Validation(Required=false)]
        public List<QueryCommercialUsageRequestAdvancedFilters> AdvancedFilters { get; set; }
        public class QueryCommercialUsageRequestAdvancedFilters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<string> Dimensions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("IntervalInSec")]
        [Validation(Required=false)]
        public int? IntervalInSec { get; set; }

        [NameInMap("Measures")]
        [Validation(Required=false)]
        public List<string> Measures { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
