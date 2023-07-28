// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertRulesResponseBody : TeaModel {
        /// <summary>
        /// The returned struct.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchAlertRulesResponseBodyPageBean PageBean { get; set; }
        public class SearchAlertRulesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The details of the alert rules.
            /// </summary>
            [NameInMap("AlertRules")]
            [Validation(Required=false)]
            public List<SearchAlertRulesResponseBodyPageBeanAlertRules> AlertRules { get; set; }
            public class SearchAlertRulesResponseBodyPageBeanAlertRules : TeaModel {
                /// <summary>
                /// The format of the alert notification.
                /// </summary>
                [NameInMap("AlarmContext")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext AlarmContext { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlarmContext : TeaModel {
                    /// <summary>
                    /// The sub-title of the alert notification content.
                    /// </summary>
                    [NameInMap("AlarmContentSubTitle")]
                    [Validation(Required=false)]
                    public string AlarmContentSubTitle { get; set; }

                    /// <summary>
                    /// The template of the alert notification.
                    /// </summary>
                    [NameInMap("AlarmContentTemplate")]
                    [Validation(Required=false)]
                    public string AlarmContentTemplate { get; set; }

                    /// <summary>
                    /// The content of the alert notification.
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// The sub-title of the alert notification.
                    /// </summary>
                    [NameInMap("SubTitle")]
                    [Validation(Required=false)]
                    public string SubTitle { get; set; }

                }

                /// <summary>
                /// The severity of the alerts. Only the value `WARN` is supported.
                /// </summary>
                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                /// <summary>
                /// The conditions of the alert rule. Multiple conditions are separated by the AND or OR logical operators.
                /// </summary>
                [NameInMap("AlertRule")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule AlertRule { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRule : TeaModel {
                    /// <summary>
                    /// The logical operator between conditions. Valid values: `&`: AND. `|`: OR.
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// The condition of the alert rule.
                    /// </summary>
                    [NameInMap("Rules")]
                    [Validation(Required=false)]
                    public List<SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules> Rules { get; set; }
                    public class SearchAlertRulesResponseBodyPageBeanAlertRulesAlertRuleRules : TeaModel {
                        /// <summary>
                        /// The aggregation logic of the metric data of the alert rule. Valid values:
                        /// 
                        /// *   `AVG`: calculates the average value for each minute
                        /// *   `SUM`: calculates the total value for each minute
                        /// *   `MAX`: calculates the maximum value for each minute
                        /// *   `MIN`: calculates the minimum value for each minute
                        /// </summary>
                        [NameInMap("Aggregates")]
                        [Validation(Required=false)]
                        public string Aggregates { get; set; }

                        /// <summary>
                        /// The displayed description of the alert metric.
                        /// </summary>
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        /// <summary>
                        /// The metric based on which alerts are triggered. For more information, see the "[Alert metrics](https://help.aliyun.com/document_detail/175825.html#h2-url-4)" section in this topic.
                        /// </summary>
                        [NameInMap("Measure")]
                        [Validation(Required=false)]
                        public string Measure { get; set; }

                        /// <summary>
                        /// The time range when data is requested. Unit: minutes. For example, a value of 5 indicates that the alert rule applies to the data in the last 5 minutes.
                        /// </summary>
                        [NameInMap("NValue")]
                        [Validation(Required=false)]
                        public int? NValue { get; set; }

                        /// <summary>
                        /// The operation logic of the condition. Valid values:
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
                        /// The threshold of the condition.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public float? Value { get; set; }

                    }

                }

                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                /// <summary>
                /// The type of the alert rule. Valid values:
                /// 
                /// *   `1`: custom alert rules that are used to monitor drill-down data sets
                /// *   `3`: custom alert rules that are used to monitor tiled data sets
                /// *   `4`: alert rules that are used to monitor the browser, including the default frontend alert rules
                /// *   `5`: alert rules that are used to monitor applications, including the default application alert rules
                /// *   `6`: the default browser alert rules
                /// *   `7`: the default application alert rules
                /// *   `8`: Tracing Analysis alert rules
                /// *   `101`: Prometheus alert rules
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public int? AlertType { get; set; }

                /// <summary>
                /// The version of the alert rule. Default value: `1`.
                /// </summary>
                [NameInMap("AlertVersion")]
                [Validation(Required=false)]
                public int? AlertVersion { get; set; }

                [NameInMap("AlertWays")]
                [Validation(Required=false)]
                public List<string> AlertWays { get; set; }

                /// <summary>
                /// The configuration items of the alert rule. The value is a JSON string.
                /// 
                /// The configuration item **continuous** indicates whether alert notifications are continuously sent. Valid values:
                /// 
                /// *   `true`: Alert notifications are sent every minute.
                /// *   `false`: The alert silence feature is enabled.
                /// 
                /// The configuration item **dataRevision** indicates the data revision policy that is used if no data is obtained or the data is null. Default value: 2. Valid values:
                /// 
                /// *   `0`: overwrites the data by using the value 0
                /// *   `1`: overwrites the data by using the value 1
                /// *   `2`: overwrites the data by using the value null. This value indicates that no alert is triggered if no data exists
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The ID of the contact group. Multiple IDs are separated by commas (,).
                /// </summary>
                [NameInMap("ContactGroupIdList")]
                [Validation(Required=false)]
                public string ContactGroupIdList { get; set; }

                /// <summary>
                /// The IDs of the alert contact groups. The value is a JSON array.
                /// </summary>
                [NameInMap("ContactGroupIds")]
                [Validation(Required=false)]
                public string ContactGroupIds { get; set; }

                /// <summary>
                /// The timestamp that shows when the alert rule was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// Indicates whether the alert is sent through the alert center. Valid values:
                /// 
                /// *   `true`
                /// *   `false`
                /// </summary>
                [NameInMap("HostByAlertManager")]
                [Validation(Required=false)]
                public bool? HostByAlertManager { get; set; }

                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The information about the application that is associated with the alert rule.
                /// </summary>
                [NameInMap("MetricParam")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam MetricParam { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParam : TeaModel {
                    /// <summary>
                    /// The ID of the application group that is associated with the alert rule. This parameter is applicable to Enterprise Distributed Application Service (EDAS) applications.
                    /// </summary>
                    [NameInMap("AppGroupId")]
                    [Validation(Required=false)]
                    public string AppGroupId { get; set; }

                    /// <summary>
                    /// The auto-increment ID of the ARMS application. You can ignore this ID.
                    /// </summary>
                    [NameInMap("AppId")]
                    [Validation(Required=false)]
                    public string AppId { get; set; }

                    /// <summary>
                    /// The dimensions in the condition.
                    /// </summary>
                    [NameInMap("Dimensions")]
                    [Validation(Required=false)]
                    public List<SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParamDimensions> Dimensions { get; set; }
                    public class SearchAlertRulesResponseBodyPageBeanAlertRulesMetricParamDimensions : TeaModel {
                        /// <summary>
                        /// The key of the dimension. Valid values:
                        /// 
                        /// *   `rpc`: the name of the API
                        /// *   `rpcType`: the type of the API call, such as HTTP or DUBBO
                        /// *   `endpoint`: the name of the database
                        /// *   `rootIp`: the IP address of the host
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The type of the dimension. Valid values:
                        /// 
                        /// *   `STATIC`: checks only the value of this dimension. In this case, you must set the **dimensions.value** parameter.
                        /// *   `ALL`: checks the values of all dimensions. The metrics of all API calls are checked. If an API call triggers an alert, the name of the API is displayed in the alert notification. In this case, you do not need to set the **dimensions.value** parameter.
                        /// *   `DISABLE`: aggregates the values of all dimensions. In this case, you do not need to set the **dimensions.value** parameter.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The value of the dimension.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// The PID of the application that is associated with the alert rule.
                    /// </summary>
                    [NameInMap("Pid")]
                    [Validation(Required=false)]
                    public string Pid { get; set; }

                    /// <summary>
                    /// The type of the metric. Valid values:
                    /// 
                    /// *   `txn`: the number of API calls during application monitoring
                    /// *   `txn_type`: the types of API calls during application monitoring
                    /// *   `db`: database metrics
                    /// *   `jvm`: Java virtual machine (JVM) metrics
                    /// *   `host`: host metrics
                    /// *   `exception`: API call errors
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The time ranges when the alert rule takes effect and when alert notifications are sent.
                /// </summary>
                [NameInMap("Notice")]
                [Validation(Required=false)]
                public SearchAlertRulesResponseBodyPageBeanAlertRulesNotice Notice { get; set; }
                public class SearchAlertRulesResponseBodyPageBeanAlertRulesNotice : TeaModel {
                    /// <summary>
                    /// The end of the time range when the alert rule takes effect within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public long? EndTime { get; set; }

                    /// <summary>
                    /// The end of the time range when alert notifications are sent based on the alert rule within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.
                    /// </summary>
                    [NameInMap("NoticeEndTime")]
                    [Validation(Required=false)]
                    public long? NoticeEndTime { get; set; }

                    /// <summary>
                    /// The beginning of the time range when alert notifications are sent based on the alert rule within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.
                    /// </summary>
                    [NameInMap("NoticeStartTime")]
                    [Validation(Required=false)]
                    public long? NoticeStartTime { get; set; }

                    /// <summary>
                    /// The beginning of the time range when the alert rule takes effect within 24 hours per day. This value is a UNIX timestamp. The year, month, and day that are indicated by the timestamp are not displayed in this value. Only the hour, minute, and second are displayed.
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public long? StartTime { get; set; }

                }

                /// <summary>
                /// The ID of the region to which the alert rule belongs.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The status of the alert rule. `RUNNING`: The alert rule is enabled. `STOPPED`: The alert rule is disabled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the Application Real-Time Monitoring Service (ARMS) task that is associated with the alert rule.
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

                /// <summary>
                /// The status of the task. This parameter is hidden from users.
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

                /// <summary>
                /// The name of the alert.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The timestamp that shows when the alert rule was updated.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

                /// <summary>
                /// The ID of the user to which the alert rule belongs.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
