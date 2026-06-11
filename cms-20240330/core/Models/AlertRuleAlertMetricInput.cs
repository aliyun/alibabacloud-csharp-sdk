// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricInput : TeaModel {
        /// <summary>
        /// <para>A list of filter conditions. Call the ListAlertMetrics operation to query the lists of parameters and filter conditions that the metric supports.</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputFilterValue> FilterValues { get; set; }

        /// <summary>
        /// <para>The key of the metric group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm.jvm</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The key of the predefined metric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstat.jvm.GcPsMarkSweepCount</para>
        /// </summary>
        [NameInMap("metricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        /// <summary>
        /// <para>A list of parameters. Call the ListAlertMetrics operation to query the lists of parameters and filter conditions that the metric supports.</para>
        /// </summary>
        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputParamValue> ParamValues { get; set; }

    }

}
