// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetNamedQueryEntry : TeaModel {
        /// <summary>
        /// <para>The label filter conditions. This parameter is optional and independent for each query.</para>
        /// </summary>
        [NameInMap("labelFilters")]
        [Validation(Required=false)]
        public List<LabelFilters> LabelFilters { get; set; }

        /// <summary>
        /// <para>The metric name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpuUsage</para>
        /// </summary>
        [NameInMap("metric")]
        [Validation(Required=false)]
        public string Metric { get; set; }

        /// <summary>
        /// <para>The metric set name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs_metrics</para>
        /// </summary>
        [NameInMap("metricSet")]
        [Validation(Required=false)]
        public string MetricSet { get; set; }

        /// <summary>
        /// <para>The query name, such as $A or $B, referenced by condition triggers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpuQuery</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
