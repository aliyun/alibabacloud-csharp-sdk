// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
                public string Address { get; set; }
                public string CreateTime { get; set; }
                public string Interval { get; set; }
                public DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson OptionsJson { get; set; }
                public class DescribeSiteMonitorListResponseBodySiteMonitorsSiteMonitorOptionsJson : TeaModel {
                    [NameInMap("acceptable_response_code")]
                    [Validation(Required=false)]
                    public string AcceptableResponseCode { get; set; }

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

                    [NameInMap("dns_match_rule")]
                    [Validation(Required=false)]
                    public string DnsMatchRule { get; set; }

                    [NameInMap("dns_server")]
                    [Validation(Required=false)]
                    public string DnsServer { get; set; }

                    [NameInMap("dns_type")]
                    [Validation(Required=false)]
                    public string DnsType { get; set; }

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
                public string TaskId { get; set; }
                public string TaskName { get; set; }
                public string TaskState { get; set; }
                public string TaskType { get; set; }
                public string UpdateTime { get; set; }
            }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
