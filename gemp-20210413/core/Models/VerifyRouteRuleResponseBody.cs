// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class VerifyRouteRuleResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public VerifyRouteRuleResponseBodyData Data { get; set; }
        public class VerifyRouteRuleResponseBodyData : TeaModel {
            [NameInMap("escalationPlans")]
            [Validation(Required=false)]
            public List<VerifyRouteRuleResponseBodyDataEscalationPlans> EscalationPlans { get; set; }
            public class VerifyRouteRuleResponseBodyDataEscalationPlans : TeaModel {
                [NameInMap("escalationPlanId")]
                [Validation(Required=false)]
                public long? EscalationPlanId { get; set; }

                [NameInMap("escalationPlanName")]
                [Validation(Required=false)]
                public string EscalationPlanName { get; set; }

            }

            [NameInMap("isValidRule")]
            [Validation(Required=false)]
            public bool? IsValidRule { get; set; }

            [NameInMap("monitorSourceIds")]
            [Validation(Required=false)]
            public List<long?> MonitorSourceIds { get; set; }

            [NameInMap("notifySubscriptionNames")]
            [Validation(Required=false)]
            public List<VerifyRouteRuleResponseBodyDataNotifySubscriptionNames> NotifySubscriptionNames { get; set; }
            public class VerifyRouteRuleResponseBodyDataNotifySubscriptionNames : TeaModel {
                [NameInMap("subscriptionId")]
                [Validation(Required=false)]
                public long? SubscriptionId { get; set; }

                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("routeRuleFailReason")]
            [Validation(Required=false)]
            public List<string> RouteRuleFailReason { get; set; }

            [NameInMap("routeType")]
            [Validation(Required=false)]
            public string RouteType { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
