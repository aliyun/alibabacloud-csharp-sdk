// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderRefundShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1000001</para>
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
        /// <para>1021000196440356908</para>
        /// </summary>
        [NameInMap("out_apply_id")]
        [Validation(Required=false)]
        public string OutApplyId { get; set; }

        [NameInMap("policy_no_list")]
        [Validation(Required=false)]
        public string PolicyNoListShrink { get; set; }

        [NameInMap("sub_ins_order_ids")]
        [Validation(Required=false)]
        public string SubInsOrderIdsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fliggy</para>
        /// </summary>
        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

    }

}
