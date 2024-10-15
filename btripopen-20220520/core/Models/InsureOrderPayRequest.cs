// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderPayRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PostalSavingsBank</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>202310101026030</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1020030003332000</para>
        /// </summary>
        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("payment_amount")]
        [Validation(Required=false)]
        public long? PaymentAmount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fliggy</para>
        /// </summary>
        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

    }

}
