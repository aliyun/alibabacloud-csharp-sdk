// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryMetricByPageRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Default value: <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Custom filter conditions.</para>
        /// </summary>
        [NameInMap("CustomFilters")]
        [Validation(Required=false)]
        public List<string> CustomFilters { get; set; }

        /// <summary>
        /// <para>The dimensions of the metric that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;detector_browser&quot;,&quot;detector_device&quot;]</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<string> Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1667546895000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public List<QueryMetricByPageRequestFilters> Filters { get; set; }
        public class QueryMetricByPageRequestFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition. You must set the key to <c>pid</c> or <c>regionId</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pid</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the filter condition. You must set the value of the <c>pid</c> or <c>regionId</c> condition. For information about how to obtain the <c>pid</c>, see the &quot;Obtain the PID of an application&quot; section.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx@74xxx</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The time interval at which you want to query metric data. Unit: milliseconds. Minimum value: 60000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000</para>
        /// </summary>
        [NameInMap("IntervalInSec")]
        [Validation(Required=false)]
        public int? IntervalInSec { get; set; }

        /// <summary>
        /// <para>The measures of the metric that you want to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pv</para>
        /// </summary>
        [NameInMap("Measures")]
        [Validation(Required=false)]
        public List<string> Measures { get; set; }

        /// <summary>
        /// <para>The metric that you want to query. You cannot specify a custom metric. For more information, see the &quot;Application monitoring metrics that can be queried&quot; section.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstat.host</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The order in which measures are sorted. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>ASC</c>: ascending order</description></item>
        /// <item><description><c>DESC</c>: descending order</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify the parameter, data is not sorted.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The dimension from which metrics are sorted. You can set this parameter to a supported dimension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pid</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>This parameter is no longer supported. The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1667287695000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
