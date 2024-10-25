// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateGroupMonitoringAgentProcessRequest : TeaModel {
        /// <summary>
        /// <para>The alert rule configurations.</para>
        /// <para>Valid values of N: 1 to 3.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AlertConfig")]
        [Validation(Required=false)]
        public List<CreateGroupMonitoringAgentProcessRequestAlertConfig> AlertConfig { get; set; }
        public class CreateGroupMonitoringAgentProcessRequestAlertConfig : TeaModel {
            /// <summary>
            /// <para>The operator that is used to compare the metric value with the threshold. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GreaterThanOrEqualToThreshold: greater than or equal to the threshold</description></item>
            /// <item><description>GreaterThanThreshold: greater than the threshold</description></item>
            /// <item><description>LessThanOrEqualToThreshold: less than or equal to the threshold</description></item>
            /// <item><description>LessThanThreshold: less than the threshold</description></item>
            /// <item><description>NotEqualToThreshold: not equal to the threshold</description></item>
            /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
            /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
            /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
            /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
            /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
            /// <item><description>LessThanLastPeriod: less than the metric value in the previous monitoring cycle</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GreaterThanOrEqualToThreshold</para>
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// <para>The period of time during which the alert rule is effective.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-23:59</para>
            /// </summary>
            [NameInMap("EffectiveInterval")]
            [Validation(Required=false)]
            public string EffectiveInterval { get; set; }

            /// <summary>
            /// <para>The alert level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>critical (default)</description></item>
            /// <item><description>warn</description></item>
            /// <item><description>info</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>warn</para>
            /// </summary>
            [NameInMap("EscalationsLevel")]
            [Validation(Required=false)]
            public string EscalationsLevel { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:00-23:59</para>
            /// </summary>
            [NameInMap("NoEffectiveInterval")]
            [Validation(Required=false)]
            public string NoEffectiveInterval { get; set; }

            /// <summary>
            /// <para>The mute period during which new alert notifications are not sent even if the trigger conditions are met. Unit: seconds. Minimum value: 3600, which is equivalent to one hour. Default value: 86400, which is equivalent to one day.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para> Only one alert notification is sent during a mute period even if the metric value exceeds the alert threshold during consecutive checks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>86400</para>
            /// </summary>
            [NameInMap("SilenceTime")]
            [Validation(Required=false)]
            public string SilenceTime { get; set; }

            /// <summary>
            /// <para>The statistical aggregation method that is used to calculate the metric values.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para> Set the value to Average.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>The alert triggers.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<CreateGroupMonitoringAgentProcessRequestAlertConfigTargetList> TargetList { get; set; }
            public class CreateGroupMonitoringAgentProcessRequestAlertConfigTargetList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud Resource Name (ARN) of the resource.</para>
                /// <para>For more information about how to query the ARN of a resource, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// <para>Format: <c>acs:{Service name abbreviation}:{regionId}:{userId}:/{Resource type}/{Resource name}/message</c>. Example: <c>acs:mns:cn-hangzhou:120886317861****:/queues/test123/message</c>. Fields:</para>
                /// <list type="bullet">
                /// <item><description><para>{Service name abbreviation}: the abbreviation of the service name. Set the value to Simple Message Queue (formerly MNS) (SMQ).</para>
                /// </description></item>
                /// <item><description><para>{userId}: the ID of the Alibaba Cloud account.</para>
                /// </description></item>
                /// <item><description><para>{regionId}: the region ID of the SMQ queue or topic.</para>
                /// </description></item>
                /// <item><description><para>{Resource type}: the type of the resource that triggers the alert. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>queues</b></description></item>
                /// <item><description><b>topics</b></description></item>
                /// </list>
                /// </description></item>
                /// <item><description><para>{Resource name}: the resource name.</para>
                /// <list type="bullet">
                /// <item><description>If the resource type is <b>queues</b>, the resource name is the queue name.</description></item>
                /// <item><description>If the resource type is <b>topics</b>, the resource name is the topic name.</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>acs:mns:cn-hangzhou:120886317861****:/queues/test/message</para>
                /// </summary>
                [NameInMap("Arn")]
                [Validation(Required=false)]
                public string Arn { get; set; }

                /// <summary>
                /// <para>The ID of the resource for which alerts are triggered.</para>
                /// <para>For more information about how to obtain the ID of a resource for which alerts are triggered, see <a href="https://help.aliyun.com/document_detail/121592.html">DescribeMetricRuleTargets</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The parameters of the alert callback. The parameters are in the JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;customField1&quot;:&quot;value1&quot;,&quot;customField2&quot;:&quot;$.name&quot;}</para>
                /// </summary>
                [NameInMap("JsonParams")]
                [Validation(Required=false)]
                public string JsonParams { get; set; }

                /// <summary>
                /// <para>The alert level. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INFO</description></item>
                /// <item><description>WARN</description></item>
                /// <item><description>CRITICAL</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;INFO&quot;, &quot;WARN&quot;, &quot;CRITICAL&quot;]</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

            }

            /// <summary>
            /// <para>The alert threshold.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            /// <summary>
            /// <para>The number of times for which the threshold can be consecutively exceeded. Default value: 3.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para> A metric triggers an alert only after the metric value reaches the threshold consecutively for the specified times.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public string Times { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyun.com">http://www.aliyun.com</a></para>
            /// </summary>
            [NameInMap("Webhook")]
            [Validation(Required=false)]
            public string Webhook { get; set; }

        }

        /// <summary>
        /// <para>The ID of the application group.</para>
        /// <para>For more information about how to obtain the ID of an application group, see <a href="https://help.aliyun.com/document_detail/115032.html">DescribeMonitorGroups</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The expressions used to match instances.</para>
        /// <para>Valid values of N: 1 to 3.</para>
        /// </summary>
        [NameInMap("MatchExpress")]
        [Validation(Required=false)]
        public List<CreateGroupMonitoringAgentProcessRequestMatchExpress> MatchExpress { get; set; }
        public class CreateGroupMonitoringAgentProcessRequestMatchExpress : TeaModel {
            /// <summary>
            /// <para>The matching condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all (default value): matches all</description></item>
            /// <item><description>startWith: starts with a prefix</description></item>
            /// <item><description>endWith: ends with a suffix</description></item>
            /// <item><description>contains: contains</description></item>
            /// <item><description>notContains: does not contain</description></item>
            /// <item><description>equals: equals</description></item>
            /// </list>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>startWith</para>
            /// </summary>
            [NameInMap("Function")]
            [Validation(Required=false)]
            public string Function { get; set; }

            /// <summary>
            /// <para>The criteria based on which the instances are matched.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// <remarks>
            /// <para>Set the value to name. The value name indicates that the instances are matched based on the instance name.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>name1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The keyword used to match the instance name.</para>
            /// <para>Valid values of N: 1 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>portalHost</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The logical operator used between conditional expressions that are used to match instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>all</description></item>
        /// <item><description>and</description></item>
        /// <item><description>or</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>and</para>
        /// </summary>
        [NameInMap("MatchExpressFilterRelation")]
        [Validation(Required=false)]
        public string MatchExpressFilterRelation { get; set; }

        /// <summary>
        /// <para>The process name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("ProcessName")]
        [Validation(Required=false)]
        public string ProcessName { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
