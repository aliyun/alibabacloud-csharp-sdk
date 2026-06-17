// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutExporterRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the export rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc_******</para>
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// <para>The destination for data export.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DstNames")]
        [Validation(Required=false)]
        public List<string> DstNames { get; set; }

        /// <summary>
        /// <para>The metric name. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CPUUtilization</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the Alibaba Cloud service. For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// <remarks>
        /// <para>If the rule name already exists, the existing rule is modified. Otherwise, a new rule is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rule1_****</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The time windows for data export. Unit: seconds.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>To export data for multiple windows, separate the windows with commas (,).</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Exporting data at intervals of less than 60 seconds is not supported.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>60,300</para>
        /// </summary>
        [NameInMap("TargetWindows")]
        [Validation(Required=false)]
        public string TargetWindows { get; set; }

    }

}
