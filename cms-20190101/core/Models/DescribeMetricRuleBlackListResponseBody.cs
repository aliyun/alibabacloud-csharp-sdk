// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleBlackListResponseBody : TeaModel {
        /// <summary>
        /// <para>The categories of the Alibaba Cloud service. For example, ApsaraDB for Redis includes the following categories: ApsaraDB for Redis (standard architecture), ApsaraDB for Redis (cluster architecture), and ApsaraDB for Redis (read/write splitting architecture). In this case, the valid values of this parameter for ApsaraDB for Redis include <c>kvstore_standard</c>, <c>kvstore_sharding</c>, and <c>kvstore_splitrw</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The queried blacklist policies.</para>
        /// </summary>
        [NameInMap("DescribeMetricRuleBlackList")]
        [Validation(Required=false)]
        public List<DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList> DescribeMetricRuleBlackList { get; set; }
        public class DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList : TeaModel {
            /// <summary>
            /// <para>The category of the cloud service. For example, ApsaraDB for Redis includes the following categories: ApsaraDB for Redis (standard architecture), ApsaraDB for Redis (cluster architecture), and ApsaraDB for Redis (read/write splitting architecture). In this case, the valid values of this parameter for ApsaraDB for Redis include <c>kvstore_standard</c>, <c>kvstore_sharding</c>, and <c>kvstore_splitrw</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The timestamp when the blacklist policy was created.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665714561000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time range within which the blacklist policy is effective.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-23:59</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the blacklist policy started to take effect.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640608200000</para>
            /// </summary>
            [NameInMap("EnableEndTime")]
            [Validation(Required=false)]
            public long? EnableEndTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the blacklist policy expired.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640237400000</para>
            /// </summary>
            [NameInMap("EnableStartTime")]
            [Validation(Required=false)]
            public long? EnableStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the blacklist policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93514c96-ceb8-47d8-8ee3-93b6d98b****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The IDs of the instances that belong to the specified cloud service.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            /// <summary>
            /// <para>The status of the blacklist policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The blacklist policy is enabled.</description></item>
            /// <item><description>false: The blacklist policy is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsEnable")]
            [Validation(Required=false)]
            public bool? IsEnable { get; set; }

            /// <summary>
            /// <para>The metrics of the instance.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackListMetrics> Metrics { get; set; }
            public class DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackListMetrics : TeaModel {
                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disk_utilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The extended dimension of the instance. For example, <c>{&quot;device&quot;:&quot;C:&quot;}</c> specifies that the blacklist policy is applied to all C disks of the specified Elastic Compute Service (ECS) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;device&quot;:&quot;C:&quot;}]</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// <para>The name of the blacklist policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Blacklist-01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace of the cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The effective scope of the blacklist policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>USER: The blacklist policy takes effect only within the current Alibaba Cloud account.</description></item>
            /// <item><description>GROUP: The blacklist policy takes effect only within the specified application group.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <para>The IDs of the application groups.</para>
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            /// <summary>
            /// <para>The timestamp when the blacklist policy was modified.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665718373000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D63E76CB-29AA-5B9F-88CE-400A6F28D428</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The namespace of the cloud service.</para>
        /// <para>For more information about the namespaces of different cloud services, see <a href="https://help.aliyun.com/document_detail/163515.html">Appendix 1: Metrics</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The timestamp when the blacklist policy was created.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
