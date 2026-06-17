// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorListResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The value 200 indicates success.</para>
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

        [NameInMap("SiteMonitors")]
        [Validation(Required=false)]
        public DescribeSiteMonitorListResponseBodySiteMonitors SiteMonitors { get; set; }
        public class DescribeSiteMonitorListResponseBodySiteMonitors : TeaModel {
            [NameInMap("SiteMonitor")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitor> SiteMonitor { get; set; }
            public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitor : TeaModel {
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                [NameInMap("AgentGroup")]
                [Validation(Required=false)]
                public string AgentGroup { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Interval")]
                [Validation(Required=false)]
                public string Interval { get; set; }

                [NameInMap("OptionsJson")]
                [Validation(Required=false)]
                public DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson OptionsJson { get; set; }
                public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson : TeaModel {
                    [NameInMap("acceptable_response_code")]
                    [Validation(Required=false)]
                    public string AcceptableResponseCode { get; set; }

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

                    [NameInMap("cert_verify")]
                    [Validation(Required=false)]
                    public bool? CertVerify { get; set; }

                    [NameInMap("cookie")]
                    [Validation(Required=false)]
                    public string Cookie { get; set; }

                    [NameInMap("diagnosis_mtr")]
                    [Validation(Required=false)]
                    public bool? DiagnosisMtr { get; set; }

                    [NameInMap("diagnosis_ping")]
                    [Validation(Required=false)]
                    public bool? DiagnosisPing { get; set; }

                    [NameInMap("dns_match_rule")]
                    [Validation(Required=false)]
                    public string DnsMatchRule { get; set; }

                    [NameInMap("dns_server")]
                    [Validation(Required=false)]
                    public string DnsServer { get; set; }

                    [NameInMap("dns_type")]
                    [Validation(Required=false)]
                    public string DnsType { get; set; }

                    [NameInMap("enable_operator_dns")]
                    [Validation(Required=false)]
                    public bool? EnableOperatorDns { get; set; }

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

                    [NameInMap("proxy_protocol")]
                    [Validation(Required=false)]
                    public bool? ProxyProtocol { get; set; }

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

                    [NameInMap("unfollow_redirect")]
                    [Validation(Required=false)]
                    public bool? UnfollowRedirect { get; set; }

                    [NameInMap("username")]
                    [Validation(Required=false)]
                    public string Username { get; set; }

                }

                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                [NameInMap("TaskState")]
                [Validation(Required=false)]
                public string TaskState { get; set; }

                [NameInMap("TaskType")]
                [Validation(Required=false)]
                public string TaskType { get; set; }

                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether the operation was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Successful.</para>
        /// </description></item>
        /// <item><description><para>false: Failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
