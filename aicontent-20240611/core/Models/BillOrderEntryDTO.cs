// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class BillOrderEntryDTO : TeaModel {
        /// <summary>
        /// <para>The change amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// <para>The balance after the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("balanceAfter")]
        [Validation(Required=false)]
        public double? BalanceAfter { get; set; }

        /// <summary>
        /// <para>The balance before the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.00</para>
        /// </summary>
        [NameInMap("balanceBefore")]
        [Validation(Required=false)]
        public double? BalanceBefore { get; set; }

        /// <summary>
        /// <para>The balance type: permanent/monthly.</para>
        /// 
        /// <b>Example:</b>
        /// <para>permanent</para>
        /// </summary>
        [NameInMap("balanceType")]
        [Validation(Required=false)]
        public string BalanceType { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The change direction: in/out.</para>
        /// 
        /// <b>Example:</b>
        /// <para>in</para>
        /// </summary>
        [NameInMap("direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>The model code (available when gateway billing deduction is applied).</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen-max</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        /// <summary>
        /// <para>The operator ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// <para>The change record ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ord_xxxxxxxx</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The change type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>recharge</para>
        /// </summary>
        [NameInMap("orderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The remark.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Top-up</para>
        /// </summary>
        [NameInMap("remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>console</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The total balance after the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100.00</para>
        /// </summary>
        [NameInMap("totalAfter")]
        [Validation(Required=false)]
        public double? TotalAfter { get; set; }

        /// <summary>
        /// <para>The total balance before the change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.00</para>
        /// </summary>
        [NameInMap("totalBefore")]
        [Validation(Required=false)]
        public double? TotalBefore { get; set; }

    }

}
