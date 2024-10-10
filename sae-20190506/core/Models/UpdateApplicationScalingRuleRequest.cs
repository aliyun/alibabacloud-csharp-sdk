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

        [NameInMap("EnableIdle")]
        [Validation(Required=false)]
        public bool? EnableIdle { get; set; }

        /// <summary>
        /// <para>The percentage of the minimum number of available instances. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>-1</b>, the minimum number of available instances is not determined based on this parameter. This is the default value.</description></item>
        /// <item><description>If you set the value to a number <b>from 0 to 100</b>, the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). The value is the nearest integer rounded up from the calculated result. For example, if you set this parameter to <b>50</b>, and five instances are available, the minimum number of available instances is 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When <b>MinReadyInstance</b> and <b>MinReadyInstanceRatio</b> are specified and <b>MinReadyInstanceRatio</b> is set to a number from 0 to 100, the value of \<em>\<em>MinReadyInstanceRatio</em></em> takes precedence.**** For example, if <b>MinReadyInstances</b> is set to *<em>5\</em>\*, and <b>MinReadyInstanceRatio</b> is set to <b>50</b>, the minimum number of available instances is set to the nearest integer rounded up from the calculated result of the following formula: Current number of instances × <b>50%</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// <para>The minimum number of available instances. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If you set the value to <b>0</b>, business interruptions occur when the auto-scaling policy is updated.</description></item>
        /// <item><description>If you set the value to \<em>\</em>-1\<em>\</em>, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// <para>The configurations of the metric-based auto scaling policy. This parameter is required if you set the ScalingRuleType parameter to metric.</para>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>maxReplicas</b>: the maximum number of instances in the application.</para>
        /// </description></item>
        /// <item><description><para><b>minReplicas</b>: the minimum number of instances in the application.</para>
        /// </description></item>
        /// <item><description><para><b>metricType</b>: the metric that is used to trigger the auto scaling policy.</para>
        /// <list type="bullet">
        /// <item><description><b>CPU</b>: the CPU utilization.</description></item>
        /// <item><description><b>MEMORY</b>: the memory usage.</description></item>
        /// <item><description><b>tcpActiveConn</b>: the average number of active TCP connections in an application instance within 30 seconds.</description></item>
        /// <item><description><b>SLB_QPS</b>: the average queries per second (QPS) of the Internet-facing Server Load Balancer (SLB) instance associated with an application instance within 15 seconds.</description></item>
        /// <item><description><b>SLB_RT</b>: the average response time of the Internet-facing SLB instance within 15 seconds.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>metricTargetAverageUtilization</b>: the limit on the metric specified by the <b>metricType</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description>The limit on the CPU utilization. Unit: percentage.</description></item>
        /// <item><description>The limit on the memory usage. Unit: percentage.</description></item>
        /// <item><description>The limit on the average number of active TCP connections per second.</description></item>
        /// <item><description>The limit on the QPS of the Internet-facing SLB instance.</description></item>
        /// <item><description>The limit on the response time of the Internet-facing SLB instance. Unit: milliseconds.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>SlbProject</b>: the Log Service project.</para>
        /// </description></item>
        /// <item><description><para><b>SlbLogstore</b>: the Log Service Logstore.</para>
        /// </description></item>
        /// <item><description><para><b>Vport</b>: the listener port for the SLB instance. HTTP and HTTPS are supported.</para>
        /// </description></item>
        /// <item><description><para><b>scaleUpRules</b>: the scale-out rule.</para>
        /// </description></item>
        /// <item><description><para><b>scaleDownRules</b>: the scale-in rule.</para>
        /// </description></item>
        /// <item><description><para><b>step</b>: the scale-out or scale-in step size. The maximum number of instances that can be added or removed per unit time.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b>: specifies whether to disable the application scale-in. If you set this parameter to true, the application instances are never scaled in. This prevents business risks during peak hours.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: disables the application scale-in.</description></item>
        /// <item><description><b>false</b>: enables the application scale-in. Default value: false.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>stabilizationWindowSeconds</b>: the cooldown period during which the system is stable and does not perform scale-out or scale-in operations. Valid values: 0 to 3600. Unit: seconds. Default value: 0.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can specify one or more metrics as the trigger conditions of the auto scaling policy. If you specify multiple metrics, the application is scaled out when the value of a metric is greater than or equal to the limit. The number of application instances after the scale-out cannot exceed the configured maximum number of application instances. If the values of all the metrics are less than the limits, the application is scaled in. The number of instances after the scale-in cannot be less than the configured minimum number of application instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxReplicas&quot;:3,&quot;minReplicas&quot;:1,&quot;metrics&quot;:[{&quot;metricType&quot;:&quot;CPU&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;MEMORY&quot;,&quot;metricTargetAverageUtilization&quot;:30},{&quot;metricType&quot;:&quot;tcpActiveConn&quot;,&quot;metricTargetAverageUtilization&quot;:20},{&quot;metricType&quot;:&quot;SLB_QPS&quot;,&quot;MetricTargetAverageUtilization&quot;:25,&quot;SlbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-<b><b><b><b><b><b>&quot;,&quot;SlbLogstore&quot;:&quot;function-log&quot;,&quot;Vport&quot;:&quot;80&quot;},{&quot;metricType&quot;:&quot;SLB_RT&quot;,&quot;MetricTargetAverageUtilization&quot;:35,&quot;SlbProject&quot;:&quot;aliyun-fc-cn-hangzhou-d95881d9-5d3c-5f26-a6b8-</b></b></b></b></b></b>&quot;,&quot;SlbLogstore&quot;:&quot;function-log&quot;,&quot;Vport&quot;:&quot;80&quot;}],&quot;scaleUpRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:0},&quot;scaleDownRules&quot;:{&quot;step&quot;:&quot;100&quot;,&quot;disabled&quot;:false,&quot;stabilizationWindowSeconds&quot;:300}}</para>
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// <para>The name of the auto scaling policy. The name must start with a lowercase letter and can contain only lowercase letters, digits, and hyphens (-). The name cannot exceed 32 characters in length.</para>
        /// <remarks>
        /// <para>You cannot change the names of created policies.</para>
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
        /// <para>The configurations of the scheduled auto scaling policy. This parameter is required when you set the ScalingRuleType parameter to timing or when you want to create a scheduled auto scaling policy by using an SDK.</para>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>beginDate</b> and <b>endDate</b>: specify the validity period of the scheduled auto scaling policy. <b>beginDate</b> specifies the start date and <b>endDate</b> specifies the end date. Take note of the following rules:</para>
        /// <list type="bullet">
        /// <item><description>If you set the two parameters to <b>null</b>, the scheduled auto scaling policy is a long-term policy. Default values of the beginDate and endDate parameters: null.</description></item>
        /// <item><description>If you set the two parameters to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if you set <b>beginDate</b> to <b>2021-03-25</b> and <b>endDate</b> to <b>2021-04-25</b>, the auto scaling policy is valid for one month.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>period</b>: specifies the frequency at which the scheduled auto scaling policy is executed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><em><em>\</em> \</em> \***: The scheduled auto scaling policy is executed at a specified point in time every day.</para>
        /// </description></item>
        /// <item><description><para><em><em>\</em> \</em> Fri,Mon**: The scheduled auto scaling policy is executed at a specified point in time on one or more specified days of each week. GMT+8 is used. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Sun</b></description></item>
        /// <item><description><b>Mon</b></description></item>
        /// <item><description><b>Tue</b></description></item>
        /// <item><description><b>Wed</b></description></item>
        /// <item><description><b>Thu</b></description></item>
        /// <item><description><b>Fri</b></description></item>
        /// <item><description><b>Sat</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><em><em>1,2,3,28,31 \</em> \</em>**: The scheduled auto scaling policy is executed at a specified point in time on one or more days of each month. Valid values: 1 to 31. If the month does not have a 31st day, the auto scaling policy is executed on the specified days other than the 31st day.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>schedules</b>: specifies the points in time at which the auto scaling policy is triggered and the number of application instances that are retained during the corresponding period of time. You can specify up to 20 points in time. Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><para><b>atTime</b>: the point in time at which the policy is triggered. Format: <b>Hour:Minute</b>. Example: <b>08:00</b>.</para>
        /// </description></item>
        /// <item><description><para><b>targetReplicas</b>: specifies the number of application instances that you want to maintain by using this policy. You can also set the value to the minimum number of available instances required for each application release. Valid values: 1 to 50.</para>
        /// <para>**</para>
        /// <para><b>Note</b>Make sure that at least <b>one</b> instance is available during the application deployment and rollback to prevent your business from being interrupted. If you set the value to <b>0</b>, business interruptions occur when the application is updated.</para>
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

    }

}
