// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelOrderPreValidateResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response body.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelOrderPreValidateResponseBodyModule Module { get; set; }
        public class HotelOrderPreValidateResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The extended attributes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("extend_info")]
            [Validation(Required=false)]
            public string ExtendInfo { get; set; }

            /// <summary>
            /// <para>The invoice information.</para>
            /// </summary>
            [NameInMap("item_invoice")]
            [Validation(Required=false)]
            public HotelOrderPreValidateResponseBodyModuleItemInvoice ItemInvoice { get; set; }
            public class HotelOrderPreValidateResponseBodyModuleItemInvoice : TeaModel {
                /// <summary>
                /// <para>Indicates whether special VAT invoices are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("support_special")]
                [Validation(Required=false)]
                public bool? SupportSpecial { get; set; }

            }

            /// <summary>
            /// <para>The itinerary ID required for the order creation API.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fb5e1abf33924b6c912bd6d80deec0eb-4</para>
            /// </summary>
            [NameInMap("itinerary_no")]
            [Validation(Required=false)]
            public string ItineraryNo { get; set; }

            /// <summary>
            /// <para>The promotion information.</para>
            /// </summary>
            [NameInMap("promotion_info")]
            [Validation(Required=false)]
            public HotelOrderPreValidateResponseBodyModulePromotionInfo PromotionInfo { get; set; }
            public class HotelOrderPreValidateResponseBodyModulePromotionInfo : TeaModel {
                /// <summary>
                /// <para>The extended attributes.</para>
                /// </summary>
                [NameInMap("ext_attr_map")]
                [Validation(Required=false)]
                public Dictionary<string, string> ExtAttrMap { get; set; }

                /// <summary>
                /// <para>The promotion information.</para>
                /// </summary>
                [NameInMap("promotion_detail_info_list")]
                [Validation(Required=false)]
                public List<HotelOrderPreValidateResponseBodyModulePromotionInfoPromotionDetailInfoList> PromotionDetailInfoList { get; set; }
                public class HotelOrderPreValidateResponseBodyModulePromotionInfoPromotionDetailInfoList : TeaModel {
                    /// <summary>
                    /// <para>The selection status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("check_status")]
                    [Validation(Required=false)]
                    public bool? CheckStatus { get; set; }

                    /// <summary>
                    /// <para>Indicates whether selection is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("need_check")]
                    [Validation(Required=false)]
                    public bool? NeedCheck { get; set; }

                    /// <summary>
                    /// <para>The promotion code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>wjdj11</para>
                    /// </summary>
                    [NameInMap("promotion_code")]
                    [Validation(Required=false)]
                    public string PromotionCode { get; set; }

                    /// <summary>
                    /// <para>The promotion ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12893</para>
                    /// </summary>
                    [NameInMap("promotion_id")]
                    [Validation(Required=false)]
                    public string PromotionId { get; set; }

                    /// <summary>
                    /// <para>The promotion name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("promotion_name")]
                    [Validation(Required=false)]
                    public string PromotionName { get; set; }

                    /// <summary>
                    /// <para>The promotion amount, in cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("promotion_price")]
                    [Validation(Required=false)]
                    public long? PromotionPrice { get; set; }

                    /// <summary>
                    /// <para>The promotion type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("promotion_type")]
                    [Validation(Required=false)]
                    public string PromotionType { get; set; }

                }

                /// <summary>
                /// <para>The total promotion amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("promotion_total_price")]
                [Validation(Required=false)]
                public long? PromotionTotalPrice { get; set; }

            }

            /// <summary>
            /// <para>The daily price.</para>
            /// </summary>
            [NameInMap("rate_plan_daily")]
            [Validation(Required=false)]
            public List<HotelOrderPreValidateResponseBodyModuleRatePlanDaily> RatePlanDaily { get; set; }
            public class HotelOrderPreValidateResponseBodyModuleRatePlanDaily : TeaModel {
                /// <summary>
                /// <para>The daily breakfast.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2份早餐</para>
                /// </summary>
                [NameInMap("board")]
                [Validation(Required=false)]
                public string Board { get; set; }

                /// <summary>
                /// <para>The daily price after discounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("discount_price")]
                [Validation(Required=false)]
                public string DiscountPrice { get; set; }

                /// <summary>
                /// <para>This field is deprecated. The maximum number of bookable rooms.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_booking_num")]
                [Validation(Required=false)]
                public int? MaxBookingNum { get; set; }

                /// <summary>
                /// <para>The daily price, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The applicable date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-19</para>
                /// </summary>
                [NameInMap("rate_start_time")]
                [Validation(Required=false)]
                public string RateStartTime { get; set; }

                /// <summary>
                /// <para>The daily room count. This field is deprecated and always returns 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("room_count")]
                [Validation(Required=false)]
                public int? RoomCount { get; set; }

                /// <summary>
                /// <para>The rounded daily price after discounts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("rounding_discount_price")]
                [Validation(Required=false)]
                public string RoundingDiscountPrice { get; set; }

                /// <summary>
                /// <para>The rounded daily price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("rounding_price")]
                [Validation(Required=false)]
                public string RoundingPrice { get; set; }

                /// <summary>
                /// <para>The service fee charged to the customer or to HuiLianYi, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("service_fee")]
                [Validation(Required=false)]
                public long? ServiceFee { get; set; }

            }

            /// <summary>
            /// <para>The product ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5314280514218</para>
            /// </summary>
            [NameInMap("rate_plan_id")]
            [Validation(Required=false)]
            public long? RatePlanId { get; set; }

            /// <summary>
            /// <para>The rate plan information.</para>
            /// </summary>
            [NameInMap("rate_plan_info")]
            [Validation(Required=false)]
            public HotelOrderPreValidateResponseBodyModuleRatePlanInfo RatePlanInfo { get; set; }
            public class HotelOrderPreValidateResponseBodyModuleRatePlanInfo : TeaModel {
                /// <summary>
                /// <para>The bed type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1张大床</para>
                /// </summary>
                [NameInMap("bed_desc")]
                [Validation(Required=false)]
                public string BedDesc { get; set; }

                /// <summary>
                /// <para>The cancellation policy.</para>
                /// </summary>
                [NameInMap("btrip_hotel_cancel_policy_d_t_o")]
                [Validation(Required=false)]
                public HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTO BtripHotelCancelPolicyDTO { get; set; }
                public class HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTO : TeaModel {
                    /// <summary>
                    /// <para>The detailed cancellation and modification units.</para>
                    /// </summary>
                    [NameInMap("btrip_hotel_cancel_policy_info_d_t_o_list")]
                    [Validation(Required=false)]
                    public List<HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList> BtripHotelCancelPolicyInfoDTOList { get; set; }
                    public class HotelOrderPreValidateResponseBodyModuleRatePlanInfoBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList : TeaModel {
                        /// <summary>
                        /// <para>The number of hours before midnight on the check-in date.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("hour")]
                        [Validation(Required=false)]
                        public long? Hour { get; set; }

                        /// <summary>
                        /// <para>The number of room nights or the amount.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public long? Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The cancellation policy type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1（类型查看报价详情）</para>
                    /// </summary>
                    [NameInMap("cancel_policy_type")]
                    [Validation(Required=false)]
                    public int? CancelPolicyType { get; set; }

                    /// <summary>
                    /// <para>The detailed content of the cancellation policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>预订成功后，不可变更/取消，未入住将收取全额费用。</para>
                    /// </summary>
                    [NameInMap("content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The brief description of the cancellation policy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>免费取消</para>
                    /// </summary>
                    [NameInMap("short_desc")]
                    [Validation(Required=false)]
                    public string ShortDesc { get; set; }

                }

                /// <summary>
                /// <para>The supported ID document types for order placement. This field is returned when ID documents are required for booking.</para>
                /// </summary>
                [NameInMap("cert_type_list")]
                [Validation(Required=false)]
                public List<string> CertTypeList { get; set; }

                /// <summary>
                /// <para>The earliest check-in time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12:00</para>
                /// </summary>
                [NameInMap("earliest_check_in_time")]
                [Validation(Required=false)]
                public string EarliestCheckInTime { get; set; }

                /// <summary>
                /// <para>The hourly room information. When the item is an hourly room (rpType=1), use the check-in and check-out time information from this model.</para>
                /// </summary>
                [NameInMap("hour_item_arrival_time_info")]
                [Validation(Required=false)]
                public HotelOrderPreValidateResponseBodyModuleRatePlanInfoHourItemArrivalTimeInfo HourItemArrivalTimeInfo { get; set; }
                public class HotelOrderPreValidateResponseBodyModuleRatePlanInfoHourItemArrivalTimeInfo : TeaModel {
                    /// <summary>
                    /// <para>The actual number of hours available for stay. No value.</para>
                    /// </summary>
                    [NameInMap("actual_live_hour")]
                    [Validation(Required=false)]
                    public string ActualLiveHour { get; set; }

                    /// <summary>
                    /// <para>The earliest check-in time, in the format yyyy-MM-dd HH:mm:ss.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-05-07 12:00:00</para>
                    /// </summary>
                    [NameInMap("earliest_check_in_time")]
                    [Validation(Required=false)]
                    public string EarliestCheckInTime { get; set; }

                    /// <summary>
                    /// <para>The latest check-in time, in the format yyyy-MM-dd HH:mm:ss.</para>
                    /// </summary>
                    [NameInMap("latest_check_in_time")]
                    [Validation(Required=false)]
                    public string LatestCheckInTime { get; set; }

                    /// <summary>
                    /// <para>The latest check-out time, in the format yyyy-MM-dd HH:mm:ss.</para>
                    /// </summary>
                    [NameInMap("latest_check_out_time")]
                    [Validation(Required=false)]
                    public string LatestCheckOutTime { get; set; }

                    /// <summary>
                    /// <para>The hotel-specified duration of stay for hourly rooms, in hours.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("live_hour")]
                    [Validation(Required=false)]
                    public string LiveHour { get; set; }

                }

                /// <summary>
                /// <para>The latest check-out time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17:00</para>
                /// </summary>
                [NameInMap("latest_check_out_time")]
                [Validation(Required=false)]
                public string LatestCheckOutTime { get; set; }

                /// <summary>
                /// <para>The maximum number of bookable rooms, representing the current inventory for this rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_booking_num")]
                [Validation(Required=false)]
                public int? MaxBookingNum { get; set; }

                /// <summary>
                /// <para>The maximum number of occupants per room. Currently, a single room can accommodate a maximum of two guests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_occupancy_num")]
                [Validation(Required=false)]
                public int? MaxOccupancyNum { get; set; }

                /// <summary>
                /// <para>Indicates whether certificate information is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("need_certificate")]
                [Validation(Required=false)]
                public bool? NeedCertificate { get; set; }

                /// <summary>
                /// <para>Indicates whether an email address is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("need_email")]
                [Validation(Required=false)]
                public bool? NeedEmail { get; set; }

                /// <summary>
                /// <para>Indicates whether an English or pinyin name (firstName/lastName) is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("need_english_name")]
                [Validation(Required=false)]
                public bool? NeedEnglishName { get; set; }

                /// <summary>
                /// <para>The item room type, which distinguishes between full-day rooms and hourly rooms. Valid values: 0: full-day room. 1: hourly room.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("rp_type")]
                [Validation(Required=false)]
                public int? RpType { get; set; }

                /// <summary>
                /// <para>The total amount after discounts, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("total_order_price")]
                [Validation(Required=false)]
                public long? TotalOrderPrice { get; set; }

                /// <summary>
                /// <para>The total room price, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("total_room_price")]
                [Validation(Required=false)]
                public long? TotalRoomPrice { get; set; }

            }

            /// <summary>
            /// <para>The validation response key required for the order creation API.</para>
            /// 
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
        /// <para>Indicates whether the request is successful.</para>
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
