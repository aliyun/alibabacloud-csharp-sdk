// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Queries : TeaModel {
        /// <summary>
        /// <para>The end offset of the time range for SLS_MULTI_QUERY (mutually exclusive with window).</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The query expression (PromQL for PROMETHEUS_MULTI_QUERY and SPL for SLS_MULTI_QUERY).</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The label filter conditions for UMODEL_METRICSET_MULTI_QUERY (optional and independent per query).</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;env&quot;,&quot;operator&quot;:&quot;=&quot;,&quot;value&quot;:&quot;prod&quot;}]</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<LabelFilters> LabelFilters { get; set; }

        /// <summary>
        /// <para>The metric name for UMODEL_METRICSET_MULTI_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The metric set name for UMODEL_METRICSET_MULTI_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>The query name for PROMETHEUS_MULTI_QUERY or UMODEL_METRICSET_MULTI_QUERY (such as $A or $B, referenced by condition triggers).</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例名称</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The start offset of the time range for SLS_MULTI_QUERY (mutually exclusive with window).</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The time unit for SLS_MULTI_QUERY (day, hour, minute, or second).</para>
        /// 
        /// <b>Example:</b>
        /// <para>second</para>
        /// </summary>
        [NameInMap("timeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// <para>The alignment window size for SLS_MULTI_QUERY (mutually exclusive with start and end).</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("window")]
        [Validation(Required=false)]
        public long? Window { get; set; }

    }

}
