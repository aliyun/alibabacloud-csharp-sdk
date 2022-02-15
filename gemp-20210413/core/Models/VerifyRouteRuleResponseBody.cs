// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class VerifyRouteRuleResponseBody : TeaModel {
        /// <summary>
        /// 验证结果
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public VerifyRouteRuleResponseBodyData Data { get; set; }
        public class VerifyRouteRuleResponseBodyData : TeaModel {
            [NameInMap("escalationPlans")]
            [Validation(Required=false)]
            public List<VerifyRouteRuleResponseBodyDataEscalationPlans> EscalationPlans { get; set; }
            public class VerifyRouteRuleResponseBodyDataEscalationPlans : TeaModel {
                public long? EscalationPlanId { get; set; }
                public string EscalationPlanName { get; set; }
            }
            [NameInMap("isValidRule")]
            [Validation(Required=false)]
            public bool? IsValidRule { get; set; }
            [NameInMap("monitorSourceIds")]
            [Validation(Required=false)]
            public List<string> MonitorSourceIds { get; set; }
            [NameInMap("notifySubscriptionNames")]
            [Validation(Required=false)]
            public List<VerifyRouteRuleResponseBodyDataNotifySubscriptionNames> NotifySubscriptionNames { get; set; }
            public class VerifyRouteRuleResponseBodyDataNotifySubscriptionNames : TeaModel {
                public long? SubscriptionId { get; set; }
                public string Title { get; set; }
            }
            [NameInMap("routeRuleFailReason")]
            [Validation(Required=false)]
            public List<string> RouteRuleFailReason { get; set; }
            [NameInMap("routeType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
