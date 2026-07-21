// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateSubscriptionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1719792000</para>
        /// </summary>
        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public long? EffectiveTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>550e8400e29b41d4a716446655440000</para>
        /// </summary>
        [NameInMap("idempotencyKey")]
        [Validation(Required=false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("subscriptionAmount")]
        [Validation(Required=false)]
        public double? SubscriptionAmount { get; set; }

    }

}
