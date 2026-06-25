// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateApplicationScalingRuleRequest : TeaModel {
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
        /// <para>Specifies whether to enable or disable the idle mode.</para>
        /// </summary>
        [NameInMap("EnableIdle")]
        [Validation(Required=false)]
        public bool? EnableIdle { get; set; }

        /// <summary>
        /// <para>The minimum percentage of instances that must remain available during a rolling deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>-1</b>: An initial value that indicates that a percentage is not used.</para>
        /// </description></item>
        /// <item><description><para><b>0 to 100</b>: A percentage that is rounded up. For example, if you have 5 instances and set this parameter to <b>50</b>, the minimum number of surviving instances is 3.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify both <b>MinReadyInstances</b> and <b>MinReadyInstanceRatio</b>, and <b>MinReadyInstanceRatio</b> is not <b>-1</b>, <b>MinReadyInstanceRatio</b> takes precedence. For example, if <b>MinReadyInstances</b> is set to <b>5</b> and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the system uses <b>50%</b> to calculate the minimum number of surviving instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of instances that must remain available during a rolling deployment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <b>0</b>, your application experiences service interruptions during a rolling deployment.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to <b>-1</b>, the system uses a recommended value, which is 25% of the current number of instances. For example, if you have 5 instances, the minimum number of surviving instances is 2 (5 × 25% = 1.25, rounded up).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>To ensure business continuity, we recommend that you set the minimum number of surviving instances for each rolling deployment to 1 or higher.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <para>The configuration for the metric-based scaling policy. This parameter is required for metric-based scaling policies.</para>
        /// <para>The parameter includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>maxReplicas</b>: The maximum number of application instances.</para>
        /// </description></item>
        /// <item><description><para><b>minReplicas</b>: The minimum number of application instances.</para>
        /// </description></item>
        /// <item><description><para><b>metricType</b>: The metric that triggers the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>CPU</b>: The CPU usage.</para>
        /// </description></item>
        /// <item><description><para><b>MEMORY</b>: The memory usage.</para>
        /// </description></item>
        /// <item><description><para><b>QPS</b>: The average QPS of a single instance of a Java application over a 1-minute period.</para>
        /// </description></item>
        /// <item><description><para><b>RT</b>: The average RT of all service interfaces of a Java application over a 1-minute period.</para>
        /// </description></item>
        /// <item><description><para><b>tcpActiveConn</b>: The average number of active TCP connections per instance over a 30-second period.</para>
        /// </description></item>
        /// <item><description><para><b>SLB_QPS</b>: The average QPS of an internet-facing SLB, measured per instance over a 15-second period.</para>
        /// </description></item>
        /// <item><description><para><b>SLB_RT</b>: The average RT of an internet-facing SLB over a 15-second period.</para>
        /// </description></item>
        /// <item><description><para><b>INTRANET_SLB_QPS</b>: The average QPS of an internal-facing SLB, measured per instance over a 15-second period.</para>
        /// </description></item>
        /// <item><description><para><b>INTRANET_SLB_RT</b>: The average RT of an internal-facing SLB over a 15-second period.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>metricTargetAverageUtilization</b>: The target value for the specified <b>metricType</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>Target CPU usage, in percent.</para>
        /// </description></item>
        /// <item><description><para>Target memory usage, in percent.</para>
        /// </description></item>
        /// <item><description><para>Target QPS.</para>
        /// </description></item>
        /// <item><description><para>Target RT, in milliseconds.</para>
        /// </description></item>
        /// <item><description><para>Average number of active TCP connections, in connections/second.</para>
        /// </description></item>
        /// <item><description><para>Target internet-facing SLB QPS.</para>
        /// </description></item>
        /// <item><description><para>Target internet-facing SLB RT, in milliseconds.</para>
        /// </description></item>
        /// <item><description><para>Target internal-facing SLB QPS.</para>
        /// </description></item>
        /// <item><description><para>Target internal-facing SLB RT, in milliseconds.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>slbId</b>: The SLB ID.</para>
        /// </description></item>
        /// <item><description><para><b>slbProject</b>: The Simple Log Service project.</para>
        /// </description></item>
        /// <item><description><para><b>slbLogstore</b>: The Simple Log Service Logstore.</para>
        /// </description></item>
        /// <item><description><para><b>vport</b>: The listening port of the SLB. Both HTTP and HTTPS are supported.</para>
        /// </description></item>
        /// <item><description><para><b>scaleUpRules</b>: The scale-out rules.</para>
        /// </description></item>
        /// <item><description><para><b>scaleDownRules</b>: The scale-in rules.</para>
        /// </description></item>
        /// <item><description><para><b>step</b>: The step size for a scale-out or scale-in action. It defines the maximum number of instances that can be added or removed at a time.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b>: Specifies whether to disable scale-in. Disabling scale-in prevents the application from scaling in, which can mitigate risks during peak traffic.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Disables scale-in.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Enables scale-in. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>stabilizationWindowSeconds</b>: The cooldown time, in seconds, for a scaling action. The value must be an integer from 0 to 3,600. The default is 0.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you specify multiple metrics, a scale-out is triggered when any metric meets its target. The number of instances will not exceed maxReplicas. A scale-in is triggered only when all metrics are below their targets. The number of instances will not drop below minReplicas.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxReplicas&quot;:3,&quot;minReplicas&quot;:1,&quot;metrics&quot;:[{&quot;metricType&quot;:&quot;CPU&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;MEMORY&quot;,&quot;metricTargetAverageUtilization&quot;:30},{&quot;metricType&quot;:&quot;tcpActiveConn&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;SLB_QPS&quot;,&quot;MetricTargetAverageUtilization&quot;:25,&quot;slbId&quot;:&quot;lb-xxx&quot;,&quot;slbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-<b><b><b><b><b><b>&quot;,&quot;slbLogstore&quot;:&quot;function-log&quot;,&quot;vport&quot;:&quot;80&quot;},{&quot;metricType&quot;:&quot;SLB_RT&quot;,&quot;MetricTargetAverageUtilization&quot;:35,&quot;slbId&quot;:&quot;lb-xxx&quot;,&quot;slbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-</b></b></b></b></b></b>&quot;,&quot;slbLogstore&quot;:&quot;function-log&quot;,&quot;vport&quot;:&quot;80&quot;}],&quot;scaleUpRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:0},&quot;scaleDownRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:300}}</para>
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// <para>The name of the auto scaling policy. The name must start with a lowercase letter, contain only lowercase letters, digits, and hyphens (-), and be no more than 32 characters long.</para>
        /// <remarks>
        /// <para>You cannot change the name of an auto scaling policy after it is created.</para>
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
        /// <para>The configuration of the scheduled scaling policy. This parameter is required for scheduled scaling policies.</para>
        /// <para>The parameter includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>beginDate</b> and <b>endDate</b>: The start and end dates for the policy\&quot;s effective period.</para>
        /// <list type="bullet">
        /// <item><description><para>If both parameters are set to <b>null</b>, the policy is always active. This is the default.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>beginDate</b> to <b>2021-03-25</b> and <b>endDate</b> to <b>2021-04-25</b>, the policy is effective for one month.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>period</b>: The execution schedule for the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><em><em>\</em> \</em> \***: Executes the policy at a specified time every day.</para>
        /// </description></item>
        /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: Executes the policy at a specified time on specified days of the week. You can select multiple days. The time is in the UTC+8 time zone. Valid values:</para>
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
        /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: Executes the policy at a specified time on specified days of a month. The value ranges from 1 to 31. If a specified day does not exist in a given month (for example, the 31st), the policy skips it.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>schedules</b>: The trigger times and the corresponding target number of instances. You can specify up to 20 time points. This field includes the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>atTime</b>: The trigger time. The format is <b>HH:mm</b>, for example, <b>08:00</b>.</para>
        /// </description></item>
        /// <item><description><para><b>targetReplicas</b>: The target number of application instances. The value ranges from 1 to 50.</para>
        /// <remarks>
        /// <para>To ensure business continuity, we recommend that you set the minimum number of surviving instances for each rolling deployment to <b>1</b> or higher. If you set this parameter to <b>0</b>, your application is interrupted during an upgrade.</para>
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
        /// <b>Example:</b>
        /// <para>timing</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
