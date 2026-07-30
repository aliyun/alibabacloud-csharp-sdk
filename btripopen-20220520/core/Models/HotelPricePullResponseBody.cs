// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelPricePullResponseBody : TeaModel {
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The module information.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public HotelPricePullResponseBodyModule Module { get; set; }
        public class HotelPricePullResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of hotel price information.</para>
            /// </summary>
            [NameInMap("hotel_price_infos")]
            [Validation(Required=false)]
            public List<HotelPricePullResponseBodyModuleHotelPriceInfos> HotelPriceInfos { get; set; }
            public class HotelPricePullResponseBodyModuleHotelPriceInfos : TeaModel {
                /// <summary>
                /// <para>The hotel address (not yet available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>成都市高新区天府大道北段1700号1栋2单元18层1801号</para>
                /// </summary>
                [NameInMap("address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>The hotel ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64389015</para>
                /// </summary>
                [NameInMap("hotel_id")]
                [Validation(Required=false)]
                public string HotelId { get; set; }

                /// <summary>
                /// <para>The hotel name (not yet available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅酒店</para>
                /// </summary>
                [NameInMap("hotel_name")]
                [Validation(Required=false)]
                public string HotelName { get; set; }

                /// <summary>
                /// <para>The room type information.</para>
                /// </summary>
                [NameInMap("rooms")]
                [Validation(Required=false)]
                public List<HotelPricePullResponseBodyModuleHotelPriceInfosRooms> Rooms { get; set; }
                public class HotelPricePullResponseBodyModuleHotelPriceInfosRooms : TeaModel {
                    /// <summary>
                    /// <para>The room area.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32</para>
                    /// </summary>
                    [NameInMap("area")]
                    [Validation(Required=false)]
                    public string Area { get; set; }

                    /// <summary>
                    /// <para>The bed description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1张大床(1.8米)</para>
                    /// </summary>
                    [NameInMap("bed")]
                    [Validation(Required=false)]
                    public string Bed { get; set; }

                    /// <summary>
                    /// <para>The bed type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>单人床</para>
                    /// </summary>
                    [NameInMap("bed_type_string")]
                    [Validation(Required=false)]
                    public string BedTypeString { get; set; }

                    /// <summary>
                    /// <para>The facilities.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;bathtub\&quot;:true}</para>
                    /// </summary>
                    [NameInMap("facility")]
                    [Validation(Required=false)]
                    public string Facility { get; set; }

                    /// <summary>
                    /// <para>The floor.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1,2,3,4,5,6</para>
                    /// </summary>
                    [NameInMap("floor")]
                    [Validation(Required=false)]
                    public string Floor { get; set; }

                    /// <summary>
                    /// <para>The maximum number of guests.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("max_occupancy")]
                    [Validation(Required=false)]
                    public int? MaxOccupancy { get; set; }

                    /// <summary>
                    /// <para>The network service. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: Wired Internet (free).</description></item>
                    /// <item><description>1: Wired Internet (unavailable).</description></item>
                    /// <item><description>2: Wired Internet (paid).</description></item>
                    /// <item><description>3: Wired Internet (partially available, free).</description></item>
                    /// <item><description>4: Wired Internet (partially available, paid).</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("network_service")]
                    [Validation(Required=false)]
                    public string NetworkService { get; set; }

                    /// <summary>
                    /// <para>The room type images.</para>
                    /// </summary>
                    [NameInMap("pics")]
                    [Validation(Required=false)]
                    public List<string> Pics { get; set; }

                    /// <summary>
                    /// <para>The rate collection.</para>
                    /// </summary>
                    [NameInMap("rates")]
                    [Validation(Required=false)]
                    public List<HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRates> Rates { get; set; }
                    public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRates : TeaModel {
                        /// <summary>
                        /// <para>The breakfast description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("breakfast")]
                        [Validation(Required=false)]
                        public string Breakfast { get; set; }

                        /// <summary>
                        /// <para>The number of breakfast servings.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("breakfast_count")]
                        [Validation(Required=false)]
                        public int? BreakfastCount { get; set; }

                        /// <summary>
                        /// <para>The cancellation policy in structured data format.</para>
                        /// </summary>
                        [NameInMap("btrip_hotel_cancel_policy")]
                        [Validation(Required=false)]
                        public HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicy BtripHotelCancelPolicy { get; set; }
                        public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicy : TeaModel {
                            /// <summary>
                            /// <para>The cancellation policy details.</para>
                            /// </summary>
                            [NameInMap("btrip_hotel_cancel_policy_info_d_t_o_list")]
                            [Validation(Required=false)]
                            public List<HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicyBtripHotelCancelPolicyInfoDTOList> BtripHotelCancelPolicyInfoDTOList { get; set; }
                            public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesBtripHotelCancelPolicyBtripHotelCancelPolicyInfoDTOList : TeaModel {
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
                                /// <para>The number of room nights or the monetary amount.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>20</para>
                                /// </summary>
                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public long? Value { get; set; }

                            }

                            /// <summary>
                            /// <para>The cancellation policy type. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description>1: Free cancellation.</description></item>
                            /// <item><description>2: Non-refundable.</description></item>
                            /// <item><description>4: Percentage charged if canceled within n hours before midnight on the check-in date.</description></item>
                            /// <item><description>5: Free cancellation if canceled n hours before midnight on the check-in date.</description></item>
                            /// <item><description>6: Room nights charged if canceled within n hours before midnight on the check-in date.</description></item>
                            /// <item><description>8: Refundable within n hours after placing the order.</description></item>
                            /// <item><description>9: Fixed amount charged if canceled within n hours before midnight on the check-in date.</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("cancel_policy_type")]
                            [Validation(Required=false)]
                            public int? CancelPolicyType { get; set; }

                        }

                        /// <summary>
                        /// <para>The free cancellation policy description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>限时取消</para>
                        /// </summary>
                        [NameInMap("cancel_policy_desc")]
                        [Validation(Required=false)]
                        public string CancelPolicyDesc { get; set; }

                        /// <summary>
                        /// <para>The corporate rate. A value of 1 indicates corporate agreement payment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("company_aassist")]
                        [Validation(Required=false)]
                        public string CompanyAassist { get; set; }

                        /// <summary>
                        /// <para>The currency code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CNY</para>
                        /// </summary>
                        [NameInMap("currency_code")]
                        [Validation(Required=false)]
                        public string CurrencyCode { get; set; }

                        /// <summary>
                        /// <para>Indicates whether instant confirmation is supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("instant_confirm")]
                        [Validation(Required=false)]
                        public bool? InstantConfirm { get; set; }

                        /// <summary>
                        /// <para>The item ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>721700504622</para>
                        /// </summary>
                        [NameInMap("item_id")]
                        [Validation(Required=false)]
                        public string ItemId { get; set; }

                        /// <summary>
                        /// <para>The maximum number of hours in advance for booking.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("max_adv_hours")]
                        [Validation(Required=false)]
                        public int? MaxAdvHours { get; set; }

                        /// <summary>
                        /// <para>The maximum number of consecutive stay days.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4344</para>
                        /// </summary>
                        [NameInMap("max_days")]
                        [Validation(Required=false)]
                        public int? MaxDays { get; set; }

                        /// <summary>
                        /// <para>The minimum number of hours in advance for booking.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("min_adv_hours")]
                        [Validation(Required=false)]
                        public int? MinAdvHours { get; set; }

                        /// <summary>
                        /// <para>The minimum number of consecutive stay days.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("min_days")]
                        [Validation(Required=false)]
                        public int? MinDays { get; set; }

                        /// <summary>
                        /// <para>The number of days between check-in and check-out.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("nod")]
                        [Validation(Required=false)]
                        public int? Nod { get; set; }

                        /// <summary>
                        /// <para>The number of guests.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("nop")]
                        [Validation(Required=false)]
                        public int? Nop { get; set; }

                        /// <summary>
                        /// <para>The payment type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>1: Full payment.</description></item>
                        /// <item><description>2: Service fee.</description></item>
                        /// <item><description>3: Deposit.</description></item>
                        /// <item><description>4: Service fee per room night.</description></item>
                        /// <item><description>5: Pay at hotel.</description></item>
                        /// <item><description>6: Credit stay.</description></item>
                        /// <item><description>7: Room voucher online reservation.</description></item>
                        /// <item><description>8: Credit stay room voucher online reservation.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("payment_type")]
                        [Validation(Required=false)]
                        public int? PaymentType { get; set; }

                        /// <summary>
                        /// <para>The average price in cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>30000</para>
                        /// </summary>
                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public long? Price { get; set; }

                        /// <summary>
                        /// <para>The promotion information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("promotion_info")]
                        [Validation(Required=false)]
                        public string PromotionInfo { get; set; }

                        /// <summary>
                        /// <para>The inventory. This value represents only the inventory and does not indicate the maximum number of rooms that can be booked.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4</para>
                        /// </summary>
                        [NameInMap("quota")]
                        [Validation(Required=false)]
                        public int? Quota { get; set; }

                        /// <summary>
                        /// <para>The daily prices.</para>
                        /// </summary>
                        [NameInMap("rate_dailys")]
                        [Validation(Required=false)]
                        public List<HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesRateDailys> RateDailys { get; set; }
                        public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesRateDailys : TeaModel {
                            /// <summary>
                            /// <para>The discount amount in cents.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>30000</para>
                            /// </summary>
                            [NameInMap("discount_price")]
                            [Validation(Required=false)]
                            public long? DiscountPrice { get; set; }

                            /// <summary>
                            /// <para>The discounted daily price in cents.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>62800</para>
                            /// </summary>
                            [NameInMap("last_discounts_price")]
                            [Validation(Required=false)]
                            public long? LastDiscountsPrice { get; set; }

                            /// <summary>
                            /// <para>The daily price in cents.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>62800</para>
                            /// </summary>
                            [NameInMap("price")]
                            [Validation(Required=false)]
                            public long? Price { get; set; }

                            /// <summary>
                            /// <para>The check-in date.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>2023-10-17</para>
                            /// </summary>
                            [NameInMap("start_date")]
                            [Validation(Required=false)]
                            public string StartDate { get; set; }

                        }

                        /// <summary>
                        /// <para>The room type ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4509447432148</para>
                        /// </summary>
                        [NameInMap("rate_id")]
                        [Validation(Required=false)]
                        public string RateId { get; set; }

                        /// <summary>
                        /// <para>The rate plan name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>高级双床房</para>
                        /// </summary>
                        [NameInMap("rate_plan_name")]
                        [Validation(Required=false)]
                        public string RatePlanName { get; set; }

                        /// <summary>
                        /// <para>The pricing rule ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>4509447432148</para>
                        /// </summary>
                        [NameInMap("rp_id")]
                        [Validation(Required=false)]
                        public string RpId { get; set; }

                        /// <summary>
                        /// <para>The seller ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2829486701</para>
                        /// </summary>
                        [NameInMap("seller_id")]
                        [Validation(Required=false)]
                        public string SellerId { get; set; }

                        /// <summary>
                        /// <para>Indicates whether special VAT invoices are supported.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("support_special_invoice")]
                        [Validation(Required=false)]
                        public bool? SupportSpecialInvoice { get; set; }

                    }

                    /// <summary>
                    /// <para>The room type ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64681618</para>
                    /// </summary>
                    [NameInMap("room_id")]
                    [Validation(Required=false)]
                    public string RoomId { get; set; }

                    /// <summary>
                    /// <para>The room type name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>高级双床房</para>
                    /// </summary>
                    [NameInMap("room_name")]
                    [Validation(Required=false)]
                    public string RoomName { get; set; }

                    /// <summary>
                    /// <para>The status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>0: Not available for sale.</description></item>
                    /// <item><description>1: Normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <para>The window type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("window_type")]
                    [Validation(Required=false)]
                    public string WindowType { get; set; }

                }

                /// <summary>
                /// <para>The search ID for log tracking (not yet available).</para>
                /// 
                /// <b>Example:</b>
                /// <para>9BCDD5DE-E6CB-5C25-93B9-9BE178A0AA56</para>
                /// </summary>
                [NameInMap("search_id")]
                [Validation(Required=false)]
                public string SearchId { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9BCDD5DE-E6CB-5C25-93B9-9BE178A0AA56</para>
        /// </summary>
        [NameInMap("request_id")]
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
