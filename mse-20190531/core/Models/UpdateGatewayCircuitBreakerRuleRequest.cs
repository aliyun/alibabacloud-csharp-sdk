// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateGatewayCircuitBreakerRuleRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

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

        [NameInMap("MaxAllowedMs")]
        [Validation(Required=false)]
        public int? MaxAllowedMs { get; set; }

        [NameInMap("MinRequestAmount")]
        [Validation(Required=false)]
        public int? MinRequestAmount { get; set; }

        [NameInMap("RecoveryTimeoutSec")]
        [Validation(Required=false)]
        public int? RecoveryTimeoutSec { get; set; }

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

}
