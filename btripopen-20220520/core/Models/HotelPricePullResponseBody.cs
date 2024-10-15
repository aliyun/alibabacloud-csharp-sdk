// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelPricePullResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelPricePullResponseBodyModule Module { get; set; }
        public class HotelPricePullResponseBodyModule : TeaModel {
            [NameInMap("hotel_price_infos")]
            [Validation(Required=false)]
            public List<HotelPricePullResponseBodyModuleHotelPriceInfos> HotelPriceInfos { get; set; }
            public class HotelPricePullResponseBodyModuleHotelPriceInfos : TeaModel {
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64389015</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                [NameInMap("rooms")]
                [Validation(Required=false)]
                public List<HotelPricePullResponseBodyModuleHotelPriceInfosRooms> Rooms { get; set; }
                public class HotelPricePullResponseBodyModuleHotelPriceInfosRooms : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>32</para>
                    /// </summary>
                    [NameInMap("area")]
                    [Validation(Required=false)]
                    public string Area { get; set; }

                    [NameInMap("bed")]
                    [Validation(Required=false)]
                    public string Bed { get; set; }

                    [NameInMap("bed_type_string")]
                    [Validation(Required=false)]
                    public string BedTypeString { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{\&quot;bathtub\&quot;:true}</para>
                    /// </summary>
                    [NameInMap("facility")]
                    [Validation(Required=false)]
                    public string Facility { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1,2,3,4,5,6</para>
                    /// </summary>
                    [NameInMap("floor")]
                    [Validation(Required=false)]
                    public string Floor { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("max_occupancy")]
                    [Validation(Required=false)]
                    public int? MaxOccupancy { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("network_service")]
                    [Validation(Required=false)]
                    public string NetworkService { get; set; }

                    [NameInMap("pics")]
                    [Validation(Required=false)]
                    public List<string> Pics { get; set; }

                    [NameInMap("rates")]
                    [Validation(Required=false)]
                    public List<HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRates> Rates { get; set; }
                    public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRates : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("breakfast")]
                        [Validation(Required=false)]
                        public string Breakfast { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("breakfast_count")]
                        [Validation(Required=false)]
                        public int? BreakfastCount { get; set; }

                        [NameInMap("btrip_hotel_cancel_policy")]
                        [Validation(Required=false)]
                        public HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicy BtripHotelCancelPolicy { get; set; }
                        public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicy : TeaModel {
                            [NameInMap("btrip_hotel_cancel_policy_info_d_t_o_list")]
                            [Validation(Required=false)]
                            public List<HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicyBtripHotelCancelPolicyInfoDTOList> BtripHotelCancelPolicyInfoDTOList { get; set; }
                            public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicyBtripHotelCancelPolicyInfoDTOList : TeaModel {
                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("hour")]
                                [Validation(Required=false)]
                                public long? Hour { get; set; }

                                /// <summary>
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public long? Value { get; set; }

                            }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("cancel_policy_type")]
                            [Validation(Required=false)]
                            public int? CancelPolicyType { get; set; }

                        }

                        [NameInMap("cancel_policy_desc")]
                        [Validation(Required=false)]
                        public string CancelPolicyDesc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("company_aassist")]
                        [Validation(Required=false)]
                        public string CompanyAassist { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CNY</para>
                        /// </summary>
                        [NameInMap("currency_code")]
                        [Validation(Required=false)]
                        public string CurrencyCode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("instant_confirm")]
                        [Validation(Required=false)]
                        public bool? InstantConfirm { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>721700504622</para>
                        /// </summary>
                        [NameInMap("item_id")]
                        [Validation(Required=false)]
                        public string ItemId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("max_adv_hours")]
                        [Validation(Required=false)]
                        public int? MaxAdvHours { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4344</para>
                        /// </summary>
                        [NameInMap("max_days")]
                        [Validation(Required=false)]
                        public int? MaxDays { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("min_adv_hours")]
                        [Validation(Required=false)]
                        public int? MinAdvHours { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("min_days")]
                        [Validation(Required=false)]
                        public int? MinDays { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("nod")]
                        [Validation(Required=false)]
                        public int? Nod { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("nop")]
                        [Validation(Required=false)]
                        public int? Nop { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("payment_type")]
                        [Validation(Required=false)]
                        public int? PaymentType { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>30000</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public long? Price { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("promotion_info")]
                        [Validation(Required=false)]
                        public string PromotionInfo { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("quota")]
                        [Validation(Required=false)]
                        public int? Quota { get; set; }

                        [NameInMap("rate_dailys")]
                        [Validation(Required=false)]
                        public List<HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesRateDailys> RateDailys { get; set; }
                        public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesRateDailys : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>30000</para>
                            /// </summary>
                            [NameInMap("discount_price")]
                            [Validation(Required=false)]
                            public long? DiscountPrice { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>62800</para>
                            /// </summary>
                            [NameInMap("last_discounts_price")]
                            [Validation(Required=false)]
                            public long? LastDiscountsPrice { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>62800</para>
                            /// </summary>
                            [NameInMap("price")]
                            [Validation(Required=false)]
                            public long? Price { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2023-10-17</para>
                            /// </summary>
                            [NameInMap("start_date")]
                            [Validation(Required=false)]
                            public string StartDate { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4509447432148</para>
                        /// </summary>
                        [NameInMap("rate_id")]
                        [Validation(Required=false)]
                        public string RateId { get; set; }

                        [NameInMap("rate_plan_name")]
                        [Validation(Required=false)]
                        public string RatePlanName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>4509447432148</para>
                        /// </summary>
                        [NameInMap("rp_id")]
                        [Validation(Required=false)]
                        public string RpId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2829486701</para>
                        /// </summary>
                        [NameInMap("seller_id")]
                        [Validation(Required=false)]
                        public string SellerId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("support_special_invoice")]
                        [Validation(Required=false)]
                        public bool? SupportSpecialInvoice { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>64681618</para>
                    /// </summary>
                    [NameInMap("room_id")]
                    [Validation(Required=false)]
                    public string RoomId { get; set; }

                    [NameInMap("room_name")]
                    [Validation(Required=false)]
                    public string RoomName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("window_type")]
                    [Validation(Required=false)]
                    public string WindowType { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9BCDD5DE-E6CB-5C25-93B9-9BE178A0AA56</para>
                /// </summary>
                [NameInMap("search_id")]
                [Validation(Required=false)]
                public string SearchId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9BCDD5DE-E6CB-5C25-93B9-9BE178A0AA56</para>
        /// </summary>
        [NameInMap("request_id")]
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f079e16603757182131635d866a</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
