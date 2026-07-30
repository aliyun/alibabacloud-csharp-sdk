// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BalanceOrderDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>600.00</para>
        /// </summary>
        [NameInMap("balanceAfter")]
        [Validation(Required=false)]
        public double? BalanceAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500.00</para>
        /// </summary>
        [NameInMap("balanceBefore")]
        [Validation(Required=false)]
        public double? BalanceBefore { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-15T10:30:00+08:00</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ord_20240715_abc123</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>recharge</para>
        /// </summary>
        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Administrator manual recharge</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1600.00</para>
        /// </summary>
        [NameInMap("totalAfter")]
        [Validation(Required=false)]
        public double? TotalAfter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1500.00</para>
        /// </summary>
        [NameInMap("totalBefore")]
        [Validation(Required=false)]
        public double? TotalBefore { get; set; }

    }

}
