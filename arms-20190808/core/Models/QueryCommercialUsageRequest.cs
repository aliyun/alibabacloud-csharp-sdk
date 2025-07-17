// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class QueryCommercialUsageRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions.</para>
        /// </summary>
        [NameInMap("AdvancedFilters")]
        [Validation(Required=false)]
        public List<QueryCommercialUsageRequestAdvancedFilters> AdvancedFilters { get; set; }
        public class QueryCommercialUsageRequestAdvancedFilters : TeaModel {
            /// <summary>
            /// <para>The key of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>regionId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The operator. Valid values: eq and in.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eq</para>
            /// </summary>
            [NameInMap("OpType")]
            [Validation(Required=false)]
            public string OpType { get; set; }

            /// <summary>
            /// <para>The value of the filter condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The dimensions of the metric that you want to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>dataType: data type</description></item>
        /// <item><description>productType: product type</description></item>
        /// <item><description>instanceId: instance ID</description></item>
        /// <item><description>instanceName: instance name</description></item>
        /// <item><description>instanceType: instance type</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public List<string> Dimensions { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699286400000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The time interval between data slices. Unit: seconds. Minimum value: 3600.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>3600: 1 hour</description></item>
        /// <item><description>86400: 1 day</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("IntervalInSec")]
        [Validation(Required=false)]
        public int? IntervalInSec { get; set; }

        /// <summary>
        /// <para>The measures of the metric that you want to query.</para>
        /// </summary>
        [NameInMap("Measures")]
        [Validation(Required=false)]
        public List<string> Measures { get; set; }

        /// <summary>
        /// <para>The name of the metric. Valid value: USAGEFEE.STAT.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USAGEFEE.STAT</para>
        /// </summary>
        [NameInMap("Metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The order in which data is sorted. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><c>ASC</c>: ascending order</description></item>
        /// <item><description><c>DESC</c>: descending order</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASC</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The dimension by which data is sorted.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description><para>dataType</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dataType</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The data type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>instantQuery: non-time series</description></item>
        /// <item><description>timeSeriesQuery: time series</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instantQuery</para>
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699200000000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
