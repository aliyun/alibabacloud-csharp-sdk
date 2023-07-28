// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorListResponseBody : TeaModel {
        /// <summary>
        /// The numeric value or character used for matching.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the DNS server of the carrier is used.
        /// 
        /// *   true (default value): The DNS server of the carrier is used.
        /// *   false: The DNS server of the carrier is not used. The default DNS server or the specified DNS server is used.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Indicates whether the alert rule is included. Valid values:
        /// 
        /// *   0: The alert rule is included.
        /// *   1: The alert rule is not included.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The domain name or IP address of the DNS server.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Indicates whether ping requests are automatically sent to detect network latency if a detection task fails. Valid values:
        /// 
        /// *   false (default value): Ping requests are not automatically sent to detect network latency if a detection task fails.
        /// *   true: Ping requests are automatically sent to detect network latency if a detection task fails.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The type of the assertion. Valid values:
        /// 
        /// *   response_time: checks whether the response time meets expectations.
        /// *   status_code: checks whether the HTTP status code meets expectations.
        /// *   header: checks whether the fields in the response header meet expectations.
        /// *   body_text: checks whether the content in the response body meets expectations by using text matching.
        /// *   body_json: checks whether the content in the response body meets expectations by using JSON parsing (JSONPath).
        /// *   body_xml: checks whether the content in the response body meets expectations by using XML parsing (XPath).
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
                /// The site monitoring tasks that are returned.
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("AgentGroup")]
                [Validation(Required=false)]
                public string AgentGroup { get; set; }

                /// <summary>
                /// The keyword to be matched.
                /// 
                /// >  You can search for tasks by name or address. Fuzzy search is supported.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The protocol type of DNS detection. Valid values:
                /// 
                /// *   udp (default value)
                /// *   tcp
                /// *   tcp-tls
                /// </summary>
                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                /// <summary>
                /// The number of the page to return. Default value: 1.
                /// </summary>
                [NameInMap("OptionsJson")]
                [Validation(Required=false)]
                public DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson OptionsJson { get; set; }
                public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson : TeaModel {
                    /// <summary>
                    /// The header of the HTTP request. An HTTP header is a key-value pair in which the key and the value are separated by a colon (:). The format is `key1:value1`. Each HTTP header occupies a line.
                    /// </summary>
                    [NameInMap("acceptable_response_code")]
                    [Validation(Required=false)]
                    public string AcceptableResponseCode { get; set; }

                    /// <summary>
                    /// The number of retries after a DNS failure occurred.
                    /// </summary>
                    [NameInMap("assertions")]
                    [Validation(Required=false)]
                    public DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertions Assertions { get; set; }
                    public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertions : TeaModel {
                        [NameInMap("assertions")]
                        [Validation(Required=false)]
                        public List<DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertionsAssertions> Assertions { get; set; }
                        public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJsonAssertionsAssertions : TeaModel {
                            [NameInMap("operator")]
                            [Validation(Required=false)]
                            public string Operator { get; set; }

                            /// <summary>
                            /// The relationship between the list of expected aliases or IP addresses and the list of DNS results. Valid values:
                            /// 
                            /// *   IN_DNS: The list of expected values is a subset of the list of DNS results.
                            /// *   DNS_IN: The list of DNS results is a subset of the list of expected values.
                            /// *   EQUAL: The list of DNS results is the same as the list of expected values.
                            /// *   ANY: The list of DNS results intersects with the list of expected values.
                            /// </summary>
                            [NameInMap("property")]
                            [Validation(Required=false)]
                            public string Property { get; set; }

                            [NameInMap("target")]
                            [Validation(Required=false)]
                            public string Target { get; set; }

                            /// <summary>
                            /// For more information about common request parameters, see [Common parameters](~~199331~~).
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public string Type { get; set; }

                        }

                    }

                    /// <summary>
                    /// The username of the FTP, SMTP, or POP3 protocol.
                    /// </summary>
                    [NameInMap("attempts")]
                    [Validation(Required=false)]
                    public long? Attempts { get; set; }

                    /// <summary>
                    /// The status of the task. Valid values:
                    /// 
                    /// *   1: The task is enabled.
                    /// *   2: The task is disabled.
                    /// </summary>
                    [NameInMap("authentication")]
                    [Validation(Required=false)]
                    public int? Authentication { get; set; }

                    /// <summary>
                    /// The page number of the returned page.
                    /// </summary>
                    [NameInMap("cert_verify")]
                    [Validation(Required=false)]
                    public bool? CertVerify { get; set; }

                    /// <summary>
                    /// The returned message.
                    /// </summary>
                    [NameInMap("cookie")]
                    [Validation(Required=false)]
                    public string Cookie { get; set; }

                    /// <summary>
                    /// The extended options of the site monitoring task. The options vary based on the specified protocol. For more information, see [CreateSiteMonitor](~~115048~~).
                    /// </summary>
                    [NameInMap("diagnosis_mtr")]
                    [Validation(Required=false)]
                    public bool? DiagnosisMtr { get; set; }

                    /// <summary>
                    /// The cookie of the HTTP request.
                    /// </summary>
                    [NameInMap("diagnosis_ping")]
                    [Validation(Required=false)]
                    public bool? DiagnosisPing { get; set; }

                    /// <summary>
                    /// The URL or IP address that is monitored by the site monitoring task.
                    /// </summary>
                    [NameInMap("dns_match_rule")]
                    [Validation(Required=false)]
                    public string DnsMatchRule { get; set; }

                    /// <summary>
                    /// Indicates whether the certificate is verified. Valid values:
                    /// 
                    /// *   false (default value): The certificate is not verified.
                    /// *   true: The certificate is verified.
                    /// </summary>
                    [NameInMap("dns_server")]
                    [Validation(Required=false)]
                    public string DnsServer { get; set; }

                    /// <summary>
                    /// Indicates whether the password is decoded by using the Base64 algorithm. Valid values:
                    /// 
                    /// *   true: The password is decoded by using the Base64 algorithm.
                    /// *   false (default value): The password is not decoded by using the Base64 algorithm.
                    /// </summary>
                    [NameInMap("dns_type")]
                    [Validation(Required=false)]
                    public string DnsType { get; set; }

                    /// <summary>
                    /// The format of the HTTP request. Valid values:
                    /// 
                    /// *   hex: hexadecimal
                    /// *   txt: text
                    /// </summary>
                    [NameInMap("enable_operator_dns")]
                    [Validation(Required=false)]
                    public bool? EnableOperatorDns { get; set; }

                    /// <summary>
                    /// The response to the HTTP request.
                    /// 
                    /// *   Hexadecimal format: If the request content is a byte string and cannot be represented in printable characters, you can convert the byte string to printable characters in the hexadecimal format. If you convert the byte string to printable characters in the hexadecimal format, one byte is converted to two hexadecimal characters. For example, (byte)1 is converted to `01` and (byte)27 is converted to `1B`. If the request content is a binary array in the Java format, for example, `{(byte)1, (byte)27}`, you can convert the binary array to `011b` or `011B`. Hexadecimal characters are not case-sensitive in site monitoring tasks. You can enter `011B` in the request content and set the request_format parameter to hex.
                    /// *   Text format: Common text refers to strings that consist of printable characters.
                    /// </summary>
                    [NameInMap("failure_rate")]
                    [Validation(Required=false)]
                    public float? FailureRate { get; set; }

                    /// <summary>
                    /// The number of entries to return on each page. Default value: 10.
                    /// </summary>
                    [NameInMap("header")]
                    [Validation(Required=false)]
                    public string Header { get; set; }

                    /// <summary>
                    /// The status of the task. Valid values:
                    /// 
                    /// *   1: The task is enabled.
                    /// *   2: The task is disabled.
                    /// </summary>
                    [NameInMap("http_method")]
                    [Validation(Required=false)]
                    public string HttpMethod { get; set; }

                    /// <summary>
                    /// The time when the site monitoring task was created.
                    /// </summary>
                    [NameInMap("isBase64Encode")]
                    [Validation(Required=false)]
                    public string IsBase64Encode { get; set; }

                    /// <summary>
                    /// The assertions.
                    /// </summary>
                    [NameInMap("match_rule")]
                    [Validation(Required=false)]
                    public int? MatchRule { get; set; }

                    /// <summary>
                    /// The number of entries returned per page.
                    /// </summary>
                    [NameInMap("password")]
                    [Validation(Required=false)]
                    public string Password { get; set; }

                    /// <summary>
                    /// The protocol that is used by the site monitoring task. Valid values: HTTP, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.
                    /// </summary>
                    [NameInMap("ping_num")]
                    [Validation(Required=false)]
                    public int? PingNum { get; set; }

                    /// <summary>
                    /// The interval at which detection requests are sent. Unit: minutes.
                    /// </summary>
                    [NameInMap("port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The name of the site monitoring task.
                    /// </summary>
                    [NameInMap("protocol")]
                    [Validation(Required=false)]
                    public string Protocol { get; set; }

                    /// <summary>
                    /// The ID of the site monitoring task.
                    /// </summary>
                    [NameInMap("proxy_protocol")]
                    [Validation(Required=false)]
                    public bool? ProxyProtocol { get; set; }

                    /// <summary>
                    /// The format of the HTTP response. Valid values:
                    /// 
                    /// *   hex: hexadecimal
                    /// *   txt: text
                    /// </summary>
                    [NameInMap("request_content")]
                    [Validation(Required=false)]
                    public string RequestContent { get; set; }

                    /// <summary>
                    /// The acceptable status code.
                    /// 
                    /// >  We recommend that you configure assertions.
                    /// </summary>
                    [NameInMap("request_format")]
                    [Validation(Required=false)]
                    public string RequestFormat { get; set; }

                    /// <summary>
                    /// The total number of returned entries.
                    /// </summary>
                    [NameInMap("response_content")]
                    [Validation(Required=false)]
                    public string ResponseContent { get; set; }

                    /// <summary>
                    /// The port number of the TCP, UDP, SMTP, or POP3 protocol.
                    /// </summary>
                    [NameInMap("response_format")]
                    [Validation(Required=false)]
                    public string ResponseFormat { get; set; }

                    /// <summary>
                    /// The ID of the request.
                    /// </summary>
                    [NameInMap("retry_delay")]
                    [Validation(Required=false)]
                    public int? RetryDelay { get; set; }

                    /// <summary>
                    /// The password of the SMTP, POP3, or FTP protocol.
                    /// </summary>
                    [NameInMap("time_out")]
                    [Validation(Required=false)]
                    public long? TimeOut { get; set; }

                    /// <summary>
                    /// Indicates whether the PROXY protocol is enabled. Valid values:
                    /// 
                    /// *   false (default value): The PROXY protocol is disabled.
                    /// *   true: The PROXY protocol is enabled.
                    /// </summary>
                    [NameInMap("unfollow_redirect")]
                    [Validation(Required=false)]
                    public bool? UnfollowRedirect { get; set; }

                    /// <summary>
                    /// The type of the DNS record. This parameter is returned only if the TaskType parameter is set to DNS. Valid values:
                    /// 
                    /// *   A (default value): a record that specifies an IP address related to the specified host name or domain name.
                    /// *   CNAME: a record that maps multiple domain names to a domain name.
                    /// *   NS: a record that specifies a DNS server used to parse domain names.
                    /// *   MX: a record that links domain names to the address of a mail server.
                    /// *   TXT: a record that stores the text information of host name or domain names. The text must be 1 to 512 bytes in length. The TXT record serves as a Sender Policy Framework (SPF) record to fight against spam.
                    /// *   AAAA: a record that maps a domain name to the relevant IPv6 address.
                    /// </summary>
                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                /// <summary>
                /// The HTTP request method. Valid values:
                /// 
                /// *   get
                /// *   post
                /// *   head
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                /// <summary>
                /// The number of times a failed detection request is retried.
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// Indicates whether MTR is automatically used to diagnose network issues if a task fails. Valid values:
                /// 
                /// *   false (default value): MTR is not automatically used to diagnose network issues if a task fails.
                /// *   true: MTR is automatically used to diagnose network issues if a task fails.
                /// </summary>
                [NameInMap("TaskState")]
                [Validation(Required=false)]
                public string TaskState { get; set; }

                /// <summary>
                /// The protocol that is used by the site monitoring task. Valid values: HTTP, PING, TCP, UDP, DNS, SMTP, POP3, and FTP.
                /// </summary>
                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                /// <summary>
                /// The packet loss rate.
                /// 
                /// >  This parameter is returned only if the TaskType parameter is set to PING.
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// The comparison operator of the assertion. Valid values:
        /// 
        /// *   contains: contains
        /// *   doesNotContain: does not contain
        /// *   matches: matches regular expressions
        /// *   doesNotMatch: does not match regular expressions
        /// *   is: equal to a numeric value or matches a character
        /// *   isNot: not equal to
        /// *   lessThan: less than
        /// *   moreThan: greater than
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// Indicates whether redirects are followed if the status code 301 or 302 is returned. Valid values:
        /// 
        /// *   true: Redirects are not followed.
        /// *   false (default value): Redirects are followed.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
