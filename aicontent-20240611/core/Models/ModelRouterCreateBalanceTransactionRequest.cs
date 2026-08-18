// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterCreateBalanceTransactionRequest : TeaModel {
        /// <summary>
        /// <para>The transaction amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// <para>The target balance pool type. If not specified, the default value is permanent. Valid values: permanent: permanent balance pool (the balance never expires). monthly: monthly balance pool (the balance is automatically cleared at the beginning of each month).</para>
        /// 
        /// <b>Example:</b>
        /// <para>amount</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>The idempotency key. UUID v4 format is recommended. The maximum length is 32 characters. Duplicate submissions with the same key are not executed more than once.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400e29b41d4a716446655440000</para>
        /// </summary>
        [NameInMap("idempotencyKey")]
        [Validation(Required=false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recharge</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The transaction type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recharge</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
