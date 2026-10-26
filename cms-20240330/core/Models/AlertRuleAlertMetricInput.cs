// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricInput : TeaModel {
        /// <summary>
        /// <para>The list of filter conditions entered by the user. You can call ListAlertMetrics to query the parameters and filter conditions supported by the metric.</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputFilterValue> FilterValues { get; set; }

        /// <summary>
        /// <para>The key of the metric group selected by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm.jvm</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The key of the predefined metric selected by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstat.jvm.GcPsMarkSweepCount</para>
        /// </summary>
        [NameInMap("metricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        /// <summary>
        /// <para>The list of input parameters. You can call ListAlertMetrics to query the parameters and filter conditions supported by the metric.</para>
        /// </summary>
        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputParamValue> ParamValues { get; set; }

    }

}
