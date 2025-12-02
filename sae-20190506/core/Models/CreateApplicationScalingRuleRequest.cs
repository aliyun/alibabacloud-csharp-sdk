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

        [NameInMap("EnableIdle")]
        [Validation(Required=false)]
        public bool? EnableIdle { get; set; }

        /// <summary>
        /// <para>The percentage of the minimum number of available instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b> (default value): The minimum number of available instances is not determined based on this parameter.</description></item>
        /// <item><description><b>0 to 100</b>: The minimum number of available instances is calculated by using the following formula: Number of existing instances × Value of MinReadyInstanceRatio × 100%. The calculation result is rounded up to the nearest integer. For example, if the number of existing instances is 5 and MinReadyInstanceRatio is set to 50, the minimum number of available instances is 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para> When <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are passed at the same time and the <b>MinReadyInstanceRatio</b> value is not \<em>\</em>-1\<em>\</em>, the <b>MinReadyInstanceRatio</b> parameter takes precedence. <b>Note</b>When both <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are specified and <b>MinReadyInstanceRatio</b> is set to a number from 0 to 100, the value of <b>MinReadyInstanceRatio</b> takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of available instances. Special values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>0</b>, business is interrupted when the application is updated.</description></item>
        /// <item><description>If you set this property to -1, the system calculates a recommended value as the minimum number of available instances by using the following formula: Recommended value = Number of existing instances × 25%. The calculation result is rounded up to the nearest integer. For example, if the number of existing instances is 5, the recommended value is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.</description></item>
        /// </list>
        /// <remarks>
        /// <para> To ensure business continuity, make sure that at least one instance is available during application deployment and rollback.</para>
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
        /// <item><description><b>true</b>: The auto scaling policy is enabled.</description></item>
        /// <item><description><b>false</b>: The auto scaling policy is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScalingRuleEnable")]
        [Validation(Required=false)]
        public bool? ScalingRuleEnable { get; set; }

        /// <summary>
        /// <para>The configurations of the metric-based auto scaling policy. This parameter is required if you set the ScalingRuleType parameter to metric.</para>
        /// <para>The following list describes the involved parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>maxReplicas</b>: the maximum number of instances in the application.</para>
        /// </description></item>
        /// <item><description><para><b>minReplicas</b>: the minimum number of instances in the application.</para>
        /// </description></item>
        /// <item><description><para><b>metricType</b>: the metric that is used to trigger the auto scaling policy.</para>
        /// <list type="bullet">
        /// <item><description><b>CPU</b>: the CPU utilization.</description></item>
        /// <item><description><b>MEMORY</b>: the memory usage.</description></item>
        /// <item><description><b>QPS</b>: the average QPS within 1 minute per Java application instance.</description></item>
        /// <item><description><b>RT</b>: the average response time of all API operations within 1 minute in the Java application.</description></item>
        /// <item><description><b>tcpActiveConn</b>: the average number of active TCP connections within 30 seconds per instance.</description></item>
        /// <item><description><b>SLB_QPS</b>: the average QPS of the Internet-facing SLB instance within 15 seconds per instance.</description></item>
        /// <item><description><b>SLB_RT</b>: the average response time of the Internet-facing SLB instance within 15 seconds.</description></item>
        /// <item><description><b>INTRANET_SLB_QPS</b>: the average QPS of the internal-facing SLB instance within 15 seconds per instance.</description></item>
        /// <item><description><b>INTRANET_SLB_RT</b>: the average response time of the internal-facing SLB instance within 15 seconds.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>metricTargetAverageUtilization</b>: the limit on the metric that is specified by <b>metricType</b>. You can specify following limits:</para>
        /// <list type="bullet">
        /// <item><description>The limit on the CPU utilization. Unit: percentage.</description></item>
        /// <item><description>The limit on the memory usage. Unit: percentage.</description></item>
        /// <item><description>The limit on the QPS.</description></item>
        /// <item><description>The limit on the response time. Unit: milliseconds.</description></item>
        /// <item><description>The limit on the average number of active TCP connections per second.</description></item>
        /// <item><description>The limit on the QPS of the Internet-facing SLB instance.</description></item>
        /// <item><description>The limit on the response time of the Internet-facing SLB instance. Unit: milliseconds.</description></item>
        /// <item><description>The limit on the QPS of the internal-facing SLB instance.</description></item>
        /// <item><description>The limit on the response time of the internal-facing SLB instance. Unit: milliseconds.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>slbId</b>: the ID of the SLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>slbProject</b>: the Simple Log Service (SLS) project.</para>
        /// </description></item>
        /// <item><description><para><b>slbLogstore</b>: the SLS Logstore.</para>
        /// </description></item>
        /// <item><description><para><b>vport</b>: the listener port of the SLB instance. HTTP and HTTPS are supported.</para>
        /// </description></item>
        /// <item><description><para><b>scaleUpRules</b>: the scale-out rules.</para>
        /// </description></item>
        /// <item><description><para><b>scaleDownRules</b>: the scale-in rule.</para>
        /// </description></item>
        /// <item><description><para><b>step</b>: the scale-out or scale-in step size. This parameter specifies the maximum number of instances that can be added or removed per unit time.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b>: specifies whether to disable the application scale-in. If you set this parameter to true, the application instances are never reduced. This prevents business risks during peak hours.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: disables the application scale-in.</description></item>
        /// <item><description><b>false</b>: enables the application scale-in. Default value: false.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>stabilizationWindowSeconds</b>: the cooldown period during which the system is stable and does not perform scale-out or scale-in operations. Valid values: 0 to 3600. Unit: seconds. Default value: 0.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para> NoteYou can specify one or more metrics as the trigger conditions of the auto scaling policy. If one of the values of the specified metrics is greater than or equal to the specified limit, the application is scaled out. The number of instances after the scale-out operation is less than or equal to the value of the specified maximum application instances. If the values of all specified metrics are less than the limits, the application is scaled in. The number of instances after the scale-in operation is greater than or equal to the value of the specified minimum application instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxReplicas&quot;:3,&quot;minReplicas&quot;:1,&quot;metrics&quot;:[{&quot;metricType&quot;:&quot;CPU&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;MEMORY&quot;,&quot;metricTargetAverageUtilization&quot;:30},{&quot;metricType&quot;:&quot;tcpActiveConn&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;SLB_QPS&quot;,&quot;MetricTargetAverageUtilization&quot;:25,&quot;SlbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-<b><b><b><b><b><b>&quot;,&quot;SlbLogstore&quot;:&quot;function-log&quot;,&quot;Vport&quot;:&quot;80&quot;},{&quot;metricType&quot;:&quot;SLB_RT&quot;,&quot;MetricTargetAverageUtilization&quot;:35,&quot;SlbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-</b></b></b></b></b></b>&quot;,&quot;SlbLogstore&quot;:&quot;function-log&quot;,&quot;Vport&quot;:&quot;80&quot;}],&quot;scaleUpRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:0},&quot;scaleDownRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:300}}</para>
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// <para>The name of the auto scaling policy. The name must be unique in an application, and can be up to 32 characters in length. It must start with a lowercase letter and can contain only lowercase letters, digits, and hyphens (-).</para>
        /// <remarks>
        /// <para> You cannot change the names of created auto scaling policies.</para>
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
        /// <para>The configuration of the scheduled elasticity policy. This parameter is required if you select Scheduled Scaling Policy or Use SDK to Set.</para>
        /// <para>The following table describes the parameters.</para>
        /// <list type="bullet">
        /// <item><description><para><b>beginDate</b> and <b>endDate</b>: <b>beginDate</b> is the start date and <b>endDate</b> is the end date, which is used to configure the timing Auto Scaling policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If both values are <b>null</b>, long-term execution is performed. This is the default value.</description></item>
        /// <item><description>If the value is a specific date, for example, the <b>beginDate</b> is <b>2021-03-25</b> and the <b>endDate</b> is <b>2021-04-25</b>, the validity period is one month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>period</b>: The period during which the timed Auto Scaling policy is executed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><em><em>\</em> \</em> \***: The scheduled policy is executed at a specified time every day.</para>
        /// </description></item>
        /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The scheduled policy is executed at the specified time on the specified number of days per week. You can select multiple time zones. The time zone is GMT +8. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Sun</b>: Sunday</description></item>
        /// <item><description><b>Mon</b>: Monday</description></item>
        /// <item><description><b>Tue</b>: Tuesday</description></item>
        /// <item><description><b>Wed</b>: Wednesday</description></item>
        /// <item><description><b>Thu</b>: Thursday</description></item>
        /// <item><description><b>Fri</b>: Friday</description></item>
        /// <item><description><b>Sat</b>: Saturday</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The scheduled auto scaling policy is executed at a specified point in time on one or more dates of each month. Valid values: 1 to 31. If a month does not have the 31st day, the auto scaling policy is executed on the specified days other than the 31st day.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>schedules</b>: the points in time at which the scheduled auto scaling policy is triggered and the number of application instances that are retained during the time periods. You can specify up to 20 points in time. The following list describes the involved parameters:</para>
        /// <list type="bullet">
        /// <item><description><para><b>atTime</b>: the point in time at which the policy is triggered. <b>targetReplicas</b>: the number of application instances that you want to retain during the corresponding time period or the minimum number of available instances required for each deployment.****</para>
        /// </description></item>
        /// <item><description><para><b>Valid values: 1 to 50.</b> Valid values: 1 to 50.</para>
        /// <para>**</para>
        /// <para><b>Note</b>Make sure that at least one instance is available during the application deployment and rollback to prevent your business from being interrupted. If you set the value to <b>0</b>, business interruptions occur when the application is updated. If you set the value to <b>0</b>, business interruptions occur when the application is updated.</para>
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
        /// <para>The type of the auto scaling policy. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description><b>timing</b>: a scheduled auto scaling policy.</description></item>
        /// <item><description><b>metric</b>: a metric-based auto scaling policy.</description></item>
        /// <item><description><b>mix</b>: a hybrid auto scaling policy.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to timing, the ScalingRuleTimer parameter must be specified.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to metric, the ScalingRuleMetric parameter must be specified.</para>
        /// </description></item>
        /// <item><description><para>If you set this parameter to mix, the ScalingRuleMetric parameter must be specified. You can specify the ScalingRuleTimer parameter based on your business requirements.</para>
        /// </description></item>
        /// </list>
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
