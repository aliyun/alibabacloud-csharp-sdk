// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class QueryMetricRequest : TeaModel {
        /// <summary>
        /// The dimensions of the metric that you want to query.
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<string> Dimensions { get; set; }

        /// <summary>
        /// The timestamp of the end time of the time range to query. The timestamp is accurate to milliseconds.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// The filter conditions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<QueryMetricRequestFilters> Filters { get; set; }
        public class QueryMetricRequestFilters : TeaModel {
            /// <summary>
            /// The key of the field that you want to use to filter the returned entries.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of the field that you want to use to filter the returned entries.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The time interval at which you want to query metric data. Unit: milliseconds. Minimum value: 60000. 
        /// 
        /// > If you set this parameter to 2147483647, all data in the specified time interval is returned.
        /// </summary>
        [NameInMap("IntervalInSec")]
        [Validation(Required=false)]
        public int? IntervalInSec { get; set; }

        /// <summary>
        /// The maximum number of entries that you want to return.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The measures of the metric that you want to query.
        /// </summary>
        [NameInMap("Measures")]
        [Validation(Required=false)]
        public List<string> Measures { get; set; }

        /// <summary>
        /// The name of the metric. Valid values:
        /// 
        /// - `appstat.incall`: trace statistics 
        /// - `appstat.sql`: SQL statistics
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// The order in which you want to sort the returned entries. Valid values:
        /// 
        /// - ASC: ascending order 
        /// - DESC: descending order
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// The field based on which you want to sort the returned entries.
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// The ID of the proxy user.
        /// </summary>
        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public string ProxyUserId { get; set; }

        /// <summary>
        /// The timestamp of the start time of the time range to query. The timestamp is accurate to milliseconds.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
