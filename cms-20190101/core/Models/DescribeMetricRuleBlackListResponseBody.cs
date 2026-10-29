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
        /// <para>The value 200 indicates success.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of alert blacklist policies.</para>
        /// </summary>
        [NameInMap("DescribeMetricRuleBlackList")]
        [Validation(Required=false)]
        public List<DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList> DescribeMetricRuleBlackList { get; set; }
        public class DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackList : TeaModel {
            /// <summary>
            /// <para>The category of the Alibaba Cloud service. For example, ApsaraDB for Redis has <c>kvstore_standard</c> (Standard Edition), <c>kvstore_sharding</c> (Cluster Edition), and <c>kvstore_splitrw</c> (read/write splitting Edition).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The timestamp when the alert blacklist policy was created.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665714561000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The effective period of the alert blacklist policy.</para>
            /// <para>The value is in the HH:mm-HH:mm format (24-hour clock). The default time zone is UTC+8. For example, &quot;00:00-23:59&quot; indicates that the policy takes effect all day.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-23:59</para>
            /// </summary>
            [NameInMap("EffectiveTime")]
            [Validation(Required=false)]
            public string EffectiveTime { get; set; }

            /// <summary>
            /// <para>The start timestamp of the alert blacklist policy.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640608200000</para>
            /// </summary>
            [NameInMap("EnableEndTime")]
            [Validation(Required=false)]
            public long? EnableEndTime { get; set; }

            /// <summary>
            /// <para>The end timestamp of the alert blacklist policy.</para>
            /// <para>Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1640237400000</para>
            /// </summary>
            [NameInMap("EnableStartTime")]
            [Validation(Required=false)]
            public long? EnableStartTime { get; set; }

            /// <summary>
            /// <para>The ID of the alert blacklist policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93514c96-ceb8-47d8-8ee3-93b6d98b****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The instances of the specified Alibaba Cloud service in the alert blacklist policy.</para>
            /// </summary>
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

            /// <summary>
            /// <para>The status of the alert blacklist policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Enabled.</para>
            /// </description></item>
            /// <item><description><para>false: Disabled.</para>
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
            /// <para>The monitoring metrics of the instances.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public List<DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackListMetrics> Metrics { get; set; }
            public class DescribeMetricRuleBlackListResponseBodyDescribeMetricRuleBlackListMetrics : TeaModel {
                /// <summary>
                /// <para>The name of the monitoring metrics.</para>
                /// 
                /// <b>Example:</b>
                /// <para>disk_utilization</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The extension dimension information of the instance. For example, <c>{&quot;device&quot;:&quot;C:&quot;}</c> indicates that the blacklist policy is applied to all C drives of the ECS instance under the Alibaba Cloud service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;device&quot;:&quot;C:&quot;}]</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public string Resource { get; set; }

            }

            /// <summary>
            /// <para>The name of the alert blacklist policy.</para>
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
            /// <para>The effective scope of the alert blacklist policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>USER: The alert blacklist policy takes effect only within the current Alibaba Cloud account.</para>
            /// </description></item>
            /// <item><description><para>GROUP: The alert blacklist policy takes effect in the specified application groups.</para>
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
            /// <para>The timestamp when the alert blacklist policy was last modified.</para>
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
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
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
        /// <para>The total number of alert blacklist policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
