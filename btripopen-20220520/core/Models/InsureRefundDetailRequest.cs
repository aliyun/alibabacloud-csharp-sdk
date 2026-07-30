// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureRefundDetailRequest : TeaModel {
        /// <summary>
        /// <para>The refund application number. At least one of the following parameters is required: insurance order ID, external refund application ID, or refund application number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1423052318072952023</para>
        /// </summary>
        [NameInMap("apply_id")]
        [Validation(Required=false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// <para>The business travel user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The insurance order ID. At least one of the following parameters is required: insurance order ID, external refund application ID, or refund application number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000003000000490</para>
        /// </summary>
        [NameInMap("ins_order_id")]
        [Validation(Required=false)]
        public string InsOrderId { get; set; }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostalSavingsBank</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The external refund application ID. At least one of the following parameters is required: insurance order ID, external refund application ID, or refund application number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1021000196440356908</para>
        /// </summary>
        [NameInMap("out_apply_id")]
        [Validation(Required=false)]
        public string OutApplyId { get; set; }

        /// <summary>
        /// <para>The supplier code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fliggy</para>
        /// </summary>
        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

    }

}
