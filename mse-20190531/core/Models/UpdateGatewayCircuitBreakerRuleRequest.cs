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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BehaviorType")]
        [Validation(Required=false)]
        public int? BehaviorType { get; set; }

        [NameInMap("BodyEncoding")]
        [Validation(Required=false)]
        public int? BodyEncoding { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public int? Enable { get; set; }

        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public long? GatewayId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("MaxAllowedMs")]
        [Validation(Required=false)]
        public int? MaxAllowedMs { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MinRequestAmount")]
        [Validation(Required=false)]
        public int? MinRequestAmount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteId")]
        [Validation(Required=false)]
        public long? RouteId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StatDurationSec")]
        [Validation(Required=false)]
        public int? StatDurationSec { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public int? Strategy { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TriggerRatio")]
        [Validation(Required=false)]
        public int? TriggerRatio { get; set; }

    }

}
