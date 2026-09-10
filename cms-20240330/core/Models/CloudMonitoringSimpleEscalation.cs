// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class CloudMonitoringSimpleEscalation : TeaModel {
        /// <summary>
        /// <para>The multi-level trigger list.</para>
        /// </summary>
        [NameInMap("escalations")]
        [Validation(Required=false)]
        public List<CloudMonitoringSimpleEscalationEntry> Escalations { get; set; }

        /// <summary>
        /// <para>The metric name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpuUsage</para>
        /// </summary>
        [NameInMap("metricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The collection period, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

    }

}
