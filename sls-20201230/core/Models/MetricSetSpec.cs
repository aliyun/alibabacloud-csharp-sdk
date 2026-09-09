// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class MetricSetSpec : TeaModel {
        /// <summary>
        /// <para>The label definitions for the metric set. Labels are recommended to be automatically generated using the dynamic method. MetricSet defines only common labels. Defining additional labels under individual Metrics is not recommended.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public MetricSetSpecLabels Labels { get; set; }
        public class MetricSetSpecLabels : TeaModel {
            /// <summary>
            /// <para>Specifies whether to automatically extract (dynamically generate) labels based on data. Set this parameter to true in most cases.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("dynamic")]
            [Validation(Required=false)]
            public bool? Dynamic { get; set; }

            /// <summary>
            /// <para>The static label key list. This parameter takes effect when dynamic is set to false.</para>
            /// </summary>
            [NameInMap("keys")]
            [Validation(Required=false)]
            public List<string> Keys { get; set; }

        }

        /// <summary>
        /// <para>The list of metrics included in the metric set.</para>
        /// </summary>
        [NameInMap("metrics")]
        [Validation(Required=false)]
        public List<Metric> Metrics { get; set; }

        /// <summary>
        /// <para>Specifies whether the metric requires secondary processing before use. For example, Prometheus counter/summary/histogram metrics require calculations such as rate before they can be used directly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("needs_processing")]
        [Validation(Required=false)]
        public bool? NeedsProcessing { get; set; }

        /// <summary>
        /// <para>The query syntax for the metrics. Valid values: prom (PromQL), spl, and cms (CloudMonitor).</para>
        /// 
        /// <b>Example:</b>
        /// <para>prom</para>
        /// </summary>
        [NameInMap("query_type")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

    }

}
