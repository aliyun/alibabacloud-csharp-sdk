// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorAttributeResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The information of the alert rules that are configured for the site monitoring task.
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
                /// Indicates whether the alert rule is enabled. Valid values:
                /// 
                /// *   true: The alert rule is enabled.
                /// *   false: The alert rule is disabled.
                /// </summary>
                [NameInMap("ActionEnable")]
                [Validation(Required=false)]
                public string ActionEnable { get; set; }

                /// <summary>
                /// The alert contact group to which alert notifications are sent.
                /// </summary>
                [NameInMap("AlarmActions")]
                [Validation(Required=false)]
                public string AlarmActions { get; set; }

                /// <summary>
                /// The operator that is used to compare the metric value with the threshold in the alert rule. Valid values:
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
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// The dimension of the alert rule.
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                /// <summary>
                /// The expression that is used to trigger alerts.
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// The alert severity. Valid values:
                /// 
                /// *   1: critical
                /// *   2: warning
                /// *   3: information
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// The metric name.
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// The namespace of the cloud service.
                /// 
                /// The value is in the following format: acs_service name.
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// The alert contact group that receives alert notifications.
                /// </summary>
                [NameInMap("OkActions")]
                [Validation(Required=false)]
                public string OkActions { get; set; }

                /// <summary>
                /// The time interval. The value is the same as the interval at which metric data is reported. Unit: seconds.
                /// 
                /// >  If you specify a statistical period for the alert rule, data is queried based on the statistical period.
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// The ID of the alert rule.
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// The name of the alert rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The alert status. Valid values:
                /// 
                /// *   OK: The alert rule has no active alerts.
                /// *   ALARM: The alert rule has active alerts.
                /// </summary>
                [NameInMap("StateValue")]
                [Validation(Required=false)]
                public string StateValue { get; set; }

                /// <summary>
                /// The statistical method of the alert rule. Valid values:
                /// 
                /// *   Availability: the percentage of available detection points
                /// *   AvailableNumber: the number of available detection points
                /// *   ErrorCodeMaximum: a status code for an alert
                /// *   ErrorCodeMinimum: all status codes for a set of alerts
                /// *   Average: response time
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// The alert threshold.
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the site monitoring task.
        /// </summary>
        [NameInMap("SiteMonitors")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodySiteMonitors SiteMonitors { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodySiteMonitors : TeaModel {
            /// <summary>
            /// The URL that is monitored by the site monitoring task.
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
            /// The interval at which the site monitoring task is executed. Unit: minutes. Valid values: 1, 5, 15, 30, and 60.
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// The information of detection points. The information includes the carriers that provide the detection points and the cities where the detection points reside.
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
                    /// The city ID.
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// The city name.
                    /// </summary>
                    [NameInMap("CityName")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// The carrier ID.
                    /// </summary>
                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public string Isp { get; set; }

                    /// <summary>
                    /// The carrier name.
                    /// </summary>
                    [NameInMap("IspName")]
                    [Validation(Required=false)]
                    public string IspName { get; set; }

                }

            }

            /// <summary>
            /// The extended options of the site monitoring task. The options vary based on the specified protocol. For more information, see [CreateSiteMonitor](https://help.aliyun.com/document_detail/115048.html).
            /// </summary>
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

                /// <summary>
                /// The number of retries after a DNS failure occurred.
                /// </summary>
                [NameInMap("attempts")]
                [Validation(Required=false)]
                public long? Attempts { get; set; }

                /// <summary>
                /// Indicates whether the security authentication feature is enabled. Valid values:
                /// 
                /// *   0: The feature is disabled.
                /// *   1: The feature is enabled.
                /// </summary>
                [NameInMap("authentication")]
                [Validation(Required=false)]
                public int? Authentication { get; set; }

                [NameInMap("blocked_url_list")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBlockedUrlList BlockedUrlList { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBlockedUrlList : TeaModel {
                    [NameInMap("blocked_url_list")]
                    [Validation(Required=false)]
                    public List<string> BlockedUrlList { get; set; }

                }

                [NameInMap("browser_headers")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHeaders BrowserHeaders { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHeaders : TeaModel {
                    [NameInMap("browser_headers")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> BrowserHeaders { get; set; }

                }

                [NameInMap("browser_hosts")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHosts BrowserHosts { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHosts : TeaModel {
                    [NameInMap("browser_hosts")]
                    [Validation(Required=false)]
                    public List<string> BrowserHosts { get; set; }

                }

                [NameInMap("browser_info")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfo BrowserInfo { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfo : TeaModel {
                    [NameInMap("browser_info")]
                    [Validation(Required=false)]
                    public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfoBrowserInfo> BrowserInfo { get; set; }
                    public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfoBrowserInfo : TeaModel {
                        [NameInMap("browser")]
                        [Validation(Required=false)]
                        public string Browser { get; set; }

                        [NameInMap("device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                    }

                }

                [NameInMap("browser_insecure")]
                [Validation(Required=false)]
                public bool? BrowserInsecure { get; set; }

                [NameInMap("browser_task_version")]
                [Validation(Required=false)]
                public string BrowserTaskVersion { get; set; }

                /// <summary>
                /// The cookie of the HTTP request.
                /// </summary>
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

                /// <summary>
                /// The relationship between the list of expected aliases or IP addresses and the list of DNS results. Valid values:
                /// 
                /// *   IN_DNS: The list of expected values is a subset of the list of DNS results.
                /// *   DNS_IN: The list of DNS results is a subset of the list of expected values.
                /// *   EQUAL: The list of DNS results is the same as the list of expected values.
                /// *   ANY: The list of DNS results intersects with the list of expected values.
                /// </summary>
                [NameInMap("dns_match_rule")]
                [Validation(Required=false)]
                public string DnsMatchRule { get; set; }

                /// <summary>
                /// The IP address of the DNS server.
                /// 
                /// >  This parameter is returned only if the TaskType parameter is set to DNS.
                /// </summary>
                [NameInMap("dns_server")]
                [Validation(Required=false)]
                public string DnsServer { get; set; }

                /// <summary>
                /// The type of the DNS record. This parameter is returned only if the TaskType parameter is set to DNS. Valid values:
                /// 
                /// *   A (default): a record that specifies an IP address related to the specified host name or domain name.
                /// *   CNAME: a record that maps multiple domain names to a domain name.
                /// *   NS: a record that specifies a DNS server used to parse domain names.
                /// *   MX: a record that links domain names to the address of a mail server.
                /// *   TXT: a record that stores the text information of host name or domain names. The text must be 1 to 512 bytes in length. The TXT record serves as a Sender Policy Framework (SPF) record to fight against spam.
                /// </summary>
                [NameInMap("dns_type")]
                [Validation(Required=false)]
                public string DnsType { get; set; }

                [NameInMap("empty_message")]
                [Validation(Required=false)]
                public bool? EmptyMessage { get; set; }

                [NameInMap("expect_exist_string")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectExistString ExpectExistString { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectExistString : TeaModel {
                    [NameInMap("expect_exist_string")]
                    [Validation(Required=false)]
                    public List<string> ExpectExistString { get; set; }

                }

                [NameInMap("expect_non_exist_string")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectNonExistString ExpectNonExistString { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectNonExistString : TeaModel {
                    [NameInMap("expect_non_exist_string")]
                    [Validation(Required=false)]
                    public List<string> ExpectNonExistString { get; set; }

                }

                /// <summary>
                /// The domain name or alias to be parsed.
                /// 
                /// >  This parameter is returned only if the TaskType parameter is set to DNS.
                /// </summary>
                [NameInMap("expect_value")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                /// <summary>
                /// The packet loss rate.
                /// 
                /// >  This parameter is returned only if the TaskType parameter is set to PING.
                /// </summary>
                [NameInMap("failure_rate")]
                [Validation(Required=false)]
                public float? FailureRate { get; set; }

                /// <summary>
                /// The header of the HTTP request.
                /// </summary>
                [NameInMap("header")]
                [Validation(Required=false)]
                public string Header { get; set; }

                /// <summary>
                /// The HTTP request method. Valid values:
                /// 
                /// *   get
                /// *   post
                /// *   head
                /// </summary>
                [NameInMap("http_method")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                [NameInMap("ip_network")]
                [Validation(Required=false)]
                public string IpNetwork { get; set; }

                [NameInMap("isBase64Encode")]
                [Validation(Required=false)]
                public string IsBase64Encode { get; set; }

                /// <summary>
                /// Indicates whether the alert rule is included. Valid values:
                /// 
                /// *   0: The alert rule is included.
                /// *   1: The alert rule is excluded.
                /// </summary>
                [NameInMap("match_rule")]
                [Validation(Required=false)]
                public int? MatchRule { get; set; }

                [NameInMap("min_tls_version")]
                [Validation(Required=false)]
                public string MinTlsVersion { get; set; }

                /// <summary>
                /// The password of the SMTP, POP3, or FTP protocol.
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// The heartbeat of the PING protocol.
                /// </summary>
                [NameInMap("ping_num")]
                [Validation(Required=false)]
                public int? PingNum { get; set; }

                [NameInMap("ping_port")]
                [Validation(Required=false)]
                public int? PingPort { get; set; }

                [NameInMap("ping_type")]
                [Validation(Required=false)]
                public string PingType { get; set; }

                /// <summary>
                /// The port number of the TCP, UDP, SMTP, or POP3 protocol.
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// The protocol that is used to send the request.
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("quic_enabled")]
                [Validation(Required=false)]
                public bool? QuicEnabled { get; set; }

                [NameInMap("quic_target")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonQuicTarget QuicTarget { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonQuicTarget : TeaModel {
                    [NameInMap("quic_target")]
                    [Validation(Required=false)]
                    public List<string> QuicTarget { get; set; }

                }

                /// <summary>
                /// The content of the HTTP request.
                /// </summary>
                [NameInMap("request_content")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

                /// <summary>
                /// The format of the HTTP request. Valid values:
                /// 
                /// *   hex: hexadecimal
                /// *   txt: text
                /// </summary>
                [NameInMap("request_format")]
                [Validation(Required=false)]
                public string RequestFormat { get; set; }

                /// <summary>
                /// The response to the HTTP request.
                /// </summary>
                [NameInMap("response_content")]
                [Validation(Required=false)]
                public string ResponseContent { get; set; }

                /// <summary>
                /// The format of the HTTP response. Valid values:
                /// 
                /// *   hex: hexadecimal
                /// *   txt: text
                /// </summary>
                [NameInMap("response_format")]
                [Validation(Required=false)]
                public string ResponseFormat { get; set; }

                [NameInMap("retry_delay")]
                [Validation(Required=false)]
                public int? RetryDelay { get; set; }

                [NameInMap("strict_mode")]
                [Validation(Required=false)]
                public bool? StrictMode { get; set; }

                /// <summary>
                /// The timeout period. Unit: milliseconds.
                /// </summary>
                [NameInMap("time_out")]
                [Validation(Required=false)]
                public long? TimeOut { get; set; }

                [NameInMap("traffic_hijack_element_blacklist")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementBlacklist TrafficHijackElementBlacklist { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementBlacklist : TeaModel {
                    [NameInMap("traffic_hijack_element_blacklist")]
                    [Validation(Required=false)]
                    public List<string> TrafficHijackElementBlacklist { get; set; }

                }

                [NameInMap("traffic_hijack_element_count")]
                [Validation(Required=false)]
                public int? TrafficHijackElementCount { get; set; }

                [NameInMap("traffic_hijack_element_whitelist")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementWhitelist TrafficHijackElementWhitelist { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementWhitelist : TeaModel {
                    [NameInMap("traffic_hijack_element_whitelist")]
                    [Validation(Required=false)]
                    public List<string> TrafficHijackElementWhitelist { get; set; }

                }

                /// <summary>
                /// The username of the FTP, SMTP, or POP3 protocol.
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("waitTime_after_completion")]
                [Validation(Required=false)]
                public int? WaitTimeAfterCompletion { get; set; }

            }

            /// <summary>
            /// The ID of the site monitoring task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// The name of the site monitoring task.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// The status of the site monitoring task. Valid values:
            /// 
            /// *   1: The task is enabled.
            /// *   2: The task is disabled.
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// The protocol that is used by the site monitoring task. Valid values: HTTP, HTTPS, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsVpcConfig VpcConfig { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsVpcConfig : TeaModel {
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
