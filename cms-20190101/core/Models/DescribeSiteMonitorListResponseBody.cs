// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A80DB41C-AF6C-50E1-ADB5-66DCBA3D266B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site monitoring tasks that are returned.</para>
        /// </summary>
        [NameInMap("SiteMonitors")]
        [Validation(Required=false)]
        public DescribeSiteMonitorListResponseBodySiteMonitors SiteMonitors { get; set; }
        public class DescribeSiteMonitorListResponseBodySiteMonitors : TeaModel {
            [NameInMap("SiteMonitor")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitor> SiteMonitor { get; set; }
            public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitor : TeaModel {
                /// <summary>
                /// <para>The URL or IP address that is monitored by the site monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://aliyun.com">https://aliyun.com</a></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The detection point type. Valid values:</para>
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
                /// <para>The time when the site monitoring task was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-01 11:05:18</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The interval at which detection requests are sent. Unit: minutes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// <para>The extended options of the site monitoring task. The options vary based on the specified protocol. For more information, see <a href="https://help.aliyun.com/document_detail/115048.html">CreateSiteMonitor</a>.</para>
                /// </summary>
                [NameInMap("OptionsJson")]
                [Validation(Required=false)]
                public DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson OptionsJson { get; set; }
                public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson : TeaModel {
                    /// <summary>
                    /// <para>The acceptable status code.</para>
                    /// <remarks>
                    /// <para> We recommend that you configure assertions.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("acceptable_response_code")]
                    [Validation(Required=false)]
                    public string AcceptableResponseCode { get; set; }

                    /// <summary>
                    /// <para>The assertions.</para>
                    /// </summary>
                    [NameInMap("assertions")]
                    [Validation(Required=false)]
                    public DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertions Assertions { get; set; }
                    public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertions : TeaModel {
                        [NameInMap("assertions")]
                        [Validation(Required=false)]
                        public List<DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertionsAssertions> Assertions { get; set; }
                        public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertionsAssertions : TeaModel {
                            /// <summary>
                            /// <para>The comparison operator of the assertion. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>contains: contains</description></item>
                            /// <item><description>doesNotContain: does not contain</description></item>
                            /// <item><description>matches: matches regular expressions</description></item>
                            /// <item><description>doesNotMatch: does not match regular expressions</description></item>
                            /// <item><description>is: equal to a numeric value or matches a character</description></item>
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
                            /// <para>The parsing path of the assertion.</para>
                            /// <list type="bullet">
                            /// <item><description>If the assertion type is <c>body_json</c>, the path is <c>json path</c>.</description></item>
                            /// <item><description>If the assertion type is <c>body_xml</c>, the path is <c>xml path</c>.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>json path</para>
                            /// </summary>
                            [NameInMap("property")]
                            [Validation(Required=false)]
                            public string Property { get; set; }

                            /// <summary>
                            /// <para>The numeric value or character used for matching.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1000</para>
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
                            /// <item><description>body_text: checks whether the content in the response body meets expectations by using text matching.</description></item>
                            /// <item><description>body_json: checks whether the content in the response body meets expectations by using JSON parsing (JSONPath).</description></item>
                            /// <item><description>body_xml: checks whether the content in the response body meets expectations by using XML parsing (XPath).</description></item>
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

                    /// <summary>
                    /// <para>Indicates whether the security authentication feature is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: The feature is enabled.</description></item>
                    /// <item><description>1: The feature is disabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("authentication")]
                    [Validation(Required=false)]
                    public int? Authentication { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the certificate is verified. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>false (default): The certificate is not verified.</description></item>
                    /// <item><description>true: The certificate is verified.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("cert_verify")]
                    [Validation(Required=false)]
                    public bool? CertVerify { get; set; }

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
                    /// <para>Indicates whether MTR is automatically used to diagnose network issues if a task fails. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>false (default): MTR is not automatically used to diagnose network issues if a task fails.</description></item>
                    /// <item><description>true: MTR is automatically used to diagnose network issues if a task fails.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("diagnosis_mtr")]
                    [Validation(Required=false)]
                    public bool? DiagnosisMtr { get; set; }

                    /// <summary>
                    /// <para>Indicates whether ping requests are automatically sent to detect network latency if a detection task fails. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>false (default): Ping requests are not automatically sent to detect network latency if a detection task fails.</description></item>
                    /// <item><description>true: Ping requests are automatically sent to detect network latency if a detection task fails.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("diagnosis_ping")]
                    [Validation(Required=false)]
                    public bool? DiagnosisPing { get; set; }

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
                    /// <para>The domain name or IP address of the DNS server.</para>
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
                    /// <item><description>AAAA: a record that maps a domain name to the relevant IPv6 address.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>A</para>
                    /// </summary>
                    [NameInMap("dns_type")]
                    [Validation(Required=false)]
                    public string DnsType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the DNS server of the carrier is used.</para>
                    /// <list type="bullet">
                    /// <item><description>true (default): The DNS server of the carrier is used.</description></item>
                    /// <item><description>false: The DNS server of the carrier is not used. The default DNS server or the specified DNS server is used.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("enable_operator_dns")]
                    [Validation(Required=false)]
                    public bool? EnableOperatorDns { get; set; }

                    /// <summary>
                    /// <para>The packet loss rate.</para>
                    /// <remarks>
                    /// <para> This parameter is returned only if the TaskType parameter is set to PING.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("failure_rate")]
                    [Validation(Required=false)]
                    public float? FailureRate { get; set; }

                    /// <summary>
                    /// <para>The header of the HTTP request. An HTTP header is a key-value pair in which the key and the value are separated by a colon (:). The format is <c>key1:value1</c>. Each HTTP header occupies a line.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testKey:testValue</para>
                    /// </summary>
                    [NameInMap("header")]
                    [Validation(Required=false)]
                    public string Header { get; set; }

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
                    /// <para>Indicates whether the password is decoded by using the Base64 algorithm. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: The password is decoded by using the Base64 algorithm.</description></item>
                    /// <item><description>false (default): The password is not decoded by using the Base64 algorithm.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("isBase64Encode")]
                    [Validation(Required=false)]
                    public string IsBase64Encode { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the alert rule is included. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: The alert rule is included.</description></item>
                    /// <item><description>1: The alert rule is not included.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("match_rule")]
                    [Validation(Required=false)]
                    public int? MatchRule { get; set; }

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
                    /// <para>The number of hops for the PING protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("ping_num")]
                    [Validation(Required=false)]
                    public int? PingNum { get; set; }

                    /// <summary>
                    /// <para>The port number of the TCP, UDP, SMTP, or POP3 protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The protocol type of DNS detection. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>udp (default)</description></item>
                    /// <item><description>tcp</description></item>
                    /// <item><description>tcp-tls</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>udp</para>
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the PROXY protocol is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>false (default): The PROXY protocol is disabled.</description></item>
                    /// <item><description>true: The PROXY protocol is enabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("proxy_protocol")]
                    [Validation(Required=false)]
                    public bool? ProxyProtocol { get; set; }

                    /// <summary>
                    /// <para>The content of the HTTP request.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cf0f85</para>
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
                    /// <para>hex</para>
                    /// </summary>
                    [NameInMap("request_format")]
                    [Validation(Required=false)]
                    public string RequestFormat { get; set; }

                    /// <summary>
                    /// <para>The response to the HTTP request.</para>
                    /// <list type="bullet">
                    /// <item><description>Hexadecimal format: If the request content is a byte string and cannot be represented in printable characters, you can convert the byte string to printable characters in the hexadecimal format. If you convert the byte string to printable characters in the hexadecimal format, one byte is converted to two hexadecimal characters. For example, (byte)1 is converted to <c>01</c> and (byte)27 is converted to <c>1B</c>. If the request content is a binary array in the Java format, for example, <c>{(byte)1, (byte)27}</c>, you can convert the binary array to <c>011b</c> or <c>011B</c>. Hexadecimal characters are not case-sensitive in site monitoring tasks. You can enter <c>011B</c> in the request content and set the request_format parameter to hex.</description></item>
                    /// <item><description>Text format: Common text refers to strings that consist of printable characters.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cf0f85</para>
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
                    /// <para>hex</para>
                    /// </summary>
                    [NameInMap("response_format")]
                    [Validation(Required=false)]
                    public string ResponseFormat { get; set; }

                    /// <summary>
                    /// <para>The number of times a failed detection request is retried.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("retry_delay")]
                    [Validation(Required=false)]
                    public int? RetryDelay { get; set; }

                    /// <summary>
                    /// <para>The timeout period. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("time_out")]
                    [Validation(Required=false)]
                    public long? TimeOut { get; set; }

                    /// <summary>
                    /// <para>Indicates whether redirects are followed if the status code 301 or 302 is returned. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Redirects are not followed.</description></item>
                    /// <item><description>false (default): Redirects are followed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("unfollow_redirect")]
                    [Validation(Required=false)]
                    public bool? UnfollowRedirect { get; set; }

                    /// <summary>
                    /// <para>The username of the FTP, SMTP, or POP3 protocol.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testUser</para>
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// <para>The ID of the site monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>f5783760-1b39-4b6b-80e8-453d962a****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// <para>The name of the site monitoring task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>域名检测_example.com.cn</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The task status. Valid values:</para>
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
                /// <para>The protocol that is used by the site monitoring task. Valid values: HTTP, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// <para>The time when the site monitoring task was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-03-08 17:14:31</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

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
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
