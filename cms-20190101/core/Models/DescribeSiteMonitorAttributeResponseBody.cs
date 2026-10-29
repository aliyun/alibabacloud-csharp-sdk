// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <remarks>
        /// <para>A value of 200 indicates success.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("MetricRules")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodyMetricRules MetricRules { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodyMetricRules : TeaModel {
            [NameInMap("MetricRule")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorAttributeResponseBodyMetricRulesMetricRule> MetricRule { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodyMetricRulesMetricRule : TeaModel {
                [NameInMap("ActionEnable")]
                [Validation(Required=false)]
                public string ActionEnable { get; set; }

                [NameInMap("AlarmActions")]
                [Validation(Required=false)]
                public string AlarmActions { get; set; }

                [NameInMap("ComparisonOperator")]
                [Validation(Required=false)]
                public string ComparisonOperator { get; set; }

                [NameInMap("Dimensions")]
                [Validation(Required=false)]
                public string Dimensions { get; set; }

                [NameInMap("EvaluationCount")]
                [Validation(Required=false)]
                public string EvaluationCount { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                [NameInMap("MetricName")]
                [Validation(Required=false)]
                public string MetricName { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("OkActions")]
                [Validation(Required=false)]
                public string OkActions { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                [NameInMap("StateValue")]
                [Validation(Required=false)]
                public string StateValue { get; set; }

                [NameInMap("Statistics")]
                [Validation(Required=false)]
                public string Statistics { get; set; }

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
        /// <para>The details of the monitoring task.</para>
        /// </summary>
        [NameInMap("SiteMonitors")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodySiteMonitors SiteMonitors { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodySiteMonitors : TeaModel {
            /// <summary>
            /// <para>The detection address of the monitoring task.</para>
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
            /// <item><description>PC: Fixed-line network.</description></item>
            /// <item><description>MOBILE: Mobile network.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PC</para>
            /// </summary>
            [NameInMap("AgentGroup")]
            [Validation(Required=false)]
            public string AgentGroup { get; set; }

            /// <summary>
            /// <para>The custom detection period. You can only select a specific time range from Monday to Sunday for detection.</para>
            /// </summary>
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

                /// <summary>
                /// <para>The custom detection end time.
                /// Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("end_hour")]
                [Validation(Required=false)]
                public int? EndHour { get; set; }

                /// <summary>
                /// <para>The custom detection start time.
                /// Unit: hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("start_hour")]
                [Validation(Required=false)]
                public int? StartHour { get; set; }

                /// <summary>
                /// <para>The time zone for the custom detection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>local</para>
                /// </summary>
                [NameInMap("time_zone")]
                [Validation(Required=false)]
                public string TimeZone { get; set; }

            }

            /// <summary>
            /// <para>The interval of the monitoring task. Unit: minutes. Valid values: 1, 5, 15, 30, and 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }

            [NameInMap("IspCities")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCities IspCities { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCities : TeaModel {
                [NameInMap("IspCity")]
                [Validation(Required=false)]
                public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCitiesIspCity> IspCity { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCitiesIspCity : TeaModel {
                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    [NameInMap("CityName")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public string Isp { get; set; }

                    [NameInMap("IspName")]
                    [Validation(Required=false)]
                    public string IspName { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The extended options. Each detection type has different extended options. For more information, see <a href="https://help.aliyun.com/document_detail/115048.html">CreateSiteMonitor</a>.</para>
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
                /// <para>The number of retries after a DNS failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("attempts")]
                [Validation(Required=false)]
                public long? Attempts { get; set; }

                /// <summary>
                /// <para>The authentication information.</para>
                /// </summary>
                [NameInMap("auth_info")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAuthInfo AuthInfo { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonAuthInfo : TeaModel {
                    /// <summary>
                    /// <para>Supported only in multi-step synthetic monitoring. The AccessKey ID used for Alibaba Cloud authentication. We recommend that you store it in an encrypted format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testAk</para>
                    /// </summary>
                    [NameInMap("access_key_id")]
                    [Validation(Required=false)]
                    public string AccessKeyId { get; set; }

                    /// <summary>
                    /// <para>Supported only in multi-step synthetic monitoring. The AccessKey secret used for Alibaba Cloud authentication. We recommend that you store it in an encrypted format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testSk</para>
                    /// </summary>
                    [NameInMap("access_key_secret")]
                    [Validation(Required=false)]
                    public string AccessKeySecret { get; set; }

                    /// <summary>
                    /// <para>Supported only in multi-step synthetic monitoring. The API operation requested when using Alibaba Cloud operations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example_api</para>
                    /// </summary>
                    [NameInMap("api_action")]
                    [Validation(Required=false)]
                    public string ApiAction { get; set; }

                    /// <summary>
                    /// <para>Supported only in multi-step synthetic monitoring. The API version requested when using Alibaba Cloud operations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2019-01-01</para>
                    /// </summary>
                    [NameInMap("api_version")]
                    [Validation(Required=false)]
                    public string ApiVersion { get; set; }

                    /// <summary>
                    /// <para>The OAuth 2.0 authentication style. Valid values: ROA and RPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ROA</para>
                    /// </summary>
                    [NameInMap("auth_style")]
                    [Validation(Required=false)]
                    public string AuthStyle { get; set; }

                    /// <summary>
                    /// <para>The client ID used for client authentication in OAuth 2.0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>client_id</para>
                    /// </summary>
                    [NameInMap("client_id")]
                    [Validation(Required=false)]
                    public string ClientId { get; set; }

                    /// <summary>
                    /// <para>The client secret used for client authentication in OAuth 2.0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>client_secret</para>
                    /// </summary>
                    [NameInMap("client_secret")]
                    [Validation(Required=false)]
                    public string ClientSecret { get; set; }

                    /// <summary>
                    /// <para>The grant type used in OAuth 2.0 authentication. Valid values: client_credentials and password.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>password</para>
                    /// </summary>
                    [NameInMap("grant_type")]
                    [Validation(Required=false)]
                    public string GrantType { get; set; }

                    /// <summary>
                    /// <para>The password used for HTTP Basic Authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_password</para>
                    /// </summary>
                    [NameInMap("password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    /// <summary>
                    /// <para>Supported only in multi-step synthetic monitoring. The region ID requested when using Alibaba Cloud authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
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

                    /// <summary>
                    /// <para>The service name requested when using AWS authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example_service_name</para>
                    /// </summary>
                    [NameInMap("service_name")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                    /// <summary>
                    /// <para>The session token used for AWS authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example_token</para>
                    /// </summary>
                    [NameInMap("session_token")]
                    [Validation(Required=false)]
                    public string SessionToken { get; set; }

                    /// <summary>
                    /// <para>The address of the authentication server in OAuth 2.0.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://www.example.com">https://www.example.com</a></para>
                    /// </summary>
                    [NameInMap("token_url")]
                    [Validation(Required=false)]
                    public string TokenUrl { get; set; }

                    /// <summary>
                    /// <para>The authentication type. Currently, only HTTP Basic Authentication is supported. Valid value: basic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>basic</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>Specifies whether the key is stored in the client cookie during digest authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("use_cookie_session_key")]
                    [Validation(Required=false)]
                    public bool? UseCookieSessionKey { get; set; }

                    /// <summary>
                    /// <para>The username used for HTTP Basic Authentication.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_username</para>
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                    /// <summary>
                    /// <para>Supported only in multi-step synthetic monitoring. Specifies whether the operation involves additional resources when Alibaba Cloud authentication is used in this step.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("with_addon_resources")]
                    [Validation(Required=false)]
                    public bool? WithAddonResources { get; set; }

                }

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

                /// <summary>
                /// <para>Specifies whether to ignore certificate errors. Valid values:</para>
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
                /// <para>The browser monitoring version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Single-page monitoring.</description></item>
                /// <item><description>2: Multi-page monitoring.</description></item>
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
                /// <para>The cookie sent in the HTTP request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>lang=en</para>
                /// </summary>
                [NameInMap("cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable automatic MTR network diagnostics after a task fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: Automatic MTR network diagnostics are disabled.</description></item>
                /// <item><description>true: Automatic MTR network diagnostics are enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("diagnosis_mtr")]
                [Validation(Required=false)]
                public bool? DiagnosisMtr { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable automatic ping network latency detection after a task fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false: Automatic ping network latency detection is disabled.</description></item>
                /// <item><description>true: Automatic ping network latency detection is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("diagnosis_ping")]
                [Validation(Required=false)]
                public bool? DiagnosisPing { get; set; }

                /// <summary>
                /// <para>The DNS hijacking whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.taobao.com:www.taobao.com.danuoyi.tbcache.com">www.taobao.com:www.taobao.com.danuoyi.tbcache.com</a></para>
                /// </summary>
                [NameInMap("dns_hijack_whitelist")]
                [Validation(Required=false)]
                public string DnsHijackWhitelist { get; set; }

                /// <summary>
                /// <para>The DNS matching rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>IN_DNS: The expected aliases or IP addresses are all included in the DNS response.</description></item>
                /// <item><description>DNS_IN: All DNS responses are included in the expected aliases or IP addresses.</description></item>
                /// <item><description>EQUAL: The DNS response is exactly the same as the expected aliases or IP addresses.</description></item>
                /// <item><description>ANY: The DNS response and the expected aliases or IP addresses have an intersection.</description></item>
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
                /// <para>This parameter applies only to DNS monitoring.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.XX.XX</para>
                /// </summary>
                [NameInMap("dns_server")]
                [Validation(Required=false)]
                public string DnsServer { get; set; }

                /// <summary>
                /// <para>The DNS record type. This parameter applies only to DNS monitoring. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>A: Specifies the IP address that corresponds to a hostname or domain name.</description></item>
                /// <item><description>CNAME: Maps multiple domain names to another domain name.</description></item>
                /// <item><description>NS: Specifies the DNS server that resolves a domain name.</description></item>
                /// <item><description>MX: Points a domain name to a mail server address.</description></item>
                /// <item><description>TXT: Provides a description of a hostname or domain name. The text length is limited to 512 bytes. It is typically used as a Sender Policy Framework (SPF) record for anti-spam purposes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("dns_type")]
                [Validation(Required=false)]
                public string DnsType { get; set; }

                /// <summary>
                /// <para>Specifies whether to allow a WebSocket task to return no message or an empty message. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>false (default): No.</description></item>
                /// <item><description>true: Yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("empty_message")]
                [Validation(Required=false)]
                public bool? EmptyMessage { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable packet capture for the task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enable_packet_capture")]
                [Validation(Required=false)]
                public bool? EnablePacketCapture { get; set; }

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
                /// <para>The alias or address to be resolved.</para>
                /// <remarks>
                /// <para>This parameter applies only to DNS monitoring.</para>
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
                /// <para>This parameter applies only to ping monitoring.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("failure_rate")]
                [Validation(Required=false)]
                public float? FailureRate { get; set; }

                /// <summary>
                /// <para>The HTTP request headers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testKey:testValue</para>
                /// </summary>
                [NameInMap("header")]
                [Validation(Required=false)]
                public string Header { get; set; }

                /// <summary>
                /// <para>The number of hops for traceroute diagnostics when a ping task fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("hops")]
                [Validation(Required=false)]
                public int? Hops { get; set; }

                /// <summary>
                /// <para>The custom host for an HTTP task. The format is <c>ip1,ip2:address</c>. You can configure multiple lines of mappings. The left side of the colon contains the A records or CNAMEs to which the domain name can be resolved, separated by commas. The right side of the colon is the domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1:<a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("host_binding")]
                [Validation(Required=false)]
                public string HostBinding { get; set; }

                /// <summary>
                /// <para>The effective method of the custom host. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Random.</description></item>
                /// <item><description>1: Round-robin.</description></item>
                /// </list>
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
                /// <item><description>get </description></item>
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
                /// <para>The timeout period for a single ping in a ping task that uses the ICMP protocol. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3000</para>
                /// </summary>
                [NameInMap("icmp_timeout_millis")]
                [Validation(Required=false)]
                public int? IcmpTimeoutMillis { get; set; }

                /// <summary>
                /// <para>The network type of the task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>v4</description></item>
                /// <item><description>v6</description></item>
                /// <item><description>auto
                /// Default value: v4.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>v4</para>
                /// </summary>
                [NameInMap("ip_network")]
                [Validation(Required=false)]
                public string IpNetwork { get; set; }

                /// <summary>
                /// <para>Specifies whether to decode and store the password in Base64. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The password is decoded and stored in Base64.</description></item>
                /// <item><description>false: The password is not decoded and stored in Base64.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("isBase64Encode")]
                [Validation(Required=false)]
                public string IsBase64Encode { get; set; }

                /// <summary>
                /// <para>Specifies whether to include alert rules. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: Yes.</description></item>
                /// <item><description>1: No.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("match_rule")]
                [Validation(Required=false)]
                public int? MatchRule { get; set; }

                /// <summary>
                /// <para>The maximum TLS version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tlsv1.3</para>
                /// </summary>
                [NameInMap("max_tls_version")]
                [Validation(Required=false)]
                public string MaxTlsVersion { get; set; }

                /// <summary>
                /// <para>The minimum TLS version. By default, TLS 1.2 and later versions are supported. TLS 1.0 and 1.1 are disabled. You can modify the configuration if you still need to support them.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tlsv1.2</para>
                /// </summary>
                [NameInMap("min_tls_version")]
                [Validation(Required=false)]
                public string MinTlsVersion { get; set; }

                /// <summary>
                /// <para>The password for SMTP, POP3, or FTP monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123****</para>
                /// </summary>
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>The number of pings for ping monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("ping_num")]
                [Validation(Required=false)]
                public int? PingNum { get; set; }

                /// <summary>
                /// <para>The ping port. This parameter applies to TCP ping.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ping_port")]
                [Validation(Required=false)]
                public int? PingPort { get; set; }

                /// <summary>
                /// <para>The ping protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>icmp</description></item>
                /// <item><description>tcp</description></item>
                /// <item><description>udp</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>icmp</para>
                /// </summary>
                [NameInMap("ping_type")]
                [Validation(Required=false)]
                public string PingType { get; set; }

                /// <summary>
                /// <para>The port for TCP, UDP, SMTP, or POP3 monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The name of the private certificate file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cert.pem</para>
                /// </summary>
                [NameInMap("private_crt_file_name")]
                [Validation(Required=false)]
                public string PrivateCrtFileName { get; set; }

                /// <summary>
                /// <para>The monitoring protocol.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the QUIC protocol for browser monitoring. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The QUIC protocol is used.</description></item>
                /// <item><description>false: The QUIC protocol is not used.
                /// Default value: false.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
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
                /// <para>The request content for HTTP monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aa=bb</para>
                /// </summary>
                [NameInMap("request_content")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

                /// <summary>
                /// <para>The format of the HTTP request content. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hex: Hexadecimal format.</description></item>
                /// <item><description>txt: Text format.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("request_format")]
                [Validation(Required=false)]
                public string RequestFormat { get; set; }

                /// <summary>
                /// <para>The expected response content to match.</para>
                /// 
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("response_content")]
                [Validation(Required=false)]
                public string ResponseContent { get; set; }

                /// <summary>
                /// <para>The format of the HTTP response content. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>hex: Hexadecimal format.</description></item>
                /// <item><description>txt: Text format.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>txt</para>
                /// </summary>
                [NameInMap("response_format")]
                [Validation(Required=false)]
                public string ResponseFormat { get; set; }

                /// <summary>
                /// <para>The number of retries after a monitoring task fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("retry_delay")]
                [Validation(Required=false)]
                public int? RetryDelay { get; set; }

                /// <summary>
                /// <para>Applies to SMTP tasks. A value of 1 indicates that a secure connection is used. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("safe_link")]
                [Validation(Required=false)]
                public int? SafeLink { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable page screenshots.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("screen_shot")]
                [Validation(Required=false)]
                public bool? ScreenShot { get; set; }

                /// <summary>
                /// <para>Specifies whether to scroll to the bottom of the page after the page is opened in a browser monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("scroll_end")]
                [Validation(Required=false)]
                public bool? ScrollEnd { get; set; }

                /// <summary>
                /// <para>The Server Name Indication (SNI).</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyun.com">www.aliyun.com</a></para>
                /// </summary>
                [NameInMap("server_name")]
                [Validation(Required=false)]
                public string ServerName { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable Server-Sent Events (SSE) monitoring.</para>
                /// </summary>
                [NameInMap("sse")]
                [Validation(Required=false)]
                public bool? Sse { get; set; }

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
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("strict_mode")]
                [Validation(Required=false)]
                public bool? StrictMode { get; set; }

                /// <summary>
                /// <para>The supported cipher suites.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TLS_AES_256_GCM_SHA384</para>
                /// </summary>
                [NameInMap("supported_cipher_suits")]
                [Validation(Required=false)]
                public string SupportedCipherSuits { get; set; }

                /// <summary>
                /// <para>The timeout period. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("time_out")]
                [Validation(Required=false)]
                public long? TimeOut { get; set; }

                /// <summary>
                /// <para>The deployment region of the target application when integrating with the OpenTelemetry edition of Managed Service for Observability.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("trace_region")]
                [Validation(Required=false)]
                public string TraceRegion { get; set; }

                /// <summary>
                /// <para>The tracing protocol used for integration with the OpenTelemetry edition of Tracing Analysis. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>OpenTelemetry</description></item>
                /// <item><description>Zipkin</description></item>
                /// <item><description>Jaeger</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>OpenTelemetry</para>
                /// </summary>
                [NameInMap("trace_type")]
                [Validation(Required=false)]
                public string TraceType { get; set; }

                [NameInMap("traffic_hijack_element_blacklist")]
                [Validation(Required=false)]
                public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementBlacklist TrafficHijackElementBlacklist { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJsonTrafficHijackElementBlacklist : TeaModel {
                    [NameInMap("traffic_hijack_element_blacklist")]
                    [Validation(Required=false)]
                    public List<string> TrafficHijackElementBlacklist { get; set; }

                }

                /// <summary>
                /// <para>When a redirect occurs, traffic hijacking is detected if the number of resources loaded by the browser exceeds this value. If this value is set to 0, no verification is performed. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
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
                /// <para>Specifies whether to use a private certificate.</para>
                /// </summary>
                [NameInMap("use_private_crt")]
                [Validation(Required=false)]
                public bool? UsePrivateCrt { get; set; }

                /// <summary>
                /// <para>Specifies whether to establish an SSL connection when executing a TCP task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tlsv1.0</para>
                /// </summary>
                [NameInMap("use_ssl")]
                [Validation(Required=false)]
                public bool? UseSsl { get; set; }

                /// <summary>
                /// <para>The username for FTP, SMTP, or POP3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testUser</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                /// <summary>
                /// <para>The additional wait time after a page is opened in a browser probing task.</para>
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
            /// <para>The name of the monitoring task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test123</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The status of the monitoring task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Enabled.</description></item>
            /// <item><description>2: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }

            /// <summary>
            /// <para>The type of the monitoring task. Site monitoring tasks support the following types: HTTP(S), PING, TCP, UDP, DNS, SMTP, POP3, and FTP.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The VPC configuration for the internal network probing task.</para>
            /// </summary>
            [NameInMap("VpcConfig")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsVpcConfig VpcConfig { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsVpcConfig : TeaModel {
                /// <summary>
                /// <para>The region where the target site of the internal network probing task is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The ID of the security group applied to the internal network probing task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sg-xxxxxx</para>
                /// </summary>
                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the VPC associated with the internal network probing task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-xxxxxx</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch associated with the internal network probing task.</para>
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
        /// <para>Indicates whether the operation is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Successful.</description></item>
        /// <item><description>false: Failed.</description></item>
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
