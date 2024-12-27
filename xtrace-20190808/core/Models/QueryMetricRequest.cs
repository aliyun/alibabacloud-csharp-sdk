// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class QueryMetricRequest : TeaModel {
        /// <summary>
        /// <para>The dimensions of the metric that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RT</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<string> Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// <remarks>
        /// <para> The value of this parameter is of the LONG type. Precision loss may occur during serialization or deserialization. The value must be less than or equal to 9007199254740991.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1575622455686</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<QueryMetricRequestFilters> Filters { get; set; }
        public class QueryMetricRequestFilters : TeaModel {
            /// <summary>
            /// <para>The key of the field that you want to use to filter the returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http.status_code</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the field that you want to use to filter the returned entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The time interval at which you want to query metric data. Unit: milliseconds. Minimum value: 60000. </para>
        /// <remarks>
        /// <para>If you set this parameter to 2147483647, all data in the specified time interval is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("IntervalInSec")]
        [Validation(Required=false)]
        public int? IntervalInSec { get; set; }

        /// <summary>
        /// <para>The maximum number of entries that you want to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The measures of the metric that you want to query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("Measures")]
        [Validation(Required=false)]
        public List<string> Measures { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>appstat.incall</c>: trace statistics </description></item>
        /// <item><description><c>appstat.sql</c>: SQL statistics</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstat.incall</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the returned entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ASC: ascending order </description></item>
        /// <item><description>DESC: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The field based on which you want to sort the returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>count</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The ID of the proxy user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testefgag12</para>
        /// </summary>
        [NameInMap("ProxyUserId")]
        [Validation(Required=false)]
        public string ProxyUserId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a timestamp that is accurate to milliseconds.</para>
        /// <remarks>
        /// <para> The value of this parameter is of the LONG type. Precision loss may occur during serialization or deserialization. The value must be less than or equal to 9007199254740991.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1575561600000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
