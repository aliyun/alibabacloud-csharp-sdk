// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("corp_refund_price")]
        [Validation(Required=false)]
        public long? CorpRefundPrice { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dis123</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>refu123</para>
        /// </summary>
        [NameInMap("dis_sub_order_id")]
        [Validation(Required=false)]
        public string DisSubOrderId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("display_refund_money")]
        [Validation(Required=false)]
        public string DisplayRefundMoney { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public Dictionary<string, string> Extra { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("is_voluntary")]
        [Validation(Required=false)]
        public int? IsVoluntary { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FlightItem_9966772382</para>
        /// </summary>
        [NameInMap("item_unit_ids")]
        [Validation(Required=false)]
        public string ItemUnitIds { get; set; }

        [NameInMap("passenger_segment_info_list")]
        [Validation(Required=false)]
        public List<FlightRefundApplyRequestPassengerSegmentInfoList> PassengerSegmentInfoList { get; set; }
        public class FlightRefundApplyRequestPassengerSegmentInfoList : TeaModel {
            [NameInMap("flight_no")]
            [Validation(Required=false)]
            public string FlightNo { get; set; }

            [NameInMap("passenger_name")]
            [Validation(Required=false)]
            public string PassengerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1245</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("personal_refund_price")]
        [Validation(Required=false)]
        public long? PersonalRefundPrice { get; set; }

        [NameInMap("reason_detail")]
        [Validation(Required=false)]
        public string ReasonDetail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("reason_type")]
        [Validation(Required=false)]
        public int? ReasonType { get; set; }

        [NameInMap("refund_voucher_info")]
        [Validation(Required=false)]
        public List<string> RefundVoucherInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f9418cd2ce34af49ab0de16fea166d1</para>
        /// </summary>
        [NameInMap("session_id")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total_refund_price")]
        [Validation(Required=false)]
        public long? TotalRefundPrice { get; set; }

    }

}
