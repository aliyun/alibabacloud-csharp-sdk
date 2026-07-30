// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundDetailV2Request : TeaModel {
        /// <summary>
        /// <para>The custom channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>name</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The business travel order ID. Either the business travel order ID or the external order ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002039195025156784</para>
        /// </summary>
        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The distribution external order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1017002195371212121</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The external refund order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002039195025156800</para>
        /// </summary>
        [NameInMap("out_refund_apply_id")]
        [Validation(Required=false)]
        public string OutRefundApplyId { get; set; }

        /// <summary>
        /// <para>The business travel refund order ID. Either the business travel refund order ID or the external refund order ID is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1002039195025156700</para>
        /// </summary>
        [NameInMap("refund_apply_id")]
        [Validation(Required=false)]
        public string RefundApplyId { get; set; }

    }

}
