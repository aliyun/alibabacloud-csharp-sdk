// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingEnquiryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingEnquiryResponseBodyModule Module { get; set; }
        public class TicketChangingEnquiryResponseBodyModule : TeaModel {
            [NameInMap("flight_info_list")]
            [Validation(Required=false)]
            public List<TicketChangingEnquiryResponseBodyModuleFlightInfoList> FlightInfoList { get; set; }
            public class TicketChangingEnquiryResponseBodyModuleFlightInfoList : TeaModel {
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public TicketChangingEnquiryResponseBodyModuleFlightInfoListAirlineInfo AirlineInfo { get; set; }
                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListAirlineInfo : TeaModel {
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    [NameInMap("airline_simple_name")]
                    [Validation(Required=false)]
                    public string AirlineSimpleName { get; set; }

                }

                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public TicketChangingEnquiryResponseBodyModuleFlightInfoListArrAirportInfo ArrAirportInfo { get; set; }
                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListArrAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("cabin_list")]
                [Validation(Required=false)]
                public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinList> CabinList { get; set; }
                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinList : TeaModel {
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    [NameInMap("cabin_desc")]
                    [Validation(Required=false)]
                    public string CabinDesc { get; set; }

                    [NameInMap("cabin_discount")]
                    [Validation(Required=false)]
                    public int? CabinDiscount { get; set; }

                    [NameInMap("change_ota_item_rule_rq")]
                    [Validation(Required=false)]
                    public TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRq ChangeOtaItemRuleRq { get; set; }
                    public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRq : TeaModel {
                        [NameInMap("baggage_details")]
                        [Validation(Required=false)]
                        public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetails> BaggageDetails { get; set; }
                        public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetails : TeaModel {
                            [NameInMap("baggage_sub_items")]
                            [Validation(Required=false)]
                            public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItems> BaggageSubItems { get; set; }
                            public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItems : TeaModel {
                                [NameInMap("attributes")]
                                [Validation(Required=false)]
                                public Dictionary<string, object> Attributes { get; set; }

                                [NameInMap("baggage_sub_content_visualizes")]
                                [Validation(Required=false)]
                                public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                                    [NameInMap("baggage_desc")]
                                    [Validation(Required=false)]
                                    public List<string> BaggageDesc { get; set; }

                                    [NameInMap("baggage_sub_content_type")]
                                    [Validation(Required=false)]
                                    public int? BaggageSubContentType { get; set; }

                                    [NameInMap("description")]
                                    [Validation(Required=false)]
                                    public TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                    public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
                                        [NameInMap("desc")]
                                        [Validation(Required=false)]
                                        public string Desc { get; set; }

                                        [NameInMap("icon")]
                                        [Validation(Required=false)]
                                        public string Icon { get; set; }

                                        [NameInMap("image")]
                                        [Validation(Required=false)]
                                        public string Image { get; set; }

                                        [NameInMap("title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                    }

                                    [NameInMap("imageDO")]
                                    [Validation(Required=false)]
                                    public TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                    public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
                                        [NameInMap("image")]
                                        [Validation(Required=false)]
                                        public string Image { get; set; }

                                        [NameInMap("largest")]
                                        [Validation(Required=false)]
                                        public string Largest { get; set; }

                                        [NameInMap("middle")]
                                        [Validation(Required=false)]
                                        public string Middle { get; set; }

                                        [NameInMap("smallest")]
                                        [Validation(Required=false)]
                                        public string Smallest { get; set; }

                                    }

                                    [NameInMap("is_highlight")]
                                    [Validation(Required=false)]
                                    public bool? IsHighlight { get; set; }

                                    [NameInMap("subTitle")]
                                    [Validation(Required=false)]
                                    public string SubTitle { get; set; }

                                }

                                [NameInMap("baggage_sub_contents")]
                                [Validation(Required=false)]
                                public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContents> BaggageSubContents { get; set; }
                                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsBaggageSubItemsBaggageSubContents : TeaModel {
                                    [NameInMap("baggage_desc")]
                                    [Validation(Required=false)]
                                    public string BaggageDesc { get; set; }

                                    [NameInMap("icon")]
                                    [Validation(Required=false)]
                                    public string Icon { get; set; }

                                    [NameInMap("style")]
                                    [Validation(Required=false)]
                                    public int? Style { get; set; }

                                    [NameInMap("sub_title")]
                                    [Validation(Required=false)]
                                    public string SubTitle { get; set; }

                                }

                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("is_struct")]
                                [Validation(Required=false)]
                                public bool? IsStruct { get; set; }

                                [NameInMap("ptc")]
                                [Validation(Required=false)]
                                public string Ptc { get; set; }

                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            [NameInMap("table_head")]
                            [Validation(Required=false)]
                            public string TableHead { get; set; }

                            [NameInMap("tips")]
                            [Validation(Required=false)]
                            public TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsTips Tips { get; set; }
                            public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqBaggageDetailsTips : TeaModel {
                                [NameInMap("logo")]
                                [Validation(Required=false)]
                                public string Logo { get; set; }

                                [NameInMap("tips_desc")]
                                [Validation(Required=false)]
                                public string TipsDesc { get; set; }

                                [NameInMap("tips_image")]
                                [Validation(Required=false)]
                                public string TipsImage { get; set; }

                            }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public int? Type { get; set; }

                        }

                        [NameInMap("change_details")]
                        [Validation(Required=false)]
                        public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetails> ChangeDetails { get; set; }
                        public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetails : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetailsExtraContents> ExtraContents { get; set; }
                            public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetailsExtraContents : TeaModel {
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("icon")]
                                [Validation(Required=false)]
                                public string Icon { get; set; }

                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            [NameInMap("refund_sub_items")]
                            [Validation(Required=false)]
                            public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetailsRefundSubItems> RefundSubItems { get; set; }
                            public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetailsRefundSubItems : TeaModel {
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("is_struct")]
                                [Validation(Required=false)]
                                public bool? IsStruct { get; set; }

                                [NameInMap("ptc")]
                                [Validation(Required=false)]
                                public string Ptc { get; set; }

                                [NameInMap("refund_sub_contents")]
                                [Validation(Required=false)]
                                public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetailsRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqChangeDetailsRefundSubItemsRefundSubContents : TeaModel {
                                    [NameInMap("fee_desc")]
                                    [Validation(Required=false)]
                                    public string FeeDesc { get; set; }

                                    [NameInMap("fee_range")]
                                    [Validation(Required=false)]
                                    public string FeeRange { get; set; }

                                    [NameInMap("style")]
                                    [Validation(Required=false)]
                                    public string Style { get; set; }

                                }

                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            [NameInMap("table_head")]
                            [Validation(Required=false)]
                            public string TableHead { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public int? Type { get; set; }

                        }

                        [NameInMap("refund_details")]
                        [Validation(Required=false)]
                        public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetails> RefundDetails { get; set; }
                        public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetails : TeaModel {
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetailsExtraContents> ExtraContents { get; set; }
                            public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetailsExtraContents : TeaModel {
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("icon")]
                                [Validation(Required=false)]
                                public string Icon { get; set; }

                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            [NameInMap("refund_sub_items")]
                            [Validation(Required=false)]
                            public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetailsRefundSubItems> RefundSubItems { get; set; }
                            public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetailsRefundSubItems : TeaModel {
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                [NameInMap("is_struct")]
                                [Validation(Required=false)]
                                public bool? IsStruct { get; set; }

                                [NameInMap("ptc")]
                                [Validation(Required=false)]
                                public string Ptc { get; set; }

                                [NameInMap("refund_sub_contents")]
                                [Validation(Required=false)]
                                public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetailsRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListChangeOtaItemRuleRqRefundDetailsRefundSubItemsRefundSubContents : TeaModel {
                                    [NameInMap("fee_desc")]
                                    [Validation(Required=false)]
                                    public string FeeDesc { get; set; }

                                    [NameInMap("fee_range")]
                                    [Validation(Required=false)]
                                    public string FeeRange { get; set; }

                                    [NameInMap("style")]
                                    [Validation(Required=false)]
                                    public string Style { get; set; }

                                }

                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            [NameInMap("table_head")]
                            [Validation(Required=false)]
                            public string TableHead { get; set; }

                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public int? Type { get; set; }

                        }

                    }

                    [NameInMap("child_cabin")]
                    [Validation(Required=false)]
                    public string ChildCabin { get; set; }

                    [NameInMap("left_num")]
                    [Validation(Required=false)]
                    public string LeftNum { get; set; }

                    [NameInMap("modify_price_list")]
                    [Validation(Required=false)]
                    public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListModifyPriceList> ModifyPriceList { get; set; }
                    public class TicketChangingEnquiryResponseBodyModuleFlightInfoListCabinListModifyPriceList : TeaModel {
                        [NameInMap("passenger_type")]
                        [Validation(Required=false)]
                        public int? PassengerType { get; set; }

                        [NameInMap("ticket_price")]
                        [Validation(Required=false)]
                        public int? TicketPrice { get; set; }

                        [NameInMap("upgrade_fee")]
                        [Validation(Required=false)]
                        public int? UpgradeFee { get; set; }

                        [NameInMap("upgrade_price")]
                        [Validation(Required=false)]
                        public int? UpgradePrice { get; set; }

                    }

                    [NameInMap("ota_itemid")]
                    [Validation(Required=false)]
                    public string OtaItemid { get; set; }

                }

                [NameInMap("carrier_airline")]
                [Validation(Required=false)]
                public string CarrierAirline { get; set; }

                [NameInMap("carrier_no")]
                [Validation(Required=false)]
                public string CarrierNo { get; set; }

                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public TicketChangingEnquiryResponseBodyModuleFlightInfoListDepAirportInfo DepAirportInfo { get; set; }
                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListDepAirportInfo : TeaModel {
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                [NameInMap("is_share")]
                [Validation(Required=false)]
                public bool? IsShare { get; set; }

                [NameInMap("lowest_cabin")]
                [Validation(Required=false)]
                public string LowestCabin { get; set; }

                [NameInMap("lowest_cabin_class")]
                [Validation(Required=false)]
                public string LowestCabinClass { get; set; }

                [NameInMap("lowest_cabin_desc")]
                [Validation(Required=false)]
                public string LowestCabinDesc { get; set; }

                [NameInMap("lowest_cabin_num")]
                [Validation(Required=false)]
                public string LowestCabinNum { get; set; }

                [NameInMap("lowest_cabin_price")]
                [Validation(Required=false)]
                public List<TicketChangingEnquiryResponseBodyModuleFlightInfoListLowestCabinPrice> LowestCabinPrice { get; set; }
                public class TicketChangingEnquiryResponseBodyModuleFlightInfoListLowestCabinPrice : TeaModel {
                    [NameInMap("passenger_type")]
                    [Validation(Required=false)]
                    public int? PassengerType { get; set; }

                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                    [NameInMap("upgrade_fee")]
                    [Validation(Required=false)]
                    public int? UpgradeFee { get; set; }

                    [NameInMap("upgrade_price")]
                    [Validation(Required=false)]
                    public int? UpgradePrice { get; set; }

                }

                [NameInMap("modify_flight_arr_time")]
                [Validation(Required=false)]
                public string ModifyFlightArrTime { get; set; }

                [NameInMap("modify_flight_dep_date")]
                [Validation(Required=false)]
                public string ModifyFlightDepDate { get; set; }

                [NameInMap("modify_flight_dep_time")]
                [Validation(Required=false)]
                public string ModifyFlightDepTime { get; set; }

                [NameInMap("session_id")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

            }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
