// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMetricRuleBlackListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>A value of 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The blacklist policies.</para>
        /// </summary>
        [NameInMap("DescribeMetricRuleBlackList")]
        [Validation(Required=false)]
        public List<DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList> DescribeMetricRuleBlackList { get; set; }
        public class DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList : TeaModel {
            /// <summary>
            /// <para>The category of the Alibaba Cloud service. For example, Redis has different editions, such as <c>kvstore_standard</c> (Standard Edition), <c>kvstore_sharding</c> (Cluster Edition), and <c>kvstore_splitrw</c> (Read/write Splitting Edition).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the blacklist policy was created.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665714561000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time range during which the blacklist policy is effective.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-23:59</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the alert blacklist policy is no longer in effect.</para>
            /// <para>The timestamp is measured in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640608200000</para>
            /// </summary>
            [NameInMap("EnableEndTime")]
            [Validation(Required=false)]
            public long? EnableEndTime { get; set; }

            /// <summary>
            /// <para>The time when the alert blacklist policy expires.</para>
            /// <para>This is a UNIX timestamp in milliseconds.</para>
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
            /// <para>The instances of the Alibaba Cloud service in the blacklist policy.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            /// <summary>
            /// <para>The status of the blacklist policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: enabled.</para>
            /// </description></item>
            /// <item><description><para>false: disabled.</para>
            /// </description></item>
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
                /// <para>The name of the metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disk_utilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The extended dimension of the instance. For example, <c>{&quot;device&quot;:&quot;C:&quot;}</c> means that the blacklist policy is applied to all C drives of an Elastic Compute Service (ECS) instance.</para>
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
            /// <para>The namespace of the Alibaba Cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs_ecs_dashboard</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The scope of the blacklist policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>USER: The blacklist policy takes effect only for the current Alibaba Cloud account.</para>
            /// </description></item>
            /// <item><description><para>GROUP: The blacklist policy takes effect for the specified application groups.</para>
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
            /// <para>The IDs of the application groups.</para>
            /// </summary>
            [NameInMap("ScopeValue")]
            [Validation(Required=false)]
            public List<string> ScopeValue { get; set; }

            /// <summary>
            /// <para>The timestamp that indicates when the blacklist policy was modified.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D63E76CB-29AA-5B9F-88CE-400A6F28D428</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The operation was successful.</para>
        /// </description></item>
        /// <item><description><para>false: The operation failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of blacklist policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
