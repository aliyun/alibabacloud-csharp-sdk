// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundDetailRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>40820102379649052</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("out_refund_apply_id")]
        [Validation(Required=false)]
        public string OutRefundApplyId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("refund_apply_id")]
        [Validation(Required=false)]
        public string RefundApplyId { get; set; }

    }

}
