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
        public DescribeRulesResponseBodyRules Rules { get; set; }
        public class DescribeRulesResponseBodyRules : TeaModel {
            [NameInMap("Rule")]
            [Validation(Required=false)]
            public List<DescribeRulesResponseBodyRulesRule> Rule { get; set; }
            public class DescribeRulesResponseBodyRulesRule : TeaModel {
                public string Cookie { get; set; }
                public int? CookieTimeout { get; set; }
                public string Domain { get; set; }
                public string HealthCheck { get; set; }
                public int? HealthCheckConnectPort { get; set; }
                public string HealthCheckDomain { get; set; }
                public string HealthCheckHttpCode { get; set; }
                public int? HealthCheckInterval { get; set; }
                public int? HealthCheckTimeout { get; set; }
                public string HealthCheckURI { get; set; }
                public int? HealthyThreshold { get; set; }
                public string ListenerSync { get; set; }
                public string RuleId { get; set; }
                public string RuleName { get; set; }
                public string Scheduler { get; set; }
                public string StickySession { get; set; }
                public string StickySessionType { get; set; }
                public int? UnhealthyThreshold { get; set; }
                public string Url { get; set; }
                public string VServerGroupId { get; set; }
            }
        };

    }

}
