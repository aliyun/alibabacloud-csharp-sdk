// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleAlertMetricInput : TeaModel {
        /// <summary>
        /// <para>用户输入的过滤条件列表。指标所支持的参数列表、过滤条件列表可通过ListAlertMetrics进行查询。</para>
        /// </summary>
        [NameInMap("filterValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputFilterValue> FilterValues { get; set; }

        /// <summary>
        /// <para>用户所选指标组的key</para>
        /// 
        /// <b>Example:</b>
        /// <para>apm.jvm</para>
        /// </summary>
        [NameInMap("groupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>用户所选预定义指标的key</para>
        /// 
        /// <b>Example:</b>
        /// <para>appstat.jvm.GcPsMarkSweepCount</para>
        /// </summary>
        [NameInMap("metricId")]
        [Validation(Required=false)]
        public string MetricId { get; set; }

        /// <summary>
        /// <para>输入的参数列表。  指标所支持的参数列表、过滤条件列表可通过ListAlertMetrics进行查询。</para>
        /// </summary>
        [NameInMap("paramValues")]
        [Validation(Required=false)]
        public List<AlertRuleAlertMetricInputParamValue> ParamValues { get; set; }

    }

}
