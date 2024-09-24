// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class PutExporterRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the data export rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Export CPU metrics</para>
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// <para>The destination to which the data is exported. Valid values of N: 1 to 20.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>distName1</para>
        /// </summary>
        [NameInMap("DstNames")]
        [Validation(Required=false)]
        public List<string> DstNames { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// <remarks>
        /// </remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// <remarks>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// </remarks>
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
        /// <para>If the specified rule exists, the existing rule is modified. Otherwise, a rule is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyRuleName</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The time window of the exported data. Unit: seconds.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Separate multiple time windows with commas (,).</para>
        /// </description></item>
        /// <item><description><para>Data in a time window of less than 60 seconds cannot be exported.</para>
        /// </description></item>
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
