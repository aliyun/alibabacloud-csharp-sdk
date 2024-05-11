// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateOrUpdateAlertRuleResponseBody : TeaModel {
        /// <summary>
        /// The details of the alert rule.
        /// </summary>
        [NameInMap("AlertRule")]
        [Validation(Required=false)]
        public CreateOrUpdateAlertRuleResponseBodyAlertRule AlertRule { get; set; }
        public class CreateOrUpdateAlertRuleResponseBodyAlertRule : TeaModel {
            /// <summary>
            /// The alert check type of the Prometheus alert rule. Valid values:
            /// 
            /// *   STATIC: a static threshold value.
            /// *   CUSTOM: a custom PromQL statement.
            /// </summary>
            [NameInMap("AlertCheckType")]
            [Validation(Required=false)]
            public string AlertCheckType { get; set; }

            /// <summary>
            /// The alert contact group ID of the Prometheus alert rule. Valid values:
            /// 
            /// *   \\-1: custom PromQL
            /// *   1: Kubernetes load
            /// *   15: Kubernetes node
            /// </summary>
            [NameInMap("AlertGroup")]
            [Validation(Required=false)]
            public long? AlertGroup { get; set; }

            /// <summary>
            /// The ID of the alert rule.
            /// </summary>
            [NameInMap("AlertId")]
            [Validation(Required=false)]
            public float? AlertId { get; set; }

            /// <summary>
            /// The name of the alert rule.
            /// </summary>
            [NameInMap("AlertName")]
            [Validation(Required=false)]
            public string AlertName { get; set; }

            /// <summary>
            /// The content of the Application Monitoring or Browser Monitoring alert rule.
            /// </summary>
            [NameInMap("AlertRuleContent")]
            [Validation(Required=false)]
            public CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContent AlertRuleContent { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContent : TeaModel {
                /// <summary>
                /// The trigger conditions of the Application Monitoring or Browser Monitoring alert rule.
                /// </summary>
                [NameInMap("AlertRuleItems")]
                [Validation(Required=false)]
                public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContentAlertRuleItems> AlertRuleItems { get; set; }
                public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAlertRuleContentAlertRuleItems : TeaModel {
                    /// <summary>
                    /// The aggregation method of the alert condition. Valid values:
                    /// 
                    /// *   AVG: calculates the average value
                    /// *   SUM: calculates the total value
                    /// *   MAX: selects the maximum value
                    /// *   MIN: selects the minimum value
                    /// </summary>
                    [NameInMap("Aggregate")]
                    [Validation(Required=false)]
                    public string Aggregate { get; set; }

                    /// <summary>
                    /// The metric of the alert condition.
                    /// </summary>
                    [NameInMap("MetricKey")]
                    [Validation(Required=false)]
                    public string MetricKey { get; set; }

                    /// <summary>
                    /// Indicates the last N minutes.
                    /// </summary>
                    [NameInMap("N")]
                    [Validation(Required=false)]
                    public float? N { get; set; }

                    /// <summary>
                    /// The comparison operator that was used to compare the metric value with the threshold. Valid values:
                    /// 
                    /// *   CURRENT_GTE: greater than or equal to
                    /// *   CURRENT_LTE: less than or equal to
                    /// *   PREVIOUS_UP: the increase percentage compared with the last period
                    /// *   PREVIOUS_DOWN: the decrease percentage compared with the last period
                    /// *   HOH_UP: the increase percentage compared with the last hour
                    /// *   HOH_DOWN: the decrease percentage compared with the last hour
                    /// *   DOD_UP: the increase percentage compared with the last day
                    /// *   DOD_DOWN: the decrease percentage compared with the last day
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// The threshold of the alert condition.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The relationship between multiple alert conditions that were specified for the Application Monitoring or Browser Monitoring alert rule. Valid values:
                /// 
                /// *   OR: meets any of the specified conditions.
                /// *   AND: meets all the specified conditions.
                /// </summary>
                [NameInMap("Condition")]
                [Validation(Required=false)]
                public string Condition { get; set; }

            }

            /// <summary>
            /// The status of the alert rule. Valid values:
            /// 
            /// *   RUNNING
            /// *   STOPPED
            /// *   PAUSED
            /// 
            /// > The PAUSED status indicates that the alert rule is abnormal and is actively paused by the system. The alert rule may be paused because that it is not unique or the associated cluster has been deleted.
            /// </summary>
            [NameInMap("AlertStatus")]
            [Validation(Required=false)]
            public string AlertStatus { get; set; }

            /// <summary>
            /// The type of the alert rule. Valid values:
            /// 
            /// *   APPLICATION_MONITORING_ALERT_RULE: alert rule for Application Monitoring
            /// *   BROWSER_MONITORING_ALERT_RULE: alert rule for Browser Monitoring
            /// *   PROMETHEUS_MONITORING_ALERT_RULE: alert rule for Prometheus Service
            /// </summary>
            [NameInMap("AlertType")]
            [Validation(Required=false)]
            public string AlertType { get; set; }

            /// <summary>
            /// The annotations of the Prometheus alert rule.
            /// </summary>
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleAnnotations> Annotations { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleAnnotations : TeaModel {
                /// <summary>
                /// The key of the annotation.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The value of the annotation.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether the alert rule was applied to new applications that were created in Application Monitoring or Browser Monitoring. Valid values:
            /// 
            /// *   `true`: enables the health check feature.
            /// *   `false`: disables the automatic backup feature.
            /// </summary>
            [NameInMap("AutoAddNewApplication")]
            [Validation(Required=false)]
            public bool? AutoAddNewApplication { get; set; }

            /// <summary>
            /// The ID of the monitored cluster.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The timestamp generated when the alert rule was created. Unit: seconds.
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// The duration of the Prometheus alert rule. Unit: minutes.
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// The extended fields.
            /// </summary>
            [NameInMap("Extend")]
            [Validation(Required=false)]
            public string Extend { get; set; }

            /// <summary>
            /// The filter conditions of the Application Monitoring or Browser Monitoring alert rule.
            /// </summary>
            [NameInMap("Filters")]
            [Validation(Required=false)]
            public CreateOrUpdateAlertRuleResponseBodyAlertRuleFilters Filters { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleFilters : TeaModel {
                /// <summary>
                /// The custom filter condition of the Browser Monitoring alert rule.
                /// </summary>
                [NameInMap("CustomSLSFilters")]
                [Validation(Required=false)]
                public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersCustomSLSFilters> CustomSLSFilters { get; set; }
                public class CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersCustomSLSFilters : TeaModel {
                    /// <summary>
                    /// The key of the filter condition.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The logical operator of the filter condition. Valid values:
                    /// 
                    /// *   \\=: equal to
                    /// *   not: not equal to
                    /// </summary>
                    [NameInMap("Opt")]
                    [Validation(Required=false)]
                    public string Opt { get; set; }

                    /// <summary>
                    /// Indicates whether this filter condition was displayed on the frontend.
                    /// </summary>
                    [NameInMap("Show")]
                    [Validation(Required=false)]
                    public bool? Show { get; set; }

                    /// <summary>
                    /// The log type of Browser Monitoring. This field was not included in other filter conditions.
                    /// </summary>
                    [NameInMap("T")]
                    [Validation(Required=false)]
                    public string T { get; set; }

                    /// <summary>
                    /// The value of the filter condition.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// The information of the aggregation dimension.
                /// </summary>
                [NameInMap("CustomSLSGroupByDimensions")]
                [Validation(Required=false)]
                public List<string> CustomSLSGroupByDimensions { get; set; }

                /// <summary>
                /// The details of the custom filter condition.
                /// </summary>
                [NameInMap("CustomSLSWheres")]
                [Validation(Required=false)]
                public List<string> CustomSLSWheres { get; set; }

                /// <summary>
                /// The information about each filter condition of the Application Monitoring or Browser Monitoring alert rule.
                /// </summary>
                [NameInMap("DimFilters")]
                [Validation(Required=false)]
                public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersDimFilters> DimFilters { get; set; }
                public class CreateOrUpdateAlertRuleResponseBodyAlertRuleFiltersDimFilters : TeaModel {
                    /// <summary>
                    /// The key of the filter condition.
                    /// </summary>
                    [NameInMap("FilterKey")]
                    [Validation(Required=false)]
                    public string FilterKey { get; set; }

                    /// <summary>
                    /// The logical operator of the filter condition.
                    /// </summary>
                    [NameInMap("FilterOpt")]
                    [Validation(Required=false)]
                    public string FilterOpt { get; set; }

                    /// <summary>
                    /// The details of the filter condition.
                    /// </summary>
                    [NameInMap("FilterValues")]
                    [Validation(Required=false)]
                    public List<string> FilterValues { get; set; }

                }

            }

            /// <summary>
            /// The tags of the Prometheus alert rule.
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleLabels> Labels { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleLabels : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

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
            /// The metric type of the Application Monitoring or Browser Monitoring alert rule.
            /// </summary>
            [NameInMap("MetricsType")]
            [Validation(Required=false)]
            public string MetricsType { get; set; }

            /// <summary>
            /// Notification Mode.
            /// </summary>
            [NameInMap("NotifyMode")]
            [Validation(Required=false)]
            public string NotifyMode { get; set; }

            /// <summary>
            /// The name of the notification policy.
            /// </summary>
            [NameInMap("NotifyStrategy")]
            [Validation(Required=false)]
            public string NotifyStrategy { get; set; }

            /// <summary>
            /// The process ID (PID) that was associated with the Application Monitoring or Browser Monitoring alert rule.
            /// </summary>
            [NameInMap("Pids")]
            [Validation(Required=false)]
            public List<string> Pids { get; set; }

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

            /// <summary>
            /// The list of tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreateOrUpdateAlertRuleResponseBodyAlertRuleTags> Tags { get; set; }
            public class CreateOrUpdateAlertRuleResponseBodyAlertRuleTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The timestamp generated when the alert rule was updated. Unit: seconds.
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
