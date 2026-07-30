// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderChangeApplyRequest : TeaModel {
        /// <summary>
        /// <para>The external user ID. If organization members have been synchronized, use btripUserId. Otherwise, pass the userId corresponding to the user in the distributor\&quot;s own system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123122</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The distributor order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3685792244476194816</para>
        /// </summary>
        [NameInMap("dis_order_id")]
        [Validation(Required=false)]
        public string DisOrderId { get; set; }

        /// <summary>
        /// <para>The reason for the order modification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>因个人原因导致的行程变更</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The list of rooms to be modified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("room_info_list")]
        [Validation(Required=false)]
        public List<HotelOrderChangeApplyRequestRoomInfoList> RoomInfoList { get; set; }
        public class HotelOrderChangeApplyRequestRoomInfoList : TeaModel {
            /// <summary>
            /// <para>The list of cancellation dates. Currently, only full order cancellation and early checkout are supported. For full order cancellation, pass all check-in dates. For early checkout, pass the dates that will no longer be occupied.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cancel_date")]
            [Validation(Required=false)]
            public List<string> CancelDate { get; set; }

            /// <summary>
            /// <para>The room number.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112</para>
            /// </summary>
            [NameInMap("room_no")]
            [Validation(Required=false)]
            public int? RoomNo { get; set; }

        }

        /// <summary>
        /// <para>The order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1402002197440511306</para>
        /// </summary>
        [NameInMap("sale_order_id")]
        [Validation(Required=false)]
        public string SaleOrderId { get; set; }

    }

}
