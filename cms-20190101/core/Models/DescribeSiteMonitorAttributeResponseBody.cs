// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The consecutive number of times for which the metric value is measured before an alert is triggered.
        /// </summary>
        [NameInMap("MetricRules")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodyMetricRules MetricRules { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodyMetricRules : TeaModel {
            [NameInMap("MetricRule")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorAttributeResponseBodyMetricRulesMetricRule> MetricRule { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodyMetricRulesMetricRule : TeaModel {
                /// <summary>
                /// The alert threshold.
                /// </summary>
                [NameInMap("ActionEnable")]
                [Validation(Required=false)]
                public string ActionEnable { get; set; }

                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("AlarmActions")]
                [Validation(Required=false)]
                public string AlarmActions { get; set; }

                /// <summary>
                /// The dimension of the alert rule.
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The status of the alert. Valid values:
                /// 
                /// *   OK: normal.
                /// *   ALARM: The alert is triggered.
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// The alert contact groups to which alert notifications are sent.
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                /// <summary>
                /// Indicates whether the alert rule is enabled. Valid values:
                /// 
                /// *   true: The alert rule is enabled.
                /// *   false: The alert rule is disabled.
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// This topic provides an example on how to query the details of a site monitoring task whose ID is `cc641dff-c19d-45f3-ad0a-818a0c4f****`. The returned result indicates that the task name is `test123`, the address that is monitored by the task is `https://aliyun.com`, and the name of the carrier is `Alibaba`.
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The namespace of the cloud service.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The alert contact group to which alert notifications are sent.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("OkActions")]
                [Validation(Required=false)]
                public string OkActions { get; set; }

                /// <summary>
                /// The expression that is used to trigger alerts.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The interval at which the monitoring data is queried. The value is the same as the interval at which metric data is reported. Unit: seconds.
                /// 
                /// >  If you specify a statistical period for the alert rule, raw data is queried based on the statistical period.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The comparison operator that is used in the alert rule. Valid values:
                /// 
                /// *   `>=`
                /// *   `>`
                /// *   `<=`
                /// *   `<`
                /// *   `=`
                /// *   `!=`
                /// *   GreaterThanYesterday: greater than the metric value at the same time yesterday
                /// *   LessThanYesterday: less than the metric value at the same time yesterday
                /// *   GreaterThanLastWeek: greater than the metric value at the same time last week
                /// *   LessThanLastWeek: less than the metric value at the same time last week
                /// *   GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle
                /// *   LessThanLastPeriod: less than the metric value in the last monitoring cycle
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The severity of the alert. Valid values:
                /// 
                /// *   1: critical
                /// *   2: warning
                /// *   3: information
                /// </summary>
                [NameInMap("StateValue")]
                [Validation(Required=false)]
                public string StateValue { get; set; }

                /// <summary>
                /// For more information about common request parameters, see [Common parameters](~~199331~~).
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The statistical method of the alert rule. Valid values:
                /// 
                /// *   Availability: the percentage of available detection points
                /// *   AvailableNumber: the number of available detection points
                /// *   ErrorCodeMaximum: a status code for an alert
                /// *   ErrorCodeMinimum: all status codes for a set of alerts
                /// *   Average: response time
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// The details of the site monitoring task.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The interval at which the site monitoring task is executed. Unit: minutes. Valid values: 1, 5, 15, 30, and 60.
        /// </summary>
        [NameInMap("SiteMonitors")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodySiteMonitors SiteMonitors { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodySiteMonitors : TeaModel {
            /// <summary>
            /// The information of detection points. The information includes the carriers that provide the detection points and the cities where the detection points reside.
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("AgentGroup")]
            [Validation(Required=false)]
            public string AgentGroup { get; set; }

            [NameInMap("CustomSchedule")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomSchedule CustomSchedule { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomSchedule : TeaModel {
                [NameInMap("days")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomScheduleDays Days { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomScheduleDays : TeaModel {
                    [NameInMap("days")]
                    [Validation(Required=false)]
                    public List<int?> Days { get; set; }

                }

                [NameInMap("end_hour")]
                [Validation(Required=false)]
                public int? EndHour { get; set; }

                [NameInMap("start_hour")]
                [Validation(Required=false)]
                public int? StartHour { get; set; }

                [NameInMap("time_zone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// The name of the site monitoring task.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// The name of the carrier.
            /// </summary>
            [NameInMap("IspCities")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCities IspCities { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCities : TeaModel {
                [NameInMap("IspCity")]
                [Validation(Required=false)]
                public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCitiesIspCity> IspCity { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCitiesIspCity : TeaModel {
                    /// <summary>
                    /// The ID of the carrier.
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("CityName")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// The information of the alert rules that are configured for the site monitoring task.
                    /// </summary>
                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public string Isp { get; set; }

                    /// <summary>
                    /// The name of the city.
                    /// </summary>
                    [NameInMap("IspName")]
                    [Validation(Required=false)]
                    public string IspName { get; set; }

                }

            }

            [NameInMap("OptionJson")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJson OptionJson { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJson : TeaModel {
                [NameInMap("assertions")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertions Assertions { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertions : TeaModel {
                    [NameInMap("assertions")]
                    [Validation(Required=false)]
                    public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertionsAssertions> Assertions { get; set; }
                    public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertionsAssertions : TeaModel {
                        [NameInMap("operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        [NameInMap("property")]
                        [Validation(Required=false)]
                        public string Property { get; set; }

                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public string Target { get; set; }

                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                [NameInMap("attempts")]
                [Validation(Required=false)]
                public long? Attempts { get; set; }

                [NameInMap("authentication")]
                [Validation(Required=false)]
                public int? Authentication { get; set; }

                [NameInMap("cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                [NameInMap("diagnosis_mtr")]
                [Validation(Required=false)]
                public bool? DiagnosisMtr { get; set; }

                [NameInMap("diagnosis_ping")]
                [Validation(Required=false)]
                public bool? DiagnosisPing { get; set; }

                [NameInMap("dns_hijack_whitelist")]
                [Validation(Required=false)]
                public string DnsHijackWhitelist { get; set; }

                [NameInMap("dns_match_rule")]
                [Validation(Required=false)]
                public string DnsMatchRule { get; set; }

                [NameInMap("dns_server")]
                [Validation(Required=false)]
                public string DnsServer { get; set; }

                [NameInMap("dns_type")]
                [Validation(Required=false)]
                public string DnsType { get; set; }

                [NameInMap("expect_value")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                [NameInMap("failure_rate")]
                [Validation(Required=false)]
                public float? FailureRate { get; set; }

                [NameInMap("header")]
                [Validation(Required=false)]
                public string Header { get; set; }

                [NameInMap("http_method")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                [NameInMap("isBase64Encode")]
                [Validation(Required=false)]
                public string IsBase64Encode { get; set; }

                [NameInMap("match_rule")]
                [Validation(Required=false)]
                public int? MatchRule { get; set; }

                [NameInMap("min_tls_version")]
                [Validation(Required=false)]
                public string MinTlsVersion { get; set; }

                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("ping_num")]
                [Validation(Required=false)]
                public int? PingNum { get; set; }

                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("request_content")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

                [NameInMap("request_format")]
                [Validation(Required=false)]
                public string RequestFormat { get; set; }

                [NameInMap("response_content")]
                [Validation(Required=false)]
                public string ResponseContent { get; set; }

                [NameInMap("response_format")]
                [Validation(Required=false)]
                public string ResponseFormat { get; set; }

                [NameInMap("retry_delay")]
                [Validation(Required=false)]
                public int? RetryDelay { get; set; }

                [NameInMap("time_out")]
                [Validation(Required=false)]
                public long? TimeOut { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// The ID of the city.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The ID of the site monitoring task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The address that is monitored by the site monitoring task.
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// The status of the site monitoring task. Valid values:
            /// 
            /// *   1: The task is enabled.
            /// *   2: The task is disabled.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// The protocol that is used by the site monitoring task. Valid values: HTTP, HTTPS, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
