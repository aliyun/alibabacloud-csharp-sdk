// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Queries : TeaModel {
        /// <summary>
        /// <para>The end offset of the time range for SLS_MULTI_QUERY. This parameter is mutually exclusive with window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        /// <summary>
        /// <para>The query expression. For PROMETHEUS_MULTI_QUERY, this is a PromQL expression. For SLS_MULTI_QUERY, this is an SPL expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleValue</para>
        /// </summary>
        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The label filter conditions for UMODEL_METRICSET_MULTI_QUERY. This parameter is optional and independent for each query.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<LabelFilters> LabelFilters { get; set; }

        /// <summary>
        /// <para>The metric name for UMODEL_METRICSET_MULTI_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The metric set name for UMODEL_METRICSET_MULTI_QUERY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>The query name used by PROMETHEUS_MULTI_QUERY and UMODEL_METRICSET_MULTI_QUERY, such as $A or $B, which can be referenced by condition triggers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The start offset of the time range for SLS_MULTI_QUERY. This parameter is mutually exclusive with window.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        /// <summary>
        /// <para>The time unit for SLS_MULTI_QUERY. Valid values: day, hour, minute, and second.</para>
        /// 
        /// <b>Example:</b>
        /// <para>second</para>
        /// </summary>
        [NameInMap("timeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// <para>The snap window size for SLS_MULTI_QUERY. This parameter is mutually exclusive with start and end.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("window")]
        [Validation(Required=false)]
        public long? Window { get; set; }

    }

}
