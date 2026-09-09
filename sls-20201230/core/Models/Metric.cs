// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class Metric : TeaModel {
        /// <summary>
        /// <para>The aggregation method of the metric (such as avg or sum). If the metric is already aggregated by the same dimensions (such as avg(rate(cpu_core_usage_seconds_total{}[1m]))), configuration is not required. Metrics based on log aggregation generally do not require configuration either.</para>
        /// 
        /// <b>Example:</b>
        /// <para>avg</para>
        /// </summary>
        [NameInMap("aggregator")]
        [Validation(Required=false)]
        public string Aggregator { get; set; }

        /// <summary>
        /// <para>The numeric or display formatting method, such as KMB (thousand/million/billion), percent, ms, or dthms (hours:minutes:seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>KMB</para>
        /// </summary>
        [NameInMap("data_format")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// <para>The business description of the metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The number of requests processed by the service per second</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name for UI presentation, which can contain Chinese characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Request Count</para>
        /// </summary>
        [NameInMap("display_name")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The generation method of the metric. In PromQL mode, this is a PromQL expression (such as rate(request_count{}[1m]), which can be combined with aggregator to compute sum(...) by (label1, label2)). In SQL/SPL mode, this is an aggregation expression (such as count(1)) that is incorporated into the generated query statement.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rate(request_count{}[1m])</para>
        /// </summary>
        [NameInMap("generator")]
        [Validation(Required=false)]
        public string Generator { get; set; }

        /// <summary>
        /// <para>Indicates whether the metric is a golden metric (core metrics such as latency, traffic, error count, and saturation).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("golden_metric")]
        [Validation(Required=false)]
        public bool? GoldenMetric { get; set; }

        /// <summary>
        /// <para>The collection interval of the metric in microseconds. Multiple values indicate that multiple collection interval precisions are supported.</para>
        /// </summary>
        [NameInMap("interval_us")]
        [Validation(Required=false)]
        public List<long?> IntervalUs { get; set; }

        /// <summary>
        /// <para>The metric name, which is unique within the MetricSet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request_count</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The expected query mode of the metric: range (range query), instant (instant query), or both.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instant</para>
        /// </summary>
        [NameInMap("query_mode")]
        [Validation(Required=false)]
        public string QueryMode { get; set; }

        /// <summary>
        /// <para>The metric type. Metrics that do not require secondary processing are fixed as gauge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gauge</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The metric unit, which is used for display only without automatic conversion. For example, ms is not automatically converted to s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ms</para>
        /// </summary>
        [NameInMap("unit")]
        [Validation(Required=false)]
        public string Unit { get; set; }

    }

}
