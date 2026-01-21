// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <remarks>
        /// <para> The status code 200 indicates that the request was successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The alert rules that are configured for the site monitoring task.</para>
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
                /// <para>Indicates whether the alert rule is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The alert rule is enabled.</description></item>
                /// <item><description>false: The alert rule is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ActionEnable")]
                [Validation(Required=false)]
                public string ActionEnable { get; set; }

                /// <summary>
                /// <para>The alert contact group to which alert notifications are sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CloudMonitor</para>
                /// </summary>
                [NameInMap("AlarmActions")]
                [Validation(Required=false)]
                public string AlarmActions { get; set; }

                /// <summary>
                /// <para>The operator that is used to compare the metric value with the threshold in the alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>&gt;=</c></description></item>
                /// <item><description><c>&gt;</c></description></item>
                /// <item><description><c>&lt;=</c></description></item>
                /// <item><description><c>&lt;</c></description></item>
                /// <item><description><c>=</c></description></item>
                /// <item><description><c>!=</c></description></item>
                /// <item><description>GreaterThanYesterday: greater than the metric value at the same time yesterday</description></item>
                /// <item><description>LessThanYesterday: less than the metric value at the same time yesterday</description></item>
                /// <item><description>GreaterThanLastWeek: greater than the metric value at the same time last week</description></item>
                /// <item><description>LessThanLastWeek: less than the metric value at the same time last week</description></item>
                /// <item><description>GreaterThanLastPeriod: greater than the metric value in the last monitoring cycle</description></item>
                /// <item><description>LessThanLastPeriod: less than the metric value in the last monitoring cycle</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>GreaterThanYesterday</para>
                /// </summary>
                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                /// <summary>
                /// <para>The dimension of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;taskId&quot;: &quot;cc641dff-c19d-45f3-ad0a-818a0c4f****&quot; }]</para>
                /// </summary>
                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                /// <summary>
                /// <para>The consecutive number of times for which the metric value meets the alert condition before an alert is triggered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                /// <summary>
                /// <para>The expression that is used to trigger alerts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>$Availability=30</para>
                /// </summary>
                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The alert severity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: critical</description></item>
                /// <item><description>2: warning</description></item>
                /// <item><description>3: information</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The metric name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Availability</para>
                /// </summary>
                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                /// <summary>
                /// <para>The namespace of the cloud service.</para>
                /// <para>The value is in the following format: acs_service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>acs_networkmonitor</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The alert contact group that receives alert notifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[ &quot;CloudMonitor&quot;]</para>
                /// </summary>
                [NameInMap("OkActions")]
                [Validation(Required=false)]
                public string OkActions { get; set; }

                /// <summary>
                /// <para>The time interval. The value is the same as the interval at which metric data is reported. Unit: seconds.</para>
                /// <remarks>
                /// <para> If you specify a statistical period for the alert rule, data is queried based on the statistical period.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>15s</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                /// <summary>
                /// <para>The ID of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bf071ae_7b7aec3817b0fdf****</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The name of the alert rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rule1</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The alert status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OK: The alert rule has no active alerts.</description></item>
                /// <item><description>ALARM: The alert rule has active alerts.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("StateValue")]
                [Validation(Required=false)]
                public string StateValue { get; set; }

                /// <summary>
                /// <para>The statistical method of the alert rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Availability: the percentage of available detection points</description></item>
                /// <item><description>AvailableNumber: the number of available detection points</description></item>
                /// <item><description>ErrorCodeMaximum: a status code for an alert</description></item>
                /// <item><description>ErrorCodeMinimum: all status codes for a set of alerts</description></item>
                /// <item><description>Average: response time</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Availability</para>
                /// </summary>
                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

                /// <summary>
                /// <para>The alert threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D17DF650-7EBD-54D0-903A-1D4E624D7402</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the site monitoring task.</para>
        /// </summary>
        [NameInMap("SiteMonitors")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodySiteMonitors SiteMonitors { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodySiteMonitors : TeaModel {
            /// <summary>
            /// <para>The URL that is monitored by the site monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
            /// </summary>
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            /// <summary>
            /// <para>The type of the detection point. Default value: PC. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PC</description></item>
            /// <item><description>MOBILE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PC</para>
            /// </summary>
            [NameInMap("AgentGroup")]
            [Validation(Required=false)]
            public string AgentGroup { get; set; }

            /// <summary>
            /// <para>The custom detection cycle. You can specify only a time range within a week (from Monday to Sunday).</para>
            /// </summary>
            [NameInMap("CustomSchedule")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomSchedule CustomSchedule { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomSchedule : TeaModel {
                /// <summary>
                /// <para>The days in a week.</para>
                /// </summary>
                [NameInMap("days")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomScheduleDays Days { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsCustomScheduleDays : TeaModel {
                    [NameInMap("days")]
                    [Validation(Required=false)]
                    public List<int?> Days { get; set; }

                }

                /// <summary>
                /// <para>The end time of the detection. Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("end_hour")]
                [Validation(Required=false)]
                public int? EndHour { get; set; }

                /// <summary>
                /// <para>The start time of the detection. Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("start_hour")]
                [Validation(Required=false)]
                public int? StartHour { get; set; }

                /// <summary>
                /// <para>The time zone of the detection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>local</para>
                /// </summary>
                [NameInMap("time_zone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// <para>The interval at which the site monitoring task is executed. Unit: minutes. Valid values: 1, 5, 15, 30, and 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            /// <summary>
            /// <para>The information of detection points. The information includes the carriers that provide the detection points and the cities where the detection points reside.</para>
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
                    /// <para>The city ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>738</para>
                    /// </summary>
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    /// <summary>
                    /// <para>The city name.</para>
                    /// </summary>
                    [NameInMap("CityName")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <para>The carrier ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>465</para>
                    /// </summary>
                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public string Isp { get; set; }

                    /// <summary>
                    /// <para>The carrier name.</para>
                    /// </summary>
                    [NameInMap("IspName")]
                    [Validation(Required=false)]
                    public string IspName { get; set; }

                    /// <summary>
                    /// <para>The network type of the detection point. Valid values: IDC, LASTMILE, and MOBILE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>IDC</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The extended options of the site monitoring task. The options vary based on the specified protocol. For more information, see <a href="https://help.aliyun.com/document_detail/115048.html">CreateSiteMonitor</a>.</para>
            /// </summary>
            [NameInMap("OptionJson")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJson OptionJson { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJson : TeaModel {
                /// <summary>
                /// <para>The assertions.</para>
                /// </summary>
                [NameInMap("assertions")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertions Assertions { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertions : TeaModel {
                    [NameInMap("assertions")]
                    [Validation(Required=false)]
                    public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertionsAssertions> Assertions { get; set; }
                    public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAssertionsAssertions : TeaModel {
                        /// <summary>
                        /// <para>The operator. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>contains: contains</description></item>
                        /// <item><description>doesNotContain: does not contain</description></item>
                        /// <item><description>matches: matches a regular expression</description></item>
                        /// <item><description>doesNotMatch: does not match a regular expression</description></item>
                        /// <item><description>is: equal to</description></item>
                        /// <item><description>isNot: not equal to</description></item>
                        /// <item><description>lessThan: less than</description></item>
                        /// <item><description>moreThan: greater than</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>lessThan</para>
                        /// </summary>
                        [NameInMap("operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The path to the assertion.</para>
                        /// <list type="bullet">
                        /// <item><description>If the assertion type is body_json, the path is json path.</description></item>
                        /// <item><description>If the assertion type is body_xml, the path is xml path.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>json path</para>
                        /// </summary>
                        [NameInMap("property")]
                        [Validation(Required=false)]
                        public string Property { get; set; }

                        /// <summary>
                        /// <para>The value or character to which the condition of the assertion is compared.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public string Target { get; set; }

                        /// <summary>
                        /// <para>The assertion type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>response_time: checks whether the response time meets expectations.</description></item>
                        /// <item><description>status_code: checks whether the HTTP status code meets expectations.</description></item>
                        /// <item><description>header: checks whether the fields in the response header meet expectations.</description></item>
                        /// <item><description>body_text: check whether the content in the response body meets expectations by using text matching.</description></item>
                        /// <item><description>body_json: check whether the content in the response body meets expectations by using JSON parsing (JSONPath).</description></item>
                        /// <item><description>body_xml: check whether the content in the response body meets expectations by using XML parsing (XPath).</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>response_time</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of retries after a DNS failure occurred.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("attempts")]
                [Validation(Required=false)]
                public long? Attempts { get; set; }

                [NameInMap("auth_info")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAuthInfo AuthInfo { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAuthInfo : TeaModel {
                    [NameInMap("access_key_id")]
                    [Validation(Required=false)]
                    public string AccessKeyId { get; set; }

                    [NameInMap("access_key_secret")]
                    [Validation(Required=false)]
                    public string AccessKeySecret { get; set; }

                    [NameInMap("api_action")]
                    [Validation(Required=false)]
                    public string ApiAction { get; set; }

                    [NameInMap("api_version")]
                    [Validation(Required=false)]
                    public string ApiVersion { get; set; }

                    [NameInMap("auth_style")]
                    [Validation(Required=false)]
                    public string AuthStyle { get; set; }

                    [NameInMap("client_id")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    [NameInMap("client_secret")]
                    [Validation(Required=false)]
                    public string ClientSecret { get; set; }

                    [NameInMap("grant_type")]
                    [Validation(Required=false)]
                    public string GrantType { get; set; }

                    [NameInMap("password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    [NameInMap("region_id")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("scopes")]
                    [Validation(Required=false)]
                    public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAuthInfoScopes Scopes { get; set; }
                    public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAuthInfoScopes : TeaModel {
                        [NameInMap("scopes")]
                        [Validation(Required=false)]
                        public List<string> Scopes { get; set; }

                    }

                    [NameInMap("service_name")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    [NameInMap("session_token")]
                    [Validation(Required=false)]
                    public string SessionToken { get; set; }

                    [NameInMap("token_url")]
                    [Validation(Required=false)]
                    public string TokenUrl { get; set; }

                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("use_cookie_session_key")]
                    [Validation(Required=false)]
                    public bool? UseCookieSessionKey { get; set; }

                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                    [NameInMap("with_addon_resources")]
                    [Validation(Required=false)]
                    public bool? WithAddonResources { get; set; }

                }

                /// <summary>
                /// <para>The blocked URLs. Wildcards are supported in paths.</para>
                /// </summary>
                [NameInMap("blocked_url_list")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBlockedUrlList BlockedUrlList { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBlockedUrlList : TeaModel {
                    [NameInMap("blocked_url_list")]
                    [Validation(Required=false)]
                    public List<string> BlockedUrlList { get; set; }

                }

                /// <summary>
                /// <para>The custom headers. Format: {&quot;key&quot;: &quot;somekey&quot;, &quot;value&quot;:&quot;somevalue&quot;}.</para>
                /// </summary>
                [NameInMap("browser_headers")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHeaders BrowserHeaders { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHeaders : TeaModel {
                    [NameInMap("browser_headers")]
                    [Validation(Required=false)]
                    public List<Dictionary<string, object>> BrowserHeaders { get; set; }

                }

                /// <summary>
                /// <para>The custom hosts. Format: {&quot;key&quot;: &quot;somekey&quot;, &quot;value&quot;:&quot;somevalue&quot;}.</para>
                /// </summary>
                [NameInMap("browser_hosts")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHosts BrowserHosts { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserHosts : TeaModel {
                    [NameInMap("browser_hosts")]
                    [Validation(Required=false)]
                    public List<string> BrowserHosts { get; set; }

                }

                /// <summary>
                /// <para>The browser information.</para>
                /// </summary>
                [NameInMap("browser_info")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfo BrowserInfo { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfo : TeaModel {
                    [NameInMap("browser_info")]
                    [Validation(Required=false)]
                    public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfoBrowserInfo> BrowserInfo { get; set; }
                    public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonBrowserInfoBrowserInfo : TeaModel {
                        /// <summary>
                        /// <para>The browser type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Chrome</para>
                        /// </summary>
                        [NameInMap("browser")]
                        [Validation(Required=false)]
                        public string Browser { get; set; }

                        /// <summary>
                        /// <para>The device type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>laptop</para>
                        /// </summary>
                        [NameInMap("device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether certificate errors are ignored. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: Certificate errors are not ignored.</description></item>
                /// <item><description>true: Certificate errors are ignored.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("browser_insecure")]
                [Validation(Required=false)]
                public bool? BrowserInsecure { get; set; }

                /// <summary>
                /// <para>The version of the browser test task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: browser test for a single page</description></item>
                /// <item><description>2: browser test for multiple pages</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("browser_task_version")]
                [Validation(Required=false)]
                public string BrowserTaskVersion { get; set; }

                [NameInMap("config_variables")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonConfigVariables ConfigVariables { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonConfigVariables : TeaModel {
                    [NameInMap("config_variables")]
                    [Validation(Required=false)]
                    public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonConfigVariablesConfigVariables> ConfigVariables { get; set; }
                    public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonConfigVariablesConfigVariables : TeaModel {
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("secure")]
                        [Validation(Required=false)]
                        public bool? Secure { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The cookie of the HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lang=en</para>
                /// </summary>
                [NameInMap("cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic MTR diagnostics feature is enabled for a failed task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: The automatic MTR diagnostics feature is disabled for a failed task.</description></item>
                /// <item><description>true: The automatic MTR diagnostics feature is enabled for a failed task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("diagnosis_mtr")]
                [Validation(Required=false)]
                public bool? DiagnosisMtr { get; set; }

                /// <summary>
                /// <para>Indicates whether the automatic ping latency detection feature is enabled for a failed task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: The automatic ping latency detection feature is disabled for a failed task.</description></item>
                /// <item><description>true: The automatic ping latency detection feature is enabled for a failed task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("diagnosis_ping")]
                [Validation(Required=false)]
                public bool? DiagnosisPing { get; set; }

                /// <summary>
                /// <para>The DNS hijack whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.taobao.com:www.taobao.com.danuoyi.tbcache.com">www.taobao.com:www.taobao.com.danuoyi.tbcache.com</a></para>
                /// </summary>
                [NameInMap("dns_hijack_whitelist")]
                [Validation(Required=false)]
                public string DnsHijackWhitelist { get; set; }

                /// <summary>
                /// <para>The relationship between the list of expected aliases or IP addresses and the list of DNS results. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IN_DNS: The list of expected values is a subset of the list of DNS results.</description></item>
                /// <item><description>DNS_IN: The list of DNS results is a subset of the list of expected values.</description></item>
                /// <item><description>EQUAL: The list of DNS results is the same as the list of expected values.</description></item>
                /// <item><description>ANY: The list of DNS results intersects with the list of expected values.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IN_DNS</para>
                /// </summary>
                [NameInMap("dns_match_rule")]
                [Validation(Required=false)]
                public string DnsMatchRule { get; set; }

                /// <summary>
                /// <para>The IP address of the DNS server.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the TaskType parameter is set to DNS.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("dns_server")]
                [Validation(Required=false)]
                public string DnsServer { get; set; }

                /// <summary>
                /// <para>The type of the DNS record. This parameter is returned only if the TaskType parameter is set to DNS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>A (default): a record that specifies an IP address related to the specified host name or domain name.</description></item>
                /// <item><description>CNAME: a record that maps multiple domain names to a domain name.</description></item>
                /// <item><description>NS: a record that specifies a DNS server used to parse domain names.</description></item>
                /// <item><description>MX: a record that links domain names to the address of a mail server.</description></item>
                /// <item><description>TXT: a record that stores the text information of host name or domain names. The text must be 1 to 512 bytes in length. The TXT record serves as a Sender Policy Framework (SPF) record to fight against spam.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("dns_type")]
                [Validation(Required=false)]
                public string DnsType { get; set; }

                /// <summary>
                /// <para>Indicates whether the WebSocket task is allowed to return no response or return an empty response. Default value: false. Valid values: false and true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("empty_message")]
                [Validation(Required=false)]
                public bool? EmptyMessage { get; set; }

                [NameInMap("enable_packet_capture")]
                [Validation(Required=false)]
                public bool? EnablePacketCapture { get; set; }

                /// <summary>
                /// <para>The string that is expected to exist on the page.</para>
                /// </summary>
                [NameInMap("expect_exist_string")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectExistString ExpectExistString { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectExistString : TeaModel {
                    [NameInMap("expect_exist_string")]
                    [Validation(Required=false)]
                    public List<string> ExpectExistString { get; set; }

                }

                /// <summary>
                /// <para>The string that is not expected to exist on the page.</para>
                /// </summary>
                [NameInMap("expect_non_exist_string")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectNonExistString ExpectNonExistString { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonExpectNonExistString : TeaModel {
                    [NameInMap("expect_non_exist_string")]
                    [Validation(Required=false)]
                    public List<string> ExpectNonExistString { get; set; }

                }

                /// <summary>
                /// <para>The domain name or alias to be parsed.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the TaskType parameter is set to DNS.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dns_server</para>
                /// </summary>
                [NameInMap("expect_value")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                /// <summary>
                /// <para>The packet loss rate.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the TaskType parameter is set to PING.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("failure_rate")]
                [Validation(Required=false)]
                public float? FailureRate { get; set; }

                /// <summary>
                /// <para>The header of the HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey:testValue</para>
                /// </summary>
                [NameInMap("header")]
                [Validation(Required=false)]
                public string Header { get; set; }

                /// <summary>
                /// <para>The number of hops to perform traceroute diagnostics if the PING task fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("hops")]
                [Validation(Required=false)]
                public int? Hops { get; set; }

                /// <summary>
                /// <para>The custom hosts for the HTTP test task. Format: ip1,ip2:address. You can specify values in multiple lines. Specify the A record or CNAME record that can be resolved by the domain name at the left of the colon. Separate multiple records with commas (,). Specify the domain name at the right of the colon.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1:<a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("host_binding")]
                [Validation(Required=false)]
                public string HostBinding { get; set; }

                /// <summary>
                /// <para>The host binding type. Valid values: 0 and 1. 0 indicates random. 1 indicates polling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("host_binding_type")]
                [Validation(Required=false)]
                public int? HostBindingType { get; set; }

                /// <summary>
                /// <para>The HTTP request method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>get</description></item>
                /// <item><description>post</description></item>
                /// <item><description>head</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>get</para>
                /// </summary>
                [NameInMap("http_method")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                /// <summary>
                /// <para>The timeout period of a PING task that uses ICMP. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("icmp_timeout_millis")]
                [Validation(Required=false)]
                public int? IcmpTimeoutMillis { get; set; }

                /// <summary>
                /// <para>ip_network indicates the network type of the task. Valid values: v4, v6, and auto. Default value: v4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("ip_network")]
                [Validation(Required=false)]
                public string IpNetwork { get; set; }

                /// <summary>
                /// <para>Indicates whether to perform Base64 decoding and then store the password. Valid values: true and false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isBase64Encode")]
                [Validation(Required=false)]
                public string IsBase64Encode { get; set; }

                /// <summary>
                /// <para>Indicates whether the alert rule is included. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: The alert rule is included.</description></item>
                /// <item><description>1: The alert rule is excluded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("match_rule")]
                [Validation(Required=false)]
                public int? MatchRule { get; set; }

                /// <summary>
                /// <para>The minimum TLS version. By default, TLS 1.2 and later versions are supported. TLS 1.0 and 1.1 are disabled. If you still require TLS 1.0 or 1.1, you can change the configuration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tlsv1.2</para>
                /// </summary>
                [NameInMap("min_tls_version")]
                [Validation(Required=false)]
                public string MinTlsVersion { get; set; }

                /// <summary>
                /// <para>The password of the SMTP, POP3, or FTP protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123****</para>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The heartbeat of the PING protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("ping_num")]
                [Validation(Required=false)]
                public int? PingNum { get; set; }

                /// <summary>
                /// <para>The port number for TCP pings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ping_port")]
                [Validation(Required=false)]
                public int? PingPort { get; set; }

                /// <summary>
                /// <para>The PING protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>icmp</description></item>
                /// <item><description>tcp</description></item>
                /// <item><description>udp</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>icmp,tcp,udp</para>
                /// </summary>
                [NameInMap("ping_type")]
                [Validation(Required=false)]
                public string PingType { get; set; }

                /// <summary>
                /// <para>The port number of the TCP, UDP, SMTP, or POP3 protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cert.pem</para>
                /// </summary>
                [NameInMap("private_crt_file_name")]
                [Validation(Required=false)]
                public string PrivateCrtFileName { get; set; }

                /// <summary>
                /// <para>The protocol that is used to send the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Indicates whether the Quick UDP Internet Connections (QUIC) protocol is used for browser detection. Valid values: true false Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("quic_enabled")]
                [Validation(Required=false)]
                public bool? QuicEnabled { get; set; }

                /// <summary>
                /// <para>The sites for which the QUIC protocol is forcibly used.</para>
                /// </summary>
                [NameInMap("quic_target")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonQuicTarget QuicTarget { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonQuicTarget : TeaModel {
                    [NameInMap("quic_target")]
                    [Validation(Required=false)]
                    public List<string> QuicTarget { get; set; }

                }

                /// <summary>
                /// <para>The content of the HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aa=bb</para>
                /// </summary>
                [NameInMap("request_content")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

                /// <summary>
                /// <para>The format of the HTTP request. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hex: hexadecimal</description></item>
                /// <item><description>txt: text</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("request_format")]
                [Validation(Required=false)]
                public string RequestFormat { get; set; }

                /// <summary>
                /// <para>The response to the HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("response_content")]
                [Validation(Required=false)]
                public string ResponseContent { get; set; }

                /// <summary>
                /// <para>The format of the HTTP response. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hex: hexadecimal</description></item>
                /// <item><description>txt: text</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("response_format")]
                [Validation(Required=false)]
                public string ResponseFormat { get; set; }

                /// <summary>
                /// <para>The number of retries for failed detections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("retry_delay")]
                [Validation(Required=false)]
                public int? RetryDelay { get; set; }

                [NameInMap("safe_link")]
                [Validation(Required=false)]
                public int? SafeLink { get; set; }

                /// <summary>
                /// <para>Indicates whether page screenshot is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("screen_shot")]
                [Validation(Required=false)]
                public bool? ScreenShot { get; set; }

                /// <summary>
                /// <para>Indicates whether to scroll to the bottom of the page after opening the page. This parameter is valid for a browser test task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("scroll_end")]
                [Validation(Required=false)]
                public bool? ScrollEnd { get; set; }

                [NameInMap("steps")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonSteps Steps { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonSteps : TeaModel {
                    [NameInMap("steps")]
                    [Validation(Required=false)]
                    public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsSteps> Steps { get; set; }
                    public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsSteps : TeaModel {
                        [NameInMap("allow_failure")]
                        [Validation(Required=false)]
                        public bool? AllowFailure { get; set; }

                        [NameInMap("auto_extract_cookie")]
                        [Validation(Required=false)]
                        public bool? AutoExtractCookie { get; set; }

                        [NameInMap("extracted_variables")]
                        [Validation(Required=false)]
                        public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsStepsExtractedVariables ExtractedVariables { get; set; }
                        public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsStepsExtractedVariables : TeaModel {
                            [NameInMap("extracted_variables")]
                            [Validation(Required=false)]
                            public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsStepsExtractedVariablesExtractedVariables> ExtractedVariables { get; set; }
                            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsStepsExtractedVariablesExtractedVariables : TeaModel {
                                [NameInMap("extracted_type")]
                                [Validation(Required=false)]
                                public string ExtractedType { get; set; }

                                [NameInMap("field")]
                                [Validation(Required=false)]
                                public string Field { get; set; }

                                [NameInMap("name")]
                                [Validation(Required=false)]
                                public string Name { get; set; }

                                [NameInMap("parser")]
                                [Validation(Required=false)]
                                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsStepsExtractedVariablesExtractedVariablesParser Parser { get; set; }
                                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonStepsStepsExtractedVariablesExtractedVariablesParser : TeaModel {
                                    [NameInMap("parser_type")]
                                    [Validation(Required=false)]
                                    public string ParserType { get; set; }

                                    [NameInMap("value")]
                                    [Validation(Required=false)]
                                    public string Value { get; set; }

                                }

                            }

                        }

                        [NameInMap("is_critical")]
                        [Validation(Required=false)]
                        public bool? IsCritical { get; set; }

                        /// <term><b>Obsolete</b></term>
                        [NameInMap("name")]
                        [Validation(Required=false)]
                        [Obsolete]
                        public string Name { get; set; }

                        [NameInMap("option")]
                        [Validation(Required=false)]
                        public string Option { get; set; }

                        [NameInMap("step_name")]
                        [Validation(Required=false)]
                        public string StepName { get; set; }

                        [NameInMap("step_type")]
                        [Validation(Required=false)]
                        public string StepType { get; set; }

                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                        [NameInMap("use_generated_cookie")]
                        [Validation(Required=false)]
                        public bool? UseGeneratedCookie { get; set; }

                        [NameInMap("wait_time_in_secs")]
                        [Validation(Required=false)]
                        public int? WaitTimeInSecs { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether to allow the loading failures of some page elements. Valid values: false and true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("strict_mode")]
                [Validation(Required=false)]
                public bool? StrictMode { get; set; }

                /// <summary>
                /// <para>The timeout period. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("time_out")]
                [Validation(Required=false)]
                public long? TimeOut { get; set; }

                [NameInMap("trace_region")]
                [Validation(Required=false)]
                public string TraceRegion { get; set; }

                [NameInMap("trace_type")]
                [Validation(Required=false)]
                public string TraceType { get; set; }

                /// <summary>
                /// <para>The traffic hijacking blacklist. When redirection occurs, if the URL of the resource loaded by the browser matches the expression in the blacklist, traffic hijacking is considered to have occurred.</para>
                /// </summary>
                [NameInMap("traffic_hijack_element_blacklist")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementBlacklist TrafficHijackElementBlacklist { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementBlacklist : TeaModel {
                    [NameInMap("traffic_hijack_element_blacklist")]
                    [Validation(Required=false)]
                    public List<string> TrafficHijackElementBlacklist { get; set; }

                }

                /// <summary>
                /// <para>When redirection occurs, if the browser loads more than the specified number of resources, traffic hijacking is considered to have occurred. If you set the value to 0, no validation is performed. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("traffic_hijack_element_count")]
                [Validation(Required=false)]
                public int? TrafficHijackElementCount { get; set; }

                /// <summary>
                /// <para>The traffic hijacking whitelist. When redirection occurs, if the URL of the resource loaded by the browser does not match any expression in the whitelist, traffic hijacking is considered to have occurred.</para>
                /// </summary>
                [NameInMap("traffic_hijack_element_whitelist")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementWhitelist TrafficHijackElementWhitelist { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementWhitelist : TeaModel {
                    [NameInMap("traffic_hijack_element_whitelist")]
                    [Validation(Required=false)]
                    public List<string> TrafficHijackElementWhitelist { get; set; }

                }

                [NameInMap("use_private_crt")]
                [Validation(Required=false)]
                public bool? UsePrivateCrt { get; set; }

                /// <summary>
                /// <para>The username of the FTP, SMTP, or POP3 protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUser</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>The additional waiting time after a page is opened in a browser test task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("waitTime_after_completion")]
                [Validation(Required=false)]
                public int? WaitTimeAfterCompletion { get; set; }

            }

            /// <summary>
            /// <para>The ID of the site monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc641dff-c19d-45f3-ad0a-818a0c4f****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The name of the site monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test123</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The status of the site monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The task is enabled.</description></item>
            /// <item><description>2: The task is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// <para>The protocol that is used by the site monitoring task. Valid values: HTTP, HTTPS, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The VPC configurations of the synthetic test task.</para>
            /// </summary>
            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsVpcConfig VpcConfig { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsVpcConfig : TeaModel {
                /// <summary>
                /// <para>The region of the website for synthetic monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the security group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxxx</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC used by the synthetic test task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch used by the synthetic test task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xxxxxx</para>
                /// </summary>
                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
