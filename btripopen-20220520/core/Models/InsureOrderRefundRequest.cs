// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderRefundRequest : TeaModel {
        /// <summary>
        /// <para>The business travel user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000001</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试乘机人</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The custom channel name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostalSavingsBank</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The external cancellation application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1021000196440356908</para>
        /// </summary>
        [NameInMap("out_apply_id")]
        [Validation(Required=false)]
        public string OutApplyId { get; set; }

        /// <summary>
        /// <para>The policy cancellation numbers. Either this parameter or sub-order IDs must be specified.</para>
        /// </summary>
        [NameInMap("policy_no_list")]
        [Validation(Required=false)]
        public List<string> PolicyNoList { get; set; }

        /// <summary>
        /// <para>The sub-order IDs to cancel.</para>
        /// </summary>
        [NameInMap("sub_ins_order_ids")]
        [Validation(Required=false)]
        public List<string> SubInsOrderIds { get; set; }

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
