// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleListRequest : TeaModel {
        /// <summary>
        /// <para>The status of the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OK: The alert rule has no active alerts.</description></item>
        /// <item><description>ALARM: The alert rule has active alerts.</description></item>
        /// <item><description>INSUFFICIENT_DATA: No data is available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("AlertState")]
        [Validation(Required=false)]
        public string AlertState { get; set; }

        /// <summary>
        /// <para>The monitoring dimensions of the specified resource.</para>
        /// <para>Set the value to a collection of <c>key:value</c> pairs. Example: <c>{&quot;userId&quot;:&quot;120886317861****&quot;}</c> or <c>{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;instanceId&quot;:&quot;i-2ze2d6j5uhg20x47****&quot;}</para>
        /// </summary>
        [NameInMap("Dimensions")]
        [Validation(Required=false)]
        public string Dimensions { get; set; }

        /// <summary>
        /// <para>Specifies whether to query enabled or disabled alert rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: queries enabled alert rules.</description></item>
        /// <item><description>false: queries disabled alert rules.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableState")]
        [Validation(Required=false)]
        public bool? EnableState { get; set; }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7301****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The name of the metric.</para>
        /// <para>For information about how to obtain the name of a metric, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpu_total</para>
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// <para>For information about how to obtain the namespace of a cloud service, see <a href="https://help.aliyun.com/document_detail/98846.html">DescribeMetricMetaList</a> or <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_ecs_dashboard</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// <para>Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Minimum value: 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the alert rule. You can specify up to 20 IDs at a time. Separate multiple IDs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>applyTemplate344cfd42-0f32-4fd6-805a-88d7908a****</para>
        /// </summary>
        [NameInMap("RuleIds")]
        [Validation(Required=false)]
        public string RuleIds { get; set; }

        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// <para>This parameter supports fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Rule_01</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
