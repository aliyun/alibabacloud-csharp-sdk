// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The balance pool to which the recharge is applied. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>permanent: the permanent balance pool.</description></item>
        /// <item><description>monthly: the monthly balance pool.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>The effective period, in UNIX timestamp (seconds). Range: from 00:00 of today to 00:00 of the first day of the next month (Asia/Shanghai).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1719792000</para>
        /// </summary>
        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public long? EffectiveTime { get; set; }

        /// <summary>
        /// <para>The idempotency key. UUID v4 format without hyphens is recommended. This prevents duplicate subscription creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400e29b41d4a716446655440000</para>
        /// </summary>
        [NameInMap("idempotencyKey")]
        [Validation(Required=false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// <para>The subscription recharge amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("subscriptionAmount")]
        [Validation(Required=false)]
        public double? SubscriptionAmount { get; set; }

    }

}
