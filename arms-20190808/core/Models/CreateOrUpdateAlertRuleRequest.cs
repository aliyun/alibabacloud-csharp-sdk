// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateAlertRuleRequest : TeaModel {
        /// <summary>
        /// The alert check type of the Prometheus alert rule. Valid values:
        /// 
        /// *   STATIC: a static threshold value. If you set the parameter to STATIC, you must specify the **MetricsKey** parameter. For more information, see the **Correspondence between AlertGroup and MetricsKey for Prometheus Service** table.
        /// *   CUSTOM: a custom PromQL statement. If you set the parameter to CUSTOM, you must specify the **PromQL**, **Duration**, and **Message** parameters to create a Prometheus alert rule.
        /// </summary>
        [NameInMap("AlertCheckType")]
        [Validation(Required=false)]
        public string AlertCheckType { get; set; }

        /// <summary>
        /// The alert contact group ID of the Prometheus alert rule. Valid values:
        /// 
        /// *   \-1: custom PromQL
        /// *   1: Kubernetes load
        /// *   15: Kubernetes node
        /// </summary>
        [NameInMap("AlertGroup")]
        [Validation(Required=false)]
        public long? AlertGroup { get; set; }

        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// *   If you do not specify this parameter, a new alert rule is created.
        /// *   If you specify this parameter, the specified alert rule is modified.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// The name of the alert rule.
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// The content of the Application Monitoring or Browser Monitoring alert rule. The following code provides an example of the **AlertRuleContent** parameter. For more information about the meaning of each field, see the supplementary description.
        /// 
        /// ```json
        /// { 
        ///     "Condition": "OR", 
        ///      "AlertRuleItems": [ 
        ///              { "Operator": "CURRENT_LTE",
        ///                  "MetricKey": "appstat.jvm.threadcount", 
        ///                  "Value": 1000, 
        ///                  "Aggregate": "AVG",
        ///                   "N": 1
        ///             } 
        ///        ]  
        ///   }
        /// ```
        /// 
        /// > The conditional fields vary depending on the values of the **MetricsType** and **AlertRuleItems.MetricKey** parameters. For more information about the types of metrics supported by Application Monitoring and Browser Monitoring and the alert rule fields corresponding to each metric, see the supplementary description.
        /// </summary>
        [NameInMap("AlertRuleContent")]
        [Validation(Required=false)]
        public string AlertRuleContent { get; set; }

        /// <summary>
        /// The status of the alert rule. Valid values:
        /// 
        /// *   RUNNING (default)
        /// *   STOPPED
        /// </summary>
        [NameInMap("AlertStatus")]
        [Validation(Required=false)]
        public string AlertStatus { get; set; }

        /// <summary>
        /// The type of the alert rule.
        /// 
        /// *   APPLICATION_MONITORING_ALERT_RULE: an alert rule of Application Monitoring
        /// *   BROWSER_MONITORING_ALERT_RULE: an alert rule of Browser Monitoring
        /// *   PROMETHEUS_MONITORING_ALERT_RULE: an alert rule of Prometheus Service
        /// 
        /// Valid values:
        /// 
        /// *   PROMETHEUS_MONITORING_ALERT_RULE
        /// *   APPLICATION_MONITORING_ALERT_RULE
        /// *   BROWSER_MONITORING_ALERT_RULE
        /// *   prometheus monitoring alert
        /// *   application monitoring alert
        /// *   browser monitoring alert
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        /// <summary>
        /// The annotations of the Prometheus alert rule.
        /// </summary>
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public string Annotations { get; set; }

        /// <summary>
        /// Specifies whether to apply the alert rule to new applications that are created in Application Monitoring or Browser Monitoring. Valid values:
        /// 
        /// *   `true`: yes
        /// *   `false`: no
        /// </summary>
        [NameInMap("AutoAddNewApplication")]
        [Validation(Required=false)]
        public bool? AutoAddNewApplication { get; set; }

        /// <summary>
        /// The cluster ID of the Prometheus alert rule.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The duration of the Prometheus alert rule. Unit: minutes.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// The filter conditions of the Application Monitoring or Browser Monitoring alert rule. The name must meet the following format requirements:
        /// 
        ///     "DimFilters": [ 
        ///     { 
        ///      "FilterOpt": "ALL",
        ///      "FilterValues": [],         // The value of the filter condition. 
        ///      "FilterKey": "rootIp"     // The key of the filter condition. 
        ///     }
        ///     ]
        /// 
        /// Valid values of **FilterOpt**:
        /// 
        /// *   STATIC: matches the value of the specified dimension.
        /// *   ALL: matches the values of all dimensions.
        /// *   DISABLE: aggregates the values of all dimensions.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// The tags of the Prometheus alert rule.
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// The severity level of the Prometheus alert rule.
        /// 
        /// *   P1: Alert notifications are sent for major issues that affect the availability of core business, have a huge impact, and may lead to serious consequences.
        /// *   P2: Alert notifications are sent for service errors that affect the system availability with relatively limited impact.
        /// *   P3: Alert notifications are sent for issues that may cause service errors or negative effects, or alert notifications for services that are relatively less important.
        /// *   P4: Alert notifications are sent for low-priority issues that do not affect your business.
        /// *   Default: Alert notifications are sent regardless of alert levels.
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The alert message of the Prometheus alert rule.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The alert metrics. If you set the **AlertCheckType** parameter to **STATIC** when you create a Prometheus alert rule, you must specify the **MetricsKey** parameter.
        /// 
        /// > Alert metrics vary depending on the value of the **AlertGroup** parameter. For more information about the correspondence between **AlertGroup** and **MetricsKey**, see the supplementary description.
        /// </summary>
        [NameInMap("MetricsKey")]
        [Validation(Required=false)]
        public string MetricsKey { get; set; }

        /// <summary>
        /// The metric type of the Application Monitoring or Browser Monitoring alert rule. For more information, see the following table.
        /// </summary>
        [NameInMap("MetricsType")]
        [Validation(Required=false)]
        public string MetricsType { get; set; }

        /// <summary>
        /// The notification policy.
        /// 
        /// *   If you set this parameter to null, no notification policy is specified. After you create an alert rule, you can create a notification policy and specify match rules and match conditions. For example, you can specify the name of the alert rule as the match condition. If the alert rule is triggered, an alert event is generated and an alert notification is sent to the contacts or contact groups that are specified in the notification policy.
        /// *   To specify a notification policy, set this parameter to the ID of the notification policy. Application Real-Time Monitoring Service (ARMS) automatically adds a match rule to the notification policy and specifies the ID of the alert rule as the match condition. The name of the alert rule is also displayed. This way, the alert events that are generated based on the alert rule can be matched by the specified notification policy.
        /// </summary>
        [NameInMap("NotifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

        /// <summary>
        /// The process ID (PID) that is associated with the Application Monitoring or Browser Monitoring alert rule.
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// The PromQL statement of the Prometheus alert rule.
        /// </summary>
        [NameInMap("PromQL")]
        [Validation(Required=false)]
        public string PromQL { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateOrUpdateAlertRuleRequestTags> Tags { get; set; }
        public class CreateOrUpdateAlertRuleRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
