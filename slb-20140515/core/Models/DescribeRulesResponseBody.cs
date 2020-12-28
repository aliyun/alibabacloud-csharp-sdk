// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeRulesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<DescribeRulesResponseBodyRules> Rules { get; set; }
        public class DescribeRulesResponseBodyRules : TeaModel {
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

            [NameInMap("HealthCheckHttpCode")]
            [Validation(Required=false)]
            public string HealthCheckHttpCode { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            [NameInMap("HealthCheckURI")]
            [Validation(Required=false)]
            public string HealthCheckURI { get; set; }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("StickySessionType")]
            [Validation(Required=false)]
            public string StickySessionType { get; set; }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            [NameInMap("ListenerSync")]
            [Validation(Required=false)]
            public string ListenerSync { get; set; }

            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            [NameInMap("CookieTimeout")]
            [Validation(Required=false)]
            public int? CookieTimeout { get; set; }

            [NameInMap("HealthCheckDomain")]
            [Validation(Required=false)]
            public string HealthCheckDomain { get; set; }

            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

            [NameInMap("StickySession")]
            [Validation(Required=false)]
            public string StickySession { get; set; }

            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public string HealthCheck { get; set; }

        }

    }

}
