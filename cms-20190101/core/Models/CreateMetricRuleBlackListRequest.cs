// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateMetricRuleBlackListRequest : TeaModel {
        /// <summary>
        /// <para>The category of the cloud service. For example, ApsaraDB for Redis includes the following categories: ApsaraDB for Redis (standard architecture), ApsaraDB for Redis (cluster architecture), and ApsaraDB for Redis (read/write splitting architecture). In this case, the valid values of this parameter for ApsaraDB for Redis include <c>kvstore_standard</c>, <c>kvstore_sharding</c>, and <c>kvstore_splitrw</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The time range within which the blacklist policy is effective.</para>
        /// <list type="bullet">
        /// <item><description><para>If you do not configure this parameter, the blacklist policy is permanently effective.</para>
        /// </description></item>
        /// <item><description><para>If you configure this parameter, the blacklist policy is effective only within the specified time range. Examples:</para>
        /// <list type="bullet">
        /// <item><description><c>03:00-04:59</c>: The blacklist policy is effective from 03:00 to 05:00 local time. 05:00 local time is excluded.</description></item>
        /// <item><description><c>03:00-04:59 UTC+0700</c>: The blacklist policy is effective from 03:00 to 05:00 (UTC+7). 05:00 (UTC+7) is excluded.</description></item>
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
        /// <para>The timestamp when the blacklist policy expires.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640608200000</para>
        /// </summary>
        [NameInMap("EnableEndTime")]
        [Validation(Required=false)]
        public string EnableEndTime { get; set; }

        /// <summary>
        /// <para>The timestamp when the blacklist policy starts to take effect.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1640237400000</para>
        /// </summary>
        [NameInMap("EnableStartTime")]
        [Validation(Required=false)]
        public string EnableStartTime { get; set; }

        /// <summary>
        /// <para>The IDs of the instances that belong to the specified cloud service.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<string> Instances { get; set; }

        /// <summary>
        /// <para>The metrics of the instance.</para>
        /// <list type="bullet">
        /// <item><description>If you do not configure this parameter, the blacklist policy applies to all metrics of the specified cloud service.</description></item>
        /// <item><description>If you configure this parameter, the blacklist policy applies only to the current metric.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public List<CreateMetricRuleBlackListRequestMetrics> Metrics { get; set; }
        public class CreateMetricRuleBlackListRequestMetrics : TeaModel {
            /// <summary>
            /// <para>The metric name.</para>
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
            /// <para>The extended dimension of the instance. For example, <c>{&quot;device&quot;:&quot;C:&quot;}</c> specifies that the blacklist policy is applied to all C disks of the specified Elastic Compute Service (ECS) instance.</para>
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
        /// <para>The name of the blacklist policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Blacklist-01</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// <para>For more information about the namespaces of different cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
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
        /// <para>The effective scope of the blacklist policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>USER (default): The blacklist policy takes effect only for the current Alibaba Cloud account.</description></item>
        /// <item><description>GROUP: The blacklist policy takes effect only for the specified application group. For information about how to query the IDs of application groups, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>USER</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// <para>The ID of the application group. The value of this parameter is a JSON array.</para>
        /// <remarks>
        /// <para>This parameter must be specified when <c>ScopeType</c> is set to <c>GROUP</c>.</para>
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
