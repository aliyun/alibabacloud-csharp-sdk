// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAlertRulesResponseBody : TeaModel {
        /// <summary>
        /// The returned pages.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public GetAlertRulesResponseBodyPageBean PageBean { get; set; }
        public class GetAlertRulesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The alert rules.
            /// </summary>
            [NameInMap("AlertRules")]
            [Validation(Required=false)]
            public List<GetAlertRulesResponseBodyPageBeanAlertRules> AlertRules { get; set; }
            public class GetAlertRulesResponseBodyPageBeanAlertRules : TeaModel {
                /// <summary>
                /// The alert check type of the Prometheus alert rule.
                /// 
                /// *   STATIC: static threshold
                /// *   CUSTOM: custom PromQL
                /// </summary>
                [NameInMap("AlertCheckType")]
                [Validation(Required=false)]
                public string AlertCheckType { get; set; }

                /// <summary>
                /// The alert contact group ID of the Prometheus alert rule.
                /// 
                /// *   \\-1: custom PromQL
                /// *   1: Kubernetes load
                /// *   15: Kubernetes node
                /// </summary>
                [NameInMap("AlertGroup")]
                [Validation(Required=false)]
                public long? AlertGroup { get; set; }

                /// <summary>
                /// The alert rule ID.
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
                /// The content of the Application Monitoring or Browser Monitoring alert rule.
                /// </summary>
                [NameInMap("AlertRuleContent")]
                [Validation(Required=false)]
                public GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContent AlertRuleContent { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContent : TeaModel {
                    /// <summary>
                    /// The trigger conditions of the Application Monitoring or Browser Monitoring alert rule.
                    /// </summary>
                    [NameInMap("AlertRuleItems")]
                    [Validation(Required=false)]
                    public List<GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContentAlertRuleItems> AlertRuleItems { get; set; }
                    public class GetAlertRulesResponseBodyPageBeanAlertRulesAlertRuleContentAlertRuleItems : TeaModel {
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
                        /// The last N minutes.
                        /// </summary>
                        [NameInMap("N")]
                        [Validation(Required=false)]
                        public long? N { get; set; }

                        /// <summary>
                        /// The operator that is used to compare the metric value with the threshold. Valid values:
                        /// 
                        /// *   CURRENT_GTE: greater than or equal to
                        /// *   CURRENT_LTE: less than or equal to
                        /// *   PREVIOUS_UP: increase in percentage compared with the previous period
                        /// *   PREVIOUS_DOWN: decrease in percentage compared with the previous period
                        /// *   HOH_UP: increase in percentage compared with the same period in the previous hour
                        /// *   HOH_DOWN: decrease in percentage compared with the same period in the previous hour
                        /// *   DOD_UP: increase in percentage compared with the same period in the previous day
                        /// *   DOD_DOWN: decrease in percentage compared with the same period in the previous day
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
                    /// The relationship between multiple alert conditions specified for the Application Monitoring or Browser Monitoring alert rule. Valid values:
                    /// 
                    /// *   OR: The alert rule is triggered if one of the conditions is met.
                    /// *   AND: The alert rule is triggered if all the conditions are met.
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
                /// >  The PAUSED state indicates that the alert rule is abnormal and has been suspended. This may be because the specified threshold value is excessively large, or the associated cluster has been deleted.
                /// </summary>
                [NameInMap("AlertStatus")]
                [Validation(Required=false)]
                public string AlertStatus { get; set; }

                /// <summary>
                /// The type of the alert rule. Valid values:
                /// 
                /// *   APPLICATION_MONITORING_ALERT_RULE: alert rule for Application Monitoring
                /// *   BROWSER_MONITORING_ALERT_RULE: alert rule for Browser Monitoring
                /// *   PROMETHEUS_MONITORING_ALERT_RULE: Prometheus alert rule
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// The annotations of the Prometheus alert rule.
                /// </summary>
                [NameInMap("Annotations")]
                [Validation(Required=false)]
                public List<GetAlertRulesResponseBodyPageBeanAlertRulesAnnotations> Annotations { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesAnnotations : TeaModel {
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
                /// Indicates whether the alert rule is applied to new applications that are created in Application Monitoring or Browser Monitoring. Valid values:
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
                /// The time when the alert rule was created. The value is a timestamp. Unit: milliseconds.
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                /// <summary>
                /// The duration of the Prometheus alert rule.
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                /// <summary>
                /// The extended fields.
                /// 
                /// >  For existing Application Monitoring alert rules, the fields contain information such as contacts, alert template, and notification content.
                /// </summary>
                [NameInMap("Extend")]
                [Validation(Required=false)]
                public string Extend { get; set; }

                /// <summary>
                /// The filter conditions of the Application Monitoring or Browser Monitoring alert rule.
                /// </summary>
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public GetAlertRulesResponseBodyPageBeanAlertRulesFilters Filters { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesFilters : TeaModel {
                    /// <summary>
                    /// The custom filter condition of the Browser Monitoring alert rule.
                    /// </summary>
                    [NameInMap("CustomSLSFilters")]
                    [Validation(Required=false)]
                    public List<GetAlertRulesResponseBodyPageBeanAlertRulesFiltersCustomSLSFilters> CustomSLSFilters { get; set; }
                    public class GetAlertRulesResponseBodyPageBeanAlertRulesFiltersCustomSLSFilters : TeaModel {
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
                        /// Indicates whether this filter condition is displayed on the frontend.
                        /// </summary>
                        [NameInMap("Show")]
                        [Validation(Required=false)]
                        public bool? Show { get; set; }

                        /// <summary>
                        /// The log type of Browser Monitoring. This field is not included in other filter conditions.
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
                    /// The information about the aggregation dimension.
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
                    public List<GetAlertRulesResponseBodyPageBeanAlertRulesFiltersDimFilters> DimFilters { get; set; }
                    public class GetAlertRulesResponseBodyPageBeanAlertRulesFiltersDimFilters : TeaModel {
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
                public List<GetAlertRulesResponseBodyPageBeanAlertRulesLabels> Labels { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesLabels : TeaModel {
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
                /// The name of the notification policy.
                /// </summary>
                [NameInMap("NotifyStrategy")]
                [Validation(Required=false)]
                public string NotifyStrategy { get; set; }

                /// <summary>
                /// The process ID (PID) of the application to which the Application Monitoring or Browser Monitoring alert rule is applied.
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
                /// The tags of the alert rule.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<GetAlertRulesResponseBodyPageBeanAlertRulesTags> Tags { get; set; }
                public class GetAlertRulesResponseBodyPageBeanAlertRulesTags : TeaModel {
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
                /// The time when the alert rule was updated. The value is a timestamp. Unit: milliseconds.
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
            /// The number of pages returned.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of alert rules returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of queried alert rules.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
