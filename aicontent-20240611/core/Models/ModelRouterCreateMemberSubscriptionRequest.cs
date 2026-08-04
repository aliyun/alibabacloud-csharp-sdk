// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateMemberSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>The subscription amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// <para>The balance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>permanent: permanent balance.</description></item>
        /// <item><description>monthly: monthly balance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>monthly</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>The effective period in UNIX timestamp (seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1753858800</para>
        /// </summary>
        [NameInMap("effectiveTime")]
        [Validation(Required=false)]
        public long? EffectiveTime { get; set; }

        /// <summary>
        /// <para>The idempotency key. UUID v4 format is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("idempotencyKey")]
        [Validation(Required=false)]
        public string IdempotencyKey { get; set; }

    }

}
