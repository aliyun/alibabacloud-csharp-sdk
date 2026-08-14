// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ModelRouterTransferToMemberRequest : TeaModel {
        /// <summary>
        /// <para>The transfer amount.</para>
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
        /// <item><description>permanent</description></item>
        /// <item><description>monthly</description></item>
        /// </list>
        /// <para>Default value: permanent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>The idempotency key. UUID v4 format is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550e8400-e29b-41d4-a716-446655440000</para>
        /// </summary>
        [NameInMap("idempotencyKey")]
        [Validation(Required=false)]
        public string IdempotencyKey { get; set; }

        /// <summary>
        /// <para>The monthly refresh quota for monthly-type transfers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("monthlyQuota")]
        [Validation(Required=false)]
        public double? MonthlyQuota { get; set; }

        /// <summary>
        /// <para>The remark for the transfer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Transfer</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
