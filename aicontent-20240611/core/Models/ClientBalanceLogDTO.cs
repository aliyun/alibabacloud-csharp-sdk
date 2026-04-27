// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ClientBalanceLogDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("balanceAfter")]
        [Validation(Required=false)]
        public double? BalanceAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>90.00</para>
        /// </summary>
        [NameInMap("balanceBefore")]
        [Validation(Required=false)]
        public double? BalanceBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10.00</para>
        /// </summary>
        [NameInMap("changeAmount")]
        [Validation(Required=false)]
        public double? ChangeAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>recharge</para>
        /// </summary>
        [NameInMap("changeType")]
        [Validation(Required=false)]
        public string ChangeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("clientId")]
        [Validation(Required=false)]
        public long? ClientId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>充值</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

    }

}
