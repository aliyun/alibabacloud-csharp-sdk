// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UpdateApplicationScalingRuleRequest : TeaModel {
        /// <summary>
        /// The application ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("EnableIdle")]
        [Validation(Required=false)]
        public bool? EnableIdle { get; set; }

        /// <summary>
        /// The percentage of the minimum number of available instances. Take note of the following rules:
        /// 
        /// *   If you set the value to **-1**, the minimum number of available instances is not determined based on this parameter. This is the default value.
        /// *   If you set the value to a number **from 0 to 100**, the minimum number of available instances is calculated by using the following formula: Current number of instances × (Value of MinReadyInstanceRatio × 100%). The value is the nearest integer rounded up from the calculated result. For example, if you set this parameter to **50**, and five instances are available, the minimum number of available instances is 3.
        /// 
        /// > When **MinReadyInstance** and **MinReadyInstanceRatio** are specified and **MinReadyInstanceRatio** is set to a number from 0 to 100, the value of \\*\\*MinReadyInstanceRatio** takes precedence.**** For example, if **MinReadyInstances** is set to **5\\*\\*, and **MinReadyInstanceRatio** is set to **50**, the minimum number of available instances is set to the nearest integer rounded up from the calculated result of the following formula: Current number of instances × **50%**.
        /// </summary>
        [NameInMap("MinReadyInstanceRatio")]
        [Validation(Required=false)]
        public int? MinReadyInstanceRatio { get; set; }

        /// <summary>
        /// The minimum number of available instances. Take note of the following rules:
        /// 
        /// *   If you set the value to **0**, business interruptions occur when the auto-scaling policy is updated.
        /// *   If you set the value to \\*\\*-1\\*\\*, the minimum number of available instances is automatically set to a system-recommended value. The value is the nearest integer to which the calculated result of the following formula is rounded up: Current number of instances × 25%. For example, if five instances are available, the minimum number of available instances is calculated by using the following formula: 5 × 25% = 1.25. In this case, the minimum number of available instances is 2.
        /// 
        /// > Make sure that at least one instance is available during application deployment and rollback to prevent business interruptions.
        /// </summary>
        [NameInMap("MinReadyInstances")]
        [Validation(Required=false)]
        public int? MinReadyInstances { get; set; }

        /// <summary>
        /// The configurations of the metric-based auto scaling policy. This parameter is required if you set the ScalingRuleType parameter to metric.
        /// 
        /// Parameter description:
        /// 
        /// *   **maxReplicas**: the maximum number of instances in the application.
        /// 
        /// *   **minReplicas**: the minimum number of instances in the application.
        /// 
        /// *   **metricType**: the metric that is used to trigger the auto scaling policy.
        /// 
        ///     *   **CPU**: the CPU utilization.
        ///     *   **MEMORY**: the memory usage.
        ///     *   **tcpActiveConn**: the average number of active TCP connections in an application instance within 30 seconds.
        ///     *   **SLB_QPS**: the average queries per second (QPS) of the Internet-facing Server Load Balancer (SLB) instance associated with an application instance within 15 seconds.
        ///     *   **SLB_RT**: the average response time of the Internet-facing SLB instance within 15 seconds.
        /// 
        /// *   **metricTargetAverageUtilization**: the limit on the metric specified by the **metricType** parameter.
        /// 
        ///     *   The limit on the CPU utilization. Unit: percentage.
        ///     *   The limit on the memory usage. Unit: percentage.
        ///     *   The limit on the average number of active TCP connections per second.
        ///     *   The limit on the QPS of the Internet-facing SLB instance.
        ///     *   The limit on the response time of the Internet-facing SLB instance. Unit: milliseconds.
        /// 
        /// *   **SlbProject**: the Log Service project.
        /// 
        /// *   **SlbLogstore**: the Log Service Logstore.
        /// 
        /// *   **Vport**: the listener port for the SLB instance. HTTP and HTTPS are supported.
        /// 
        /// *   **scaleUpRules**: the scale-out rule.
        /// 
        /// *   **scaleDownRules**: the scale-in rule.
        /// 
        /// *   **step**: the scale-out or scale-in step size. The maximum number of instances that can be added or removed per unit time.
        /// 
        /// *   **disabled**: specifies whether to disable the application scale-in. If you set this parameter to true, the application instances are never scaled in. This prevents business risks during peak hours.
        /// 
        ///     *   **true**: disables the application scale-in.
        ///     *   **false**: enables the application scale-in. Default value: false.
        /// 
        /// *   **stabilizationWindowSeconds**: the cooldown period during which the system is stable and does not perform scale-out or scale-in operations. Valid values: 0 to 3600. Unit: seconds. Default value: 0.
        /// 
        /// > You can specify one or more metrics as the trigger conditions of the auto scaling policy. If you specify multiple metrics, the application is scaled out when the value of a metric is greater than or equal to the limit. The number of application instances after the scale-out cannot exceed the configured maximum number of application instances. If the values of all the metrics are less than the limits, the application is scaled in. The number of instances after the scale-in cannot be less than the configured minimum number of application instances.
        /// </summary>
        [NameInMap("ScalingRuleMetric")]
        [Validation(Required=false)]
        public string ScalingRuleMetric { get; set; }

        /// <summary>
        /// The name of the auto scaling policy. The name must start with a lowercase letter and can contain only lowercase letters, digits, and hyphens (-). The name cannot exceed 32 characters in length.
        /// 
        /// > You cannot change the names of created policies.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// The configurations of the scheduled auto scaling policy. This parameter is required when you set the ScalingRuleType parameter to timing or when you want to create a scheduled auto scaling policy by using an SDK.
        /// 
        /// Parameter description:
        /// 
        /// *   **beginDate** and **endDate**: specify the validity period of the scheduled auto scaling policy. **beginDate** specifies the start date and **endDate** specifies the end date. Take note of the following rules:
        /// 
        ///     *   If you set the two parameters to **null**, the scheduled auto scaling policy is a long-term policy. Default values of the beginDate and endDate parameters: null.
        ///     *   If you set the two parameters to specific dates, the scheduled auto scaling policy can be triggered during the period between the two dates. For example, if you set **beginDate** to **2021-03-25** and **endDate** to **2021-04-25**, the auto scaling policy is valid for one month.
        /// 
        /// *   **period**: specifies the frequency at which the scheduled auto scaling policy is executed. Valid values:
        /// 
        ///     *   **\\* \\* \\***: The scheduled auto scaling policy is executed at a specified point in time every day.
        /// 
        ///     *   **\\* \\* Fri,Mon**: The scheduled auto scaling policy is executed at a specified point in time on one or more specified days of each week. GMT+8 is used. Valid values:
        /// 
        ///         *   **Sun**
        ///         *   **Mon**
        ///         *   **Tue**
        ///         *   **Wed**
        ///         *   **Thu**
        ///         *   **Fri**
        ///         *   **Sat**
        /// 
        ///     *   **1,2,3,28,31 \\* \\***: The scheduled auto scaling policy is executed at a specified point in time on one or more days of each month. Valid values: 1 to 31. If the month does not have a 31st day, the auto scaling policy is executed on the specified days other than the 31st day.
        /// 
        /// *   **schedules**: specifies the points in time at which the auto scaling policy is triggered and the number of application instances that are retained during the corresponding period of time. You can specify up to 20 points in time. Parameter description:
        /// 
        ///     *   **atTime**: the point in time at which the policy is triggered. Format: **Hour:Minute**. Example: **08:00**.
        /// 
        ///     *   **targetReplicas**: specifies the number of application instances that you want to maintain by using this policy. You can also set the value to the minimum number of available instances required for each application release. Valid values: 1 to 50.
        /// 
        ///         **
        /// 
        ///         **Note**Make sure that at least **one** instance is available during the application deployment and rollback to prevent your business from being interrupted. If you set the value to **0**, business interruptions occur when the application is updated.
        /// </summary>
        [NameInMap("ScalingRuleTimer")]
        [Validation(Required=false)]
        public string ScalingRuleTimer { get; set; }

    }

}
