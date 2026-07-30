// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The enterprise refund amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("corp_refund_price")]
        [Validation(Required=false)]
        public long? CorpRefundPrice { get; set; }

        /// <summary>
        /// <para>The external order ID of the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>The external order ID of the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>refu123</para>
        /// </summary>
        [NameInMap("dis_sub_order_id")]
        [Validation(Required=false)]
        public string DisSubOrderId { get; set; }

        /// <summary>
        /// <para>The refund amount displayed to the user.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("display_refund_money")]
        [Validation(Required=false)]
        public string DisplayRefundMoney { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// </summary>
        [NameInMap("extra")]
        [Validation(Required=false)]
        public string ExtraShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the refund is voluntary.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        /// <summary>
        /// <para>The encrypted order parameter returned by the distribution pre-calculation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlightItem_9966772382</para>
        /// </summary>
        [NameInMap("item_unit_ids")]
        [Validation(Required=false)]
        public string ItemUnitIds { get; set; }

        /// <summary>
        /// <para>The list of passenger segments selected for the refund.</para>
        /// </summary>
        [NameInMap("passenger_segment_info_list")]
        [Validation(Required=false)]
        public string PassengerSegmentInfoListShrink { get; set; }

        /// <summary>
        /// <para>The personal refund amount.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("personal_refund_price")]
        [Validation(Required=false)]
        public long? PersonalRefundPrice { get; set; }

        /// <summary>
        /// <para>The detailed refund reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>分销商自定义</para>
        /// </summary>
        [NameInMap("reason_detail")]
        [Validation(Required=false)]
        public string ReasonDetail { get; set; }

        /// <summary>
        /// <para>The refund reason type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("reason_type")]
        [Validation(Required=false)]
        public int? ReasonType { get; set; }

        /// <summary>
        /// <para>The refund voucher information in JSON format.</para>
        /// </summary>
        [NameInMap("refund_voucher_info")]
        [Validation(Required=false)]
        public string RefundVoucherInfoShrink { get; set; }

        /// <summary>
        /// <para>The session ID returned by the distribution pre-calculation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f9418cd2ce34af49ab0de16fea166d1</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The total refund amount of the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_refund_price")]
        [Validation(Required=false)]
        public long? TotalRefundPrice { get; set; }

    }

}
