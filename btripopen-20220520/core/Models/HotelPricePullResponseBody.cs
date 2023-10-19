// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class HotelPricePullResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
                    [NameInMap("area")]
                    [Validation(Required=false)]
                    public string Area { get; set; }

                    [NameInMap("bed")]
                    [Validation(Required=false)]
                    public string Bed { get; set; }

                    [NameInMap("bed_type_string")]
                    [Validation(Required=false)]
                    public string BedTypeString { get; set; }

                    [NameInMap("facility")]
                    [Validation(Required=false)]
                    public string Facility { get; set; }

                    [NameInMap("floor")]
                    [Validation(Required=false)]
                    public string Floor { get; set; }

                    [NameInMap("max_occupancy")]
                    [Validation(Required=false)]
                    public int? MaxOccupancy { get; set; }

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
                        [NameInMap("breakfast")]
                        [Validation(Required=false)]
                        public string Breakfast { get; set; }

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
                                [NameInMap("hour")]
                                [Validation(Required=false)]
                                public long? Hour { get; set; }

                                [NameInMap("value")]
                                [Validation(Required=false)]
                                public long? Value { get; set; }

                            }

                            [NameInMap("cancel_policy_type")]
                            [Validation(Required=false)]
                            public int? CancelPolicyType { get; set; }

                        }

                        [NameInMap("cancel_policy_desc")]
                        [Validation(Required=false)]
                        public string CancelPolicyDesc { get; set; }

                        [NameInMap("company_aassist")]
                        [Validation(Required=false)]
                        public string CompanyAassist { get; set; }

                        [NameInMap("currency_code")]
                        [Validation(Required=false)]
                        public string CurrencyCode { get; set; }

                        [NameInMap("instant_confirm")]
                        [Validation(Required=false)]
                        public bool? InstantConfirm { get; set; }

                        [NameInMap("item_id")]
                        [Validation(Required=false)]
                        public string ItemId { get; set; }

                        [NameInMap("max_adv_hours")]
                        [Validation(Required=false)]
                        public int? MaxAdvHours { get; set; }

                        [NameInMap("max_days")]
                        [Validation(Required=false)]
                        public int? MaxDays { get; set; }

                        [NameInMap("min_adv_hours")]
                        [Validation(Required=false)]
                        public int? MinAdvHours { get; set; }

                        [NameInMap("min_days")]
                        [Validation(Required=false)]
                        public int? MinDays { get; set; }

                        [NameInMap("nod")]
                        [Validation(Required=false)]
                        public int? Nod { get; set; }

                        [NameInMap("nop")]
                        [Validation(Required=false)]
                        public int? Nop { get; set; }

                        [NameInMap("payment_type")]
                        [Validation(Required=false)]
                        public int? PaymentType { get; set; }

                        [NameInMap("price")]
                        [Validation(Required=false)]
                        public long? Price { get; set; }

                        [NameInMap("promotion_info")]
                        [Validation(Required=false)]
                        public string PromotionInfo { get; set; }

                        [NameInMap("quota")]
                        [Validation(Required=false)]
                        public int? Quota { get; set; }

                        [NameInMap("rate_dailys")]
                        [Validation(Required=false)]
                        public List<HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesRateDailys> RateDailys { get; set; }
                        public class HotelPricePullResponseBodyModuleHotelPriceInfosRoomsRatesRateDailys : TeaModel {
                            [NameInMap("discount_price")]
                            [Validation(Required=false)]
                            public long? DiscountPrice { get; set; }

                            [NameInMap("last_discounts_price")]
                            [Validation(Required=false)]
                            public long? LastDiscountsPrice { get; set; }

                            [NameInMap("price")]
                            [Validation(Required=false)]
                            public long? Price { get; set; }

                            [NameInMap("start_date")]
                            [Validation(Required=false)]
                            public string StartDate { get; set; }

                        }

                        [NameInMap("rate_id")]
                        [Validation(Required=false)]
                        public string RateId { get; set; }

                        [NameInMap("rate_plan_name")]
                        [Validation(Required=false)]
                        public string RatePlanName { get; set; }

                        [NameInMap("rp_id")]
                        [Validation(Required=false)]
                        public string RpId { get; set; }

                        [NameInMap("seller_id")]
                        [Validation(Required=false)]
                        public string SellerId { get; set; }

                        [NameInMap("support_special_invoice")]
                        [Validation(Required=false)]
                        public bool? SupportSpecialInvoice { get; set; }

                    }

                    [NameInMap("room_id")]
                    [Validation(Required=false)]
                    public string RoomId { get; set; }

                    [NameInMap("room_name")]
                    [Validation(Required=false)]
                    public string RoomName { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("window_type")]
                    [Validation(Required=false)]
                    public string WindowType { get; set; }

                }

                [NameInMap("search_id")]
                [Validation(Required=false)]
                public string SearchId { get; set; }

            }

        }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
