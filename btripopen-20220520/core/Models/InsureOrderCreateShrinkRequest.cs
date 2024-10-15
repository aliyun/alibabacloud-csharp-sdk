// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderCreateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string ApplicantShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20202109390122</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ins_person_and_segment_list")]
        [Validation(Required=false)]
        public string InsPersonAndSegmentListShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostalSavingsBank</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100000320302020</para>
        /// </summary>
        [NameInMap("out_ins_order_id")]
        [Validation(Required=false)]
        public string OutInsOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
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
        /// <b>Example:</b>
        /// <para>fliggy</para>
        /// </summary>
        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

    }

}
