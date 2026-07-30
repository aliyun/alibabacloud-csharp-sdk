// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderChangeDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>operation success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderChangeDetailResponseBodyModule Module { get; set; }
        public class HotelOrderChangeDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The change order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("change_order_id")]
            [Validation(Required=false)]
            public string ChangeOrderId { get; set; }

            /// <summary>
            /// <para>The change order type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: early checkout.</description></item>
            /// <item><description>1: negotiated refund.</description></item>
            /// <item><description>2: partial room cancellation.</description></item>
            /// <item><description>3: delayed check-in.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("change_type")]
            [Validation(Required=false)]
            public int? ChangeType { get; set; }

            /// <summary>
            /// <para>The enterprise ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open12ih3c8jb8o47v10B4r4josN00</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The distribution order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dis1234</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-07 13:42:49</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-07 13:42:49</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The application reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>因公司原因导致的行程变更</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>无</para>
            /// </summary>
            [NameInMap("remarks")]
            [Validation(Required=false)]
            public string Remarks { get; set; }

            /// <summary>
            /// <para>The room information.</para>
            /// </summary>
            [NameInMap("room_info_list")]
            [Validation(Required=false)]
            public List<HotelOrderChangeDetailResponseBodyModuleRoomInfoList> RoomInfoList { get; set; }
            public class HotelOrderChangeDetailResponseBodyModuleRoomInfoList : TeaModel {
                /// <summary>
                /// <para>The list of cancellation dates.</para>
                /// </summary>
                [NameInMap("cancel_date")]
                [Validation(Required=false)]
                public List<string> CancelDate { get; set; }

                /// <summary>
                /// <para>The room refund information.</para>
                /// </summary>
                [NameInMap("room_daily_refund_infos")]
                [Validation(Required=false)]
                public List<HotelOrderChangeDetailResponseBodyModuleRoomInfoListRoomDailyRefundInfos> RoomDailyRefundInfos { get; set; }
                public class HotelOrderChangeDetailResponseBodyModuleRoomInfoListRoomDailyRefundInfos : TeaModel {
                    /// <summary>
                    /// <para>The check-in date.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-02-10</para>
                    /// </summary>
                    [NameInMap("check_in_date")]
                    [Validation(Required=false)]
                    public string CheckInDate { get; set; }

                    /// <summary>
                    /// <para>The penalty fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>71000</para>
                    /// </summary>
                    [NameInMap("penalty_price")]
                    [Validation(Required=false)]
                    public long? PenaltyPrice { get; set; }

                    /// <summary>
                    /// <para>The daily price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>71000</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public long? Price { get; set; }

                    /// <summary>
                    /// <para>The refund amount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>71000</para>
                    /// </summary>
                    [NameInMap("refund_price")]
                    [Validation(Required=false)]
                    public long? RefundPrice { get; set; }

                }

                /// <summary>
                /// <para>The room number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("room_no")]
                [Validation(Required=false)]
                public int? RoomNo { get; set; }

            }

            /// <summary>
            /// <para>The sales order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1402002197440511306</para>
            /// </summary>
            [NameInMap("sale_order_id")]
            [Validation(Required=false)]
            public string SaleOrderId { get; set; }

            /// <summary>
            /// <para>The source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: user-created.</description></item>
            /// <item><description>1: system-supplemented.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public int? Source { get; set; }

            /// <summary>
            /// <para>The application status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: pending.</description></item>
            /// <item><description>1: approved.</description></item>
            /// <item><description>3: rejected.</description></item>
            /// <item><description>4: refund successful.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2505048378320666</para>
            /// </summary>
            [NameInMap("work_order_id")]
            [Validation(Required=false)]
            public string WorkOrderId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
