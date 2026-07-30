// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightRefundDetailRequest : TeaModel {
        /// <summary>
        /// <para>The business travel order ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002145190081005400</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The external order ID. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40820102379649052</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The external refund or rebooking application ID. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202503251022170001</para>
        /// </summary>
        [NameInMap("out_refund_apply_id")]
        [Validation(Required=false)]
        public string OutRefundApplyId { get; set; }

        /// <summary>
        /// <para>The refund application ID. This parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000004605026</para>
        /// </summary>
        [NameInMap("refund_apply_id")]
        [Validation(Required=false)]
        public string RefundApplyId { get; set; }

    }

}
