// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateApplicationScalingRuleRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7171a6ca-d1cd-4928-8642-7d5cfe69****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable idle mode for the application.</para>
        /// </summary>
        [NameInMap("EnableIdle")]
        [Validation(Required=false)]
        public bool? EnableIdle { get; set; }

        /// <summary>
        /// <para>The minimum number of ready instances, specified as a percentage of the total number of instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b>: Indicates that a percentage is not used. In this case, the value of <c>MinReadyInstances</c> is used.</para>
        /// </description></item>
        /// <item><description><para><b>0\~100</b>: A percentage. The result is rounded up. For example, if you set this parameter to 50 (%) and the application has 5 instances, the minimum number of ready instances is 3.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify both <c>MinReadyInstances</c> and a <c>MinReadyInstanceRatio</c> other than <c>-1</c>, <c>MinReadyInstanceRatio</c> takes precedence. For example, if <c>MinReadyInstances</c> is set to <c>5</c> and <c>MinReadyInstanceRatio</c> is set to <c>50</c>, the system uses <c>50</c> (%) to calculate the minimum number of ready instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of ready instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <c>0</c>, the application is interrupted during an update.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <c>-1</c>, the system sets the value to 25% of the current number of instances, rounded up. For example, if the application has 5 instances, the minimum number of ready instances is 2 (5 × 25% = 1.25, rounded up to 2).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To ensure service continuity during a rolling deployment, we recommend setting the minimum number of ready instances to 1 or more.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the auto scaling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScalingRuleEnable")]
        [Validation(Required=false)]
        public bool? ScalingRuleEnable { get; set; }

        /// <summary>
        /// <para>Configurations for the metric-based auto scaling policy. This parameter is required if <c>ScalingRuleType</c> is set to <c>metric</c> or <c>mix</c>.</para>
        /// <para>The parameter is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>maxReplicas</b>: The maximum number of application instances.</para>
        /// </description></item>
        /// <item><description><para><b>minReplicas</b>: The minimum number of application instances.</para>
        /// </description></item>
        /// <item><description><para><b>metricType</b>: The metric that triggers the auto scaling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CPU</b>: CPU utilization.</para>
        /// </description></item>
        /// <item><description><para><b>MEMORY</b>: Memory utilization.</para>
        /// </description></item>
        /// <item><description><para><b>QPS</b>: The average queries per second (QPS) per instance for a Java application over a 1-minute period.</para>
        /// </description></item>
        /// <item><description><para><b>RT</b>: The average response time (RT) of all service interfaces for a Java application over a 1-minute period.</para>
        /// </description></item>
        /// <item><description><para><b>tcpActiveConn</b>: The average number of active TCP connections per instance over a 30-second period.</para>
        /// </description></item>
        /// <item><description><para><b>SLB_QPS</b>: The average QPS per instance for a public-facing SLB instance over a 15-second period.</para>
        /// </description></item>
        /// <item><description><para><b>SLB_RT</b>: The average RT of a public-facing SLB instance over a 15-second period.</para>
        /// </description></item>
        /// <item><description><para><b>INTRANET_SLB_QPS</b>: The average QPS per instance for an internal-facing SLB instance over a 15-second period.</para>
        /// </description></item>
        /// <item><description><para><b>INTRANET_SLB_RT</b>: The average RT of an internal-facing SLB instance over a 15-second period.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>metricTargetAverageUtilization</b>: The target value for the metric specified by <c>metricType</c>. The unit of this value depends on <c>metricType</c>.</para>
        /// <list type="bullet">
        /// <item><description><para>Target CPU utilization, in percentage.</para>
        /// </description></item>
        /// <item><description><para>Target memory utilization, in percentage.</para>
        /// </description></item>
        /// <item><description><para>Target QPS, in requests per second.</para>
        /// </description></item>
        /// <item><description><para>Target response time, in milliseconds.</para>
        /// </description></item>
        /// <item><description><para>Average number of active TCP connections.</para>
        /// </description></item>
        /// <item><description><para>Target public-facing SLB QPS, in requests per second.</para>
        /// </description></item>
        /// <item><description><para>Target public-facing SLB response time, in milliseconds.</para>
        /// </description></item>
        /// <item><description><para>Target internal-facing SLB QPS, in requests per second.</para>
        /// </description></item>
        /// <item><description><para>Target internal-facing SLB response time, in milliseconds.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>slbId</b>: The SLB instance ID.</para>
        /// </description></item>
        /// <item><description><para><b>slbProject</b>: The Log Service project.</para>
        /// </description></item>
        /// <item><description><para><b>slbLogstore</b>: The Log Service Logstore.</para>
        /// </description></item>
        /// <item><description><para><b>vport</b>: The SLB listener port. The HTTP and HTTPS protocols are supported.</para>
        /// </description></item>
        /// <item><description><para><b>scaleUpRules</b>: The rules to scale out the application.</para>
        /// </description></item>
        /// <item><description><para><b>scaleDownRules</b>: The rules to scale in the application.</para>
        /// </description></item>
        /// <item><description><para><b>step</b>: The step size for scaling out or scaling in. This is the maximum number of instances that can be added or removed in a single scaling activity.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b>: Specifies whether to prevent the application from scaling in. If set to <c>true</c>, the number of application instances is never reduced. This can prevent business risks caused by scaling in during peak hours.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Scale-in is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Scale-in is enabled. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>stabilizationWindowSeconds</b>: The cooldown period for scaling out or scaling in, in seconds. Valid values: 0 to 3600. The default value is 0.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can configure one or more metrics. If you configure multiple metrics, the application scales out when any of the metrics meets or exceeds its target value, up to the specified maximum number of instances. The application scales in only when all metrics are below their target values, down to the specified minimum number of instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxReplicas&quot;:3,&quot;minReplicas&quot;:1,&quot;metrics&quot;:[{&quot;metricType&quot;:&quot;CPU&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;MEMORY&quot;,&quot;metricTargetAverageUtilization&quot;:30},{&quot;metricType&quot;:&quot;tcpActiveConn&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;SLB_QPS&quot;,&quot;MetricTargetAverageUtilization&quot;:25,&quot;slbId&quot;:&quot;lb-xxx&quot;,&quot;slbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-<b><b><b><b><b><b>&quot;,&quot;slbLogstore&quot;:&quot;function-log&quot;,&quot;vport&quot;:&quot;80&quot;},{&quot;metricType&quot;:&quot;SLB_RT&quot;,&quot;MetricTargetAverageUtilization&quot;:35,&quot;slbId&quot;:&quot;lb-xxx&quot;,&quot;slbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-</b></b></b></b></b></b>&quot;,&quot;slbLogstore&quot;:&quot;function-log&quot;,&quot;vport&quot;:&quot;80&quot;}],&quot;scaleUpRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:0},&quot;scaleDownRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:300}}</para>
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// <para>The name of the auto scaling policy. The name must be unique within an application, start with a lowercase letter, and contain only lowercase letters, digits, and hyphens (-). The name can be up to 32 characters long.</para>
        /// <remarks>
        /// <para>The policy name cannot be changed after creation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timer-0800-2100</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>Configurations for the scheduled auto scaling policy. This parameter is required if <c>ScalingRuleType</c> is set to <c>timing</c> or if you use an SDK.</para>
        /// <para>The parameter is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>beginDate</b> and <b>endDate</b>: The start and end dates of the policy\&quot;s effective period.</para>
        /// <list type="bullet">
        /// <item><description><para>If both fields are set to <c>null</c> (default), the policy is effective indefinitely.</para>
        /// </description></item>
        /// <item><description><para>If you specify a date range, for example, <c>beginDate</c> is <c>2021-03-25</c> and <c>endDate</c> is <c>2021-04-25</c>, the policy is effective for one month.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>period</b>: The recurrence rule for the scheduled auto scaling policy.</para>
        /// <list type="bullet">
        /// <item><description><para><em><em>\</em> \</em> \***: The policy is executed at a specified time every day.</para>
        /// </description></item>
        /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The policy is executed at a specified time on specific days of the week. You can select multiple days. The time is in the GMT+8 time zone. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Sun</b>: Sunday</para>
        /// </description></item>
        /// <item><description><para><b>Mon</b>: Monday</para>
        /// </description></item>
        /// <item><description><para><b>Tue</b>: Tuesday</para>
        /// </description></item>
        /// <item><description><para><b>Wed</b>: Wednesday</para>
        /// </description></item>
        /// <item><description><para><b>Thu</b>: Thursday</para>
        /// </description></item>
        /// <item><description><para><b>Fri</b>: Friday</para>
        /// </description></item>
        /// <item><description><para><b>Sat</b>: Saturday</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The policy is executed at a specified time on specific days of a month. You can select multiple days. The value can be from 1 to 31. If a month does not have the specified day, for example, the 31st, the policy is not executed on that day for that month.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>schedules</b>: The trigger times and the corresponding target number of instances. You can specify a maximum of 20 schedules. The parameter includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>atTime</b>: The trigger time in <c>HH:mm</c> format. For example, <c>08:00</c>.</para>
        /// </description></item>
        /// <item><description><para><b>targetReplicas</b>: The target number of application instances. Valid values: 1 to 50.</para>
        /// <remarks>
        /// <para>During a rolling deployment, we recommend that you set the minimum number of ready instances to 1 or more to prevent service interruptions. If you set the minimum number of ready instances to <c>0</c>, your application will be interrupted during an update.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;beginDate&quot;:null,&quot;endDate&quot;:null,&quot;period&quot;:&quot;* * *&quot;,&quot;schedules&quot;:[{&quot;atTime&quot;:&quot;08:00&quot;,&quot;targetReplicas&quot;:10},{&quot;atTime&quot;:&quot;20:00&quot;,&quot;targetReplicas&quot;:3}]}</para>
        /// </summary>
        [NameInMap("ScalingRuleTimer")]
        [Validation(Required=false)]
        public string ScalingRuleTimer { get; set; }

        /// <summary>
        /// <para>The type of the auto scaling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>timing</b>: scheduled auto scaling.</para>
        /// </description></item>
        /// <item><description><para><b>metric</b>: metric-based auto scaling.</para>
        /// </description></item>
        /// <item><description><para><b>mix</b>: mixed auto scaling.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <c>timing</c>, the <c>ScalingRuleTimer</c> parameter is required.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <c>metric</c>, the <c>ScalingRuleMetric</c> parameter is required.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <c>mix</c>, the <c>ScalingRuleMetric</c> parameter is required. You can also configure the <c>ScalingRuleTimer</c> parameter as needed.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timing</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
