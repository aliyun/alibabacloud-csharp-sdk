// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderChangeDetailResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderChangeDetailResponseBodyModule Module { get; set; }
        public class HotelOrderChangeDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("change_order_id")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("change_type")]
            [Validation(Required=false)]
            public int? ChangeType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>open12ih3c8jb8o47v10B4r4josN00</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dis1234</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-07 13:42:49</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-07 13:42:49</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            [NameInMap("room_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderChangeDetailResponseBodyModuleRoomInfoList> RoomInfoList { get; set; }
            public class HotelOrderChangeDetailResponseBodyModuleRoomInfoList : TeaModel {
                [NameInMap("cancel_date")]
                [Validation(Required=false)]
                public List<string> CancelDate { get; set; }

                [NameInMap("room_daily_refund_infos")]
                [Validation(Required=false)]
                public List<HotelOrderChangeDetailResponseBodyModuleRoomInfoListRoomDailyRefundInfos> RoomDailyRefundInfos { get; set; }
                public class HotelOrderChangeDetailResponseBodyModuleRoomInfoListRoomDailyRefundInfos : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-02-10</para>
                    /// </summary>
                    [NameInMap("check_in_date")]
                    [Validation(Required=false)]
                    public string CheckInDate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>71000</para>
                    /// </summary>
                    [NameInMap("penalty_price")]
                    [Validation(Required=false)]
                    public long? PenaltyPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>71000</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>71000</para>
                    /// </summary>
                    [NameInMap("refund_price")]
                    [Validation(Required=false)]
                    public long? RefundPrice { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("room_no")]
                [Validation(Required=false)]
                public int? RoomNo { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1402002197440511306</para>
            /// </summary>
            [NameInMap("sale_order_id")]
            [Validation(Required=false)]
            public string SaleOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public int? Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2505048378320666</para>
            /// </summary>
            [NameInMap("work_order_id")]
            [Validation(Required=false)]
            public string WorkOrderId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
