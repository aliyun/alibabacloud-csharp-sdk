// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelGoodsQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
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
        public HotelGoodsQueryResponseBodyModule Module { get; set; }
        public class HotelGoodsQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>贵州省贵阳市贵阳国家高新技术产业开发区沙文园区科学城智谷13-2栋三、四层</para>
            /// </summary>
            [NameInMap("address")]
            [Validation(Required=false)]
            public string Address { get; set; }

            [NameInMap("booking_instructions")]
            [Validation(Required=false)]
            public Dictionary<string, string> BookingInstructions { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("can_foreigner")]
            [Validation(Required=false)]
            public bool? CanForeigner { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-15</para>
            /// </summary>
            [NameInMap("check_in")]
            [Validation(Required=false)]
            public string CheckIn { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-15</para>
            /// </summary>
            [NameInMap("check_out")]
            [Validation(Required=false)]
            public string CheckOut { get; set; }

            [NameInMap("descriptions")]
            [Validation(Required=false)]
            public List<string> Descriptions { get; set; }

            [NameInMap("dinamic_banner_pic_urls")]
            [Validation(Required=false)]
            public List<string> DinamicBannerPicUrls { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>17:00</para>
            /// </summary>
            [NameInMap("early_arrival_time")]
            [Validation(Required=false)]
            public string EarlyArrivalTime { get; set; }

            [NameInMap("hotel_group_desc")]
            [Validation(Required=false)]
            public string HotelGroupDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>29382</para>
            /// </summary>
            [NameInMap("hotel_id")]
            [Validation(Required=false)]
            public long? HotelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>未来酒店</para>
            /// </summary>
            [NameInMap("hotel_name")]
            [Validation(Required=false)]
            public string HotelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12:00</para>
            /// </summary>
            [NameInMap("late_arrival_time")]
            [Validation(Required=false)]
            public string LateArrivalTime { get; set; }

            [NameInMap("rooms")]
            [Validation(Required=false)]
            public List<HotelGoodsQueryResponseBodyModuleRooms> Rooms { get; set; }
            public class HotelGoodsQueryResponseBodyModuleRooms : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("area")]
                [Validation(Required=false)]
                public string Area { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2张1.2米单人床</para>
                /// </summary>
                [NameInMap("bed_type_string")]
                [Validation(Required=false)]
                public string BedTypeString { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("extra_bed")]
                [Validation(Required=false)]
                public bool? ExtraBed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{\&quot;facilityList\&quot;:[{\&quot;fee\&quot;:false,\&quot;logoUrl\&quot;:\&quot;<a href="https://gw.alicdn.com/imgextra/i4/O1CN017s2RbJ1JFaKKSdv1c_!!6000000000999-2-tps-96-96.png%5C%5C%22,%5C%5C%22name%5C%5C%22:%5C%5C%22%E7%93%B6%E8%A3%85%E6%B0%B4%5C%5C%22,%5C%5C%22yesNo%5C%5C%22:true%7D%7D%5D">https://gw.alicdn.com/imgextra/i4/O1CN017s2RbJ1JFaKKSdv1c_!!6000000000999-2-tps-96-96.png\\&quot;,\\&quot;name\\&quot;:\\&quot;瓶装水\\&quot;,\\&quot;yesNo\\&quot;:true}}]</a></para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("max_occupancy")]
                [Validation(Required=false)]
                public int? MaxOccupancy { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>高级双床房</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("network_service")]
                [Validation(Required=false)]
                public string NetworkService { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://img.alicdn.com/imgextra/i4/6000000007171/O1CN01NHHdOw22qMoYHweI9_!!6000000007171-0-hotel.jpg">https://img.alicdn.com/imgextra/i4/6000000007171/O1CN01NHHdOw22qMoYHweI9_!!6000000007171-0-hotel.jpg</a></para>
                /// </summary>
                [NameInMap("pics")]
                [Validation(Required=false)]
                public string Pics { get; set; }

                [NameInMap("rates")]
                [Validation(Required=false)]
                public List<HotelGoodsQueryResponseBodyModuleRoomsRates> Rates { get; set; }
                public class HotelGoodsQueryResponseBodyModuleRoomsRates : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2张单人床(1.2M)</para>
                    /// </summary>
                    [NameInMap("bed_desc")]
                    [Validation(Required=false)]
                    public string BedDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2张1.2米单人床</para>
                    /// </summary>
                    [NameInMap("bed_type")]
                    [Validation(Required=false)]
                    public string BedType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>双早</para>
                    /// </summary>
                    [NameInMap("breakfast")]
                    [Validation(Required=false)]
                    public string Breakfast { get; set; }

                    [NameInMap("btrip_cancel_rule")]
                    [Validation(Required=false)]
                    public HotelGoodsQueryResponseBodyModuleRoomsRatesBtripCancelRule BtripCancelRule { get; set; }
                    public class HotelGoodsQueryResponseBodyModuleRoomsRatesBtripCancelRule : TeaModel {
                        [NameInMap("btrip_hotel_cancel_policy_d_t_o")]
                        [Validation(Required=false)]
                        public HotelGoodsQueryResponseBodyModuleRoomsRatesBtripCancelRuleBtripHotelCancelPolicyDTO BtripHotelCancelPolicyDTO { get; set; }
                        public class HotelGoodsQueryResponseBodyModuleRoomsRatesBtripCancelRuleBtripHotelCancelPolicyDTO : TeaModel {
                            [NameInMap("btrip_hotel_cancel_policy_info_d_t_o_list")]
                            [Validation(Required=false)]
                            public List<HotelGoodsQueryResponseBodyModuleRoomsRatesBtripCancelRuleBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList> BtripHotelCancelPolicyInfoDTOList { get; set; }
                            public class HotelGoodsQueryResponseBodyModuleRoomsRatesBtripCancelRuleBtripHotelCancelPolicyDTOBtripHotelCancelPolicyInfoDTOList : TeaModel {
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

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>不可取消</para>
                        /// </summary>
                        [NameInMap("cancel_policy_title")]
                        [Validation(Required=false)]
                        public string CancelPolicyTitle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-02-27</para>
                        /// </summary>
                        [NameInMap("check_in")]
                        [Validation(Required=false)]
                        public string CheckIn { get; set; }

                    }

                    [NameInMap("btrip_hotel_cancel_desc")]
                    [Validation(Required=false)]
                    public List<HotelGoodsQueryResponseBodyModuleRoomsRatesBtripHotelCancelDesc> BtripHotelCancelDesc { get; set; }
                    public class HotelGoodsQueryResponseBodyModuleRoomsRatesBtripHotelCancelDesc : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023年3月25日18:00前可免费取消订单。</para>
                        /// </summary>
                        [NameInMap("desc")]
                        [Validation(Required=false)]
                        public string Desc { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023年3月25日18点00分前可免费取消</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("can_smoking")]
                    [Validation(Required=false)]
                    public bool? CanSmoking { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023年3月25日18点00分前可免费取消</para>
                    /// </summary>
                    [NameInMap("cancel_policy_desc")]
                    [Validation(Required=false)]
                    public string CancelPolicyDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("cancel_policy_type")]
                    [Validation(Required=false)]
                    public int? CancelPolicyType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("company_aassist")]
                    [Validation(Required=false)]
                    public string CompanyAassist { get; set; }

                    [NameInMap("company_assist_type")]
                    [Validation(Required=false)]
                    public string CompanyAssistType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("confirm_type")]
                    [Validation(Required=false)]
                    public int? ConfirmType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cny</para>
                    /// </summary>
                    [NameInMap("currency_code")]
                    [Validation(Required=false)]
                    public string CurrencyCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("daily_price_format_yuan")]
                    [Validation(Required=false)]
                    public string DailyPriceFormatYuan { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>400</para>
                    /// </summary>
                    [NameInMap("daily_price_view")]
                    [Validation(Required=false)]
                    public string DailyPriceView { get; set; }

                    [NameInMap("discount_desc")]
                    [Validation(Required=false)]
                    public HotelGoodsQueryResponseBodyModuleRoomsRatesDiscountDesc DiscountDesc { get; set; }
                    public class HotelGoodsQueryResponseBodyModuleRoomsRatesDiscountDesc : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("cash_reduce_total")]
                        [Validation(Required=false)]
                        public string CashReduceTotal { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>F3会员价</para>
                        /// </summary>
                        [NameInMap("dinamic_label")]
                        [Validation(Required=false)]
                        public string DinamicLabel { get; set; }

                        [NameInMap("discount_detail")]
                        [Validation(Required=false)]
                        public List<HotelGoodsQueryResponseBodyModuleRoomsRatesDiscountDescDiscountDetail> DiscountDetail { get; set; }
                        public class HotelGoodsQueryResponseBodyModuleRoomsRatesDiscountDescDiscountDetail : TeaModel {
                            [NameInMap("label_name")]
                            [Validation(Required=false)]
                            public List<string> LabelName { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>-¥3</para>
                            /// </summary>
                            [NameInMap("money_desc")]
                            [Validation(Required=false)]
                            public string MoneyDesc { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>最终优惠以下单页为准</para>
                        /// </summary>
                        [NameInMap("sub_title")]
                        [Validation(Required=false)]
                        public string SubTitle { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>每晚优惠说明</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("end_time_daily")]
                    [Validation(Required=false)]
                    public string EndTimeDaily { get; set; }

                    [NameInMap("hotel_detail_rate_price_d_t_o")]
                    [Validation(Required=false)]
                    public List<HotelGoodsQueryResponseBodyModuleRoomsRatesHotelDetailRatePriceDTO> HotelDetailRatePriceDTO { get; set; }
                    public class HotelGoodsQueryResponseBodyModuleRoomsRatesHotelDetailRatePriceDTO : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("before_discount_price")]
                        [Validation(Required=false)]
                        public long? BeforeDiscountPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("breakfast")]
                        [Validation(Required=false)]
                        public string Breakfast { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("discount_price")]
                        [Validation(Required=false)]
                        public long? DiscountPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("last_discounts_price")]
                        [Validation(Required=false)]
                        public long? LastDiscountsPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("last_discounts_rounding_price")]
                        [Validation(Required=false)]
                        public long? LastDiscountsRoundingPrice { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("last_num")]
                        [Validation(Required=false)]
                        public int? LastNum { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2023-03-25</para>
                        /// </summary>
                        [NameInMap("rate_start_time")]
                        [Validation(Required=false)]
                        public string RateStartTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                    }

                    [NameInMap("hotel_member_benefit")]
                    [Validation(Required=false)]
                    public Dictionary<string, string> HotelMemberBenefit { get; set; }

                    [NameInMap("hotel_onsite_price_detail")]
                    [Validation(Required=false)]
                    public HotelGoodsQueryResponseBodyModuleRoomsRatesHotelOnsitePriceDetail HotelOnsitePriceDetail { get; set; }
                    public class HotelGoodsQueryResponseBodyModuleRoomsRatesHotelOnsitePriceDetail : TeaModel {
                        [NameInMap("avg_onsite_price")]
                        [Validation(Required=false)]
                        public HotelGoodsQueryResponseBodyModuleRoomsRatesHotelOnsitePriceDetailAvgOnsitePrice AvgOnsitePrice { get; set; }
                        public class HotelGoodsQueryResponseBodyModuleRoomsRatesHotelOnsitePriceDetailAvgOnsitePrice : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CNY</para>
                            /// </summary>
                            [NameInMap("currency")]
                            [Validation(Required=false)]
                            public string Currency { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>USD</para>
                            /// </summary>
                            [NameInMap("foreign_currency")]
                            [Validation(Required=false)]
                            public string ForeignCurrency { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("foreign_price_cent")]
                            [Validation(Required=false)]
                            public long? ForeignPriceCent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>24</para>
                            /// </summary>
                            [NameInMap("price_cent")]
                            [Validation(Required=false)]
                            public long? PriceCent { get; set; }

                        }

                        [NameInMap("daily_onsite_price")]
                        [Validation(Required=false)]
                        public List<HotelGoodsQueryResponseBodyModuleRoomsRatesHotelOnsitePriceDetailDailyOnsitePrice> DailyOnsitePrice { get; set; }
                        public class HotelGoodsQueryResponseBodyModuleRoomsRatesHotelOnsitePriceDetailDailyOnsitePrice : TeaModel {
                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>CNY</para>
                            /// </summary>
                            [NameInMap("currency")]
                            [Validation(Required=false)]
                            public string Currency { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>2026-04-22</para>
                            /// </summary>
                            [NameInMap("day")]
                            [Validation(Required=false)]
                            public string Day { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>USD</para>
                            /// </summary>
                            [NameInMap("foreign_currency")]
                            [Validation(Required=false)]
                            public string ForeignCurrency { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>3</para>
                            /// </summary>
                            [NameInMap("foreign_price_cent")]
                            [Validation(Required=false)]
                            public long? ForeignPriceCent { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>24</para>
                            /// </summary>
                            [NameInMap("price_cent")]
                            [Validation(Required=false)]
                            public long? PriceCent { get; set; }

                        }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("instant_confirm")]
                    [Validation(Required=false)]
                    public bool? InstantConfirm { get; set; }

                    [NameInMap("inventory_desc")]
                    [Validation(Required=false)]
                    public string InventoryDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("inventory_price")]
                    [Validation(Required=false)]
                    public string InventoryPrice { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("is_business_pay4_goods")]
                    [Validation(Required=false)]
                    public bool? IsBusinessPay4Goods { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1（暂无·）</para>
                    /// </summary>
                    [NameInMap("is_guarantee")]
                    [Validation(Required=false)]
                    public int? IsGuarantee { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("is_need_email")]
                    [Validation(Required=false)]
                    public bool? IsNeedEmail { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>612673015638</para>
                    /// </summary>
                    [NameInMap("item_id")]
                    [Validation(Required=false)]
                    public long? ItemId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("last_cancel_time")]
                    [Validation(Required=false)]
                    public string LastCancelTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("max_occupancy")]
                    [Validation(Required=false)]
                    public int? MaxOccupancy { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("min_adv_hours")]
                    [Validation(Required=false)]
                    public int? MinAdvHours { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("min_days")]
                    [Validation(Required=false)]
                    public int? MinDays { get; set; }

                    [NameInMap("need_certificate")]
                    [Validation(Required=false)]
                    public bool? NeedCertificate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("nod")]
                    [Validation(Required=false)]
                    public int? Nod { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("nop")]
                    [Validation(Required=false)]
                    public int? Nop { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("order_ship_time")]
                    [Validation(Required=false)]
                    public int? OrderShipTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("payment_type")]
                    [Validation(Required=false)]
                    public int? PaymentType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("price_type")]
                    [Validation(Required=false)]
                    public int? PriceType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("promotion_info")]
                    [Validation(Required=false)]
                    public string PromotionInfo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4509447432148</para>
                    /// </summary>
                    [NameInMap("rate_id")]
                    [Validation(Required=false)]
                    public long? RateId { get; set; }

                    [NameInMap("rate_key")]
                    [Validation(Required=false)]
                    public string RateKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>高级双床房</para>
                    /// </summary>
                    [NameInMap("rate_plan_name")]
                    [Validation(Required=false)]
                    public string RatePlanName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4509447432148</para>
                    /// </summary>
                    [NameInMap("rp_id")]
                    [Validation(Required=false)]
                    public long? RpId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4011822148</para>
                    /// </summary>
                    [NameInMap("seller_id")]
                    [Validation(Required=false)]
                    public long? SellerId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("start_time_daily")]
                    [Validation(Required=false)]
                    public string StartTimeDaily { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2321</para>
                    /// </summary>
                    [NameInMap("supplier_code")]
                    [Validation(Required=false)]
                    public string SupplierCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("supplier_name")]
                    [Validation(Required=false)]
                    public string SupplierName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("support_special_invoice")]
                    [Validation(Required=false)]
                    public bool? SupportSpecialInvoice { get; set; }

                    [NameInMap("tax_fee_desc")]
                    [Validation(Required=false)]
                    public string TaxFeeDesc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>40000</para>
                    /// </summary>
                    [NameInMap("unrounding_daily_price_format_yuan")]
                    [Validation(Required=false)]
                    public string UnroundingDailyPriceFormatYuan { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("room_dasc")]
                [Validation(Required=false)]
                public string RoomDasc { get; set; }

                [NameInMap("room_facility")]
                [Validation(Required=false)]
                public List<string> RoomFacility { get; set; }

                [NameInMap("room_service")]
                [Validation(Required=false)]
                public List<HotelGoodsQueryResponseBodyModuleRoomsRoomService> RoomService { get; set; }
                public class HotelGoodsQueryResponseBodyModuleRoomsRoomService : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>#000000</para>
                    /// </summary>
                    [NameInMap("color")]
                    [Validation(Required=false)]
                    public string Color { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><span>免费</span>有线上网 <span>免费</span>wifi</para>
                    /// </summary>
                    [NameInMap("desc")]
                    [Validation(Required=false)]
                    public string Desc { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>#4AA900</para>
                    /// </summary>
                    [NameInMap("highlight_color_color")]
                    [Validation(Required=false)]
                    public string HighlightColorColor { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>网络</para>
                    /// </summary>
                    [NameInMap("title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100929</para>
                /// </summary>
                [NameInMap("srid")]
                [Validation(Required=false)]
                public long? Srid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>有窗</para>
                /// </summary>
                [NameInMap("window_type")]
                [Validation(Required=false)]
                public string WindowType { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("search_id")]
            [Validation(Required=false)]
            public string SearchId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>210e847f16611516748613869de4f6</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
