// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPreValidateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderPreValidateResponseBodyModule Module { get; set; }
        public class HotelOrderPreValidateResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("extend_info")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fb5e1abf33924b6c912bd6d80deec0eb-4</para>
            /// </summary>
            [NameInMap("itinerary_no")]
            [Validation(Required=false)]
            public string ItineraryNo { get; set; }

            [NameInMap("promotion_info")]
            [Validation(Required=false)]
            public HotelOrderPreValidateResponseBodyModulePromotionInfo PromotionInfo { get; set; }
            public class HotelOrderPreValidateResponseBodyModulePromotionInfo : TeaModel {
                [NameInMap("ext_attr_map")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtAttrMap { get; set; }

                [NameInMap("promotion_detail_info_list")]
                [Validation(Required=false)]
                public List<HotelOrderPreValidateResponseBodyModulePromotionInfoPromotionDetailInfoList> PromotionDetailInfoList { get; set; }
                public class HotelOrderPreValidateResponseBodyModulePromotionInfoPromotionDetailInfoList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("check_status")]
                    [Validation(Required=false)]
                    public bool? CheckStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("need_check")]
                    [Validation(Required=false)]
                    public bool? NeedCheck { get; set; }

                    [NameInMap("promotion_code")]
                    [Validation(Required=false)]
                    public string PromotionCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12893</para>
                    /// </summary>
                    [NameInMap("promotion_id")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("promotion_name")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("promotion_price")]
                    [Validation(Required=false)]
                    public long? PromotionPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("promotion_type")]
                    [Validation(Required=false)]
                    public string PromotionType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("promotion_total_price")]
                [Validation(Required=false)]
                public long? PromotionTotalPrice { get; set; }

            }

            [NameInMap("rate_plan_daily")]
            [Validation(Required=false)]
            public List<HotelOrderPreValidateResponseBodyModuleRatePlanDaily> RatePlanDaily { get; set; }
            public class HotelOrderPreValidateResponseBodyModuleRatePlanDaily : TeaModel {
                [NameInMap("board")]
                [Validation(Required=false)]
                public string Board { get; set; }

                [NameInMap("discount_price")]
                [Validation(Required=false)]
                public string DiscountPrice { get; set; }

                [NameInMap("max_booking_num")]
                [Validation(Required=false)]
                public int? MaxBookingNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-01-19</para>
                /// </summary>
                [NameInMap("rate_start_time")]
                [Validation(Required=false)]
                public string RateStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("room_count")]
                [Validation(Required=false)]
                public int? RoomCount { get; set; }

                [NameInMap("rounding_discount_price")]
                [Validation(Required=false)]
                public string RoundingDiscountPrice { get; set; }

                [NameInMap("rounding_price")]
                [Validation(Required=false)]
                public string RoundingPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5314280514218</para>
            /// </summary>
            [NameInMap("rate_plan_id")]
            [Validation(Required=false)]
            public long? RatePlanId { get; set; }

            [NameInMap("rate_plan_info")]
            [Validation(Required=false)]
            public HotelOrderPreValidateResponseBodyModuleRatePlanInfo RatePlanInfo { get; set; }
            public class HotelOrderPreValidateResponseBodyModuleRatePlanInfo : TeaModel {
                [NameInMap("bed_desc")]
                [Validation(Required=false)]
                public string BedDesc { get; set; }

                [NameInMap("btrip_hotel_cancel_policy_d_t_o")]
                [Validation(Required=false)]
                public HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTO BtripHotelCancelPolicyDTO { get; set; }
                public class HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTO : TeaModel {
                    [NameInMap("btrip_hotel_cancel_policy_info_d_t_o_list")]
                    [Validation(Required=false)]
                    public List<HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList> BtripHotelCancelPolicyInfoDTOList { get; set; }
                    public class HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("hour")]
                        [Validation(Required=false)]
                        public long? Hour { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public long? Value { get; set; }

                    }

                    [NameInMap("cancel_policy_type")]
                    [Validation(Required=false)]
                    public int? CancelPolicyType { get; set; }

                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("short_desc")]
                    [Validation(Required=false)]
                    public string ShortDesc { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12:00</para>
                /// </summary>
                [NameInMap("earliest_check_in_time")]
                [Validation(Required=false)]
                public string EarliestCheckInTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>17:00</para>
                /// </summary>
                [NameInMap("latest_check_out_time")]
                [Validation(Required=false)]
                public string LatestCheckOutTime { get; set; }

                [NameInMap("max_booking_num")]
                [Validation(Required=false)]
                public int? MaxBookingNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_occupancy_num")]
                [Validation(Required=false)]
                public int? MaxOccupancyNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("need_certificate")]
                [Validation(Required=false)]
                public bool? NeedCertificate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("need_email")]
                [Validation(Required=false)]
                public bool? NeedEmail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("need_english_name")]
                [Validation(Required=false)]
                public bool? NeedEnglishName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("total_order_price")]
                [Validation(Required=false)]
                public long? TotalOrderPrice { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("total_room_price")]
                [Validation(Required=false)]
                public long? TotalRoomPrice { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>nonUltron_1673575241156_d91ea8ad16735752359161037bf6cf_c54d3768312a4b249b719f126377bf82</para>
            /// </summary>
            [NameInMap("validate_res_key")]
            [Validation(Required=false)]
            public string ValidateResKey { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
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
