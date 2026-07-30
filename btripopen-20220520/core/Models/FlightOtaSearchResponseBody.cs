// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightOtaSearchResponseBody : TeaModel {
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
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightOtaSearchResponseBodyModule Module { get; set; }
        public class FlightOtaSearchResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The flight information.</para>
            /// </summary>
            [NameInMap("flight_list")]
            [Validation(Required=false)]
            public List<FlightOtaSearchResponseBodyModuleFlightList> FlightList { get; set; }
            public class FlightOtaSearchResponseBodyModuleFlightList : TeaModel {
                /// <summary>
                /// <para>The marketing airline information.</para>
                /// </summary>
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightOtaSearchResponseBodyModuleFlightListAirlineInfo AirlineInfo { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListAirlineInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The airline name.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty when the operating airline information is not available.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("airline_name")]
                    [Validation(Required=false)]
                    public string AirlineName { get; set; }

                    /// <summary>
                    /// <para>The airline short name.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty when the operating airline information is not available.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>国航</para>
                    /// </summary>
                    [NameInMap("airline_simple_name")]
                    [Validation(Required=false)]
                    public string AirlineSimpleName { get; set; }

                }

                /// <summary>
                /// <para>The arrival airport information.</para>
                /// </summary>
                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightOtaSearchResponseBodyModuleFlightListArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListArrAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The three-letter code of the airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>萧山国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HGH</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <para>The city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T3</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <para>The airport construction fee.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("build_price")]
                [Validation(Required=false)]
                public int? BuildPrice { get; set; }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y</para>
                /// </summary>
                [NameInMap("cabin")]
                [Validation(Required=false)]
                public string Cabin { get; set; }

                /// <summary>
                /// <para>The cabin class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("cabin_class")]
                [Validation(Required=false)]
                public string CabinClass { get; set; }

                /// <summary>
                /// <para>The multi-cabin price information.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Returns empty when no value is available.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("cabin_info_list")]
                [Validation(Required=false)]
                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoList> CabinInfoList { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoList : TeaModel {
                    /// <summary>
                    /// <para>The agent ID.</para>
                    /// <remarks>
                    /// <para>Notice: Returns empty.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>无</para>
                    /// </summary>
                    [NameInMap("agent_id")]
                    [Validation(Required=false)]
                    public long? AgentId { get; set; }

                    /// <summary>
                    /// <para>The cabin base price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12456</para>
                    /// </summary>
                    [NameInMap("basic_cabin_price")]
                    [Validation(Required=false)]
                    public int? BasicCabinPrice { get; set; }

                    /// <summary>
                    /// <para>The airport construction fee.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("build_price")]
                    [Validation(Required=false)]
                    public int? BuildPrice { get; set; }

                    /// <summary>
                    /// <para>The cabin code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>G</para>
                    /// </summary>
                    [NameInMap("cabin")]
                    [Validation(Required=false)]
                    public string Cabin { get; set; }

                    /// <summary>
                    /// <para>The cabin class.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Y</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>The sub-cabin class display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经济舱</para>
                    /// </summary>
                    [NameInMap("cabin_class_name")]
                    [Validation(Required=false)]
                    public string CabinClassName { get; set; }

                    /// <summary>
                    /// <para>The sub-cabin code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>G</para>
                    /// </summary>
                    [NameInMap("child_cabin")]
                    [Validation(Required=false)]
                    public string ChildCabin { get; set; }

                    /// <summary>
                    /// <para>The cabin class name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经济舱</para>
                    /// </summary>
                    [NameInMap("class_name")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    /// <summary>
                    /// <para>The description of refund, change, and endorsement rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("class_rule")]
                    [Validation(Required=false)]
                    public string ClassRule { get; set; }

                    /// <summary>
                    /// <para>The discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("discount")]
                    [Validation(Required=false)]
                    public string Discount { get; set; }

                    /// <summary>
                    /// <para>The list of refund, change, and endorsement rules.</para>
                    /// </summary>
                    [NameInMap("flight_rule_list")]
                    [Validation(Required=false)]
                    public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleList> FlightRuleList { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleList : TeaModel {
                        /// <summary>
                        /// <para>The baggage allowance description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>demo</para>
                        /// </summary>
                        [NameInMap("baggage_info")]
                        [Validation(Required=false)]
                        public string BaggageInfo { get; set; }

                        /// <summary>
                        /// <para>The baggage rule.</para>
                        /// </summary>
                        [NameInMap("baggage_item")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItem BaggageItem { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItem : TeaModel {
                            /// <summary>
                            /// <para>The baggage allowance sub-content.</para>
                            /// </summary>
                            [NameInMap("baggage_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                                /// <summary>
                                /// <para>The baggage sub-content visualization.</para>
                                /// </summary>
                                [NameInMap("baggage_sub_content_visualizes")]
                                [Validation(Required=false)]
                                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                                    /// <summary>
                                    /// <para>The sub-baggage allowance title.</para>
                                    /// </summary>
                                    [NameInMap("baggage_desc")]
                                    [Validation(Required=false)]
                                    public List<string> BaggageDesc { get; set; }

                                    /// <summary>
                                    /// <para>The baggage sub-content type.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>0</para>
                                    /// </summary>
                                    [NameInMap("baggage_sub_content_type")]
                                    [Validation(Required=false)]
                                    public int? BaggageSubContentType { get; set; }

                                    /// <summary>
                                    /// <para>The description.</para>
                                    /// </summary>
                                    [NameInMap("description")]
                                    [Validation(Required=false)]
                                    public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                    public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
                                        /// <summary>
                                        /// <para>The description.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>您可以随身携带上飞机客舱内的行李物品，由旅客自行负责保管。具体尺寸、重量、类型等以各航空公司规定为准</para>
                                        /// </summary>
                                        [NameInMap("desc")]
                                        [Validation(Required=false)]
                                        public string Desc { get; set; }

                                        /// <summary>
                                        /// <para>The icon.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para><a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a></para>
                                        /// </summary>
                                        [NameInMap("icon")]
                                        [Validation(Required=false)]
                                        public string Icon { get; set; }

                                        /// <summary>
                                        /// <para>The image URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png</a></para>
                                        /// </summary>
                                        [NameInMap("image")]
                                        [Validation(Required=false)]
                                        public string Image { get; set; }

                                        /// <summary>
                                        /// <para>The image title.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>手提行李说明</para>
                                        /// </summary>
                                        [NameInMap("title")]
                                        [Validation(Required=false)]
                                        public string Title { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>The image information.</para>
                                    /// </summary>
                                    [NameInMap("image_d_o")]
                                    [Validation(Required=false)]
                                    public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                    public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
                                        /// <summary>
                                        /// <para>The URL.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>demo</para>
                                        /// </summary>
                                        [NameInMap("image")]
                                        [Validation(Required=false)]
                                        public string Image { get; set; }

                                        /// <summary>
                                        /// <para>The maximum quantity.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>50</para>
                                        /// </summary>
                                        [NameInMap("largest")]
                                        [Validation(Required=false)]
                                        public string Largest { get; set; }

                                        /// <summary>
                                        /// <para>The middle value.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>40</para>
                                        /// </summary>
                                        [NameInMap("middle")]
                                        [Validation(Required=false)]
                                        public string Middle { get; set; }

                                        /// <summary>
                                        /// <para>The minimum value.</para>
                                        /// 
                                        /// <b>Example:</b>
                                        /// <para>20</para>
                                        /// </summary>
                                        [NameInMap("smallest")]
                                        [Validation(Required=false)]
                                        public string Smallest { get; set; }

                                    }

                                    /// <summary>
                                    /// <para>Indicates whether the content is highlighted.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>true</para>
                                    /// </summary>
                                    [NameInMap("is_highlight")]
                                    [Validation(Required=false)]
                                    public bool? IsHighlight { get; set; }

                                    /// <summary>
                                    /// <para>The subtitle.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>免费手提行李</para>
                                    /// </summary>
                                    [NameInMap("sub_title")]
                                    [Validation(Required=false)]
                                    public string SubTitle { get; set; }

                                }

                                /// <summary>
                                /// <para>(Not available)</para>
                                /// </summary>
                                [NameInMap("extra_content_visualizes")]
                                [Validation(Required=false)]
                                public List<object> ExtraContentVisualizes { get; set; }

                                /// <summary>
                                /// <para>Indicates whether the content is structured.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("is_struct")]
                                [Validation(Required=false)]
                                public bool? IsStruct { get; set; }

                                /// <summary>
                                /// <para>PTC</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ADT</para>
                                /// </summary>
                                [NameInMap("ptc")]
                                [Validation(Required=false)]
                                public string Ptc { get; set; }

                                /// <summary>
                                /// <para>The title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>成人</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>The sorting index.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            /// <summary>
                            /// <para>The table header content (e.g., outbound route Beijing-Shanghai).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>北京-上海)</para>
                            /// </summary>
                            [NameInMap("table_head")]
                            [Validation(Required=false)]
                            public string TableHead { get; set; }

                            /// <summary>
                            /// <para>The tips.</para>
                            /// </summary>
                            [NameInMap("tips")]
                            [Validation(Required=false)]
                            public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips Tips { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListBaggageItemTips : TeaModel {
                                /// <summary>
                                /// <para>The avatar URL.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png">https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png</a></para>
                                /// </summary>
                                [NameInMap("logo")]
                                [Validation(Required=false)]
                                public string Logo { get; set; }

                                /// <summary>
                                /// <para>The tip description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>各个尺寸的行李箱有多大</para>
                                /// </summary>
                                [NameInMap("tips_desc")]
                                [Validation(Required=false)]
                                public string TipsDesc { get; set; }

                                /// <summary>
                                /// <para>The image URL.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01rJxjw61f3bXNHAmlk_!!6000000003951-2-tps-1050-675.png">https://gw.alicdn.com/imgextra/i3/O1CN01rJxjw61f3bXNHAmlk_!!6000000003951-2-tps-1050-675.png</a></para>
                                /// </summary>
                                [NameInMap("tips_image")]
                                [Validation(Required=false)]
                                public string TipsImage { get; set; }

                            }

                            /// <summary>
                            /// <para>The table title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>退票规则/同舱改期规则</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            /// <summary>
                            /// <para>The content type. 0: refund. 1: change.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public int? Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The change rule.</para>
                        /// </summary>
                        [NameInMap("change_rule")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule ChangeRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRule : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether this is a struct.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            /// <summary>
                            /// <para>The preview information.</para>
                            /// </summary>
                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleInfo : TeaModel {
                                /// <summary>
                                /// <para>The content.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>同改签规则里的说明</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The fee.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("cost")]
                                [Validation(Required=false)]
                                public int? Cost { get; set; }

                                /// <summary>
                                /// <para>The fee percentage.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("cost_percent")]
                                [Validation(Required=false)]
                                public int? CostPercent { get; set; }

                                /// <summary>
                                /// <para>The sorting timestamp.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1675036500000</para>
                                /// </summary>
                                [NameInMap("time_stamp")]
                                [Validation(Required=false)]
                                public int? TimeStamp { get; set; }

                                /// <summary>
                                /// <para>Specifies whether the time is before or after the time node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("time_type")]
                                [Validation(Required=false)]
                                public string TimeType { get; set; }

                                /// <summary>
                                /// <para>The text title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>改签规则</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The change rule description.</para>
                        /// </summary>
                        [NameInMap("change_rule_item")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItem : TeaModel {
                            /// <summary>
                            /// <para>content: Non-endorsable.</para>
                            /// </summary>
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemExtraContents : TeaModel {
                                /// <summary>
                                /// <para>The description content.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The content title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>The sorting index.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            /// <summary>
                            /// <para>The refund and change rule content.</para>
                            /// </summary>
                            [NameInMap("refund_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the content is structured.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("is_struct")]
                                [Validation(Required=false)]
                                public bool? IsStruct { get; set; }

                                /// <summary>
                                /// <para>PTC</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ADT</para>
                                /// </summary>
                                [NameInMap("ptc")]
                                [Validation(Required=false)]
                                public string Ptc { get; set; }

                                /// <summary>
                                /// <para>The refund sub-content.</para>
                                /// </summary>
                                [NameInMap("refund_sub_contents")]
                                [Validation(Required=false)]
                                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
                                    /// <summary>
                                    /// <para>The fee description.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>￥161/人</para>
                                    /// </summary>
                                    [NameInMap("fee_desc")]
                                    [Validation(Required=false)]
                                    public string FeeDesc { get; set; }

                                    /// <summary>
                                    /// <para>The fee range.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1月23日 09:30 前</para>
                                    /// </summary>
                                    [NameInMap("fee_range")]
                                    [Validation(Required=false)]
                                    public string FeeRange { get; set; }

                                    /// <summary>
                                    /// <para>The style.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("style")]
                                    [Validation(Required=false)]
                                    public int? Style { get; set; }

                                }

                                /// <summary>
                                /// <para>The type of the refund and change rule.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>成人</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>Consistent with the number of columns in the sub-content.</para>
                            /// </summary>
                            [NameInMap("sub_table_head")]
                            [Validation(Required=false)]
                            public List<string> SubTableHead { get; set; }

                            /// <summary>
                            /// <para>The table header content (e.g., outbound route Beijing-Shanghai).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>北京-上海</para>
                            /// </summary>
                            [NameInMap("table_head")]
                            [Validation(Required=false)]
                            public string TableHead { get; set; }

                            /// <summary>
                            /// <para>The table title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>退票规则/同舱改期规则</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            /// <summary>
                            /// <para>The content type. 0: refund. 1: change.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>0</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public int? Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The extra information.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{}</para>
                        /// </summary>
                        [NameInMap("extra")]
                        [Validation(Required=false)]
                        public string Extra { get; set; }

                        /// <summary>
                        /// <para>The refund rule.</para>
                        /// </summary>
                        [NameInMap("refund_rule")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule RefundRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRule : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the change is allowed.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            /// <summary>
                            /// <para>The preview information.</para>
                            /// </summary>
                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleInfo : TeaModel {
                                /// <summary>
                                /// <para>The fee description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>同改签规则里的说明</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The fee.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("cost")]
                                [Validation(Required=false)]
                                public int? Cost { get; set; }

                                /// <summary>
                                /// <para>The fee percentage.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("cost_percent")]
                                [Validation(Required=false)]
                                public int? CostPercent { get; set; }

                                /// <summary>
                                /// <para>The sorting timestamp.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1675036500000</para>
                                /// </summary>
                                [NameInMap("time_stamp")]
                                [Validation(Required=false)]
                                public int? TimeStamp { get; set; }

                                /// <summary>
                                /// <para>Specifies whether the time is before or after the time node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("time_type")]
                                [Validation(Required=false)]
                                public string TimeType { get; set; }

                                /// <summary>
                                /// <para>The text title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>退票规则</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The refund rule.</para>
                        /// </summary>
                        [NameInMap("refund_rule_item")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItem : TeaModel {
                            /// <summary>
                            /// <para>The supplementary description text.</para>
                            /// </summary>
                            [NameInMap("extra_contents")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemExtraContents : TeaModel {
                                /// <summary>
                                /// <para>The content text.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The content title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>The sorting index.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("index")]
                            [Validation(Required=false)]
                            public int? Index { get; set; }

                            /// <summary>
                            /// <para>The refund and change rule content.</para>
                            /// </summary>
                            [NameInMap("refund_sub_items")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
                                /// <summary>
                                /// <para>Indicates whether the content is structured.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("is_struct")]
                                [Validation(Required=false)]
                                public bool? IsStruct { get; set; }

                                /// <summary>
                                /// <para>PTC</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ADT</para>
                                /// </summary>
                                [NameInMap("ptc")]
                                [Validation(Required=false)]
                                public string Ptc { get; set; }

                                /// <summary>
                                /// <para>feeDesc: ￥156/person.</para>
                                /// </summary>
                                [NameInMap("refund_sub_contents")]
                                [Validation(Required=false)]
                                public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
                                    /// <summary>
                                    /// <para>The fee description.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>￥161/人</para>
                                    /// </summary>
                                    [NameInMap("fee_desc")]
                                    [Validation(Required=false)]
                                    public string FeeDesc { get; set; }

                                    /// <summary>
                                    /// <para>The fee range.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1月23日 09:30 前</para>
                                    /// </summary>
                                    [NameInMap("fee_range")]
                                    [Validation(Required=false)]
                                    public string FeeRange { get; set; }

                                    /// <summary>
                                    /// <para>The type.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>1</para>
                                    /// </summary>
                                    [NameInMap("style")]
                                    [Validation(Required=false)]
                                    public int? Style { get; set; }

                                }

                                /// <summary>
                                /// <para>The title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>规则</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                            /// <summary>
                            /// <para>Consistent with the number of columns in the sub-content.</para>
                            /// </summary>
                            [NameInMap("sub_table_head")]
                            [Validation(Required=false)]
                            public List<string> SubTableHead { get; set; }

                            /// <summary>
                            /// <para>The table header content (e.g., outbound route Beijing-Shanghai).</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>北京-上海)</para>
                            /// </summary>
                            [NameInMap("table_head")]
                            [Validation(Required=false)]
                            public string TableHead { get; set; }

                            /// <summary>
                            /// <para>The table title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                            /// <summary>
                            /// <para>The content type. 0: refund. 1: change.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1</para>
                            /// </summary>
                            [NameInMap("type")]
                            [Validation(Required=false)]
                            public int? Type { get; set; }

                        }

                        /// <summary>
                        /// <para>The endorsement rule.</para>
                        /// </summary>
                        [NameInMap("sign_rule")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule SignRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRule : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether this is a struct.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            /// <summary>
                            /// <para>The preview information.</para>
                            /// </summary>
                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListSignRuleInfo : TeaModel {
                                /// <summary>
                                /// <para>The fee description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>同改签规则里的说明</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The fee.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("cost")]
                                [Validation(Required=false)]
                                public int? Cost { get; set; }

                                /// <summary>
                                /// <para>The fee percentage.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("cost_percent")]
                                [Validation(Required=false)]
                                public int? CostPercent { get; set; }

                                /// <summary>
                                /// <para>The sorting timestamp.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1675036500000</para>
                                /// </summary>
                                [NameInMap("time_stamp")]
                                [Validation(Required=false)]
                                public int? TimeStamp { get; set; }

                                /// <summary>
                                /// <para>Specifies whether the time is before or after the time node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("time_type")]
                                [Validation(Required=false)]
                                public string TimeType { get; set; }

                                /// <summary>
                                /// <para>The text title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>签转规则</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The description of refund, change, and endorsement rules.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>文案</para>
                        /// </summary>
                        [NameInMap("tuigaiqian_info")]
                        [Validation(Required=false)]
                        public string TuigaiqianInfo { get; set; }

                        /// <summary>
                        /// <para>The upgrade rule.</para>
                        /// </summary>
                        [NameInMap("upgrade_rule")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRule : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the change is allowed.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("able")]
                            [Validation(Required=false)]
                            public bool? Able { get; set; }

                            /// <summary>
                            /// <para>The preview information.</para>
                            /// </summary>
                            [NameInMap("info")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRuleInfo> Info { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListCabinInfoListFlightRuleListUpgradeRuleInfo : TeaModel {
                                /// <summary>
                                /// <para>The fee description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>同上面规则里的说明</para>
                                /// </summary>
                                [NameInMap("content")]
                                [Validation(Required=false)]
                                public string Content { get; set; }

                                /// <summary>
                                /// <para>The fee.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>100</para>
                                /// </summary>
                                [NameInMap("cost")]
                                [Validation(Required=false)]
                                public int? Cost { get; set; }

                                /// <summary>
                                /// <para>The fee percentage.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>10</para>
                                /// </summary>
                                [NameInMap("cost_percent")]
                                [Validation(Required=false)]
                                public int? CostPercent { get; set; }

                                /// <summary>
                                /// <para>The sorting timestamp.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1675036500000</para>
                                /// </summary>
                                [NameInMap("time_stamp")]
                                [Validation(Required=false)]
                                public int? TimeStamp { get; set; }

                                /// <summary>
                                /// <para>Specifies whether the time is before or after the time node.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>demo</para>
                                /// </summary>
                                [NameInMap("time_type")]
                                [Validation(Required=false)]
                                public string TimeType { get; set; }

                                /// <summary>
                                /// <para>The text title.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>升舱规则</para>
                                /// </summary>
                                [NameInMap("title")]
                                [Validation(Required=false)]
                                public string Title { get; set; }

                            }

                        }

                    }

                    /// <summary>
                    /// <para>The refund, change, and endorsement rules in JSON format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("flight_rule_list_str")]
                    [Validation(Required=false)]
                    public string FlightRuleListStr { get; set; }

                    /// <summary>
                    /// <para>The itinerary receipt type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("invoice_type")]
                    [Validation(Required=false)]
                    public int? InvoiceType { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the price is a negotiated price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("is_protocol")]
                    [Validation(Required=false)]
                    public bool? IsProtocol { get; set; }

                    /// <summary>
                    /// <para>The fuel surcharge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("oil_price")]
                    [Validation(Required=false)]
                    public int? OilPrice { get; set; }

                    /// <summary>
                    /// <para>The encrypted parameters, which contain the agentId and other parameter information required for placing an order.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000_1_0</para>
                    /// </summary>
                    [NameInMap("order_params")]
                    [Validation(Required=false)]
                    public string OrderParams { get; set; }

                    /// <summary>
                    /// <para>The product ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>97f64e2d6f61408a827dd523817fefd6_0</para>
                    /// </summary>
                    [NameInMap("ota_item_id")]
                    [Validation(Required=false)]
                    public string OtaItemId { get; set; }

                    /// <summary>
                    /// <para>The ticket selling price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public int? Price { get; set; }

                    /// <summary>
                    /// <para>The product type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("product_type")]
                    [Validation(Required=false)]
                    public long? ProductType { get; set; }

                    /// <summary>
                    /// <para>The standard or non-standard product type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("product_type_desc")]
                    [Validation(Required=false)]
                    public string ProductTypeDesc { get; set; }

                    /// <summary>
                    /// <para>The promotional price.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("promotion_price")]
                    [Validation(Required=false)]
                    public string PromotionPrice { get; set; }

                    /// <summary>
                    /// <para>The number of remaining seats.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("remained_seat_count")]
                    [Validation(Required=false)]
                    public string RemainedSeatCount { get; set; }

                    /// <summary>
                    /// <para>The face value price of the ticket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("ticket_price")]
                    [Validation(Required=false)]
                    public int? TicketPrice { get; set; }

                    /// <summary>
                    /// <para>The total price, which equals the ticket price plus the construction fee plus the fuel surcharge.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("total_price")]
                    [Validation(Required=false)]
                    public int? TotalPrice { get; set; }

                }

                /// <summary>
                /// <para>The operating flight information. This field has a value only for codeshare flights.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FM</para>
                /// </summary>
                [NameInMap("carrier_airline")]
                [Validation(Required=false)]
                public string CarrierAirline { get; set; }

                /// <summary>
                /// <para>The operating flight information. This field has a value only for codeshare flights.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FM9152</para>
                /// </summary>
                [NameInMap("carrier_no")]
                [Validation(Required=false)]
                public string CarrierNo { get; set; }

                /// <summary>
                /// <para>The departure airport information.</para>
                /// </summary>
                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightOtaSearchResponseBodyModuleFlightListDepAirportInfo DepAirportInfo { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListDepAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The three-letter code of the airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PEK</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Returns empty when no value is available.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京首都国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>BJS</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <para>The city name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T3</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("discount")]
                [Validation(Required=false)]
                public int? Discount { get; set; }

                /// <summary>
                /// <para>The marketing flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1234</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The list of refund, change, and endorsement rules.</para>
                /// </summary>
                [NameInMap("flight_rule_list")]
                [Validation(Required=false)]
                public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleList> FlightRuleList { get; set; }
                public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleList : TeaModel {
                    /// <summary>
                    /// <para>The baggage allowance description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>demo</para>
                    /// </summary>
                    [NameInMap("baggage_info")]
                    [Validation(Required=false)]
                    public string BaggageInfo { get; set; }

                    /// <summary>
                    /// <para>The baggage rule.</para>
                    /// </summary>
                    [NameInMap("baggage_item")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItem BaggageItem { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItem : TeaModel {
                        /// <summary>
                        /// <para>The baggage allowance sub-content.</para>
                        /// </summary>
                        [NameInMap("baggage_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems> BaggageSubItems { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItems : TeaModel {
                            /// <summary>
                            /// <para>The baggage sub-content visualization.</para>
                            /// </summary>
                            [NameInMap("baggage_sub_content_visualizes")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes> BaggageSubContentVisualizes { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizes : TeaModel {
                                /// <summary>
                                /// <para>The sub-baggage allowance title.</para>
                                /// </summary>
                                [NameInMap("baggage_desc")]
                                [Validation(Required=false)]
                                public List<string> BaggageDesc { get; set; }

                                /// <summary>
                                /// <para>The baggage sub-content type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("baggage_sub_content_type")]
                                [Validation(Required=false)]
                                public int? BaggageSubContentType { get; set; }

                                /// <summary>
                                /// <para>The baggage description.</para>
                                /// </summary>
                                [NameInMap("description")]
                                [Validation(Required=false)]
                                public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription Description { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesDescription : TeaModel {
                                    /// <summary>
                                    /// <para>The description.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>您可以随身携带上飞机客舱内的行李物品，由旅客自行负责保管。具体尺寸、重量、类型等以各航空公司规定为准</para>
                                    /// </summary>
                                    [NameInMap("desc")]
                                    [Validation(Required=false)]
                                    public string Desc { get; set; }

                                    /// <summary>
                                    /// <para>The icon.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para><a href="https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png">https://gw.alicdn.com/imgextra/i4/O1CN01UynXG31pjsEtA3tMF_!!6000000005397-2-tps-36-36.png</a></para>
                                    /// </summary>
                                    [NameInMap("icon")]
                                    [Validation(Required=false)]
                                    public string Icon { get; set; }

                                    /// <summary>
                                    /// <para>The image URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png">https://gw.alicdn.com/imgextra/i1/O1CN01qe7wL21gJ0SmEXXL7_!!6000000004120-2-tps-1206-768.png</a></para>
                                    /// </summary>
                                    [NameInMap("image")]
                                    [Validation(Required=false)]
                                    public string Image { get; set; }

                                    /// <summary>
                                    /// <para>The image title.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>手提行李说明</para>
                                    /// </summary>
                                    [NameInMap("title")]
                                    [Validation(Required=false)]
                                    public string Title { get; set; }

                                }

                                /// <summary>
                                /// <para>The image information.</para>
                                /// </summary>
                                [NameInMap("image_d_o")]
                                [Validation(Required=false)]
                                public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO ImageDO { get; set; }
                                public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemBaggageSubItemsBaggageSubContentVisualizesImageDO : TeaModel {
                                    /// <summary>
                                    /// <para>The URL.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>demo</para>
                                    /// </summary>
                                    [NameInMap("image")]
                                    [Validation(Required=false)]
                                    public string Image { get; set; }

                                    /// <summary>
                                    /// <para>The maximum quantity.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>50</para>
                                    /// </summary>
                                    [NameInMap("largest")]
                                    [Validation(Required=false)]
                                    public string Largest { get; set; }

                                    /// <summary>
                                    /// <para>The middle value.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>40</para>
                                    /// </summary>
                                    [NameInMap("middle")]
                                    [Validation(Required=false)]
                                    public string Middle { get; set; }

                                    /// <summary>
                                    /// <para>The minimum value.</para>
                                    /// 
                                    /// <b>Example:</b>
                                    /// <para>20</para>
                                    /// </summary>
                                    [NameInMap("smallest")]
                                    [Validation(Required=false)]
                                    public string Smallest { get; set; }

                                }

                                /// <summary>
                                /// <para>Indicates whether the content is highlighted.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>true</para>
                                /// </summary>
                                [NameInMap("is_highlight")]
                                [Validation(Required=false)]
                                public bool? IsHighlight { get; set; }

                                /// <summary>
                                /// <para>The subtitle.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>免费手提行李</para>
                                /// </summary>
                                [NameInMap("sub_title")]
                                [Validation(Required=false)]
                                public string SubTitle { get; set; }

                            }

                            /// <summary>
                            /// <para>(Not available)</para>
                            /// </summary>
                            [NameInMap("extra_content_visualizes")]
                            [Validation(Required=false)]
                            public List<object> ExtraContentVisualizes { get; set; }

                            /// <summary>
                            /// <para>Indicates whether the content is structured.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// <para>PTC</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ADT</para>
                            /// </summary>
                            [NameInMap("ptc")]
                            [Validation(Required=false)]
                            public string Ptc { get; set; }

                            /// <summary>
                            /// <para>The title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>成人</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        /// <summary>
                        /// <para>The sorting index.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The table header content (e.g., outbound route Beijing-Shanghai).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>北京-上海</para>
                        /// </summary>
                        [NameInMap("table_head")]
                        [Validation(Required=false)]
                        public string TableHead { get; set; }

                        /// <summary>
                        /// <para>The tips.</para>
                        /// </summary>
                        [NameInMap("tips")]
                        [Validation(Required=false)]
                        public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemTips Tips { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListBaggageItemTips : TeaModel {
                            /// <summary>
                            /// <para>The avatar URL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png">https://gw.alicdn.com/imgextra/i1/O1CN019zl3WZ22fNLxzx2cR_!!6000000007147-2-tps-125-45.png</a></para>
                            /// </summary>
                            [NameInMap("logo")]
                            [Validation(Required=false)]
                            public string Logo { get; set; }

                            /// <summary>
                            /// <para>The tip description.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>各个尺寸的行李箱有多大</para>
                            /// </summary>
                            [NameInMap("tips_desc")]
                            [Validation(Required=false)]
                            public string TipsDesc { get; set; }

                            /// <summary>
                            /// <para>The image URL.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para><a href="https://gw.alicdn.com/imgextra/i3/O1CN01rJxjw61f3bXNHAmlk_!!6000000003951-2-tps-1050-675.png">https://gw.alicdn.com/imgextra/i3/O1CN01rJxjw61f3bXNHAmlk_!!6000000003951-2-tps-1050-675.png</a></para>
                            /// </summary>
                            [NameInMap("tips_image")]
                            [Validation(Required=false)]
                            public string TipsImage { get; set; }

                        }

                        /// <summary>
                        /// <para>The table title.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>退票规则/同舱改期规则</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <para>The content type. 0: refund. 1: change.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The change rule.</para>
                    /// </summary>
                    [NameInMap("change_rule")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRule ChangeRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRule : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the change is allowed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        /// <summary>
                        /// <para>The preview information.</para>
                        /// </summary>
                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleInfo : TeaModel {
                            /// <summary>
                            /// <para>The content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>改期如存在票面差价，需同时收取差价和改期费。除另有规定外，客票有效期自旅行之日起，一年内承运有效；如果客票全部未使用，则从填开客票之日起，一年内承运有效。变更后客票的有效期以旧客票有效期为</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The fee.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <para>The fee percentage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <para>The sorting timestamp.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the time is before or after the time node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            /// <summary>
                            /// <para>The text title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>行李规定</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The change rule description.</para>
                    /// </summary>
                    [NameInMap("change_rule_item")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItem ChangeRuleItem { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItem : TeaModel {
                        /// <summary>
                        /// <para>content: Non-endorsable.</para>
                        /// </summary>
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemExtraContents : TeaModel {
                            /// <summary>
                            /// <para>The description content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>如允许改期的客票在变更时产生票价差价，需加收差价费用，换开后客票提交退票，已收取的变更手续费不退。改期后提交退票，客票自填开之日起，一年内必须开始旅行，自首次旅行开始之日起，一年内运输有效；客票全部未使用的，则从填开客票之日起，一年内有效</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>特殊说明</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        /// <summary>
                        /// <para>The sorting index.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The refund sub-content.</para>
                        /// </summary>
                        [NameInMap("refund_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItems : TeaModel {
                            /// <summary>
                            /// <para>isStruct : true</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// <para>PTC</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ADT</para>
                            /// </summary>
                            [NameInMap("ptc")]
                            [Validation(Required=false)]
                            public string Ptc { get; set; }

                            /// <summary>
                            /// <para>The refund sub-content.</para>
                            /// </summary>
                            [NameInMap("refund_sub_contents")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListChangeRuleItemRefundSubItemsRefundSubContents : TeaModel {
                                /// <summary>
                                /// <para>The fee description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>￥161/人</para>
                                /// </summary>
                                [NameInMap("fee_desc")]
                                [Validation(Required=false)]
                                public string FeeDesc { get; set; }

                                /// <summary>
                                /// <para>The fee range.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1月23日 09:30 前</para>
                                /// </summary>
                                [NameInMap("fee_range")]
                                [Validation(Required=false)]
                                public string FeeRange { get; set; }

                                /// <summary>
                                /// <para>The type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("style")]
                                [Validation(Required=false)]
                                public int? Style { get; set; }

                            }

                            /// <summary>
                            /// <para>The form name.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>退票规则/同舱改期规则</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        /// <summary>
                        /// <para>Consistent with the number of columns in the sub-content.</para>
                        /// </summary>
                        [NameInMap("sub_table_head")]
                        [Validation(Required=false)]
                        public List<string> SubTableHead { get; set; }

                        /// <summary>
                        /// <para>The table header content (e.g., outbound route Beijing-Shanghai).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>北京-上海</para>
                        /// </summary>
                        [NameInMap("table_head")]
                        [Validation(Required=false)]
                        public string TableHead { get; set; }

                        /// <summary>
                        /// <para>The table title.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>退票规则/同舱改期规则</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <para>The content type. 0: refund. 1: change.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The extra information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{}</para>
                    /// </summary>
                    [NameInMap("extra")]
                    [Validation(Required=false)]
                    public string Extra { get; set; }

                    /// <summary>
                    /// <para>The refund rule.</para>
                    /// </summary>
                    [NameInMap("refund_rule")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRule RefundRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRule : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the change is allowed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        /// <summary>
                        /// <para>The preview information.</para>
                        /// </summary>
                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleInfo : TeaModel {
                            /// <summary>
                            /// <para>The text content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>同上</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The fee.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <para>The fee percentage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <para>The sorting timestamp.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the time is before or after the time node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            /// <summary>
                            /// <para>The text title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>行李规定</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The refund rule.</para>
                    /// </summary>
                    [NameInMap("refund_rule_item")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItem RefundRuleItem { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItem : TeaModel {
                        /// <summary>
                        /// <para>content: Non-endorsable.</para>
                        /// </summary>
                        [NameInMap("extra_contents")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents> ExtraContents { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemExtraContents : TeaModel {
                            /// <summary>
                            /// <para>The description content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The content title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        /// <summary>
                        /// <para>The sorting index.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        /// <summary>
                        /// <para>The object.</para>
                        /// </summary>
                        [NameInMap("refund_sub_items")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems> RefundSubItems { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItems : TeaModel {
                            /// <summary>
                            /// <para>Indicates whether the content is structured.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>true</para>
                            /// </summary>
                            [NameInMap("is_struct")]
                            [Validation(Required=false)]
                            public bool? IsStruct { get; set; }

                            /// <summary>
                            /// <para>PTC</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ADT</para>
                            /// </summary>
                            [NameInMap("ptc")]
                            [Validation(Required=false)]
                            public string Ptc { get; set; }

                            /// <summary>
                            /// <para>feeDesc: ￥156/person.</para>
                            /// </summary>
                            [NameInMap("refund_sub_contents")]
                            [Validation(Required=false)]
                            public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents> RefundSubContents { get; set; }
                            public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListRefundRuleItemRefundSubItemsRefundSubContents : TeaModel {
                                /// <summary>
                                /// <para>The fee description.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>￥161/人</para>
                                /// </summary>
                                [NameInMap("fee_desc")]
                                [Validation(Required=false)]
                                public string FeeDesc { get; set; }

                                /// <summary>
                                /// <para>The fee range.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1月23日 09:30 前</para>
                                /// </summary>
                                [NameInMap("fee_range")]
                                [Validation(Required=false)]
                                public string FeeRange { get; set; }

                                /// <summary>
                                /// <para>The type.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>1</para>
                                /// </summary>
                                [NameInMap("style")]
                                [Validation(Required=false)]
                                public int? Style { get; set; }

                            }

                            /// <summary>
                            /// <para>The title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>规则</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                        /// <summary>
                        /// <para>Consistent with the number of columns in the sub-content.</para>
                        /// </summary>
                        [NameInMap("sub_table_head")]
                        [Validation(Required=false)]
                        public List<string> SubTableHead { get; set; }

                        /// <summary>
                        /// <para>The table header content (e.g., outbound route Beijing-Shanghai).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>北京-上海</para>
                        /// </summary>
                        [NameInMap("table_head")]
                        [Validation(Required=false)]
                        public string TableHead { get; set; }

                        /// <summary>
                        /// <para>The table title.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>退票规则/同舱改期规则</para>
                        /// </summary>
                        [NameInMap("title")]
                        [Validation(Required=false)]
                        public string Title { get; set; }

                        /// <summary>
                        /// <para>The content type. 0: refund. 1: change.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("type")]
                        [Validation(Required=false)]
                        public int? Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The endorsement rule.</para>
                    /// </summary>
                    [NameInMap("sign_rule")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRule SignRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRule : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the change is allowed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        /// <summary>
                        /// <para>The preview information.</para>
                        /// </summary>
                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListSignRuleInfo : TeaModel {
                            /// <summary>
                            /// <para>The content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>同上</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The fee.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <para>The fee percentage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <para>The sorting timestamp.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the time is before or after the time node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            /// <summary>
                            /// <para>The text title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>签转规则</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The description of refund, change, and endorsement rules.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>文案</para>
                    /// </summary>
                    [NameInMap("tuigaiqian_info")]
                    [Validation(Required=false)]
                    public string TuigaiqianInfo { get; set; }

                    /// <summary>
                    /// <para>The upgrade rule.</para>
                    /// </summary>
                    [NameInMap("upgrade_rule")]
                    [Validation(Required=false)]
                    public FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRule UpgradeRule { get; set; }
                    public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRule : TeaModel {
                        /// <summary>
                        /// <para>Indicates whether the change is allowed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("able")]
                        [Validation(Required=false)]
                        public bool? Able { get; set; }

                        /// <summary>
                        /// <para>The preview information.</para>
                        /// </summary>
                        [NameInMap("info")]
                        [Validation(Required=false)]
                        public List<FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo> Info { get; set; }
                        public class FlightOtaSearchResponseBodyModuleFlightListFlightRuleListUpgradeRuleInfo : TeaModel {
                            /// <summary>
                            /// <para>The text content.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>同上</para>
                            /// </summary>
                            [NameInMap("content")]
                            [Validation(Required=false)]
                            public string Content { get; set; }

                            /// <summary>
                            /// <para>The fee.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>100</para>
                            /// </summary>
                            [NameInMap("cost")]
                            [Validation(Required=false)]
                            public int? Cost { get; set; }

                            /// <summary>
                            /// <para>The fee percentage.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>10</para>
                            /// </summary>
                            [NameInMap("cost_percent")]
                            [Validation(Required=false)]
                            public int? CostPercent { get; set; }

                            /// <summary>
                            /// <para>The sorting timestamp.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>1675036500000</para>
                            /// </summary>
                            [NameInMap("time_stamp")]
                            [Validation(Required=false)]
                            public int? TimeStamp { get; set; }

                            /// <summary>
                            /// <para>Specifies whether the time is before or after the time node.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>demo</para>
                            /// </summary>
                            [NameInMap("time_type")]
                            [Validation(Required=false)]
                            public string TimeType { get; set; }

                            /// <summary>
                            /// <para>The text title.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>升舱规则</para>
                            /// </summary>
                            [NameInMap("title")]
                            [Validation(Required=false)]
                            public string Title { get; set; }

                        }

                    }

                }

                /// <summary>
                /// <para>The refund, change, and endorsement rules in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("flight_rule_list_str")]
                [Validation(Required=false)]
                public string FlightRuleListStr { get; set; }

                /// <summary>
                /// <para>The aircraft size.</para>
                /// 
                /// <b>Example:</b>
                /// <para>中型机</para>
                /// </summary>
                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

                /// <summary>
                /// <para>The aircraft model number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>demo</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <para>The itinerary receipt type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_type")]
                [Validation(Required=false)]
                public int? InvoiceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the price is a negotiated price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("is_protocol")]
                [Validation(Required=false)]
                public bool? IsProtocol { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight is a codeshare flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_share")]
                [Validation(Required=false)]
                public bool? IsShare { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight has a stopover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_stop")]
                [Validation(Required=false)]
                public bool? IsStop { get; set; }

                /// <summary>
                /// <para>Indicates whether the flight has a transfer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("is_transfer")]
                [Validation(Required=false)]
                public bool? IsTransfer { get; set; }

                /// <summary>
                /// <para>The meal service description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无餐食</para>
                /// </summary>
                [NameInMap("meal_desc")]
                [Validation(Required=false)]
                public string MealDesc { get; set; }

                /// <summary>
                /// <para>The fuel surcharge.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("oil_price")]
                [Validation(Required=false)]
                public int? OilPrice { get; set; }

                /// <summary>
                /// <para>The product ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6669c8e53b684105b8687bad0331988a_41</para>
                /// </summary>
                [NameInMap("ota_item_id")]
                [Validation(Required=false)]
                public string OtaItemId { get; set; }

                /// <summary>
                /// <para>The selling price of the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public int? Price { get; set; }

                /// <summary>
                /// <para>The product type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("product_type")]
                [Validation(Required=false)]
                public long? ProductType { get; set; }

                /// <summary>
                /// <para>The product type description.</para>
                /// <remarks>
                /// <para>Two types:</para>
                /// <list type="bullet">
                /// <item><description>Standard product</description></item>
                /// <item><description>Non-standard product</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>标准产品</para>
                /// </summary>
                [NameInMap("product_type_desc")]
                [Validation(Required=false)]
                public string ProductTypeDesc { get; set; }

                /// <summary>
                /// <para>The promotional price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("promotion_price")]
                [Validation(Required=false)]
                public string PromotionPrice { get; set; }

                /// <summary>
                /// <para>The number of remaining seats.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("remained_seat_count")]
                [Validation(Required=false)]
                public string RemainedSeatCount { get; set; }

                /// <summary>
                /// <para>The encrypted parameters, including agentId and other information required for placing orders.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000_1_0</para>
                /// </summary>
                [NameInMap("secret_params")]
                [Validation(Required=false)]
                public string SecretParams { get; set; }

                /// <summary>
                /// <para>The segment number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("segment_number")]
                [Validation(Required=false)]
                public string SegmentNumber { get; set; }

                /// <summary>
                /// <para>The arrival time at the stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("stop_arr_time")]
                [Validation(Required=false)]
                public string StopArrTime { get; set; }

                /// <summary>
                /// <para>The stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("stop_city")]
                [Validation(Required=false)]
                public string StopCity { get; set; }

                /// <summary>
                /// <para>The departure time from the stopover city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>yyyy-MM-dd HH:mm:ss</para>
                /// </summary>
                [NameInMap("stop_dep_time")]
                [Validation(Required=false)]
                public string StopDepTime { get; set; }

                /// <summary>
                /// <para>The face value price of the ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("ticket_price")]
                [Validation(Required=false)]
                public int? TicketPrice { get; set; }

                /// <summary>
                /// <para>The total price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("total_price")]
                [Validation(Required=false)]
                public string TotalPrice { get; set; }

                /// <summary>
                /// <para>The route type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_type")]
                [Validation(Required=false)]
                public int? TripType { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
        /// <para>The global trace identifier of the request, typically used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
