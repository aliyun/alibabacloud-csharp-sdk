// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricInput : TeaModel {
        /// <summary>
        /// <para>List of user-provided filter conditions. The supported parameters and filter conditions for the metric can be queried via ListAlertMetrics.</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputFilterValue> FilterValues { get; set; }

        /// <summary>
        /// <para>Key of the metric group selected by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm.jvm</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>Key of the predefined metric selected by the user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstat.jvm.GcPsMarkSweepCount</para>
        /// </summary>
        [NameInMap("metricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        /// <summary>
        /// <para>List of input parameters. The metric\&quot;s supported parameters and filter conditions can be queried via ListAlertMetrics.</para>
        /// </summary>
        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputParamValue> ParamValues { get; set; }

    }

}
