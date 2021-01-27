// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorAttributeResponseBody : TeaModel {
        [NameInMap("MetricRules")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodyMetricRules MetricRules { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodyMetricRules : TeaModel {
            [NameInMap("MetricRule")]
            [Validation(Required=false)]
            public List<DescribeSiteMonitorAttributeResponseBodyMetricRulesMetricRule> MetricRule { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodyMetricRulesMetricRule : TeaModel {
                public string MetricName { get; set; }
                public string EvaluationCount { get; set; }
                public string Namespace { get; set; }
                public string OkActions { get; set; }
                public string AlarmActions { get; set; }
                public string Period { get; set; }
                public string RuleName { get; set; }
                public string RuleId { get; set; }
                public string ComparisonOperator { get; set; }
                public string Expression { get; set; }
                public string Dimensions { get; set; }
                public string StateValue { get; set; }
                public string ActionEnable { get; set; }
                public string Level { get; set; }
                public string Threshold { get; set; }
                public string Statistics { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("SiteMonitors")]
        [Validation(Required=false)]
        public DescribeSiteMonitorAttributeResponseBodySiteMonitors SiteMonitors { get; set; }
        public class DescribeSiteMonitorAttributeResponseBodySiteMonitors : TeaModel {
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }
            [NameInMap("OptionJson")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJson OptionJson { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsOptionJson : TeaModel {
                [NameInMap("password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                [NameInMap("request_format")]
                [Validation(Required=false)]
                public string RequestFormat { get; set; }

                [NameInMap("expect_value")]
                [Validation(Required=false)]
                public string ExpectValue { get; set; }

                [NameInMap("response_content")]
                [Validation(Required=false)]
                public string ResponseContent { get; set; }

                [NameInMap("time_out")]
                [Validation(Required=false)]
                public long? TimeOut { get; set; }

                [NameInMap("failure_rate")]
                [Validation(Required=false)]
                public float? FailureRate { get; set; }

                [NameInMap("header")]
                [Validation(Required=false)]
                public string Header { get; set; }

                [NameInMap("cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                [NameInMap("ping_num")]
                [Validation(Required=false)]
                public int? PingNum { get; set; }

                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                [NameInMap("authentication")]
                [Validation(Required=false)]
                public int? Authentication { get; set; }

                [NameInMap("http_method")]
                [Validation(Required=false)]
                public string HttpMethod { get; set; }

                [NameInMap("match_rule")]
                [Validation(Required=false)]
                public int? MatchRule { get; set; }

                [NameInMap("request_content")]
                [Validation(Required=false)]
                public string RequestContent { get; set; }

                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

                [NameInMap("traceroute")]
                [Validation(Required=false)]
                public long? Traceroute { get; set; }

                [NameInMap("response_format")]
                [Validation(Required=false)]
                public string ResponseFormat { get; set; }

                [NameInMap("dns_type")]
                [Validation(Required=false)]
                public string DnsType { get; set; }

                [NameInMap("dns_server")]
                [Validation(Required=false)]
                public string DnsServer { get; set; }

            }
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public string Interval { get; set; }
            [NameInMap("TaskState")]
            [Validation(Required=false)]
            public string TaskState { get; set; }
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }
            [NameInMap("Address")]
            [Validation(Required=false)]
            public string Address { get; set; }
            [NameInMap("IspCities")]
            [Validation(Required=false)]
            public DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCities IspCities { get; set; }
            public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCities : TeaModel {
                [NameInMap("IspCity")]
                [Validation(Required=false)]
                public List<DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCitiesIspCity> IspCity { get; set; }
                public class DescribeSiteMonitorAttributeResponseBodySiteMonitorsIspCitiesIspCity : TeaModel {
                    [NameInMap("CityName")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("City")]
                    [Validation(Required=false)]
                    public string City { get; set; }

                    [NameInMap("IspName")]
                    [Validation(Required=false)]
                    public string IspName { get; set; }

                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public string Isp { get; set; }

                }

            }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }
        };

    }

}
