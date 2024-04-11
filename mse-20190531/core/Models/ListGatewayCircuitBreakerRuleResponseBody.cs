// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListGatewayCircuitBreakerRuleResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListGatewayCircuitBreakerRuleResponseBodyData Data { get; set; }
        public class ListGatewayCircuitBreakerRuleResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListGatewayCircuitBreakerRuleResponseBodyDataResult> Result { get; set; }
            public class ListGatewayCircuitBreakerRuleResponseBodyDataResult : TeaModel {
                [NameInMap("BehaviorType")]
                [Validation(Required=false)]
                public int? BehaviorType { get; set; }

                [NameInMap("BodyEncoding")]
                [Validation(Required=false)]
                public int? BodyEncoding { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public int? Enable { get; set; }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IdList")]
                [Validation(Required=false)]
                public List<long?> IdList { get; set; }

                [NameInMap("LimitMode")]
                [Validation(Required=false)]
                public int? LimitMode { get; set; }

                [NameInMap("MaxAllowedMs")]
                [Validation(Required=false)]
                public int? MaxAllowedMs { get; set; }

                [NameInMap("MinRequestAmount")]
                [Validation(Required=false)]
                public int? MinRequestAmount { get; set; }

                [NameInMap("RecoveryTimeoutSec")]
                [Validation(Required=false)]
                public int? RecoveryTimeoutSec { get; set; }

                [NameInMap("ResponseAdditionalHeaders")]
                [Validation(Required=false)]
                public string ResponseAdditionalHeaders { get; set; }

                [NameInMap("ResponseContentBody")]
                [Validation(Required=false)]
                public string ResponseContentBody { get; set; }

                [NameInMap("ResponseRedirectUrl")]
                [Validation(Required=false)]
                public string ResponseRedirectUrl { get; set; }

                [NameInMap("ResponseStatusCode")]
                [Validation(Required=false)]
                public int? ResponseStatusCode { get; set; }

                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

                [NameInMap("StatDurationSec")]
                [Validation(Required=false)]
                public int? StatDurationSec { get; set; }

                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

                [NameInMap("TriggerRatio")]
                [Validation(Required=false)]
                public int? TriggerRatio { get; set; }

            }

            [NameInMap("Results")]
            [Validation(Required=false)]
            public List<ListGatewayCircuitBreakerRuleResponseBodyDataResults> Results { get; set; }
            public class ListGatewayCircuitBreakerRuleResponseBodyDataResults : TeaModel {
                [NameInMap("BehaviorType")]
                [Validation(Required=false)]
                public int? BehaviorType { get; set; }

                [NameInMap("BodyEncoding")]
                [Validation(Required=false)]
                public int? BodyEncoding { get; set; }

                [NameInMap("Enable")]
                [Validation(Required=false)]
                public int? Enable { get; set; }

                [NameInMap("GatewayId")]
                [Validation(Required=false)]
                public long? GatewayId { get; set; }

                [NameInMap("GatewayUniqueId")]
                [Validation(Required=false)]
                public string GatewayUniqueId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("IdList")]
                [Validation(Required=false)]
                public List<long?> IdList { get; set; }

                [NameInMap("LimitMode")]
                [Validation(Required=false)]
                public int? LimitMode { get; set; }

                [NameInMap("MaxAllowedMs")]
                [Validation(Required=false)]
                public int? MaxAllowedMs { get; set; }

                [NameInMap("MinRequestAmount")]
                [Validation(Required=false)]
                public int? MinRequestAmount { get; set; }

                [NameInMap("RecoveryTimeoutSec")]
                [Validation(Required=false)]
                public int? RecoveryTimeoutSec { get; set; }

                [NameInMap("ResponseAdditionalHeaders")]
                [Validation(Required=false)]
                public string ResponseAdditionalHeaders { get; set; }

                [NameInMap("ResponseContentBody")]
                [Validation(Required=false)]
                public string ResponseContentBody { get; set; }

                [NameInMap("ResponseRedirectUrl")]
                [Validation(Required=false)]
                public string ResponseRedirectUrl { get; set; }

                [NameInMap("ResponseStatusCode")]
                [Validation(Required=false)]
                public int? ResponseStatusCode { get; set; }

                [NameInMap("RouteId")]
                [Validation(Required=false)]
                public long? RouteId { get; set; }

                [NameInMap("RouteName")]
                [Validation(Required=false)]
                public string RouteName { get; set; }

                [NameInMap("StatDurationSec")]
                [Validation(Required=false)]
                public int? StatDurationSec { get; set; }

                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

                [NameInMap("TriggerRatio")]
                [Validation(Required=false)]
                public int? TriggerRatio { get; set; }

            }

            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
