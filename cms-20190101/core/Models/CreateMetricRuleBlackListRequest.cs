// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// <para>The category of the Alibaba Cloud service. For example, Redis includes <c>kvstore_standard</c> (Standard Edition), <c>kvstore_sharding</c> (Cluster Edition), and <c>kvstore_splitrw</c> (Read/Write Splitting Edition).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The effective period of the alert blacklist policy.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the alert blacklist policy is permanently valid.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the blacklist policy is valid only within the specified time range. This parameter supports the following two formats:</para>
        /// <list type="bullet">
        /// <item><description><c>03:00-04:59</c>: The alert blacklist policy is valid from 03:00 to 04:59 (excluding 05:00) local time.</description></item>
        /// <item><description><c>03:00-04:59 UTC+0700</c>: The alert blacklist policy is valid from 03:00 to 04:59 (excluding 05:00) UTC+07:00.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>03:00-04:59</para>
        /// </summary>
        [NameInMap("EffectiveTime")]
        [Validation(Required=false)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// <para>The end timestamp when the alert blacklist policy takes effect.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640608200000</para>
        /// </summary>
        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public string EnableEndTime { get; set; }

        /// <summary>
        /// <para>The start timestamp when the alert blacklist policy takes effect.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640237400000</para>
        /// </summary>
        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public string EnableStartTime { get; set; }

        /// <summary>
        /// <para>The list of instances of the specified Alibaba Cloud service in the alert blacklist policy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>The metrics of the instances.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, the alert blacklist policy applies to all metrics of the specified Alibaba Cloud service.</para>
        /// </description></item>
        /// <item><description><para>If you specify this parameter, the blacklist policy applies only to the specified metrics.</para>
        /// </description></item>
        /// </list>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<CreateMetricRuleBlackListRequestMetrics> Metrics { get; set; }
        public class CreateMetricRuleBlackListRequestMetrics : TeaModel {
            /// <summary>
            /// <para>The name of the metric.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk_utilization</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The extended dimension information of the instance. For example, <c>{&quot;device&quot;:&quot;C:&quot;}</c> indicates that the blacklist policy applies to all C drives of the ECS instance.</para>
            /// <para>Valid values of N: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;device&quot;:&quot;C:&quot;}</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

        }

        /// <summary>
        /// <para>The name of the alert blacklist policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Blacklist-01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The data namespace of the Alibaba Cloud service.</para>
        /// <para>For more information about the namespaces of Alibaba Cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Cloud service metrics</a>.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The effective scope of the alert blacklist policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>USER: The alert blacklist policy takes effect only within the current Alibaba Cloud account. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>GROUP: The alert blacklist policy takes effect within the specified application group. You must specify an application group. For more information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// <para>The list of application group IDs. The value is a JSON array.</para>
        /// <remarks>
        /// <para>This parameter is required only when <c>ScopeType</c> is set to <c>GROUP</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;67****&quot;,&quot;78****&quot;]</para>
        /// </summary>
        [NameInMap("ScopeValue")]
        [Validation(Required=false)]
        public string ScopeValue { get; set; }

    }

}
