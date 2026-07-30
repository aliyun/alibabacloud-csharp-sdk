// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightModifyOtaSearchV2ResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
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
        /// <para>module</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightModifyOtaSearchV2ResponseBodyModule Module { get; set; }
        public class FlightModifyOtaSearchV2ResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The list of secondary screen agent information with quotations.</para>
            /// </summary>
            [NameInMap("agentInfos")]
            [Validation(Required=false)]
            public List<FlightModifyOtaSearchV2ResponseBodyModuleAgentInfos> AgentInfos { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfos : TeaModel {
                /// <summary>
                /// <para>The product description.</para>
                /// </summary>
                [NameInMap("attribute_show_info_map")]
                [Validation(Required=false)]
                public Dictionary<string, List<ModuleAgentInfosAttributeShowInfoMapValue>> AttributeShowInfoMap { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("best_discount")]
                [Validation(Required=false)]
                public double? BestDiscount { get; set; }

                /// <summary>
                /// <para>The cabin class information.</para>
                /// </summary>
                [NameInMap("cabin_class_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosCabinClassInfo CabinClassInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosCabinClassInfo : TeaModel {
                    /// <summary>
                    /// <para>The cabin class level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>舱位等级</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>The cabin class name, such as &quot;Full-fare economy class&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>舱位等级名称,eg:全价经济舱</para>
                    /// </summary>
                    [NameInMap("class_name")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    /// <summary>
                    /// <para>inner_cabin_class</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("inner_cabin_class")]
                    [Validation(Required=false)]
                    public int? InnerCabinClass { get; set; }

                    /// <summary>
                    /// <para>The remaining quantity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cabin_code")]
                [Validation(Required=false)]
                public int? CabinCode { get; set; }

                /// <summary>
                /// <para>The cabin name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_name")]
                [Validation(Required=false)]
                public string CabinName { get; set; }

                /// <summary>
                /// <para>item_id</para>
                /// 
                /// <b>Example:</b>
                /// <para>c85124c527fc4b26b86d0c043ddc08d3_0</para>
                /// </summary>
                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The change type description, such as &quot;Change according to the original ticket change rules&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>按照原票改签规则，进行改签</para>
                /// </summary>
                [NameInMap("modify_type_desc")]
                [Validation(Required=false)]
                public string ModifyTypeDesc { get; set; }

                /// <summary>
                /// <para>The change type name, such as &quot;Direct change&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>直接改签</para>
                /// </summary>
                [NameInMap("modify_type_name")]
                [Validation(Required=false)]
                public string ModifyTypeName { get; set; }

                /// <summary>
                /// <para>The price information.</para>
                /// </summary>
                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTO : TeaModel {
                    /// <summary>
                    /// <para>The adult (student) discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    /// <summary>
                    /// <para>The adult (student) tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11000</para>
                    /// </summary>
                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    /// <summary>
                    /// <para>The adult (student) total price including tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>137000</para>
                    /// </summary>
                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The price before price control, excluding tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    /// <summary>
                    /// <para>The child discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64000</para>
                    /// </summary>
                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    /// <summary>
                    /// <para>The child tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    /// <summary>
                    /// <para>The child total price including tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>66000</para>
                    /// </summary>
                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The infant discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    /// <summary>
                    /// <para>The infant tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    /// <summary>
                    /// <para>The infant total price including tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The price before discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1300</para>
                    /// </summary>
                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    /// <summary>
                    /// <para>The price before discount, including tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12300</para>
                    /// </summary>
                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The re-shop price information (fees required for the flight change).</para>
                    /// </summary>
                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfosPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        /// <summary>
                        /// <para>The re-shop change fee per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total re-shop cost per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        /// <summary>
                        /// <para>The re-shop price difference per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        /// <summary>
                        /// <para>The re-shop change fee per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total re-shop cost per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        /// <summary>
                        /// <para>The re-shop price difference per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        /// <summary>
                        /// <para>The re-shop change fee per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total re-shop cost per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        /// <summary>
                        /// <para>The re-shop price difference per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of remaining tickets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                /// <summary>
                /// <para>Indicates whether child tickets are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("support_child_ticket")]
                [Validation(Required=false)]
                public bool? SupportChildTicket { get; set; }

            }

            /// <summary>
            /// <para>The secondary screen agent information with the lowest price.</para>
            /// </summary>
            [NameInMap("agent_info")]
            [Validation(Required=false)]
            public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfo AgentInfo { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfo : TeaModel {
                /// <summary>
                /// <para>The product description.</para>
                /// </summary>
                [NameInMap("attribute_show_info_map")]
                [Validation(Required=false)]
                public Dictionary<string, List<ModuleAgentInfoAttributeShowInfoMapValue>> AttributeShowInfoMap { get; set; }

                /// <summary>
                /// <para>The discount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("best_discount")]
                [Validation(Required=false)]
                public double? BestDiscount { get; set; }

                /// <summary>
                /// <para>The cabin class information.</para>
                /// </summary>
                [NameInMap("cabin_class_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoCabinClassInfo CabinClassInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoCabinClassInfo : TeaModel {
                    /// <summary>
                    /// <para>The cabin class level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>舱位等级</para>
                    /// </summary>
                    [NameInMap("cabin_class")]
                    [Validation(Required=false)]
                    public string CabinClass { get; set; }

                    /// <summary>
                    /// <para>The cabin class name, such as &quot;Full-fare economy class&quot;.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>舱位等级名称,eg:全价经济舱</para>
                    /// </summary>
                    [NameInMap("class_name")]
                    [Validation(Required=false)]
                    public string ClassName { get; set; }

                    /// <summary>
                    /// <para>inner_cabin_class</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("inner_cabin_class")]
                    [Validation(Required=false)]
                    public int? InnerCabinClass { get; set; }

                    /// <summary>
                    /// <para>The remaining quantity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>剩余数量</para>
                    /// </summary>
                    [NameInMap("quantity")]
                    [Validation(Required=false)]
                    public string Quantity { get; set; }

                }

                /// <summary>
                /// <para>The cabin code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cabin_code")]
                [Validation(Required=false)]
                public int? CabinCode { get; set; }

                /// <summary>
                /// <para>The cabin name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>经济舱</para>
                /// </summary>
                [NameInMap("cabin_name")]
                [Validation(Required=false)]
                public string CabinName { get; set; }

                /// <summary>
                /// <para>item_id</para>
                /// 
                /// <b>Example:</b>
                /// <para>c85124c527fc4b26b86d0c043ddc08d3_0</para>
                /// </summary>
                [NameInMap("item_id")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The change type description, such as &quot;Change according to the original ticket change rules&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>按照原票改签规则，进行改签</para>
                /// </summary>
                [NameInMap("modify_type_desc")]
                [Validation(Required=false)]
                public string ModifyTypeDesc { get; set; }

                /// <summary>
                /// <para>The change type name, such as &quot;Direct change&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>直接改签</para>
                /// </summary>
                [NameInMap("modify_type_name")]
                [Validation(Required=false)]
                public string ModifyTypeName { get; set; }

                /// <summary>
                /// <para>The price information.</para>
                /// </summary>
                [NameInMap("price_info_d_t_o")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTO PriceInfoDTO { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTO : TeaModel {
                    /// <summary>
                    /// <para>The adult (student) discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("adult_price")]
                    [Validation(Required=false)]
                    public int? AdultPrice { get; set; }

                    /// <summary>
                    /// <para>The adult (student) tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>11000</para>
                    /// </summary>
                    [NameInMap("adult_tax")]
                    [Validation(Required=false)]
                    public int? AdultTax { get; set; }

                    /// <summary>
                    /// <para>The adult (student) total price including tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>137000</para>
                    /// </summary>
                    [NameInMap("adult_total_price")]
                    [Validation(Required=false)]
                    public int? AdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The price before price control, excluding tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>126000</para>
                    /// </summary>
                    [NameInMap("before_control_price")]
                    [Validation(Required=false)]
                    public int? BeforeControlPrice { get; set; }

                    /// <summary>
                    /// <para>The child discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64000</para>
                    /// </summary>
                    [NameInMap("child_price")]
                    [Validation(Required=false)]
                    public int? ChildPrice { get; set; }

                    /// <summary>
                    /// <para>The child tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("child_tax")]
                    [Validation(Required=false)]
                    public int? ChildTax { get; set; }

                    /// <summary>
                    /// <para>The child total price including tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>66000</para>
                    /// </summary>
                    [NameInMap("child_total_price")]
                    [Validation(Required=false)]
                    public int? ChildTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The infant discounted price. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("infant_price")]
                    [Validation(Required=false)]
                    public int? InfantPrice { get; set; }

                    /// <summary>
                    /// <para>The infant tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("infant_tax")]
                    [Validation(Required=false)]
                    public int? InfantTax { get; set; }

                    /// <summary>
                    /// <para>The infant total price including tax. Unit: cents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("infant_total_price")]
                    [Validation(Required=false)]
                    public int? InfantTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The price before discount.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1300</para>
                    /// </summary>
                    [NameInMap("original_adult_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultPrice { get; set; }

                    /// <summary>
                    /// <para>The price before discount, including tax.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12300</para>
                    /// </summary>
                    [NameInMap("original_adult_total_price")]
                    [Validation(Required=false)]
                    public int? OriginalAdultTotalPrice { get; set; }

                    /// <summary>
                    /// <para>The re-shop price information (fees required for the flight change).</para>
                    /// </summary>
                    [NameInMap("re_shop_price_info_d_t_o")]
                    [Validation(Required=false)]
                    public FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTOReShopPriceInfoDTO ReShopPriceInfoDTO { get; set; }
                    public class FlightModifyOtaSearchV2ResponseBodyModuleAgentInfoPriceInfoDTOReShopPriceInfoDTO : TeaModel {
                        /// <summary>
                        /// <para>The re-shop change fee per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopAdultChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total re-shop cost per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPrice { get; set; }

                        /// <summary>
                        /// <para>The re-shop price difference per adult. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_adult_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopAdultPriceGap { get; set; }

                        /// <summary>
                        /// <para>The re-shop change fee per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopChildChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total re-shop cost per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price")]
                        [Validation(Required=false)]
                        public int? ReShopChildPrice { get; set; }

                        /// <summary>
                        /// <para>The re-shop price difference per child. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_child_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopChildPriceGap { get; set; }

                        /// <summary>
                        /// <para>The re-shop change fee per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_change_fee")]
                        [Validation(Required=false)]
                        public int? ReShopInfChangeFee { get; set; }

                        /// <summary>
                        /// <para>The total re-shop cost per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price")]
                        [Validation(Required=false)]
                        public int? ReShopInfPrice { get; set; }

                        /// <summary>
                        /// <para>The re-shop price difference per infant. Unit: cents.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>-1</para>
                        /// </summary>
                        [NameInMap("re_shop_inf_price_gap")]
                        [Validation(Required=false)]
                        public int? ReShopInfPriceGap { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of remaining tickets.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("quantity")]
                [Validation(Required=false)]
                public int? Quantity { get; set; }

                /// <summary>
                /// <para>Indicates whether child tickets are supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("support_child_ticket")]
                [Validation(Required=false)]
                public bool? SupportChildTicket { get; set; }

            }

            /// <summary>
            /// <para>The cached data key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2136019116915615639457351e06ee</para>
            /// </summary>
            [NameInMap("cache_key")]
            [Validation(Required=false)]
            public string CacheKey { get; set; }

            /// <summary>
            /// <para>The flight change segment information.</para>
            /// </summary>
            [NameInMap("flight_segment_infos")]
            [Validation(Required=false)]
            public List<List<FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfos>> FlightSegmentInfos { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfos : TeaModel {
                /// <summary>
                /// <para>The journey sequence number. The sequence starts from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("journey_seq")]
                [Validation(Required=false)]
                public int? JourneySeq { get; set; }

                /// <summary>
                /// <para>The segment sequence number. The sequence starts from 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("segment_seq")]
                [Validation(Required=false)]
                public int? SegmentSeq { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CA1110</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XIL</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The name of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>锡林浩特</para>
                /// </summary>
                [NameInMap("dep_city_name")]
                [Validation(Required=false)]
                public string DepCityName { get; set; }

                /// <summary>
                /// <para>The name of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city_name")]
                [Validation(Required=false)]
                public string ArrCityName { get; set; }

                /// <summary>
                /// <para>The departure airport information.</para>
                /// </summary>
                [NameInMap("dep_airport_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosDepAirportInfo DepAirportInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosDepAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>XIL</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>锡林浩特机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The short name of the airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>锡林浩特</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

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
                /// <para>The arrival airport information.</para>
                /// </summary>
                [NameInMap("arr_airport_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosArrAirportInfo ArrAirportInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosArrAirportInfo : TeaModel {
                    /// <summary>
                    /// <para>The airport code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PEK</para>
                    /// </summary>
                    [NameInMap("airport_code")]
                    [Validation(Required=false)]
                    public string AirportCode { get; set; }

                    /// <summary>
                    /// <para>The airport name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都国际机场</para>
                    /// </summary>
                    [NameInMap("airport_name")]
                    [Validation(Required=false)]
                    public string AirportName { get; set; }

                    /// <summary>
                    /// <para>The short name of the airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>首都</para>
                    /// </summary>
                    [NameInMap("airport_short_name")]
                    [Validation(Required=false)]
                    public string AirportShortName { get; set; }

                    /// <summary>
                    /// <para>The terminal.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>T2</para>
                    /// </summary>
                    [NameInMap("terminal")]
                    [Validation(Required=false)]
                    public string Terminal { get; set; }

                }

                /// <summary>
                /// <para>The departure time, such as 2021-11-15 21:55.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-18 09:10:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The arrival time, such as 2021-11-15 21:55.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-09-18 10:25:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The marketing airline information.</para>
                /// </summary>
                [NameInMap("airline_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosAirlineInfo AirlineInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosAirlineInfo : TeaModel {
                    /// <summary>
                    /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CA</para>
                    /// </summary>
                    [NameInMap("airline_code")]
                    [Validation(Required=false)]
                    public string AirlineCode { get; set; }

                    /// <summary>
                    /// <para>The Chinese name of the airline, such as Air China.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>中国国航</para>
                    /// </summary>
                    [NameInMap("airline_chinese_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseName { get; set; }

                    /// <summary>
                    /// <para>The Chinese short name of the airline, such as 国航.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>国航</para>
                    /// </summary>
                    [NameInMap("airline_chinese_short_name")]
                    [Validation(Required=false)]
                    public string AirlineChineseShortName { get; set; }

                    /// <summary>
                    /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>//gw.alicdn.com/tfs/TB12fJAFHr1gK0jSZR0XXbP8XXa-450-450.png_80x80.jpg</para>
                    /// </summary>
                    [NameInMap("airline_icon")]
                    [Validation(Required=false)]
                    public string AirlineIcon { get; set; }

                    /// <summary>
                    /// <para>The low-cost carrier indicator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("cheap_flight")]
                    [Validation(Required=false)]
                    public bool? CheapFlight { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether this is a codeshare flight.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("share")]
                [Validation(Required=false)]
                public bool? Share { get; set; }

                /// <summary>
                /// <para>The codeshare flight information.</para>
                /// </summary>
                [NameInMap("flight_shared_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfo FlightSharedInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfo : TeaModel {
                    /// <summary>
                    /// <para>The operating carrier flight number. This field has a value only for codeshare flights.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>承运方航班号（共享航班时有值）</para>
                    /// </summary>
                    [NameInMap("operating_flight_no")]
                    [Validation(Required=false)]
                    public string OperatingFlightNo { get; set; }

                    /// <summary>
                    /// <para>The operating airline information.</para>
                    /// </summary>
                    [NameInMap("operating_airline_info")]
                    [Validation(Required=false)]
                    public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfoOperatingAirlineInfo OperatingAirlineInfo { get; set; }
                    public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightSharedInfoOperatingAirlineInfo : TeaModel {
                        /// <summary>
                        /// <para>The airline code, such as &quot;HU&quot; for Hainan Airlines.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司代码, 如&quot;HU&quot;, 表示海航</para>
                        /// </summary>
                        [NameInMap("airline_code")]
                        [Validation(Required=false)]
                        public string AirlineCode { get; set; }

                        /// <summary>
                        /// <para>The Chinese name of the airline, such as Air China.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文名, 如：中国国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseName { get; set; }

                        /// <summary>
                        /// <para>The Chinese short name of the airline, such as 国航.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司中文简称, 如：国航</para>
                        /// </summary>
                        [NameInMap("airline_chinese_short_name")]
                        [Validation(Required=false)]
                        public string AirlineChineseShortName { get; set; }

                        /// <summary>
                        /// <para>The airline logo URL, such as <a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>航空公司logo，如：<a href="https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png">https://img.alicdn.com/tps/TB1DjLzLXXXXXaoXFXXXXXXXXXX-64-64.png</a></para>
                        /// </summary>
                        [NameInMap("airline_icon")]
                        [Validation(Required=false)]
                        public string AirlineIcon { get; set; }

                        /// <summary>
                        /// <para>The low-cost carrier indicator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("cheap_flight")]
                        [Validation(Required=false)]
                        public bool? CheapFlight { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether the flight has a stopover.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("stop")]
                [Validation(Required=false)]
                public bool? Stop { get; set; }

                /// <summary>
                /// <para>The stopover information.</para>
                /// </summary>
                [NameInMap("flight_stop_info")]
                [Validation(Required=false)]
                public FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightStopInfo FlightStopInfo { get; set; }
                public class FlightModifyOtaSearchV2ResponseBodyModuleFlightSegmentInfosFlightStopInfo : TeaModel {
                    /// <summary>
                    /// <para>The name of the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停城市名称</para>
                    /// </summary>
                    [NameInMap("stop_city_name")]
                    [Validation(Required=false)]
                    public string StopCityName { get; set; }

                    /// <summary>
                    /// <para>The arrival time at the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停站到达时间</para>
                    /// </summary>
                    [NameInMap("stop_arr_time")]
                    [Validation(Required=false)]
                    public string StopArrTime { get; set; }

                    /// <summary>
                    /// <para>The departure time from the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停站出发时间</para>
                    /// </summary>
                    [NameInMap("stop_dep_time")]
                    [Validation(Required=false)]
                    public string StopDepTime { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the stopover city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停城市三字码</para>
                    /// </summary>
                    [NameInMap("stop_city_code")]
                    [Validation(Required=false)]
                    public string StopCityCode { get; set; }

                    /// <summary>
                    /// <para>The stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停机场</para>
                    /// </summary>
                    [NameInMap("stop_airport")]
                    [Validation(Required=false)]
                    public string StopAirport { get; set; }

                    /// <summary>
                    /// <para>The arrival terminal at the stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停航站楼: 降落</para>
                    /// </summary>
                    [NameInMap("stop_arr_term")]
                    [Validation(Required=false)]
                    public string StopArrTerm { get; set; }

                    /// <summary>
                    /// <para>The departure terminal at the stopover airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>经停航站楼: 起飞</para>
                    /// </summary>
                    [NameInMap("stop_dep_term")]
                    [Validation(Required=false)]
                    public string StopDepTerm { get; set; }

                }

                /// <summary>
                /// <para>The transfer time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("transfer_time")]
                [Validation(Required=false)]
                public int? TransferTime { get; set; }

                /// <summary>
                /// <para>The flight duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>75</para>
                /// </summary>
                [NameInMap("duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// <para>The aircraft manufacturer, such as &quot;Boeing&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>制造商，如&quot;波音&quot;</para>
                /// </summary>
                [NameInMap("manufacturer")]
                [Validation(Required=false)]
                public string Manufacturer { get; set; }

                /// <summary>
                /// <para>The aircraft type code, such as 738.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ARJ</para>
                /// </summary>
                [NameInMap("flight_type")]
                [Validation(Required=false)]
                public string FlightType { get; set; }

                /// <summary>
                /// <para>The aircraft size name, such as &quot;medium aircraft&quot;.</para>
                /// 
                /// <b>Example:</b>
                /// <para>小型机</para>
                /// </summary>
                [NameInMap("flight_size")]
                [Validation(Required=false)]
                public string FlightSize { get; set; }

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
                /// <para>The on-time rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>准点率</para>
                /// </summary>
                [NameInMap("on_time_rate")]
                [Validation(Required=false)]
                public string OnTimeRate { get; set; }

            }

            /// <summary>
            /// <para>The requested adult and child passenger count.</para>
            /// </summary>
            [NameInMap("passenger_count")]
            [Validation(Required=false)]
            public FlightModifyOtaSearchV2ResponseBodyModulePassengerCount PassengerCount { get; set; }
            public class FlightModifyOtaSearchV2ResponseBodyModulePassengerCount : TeaModel {
                /// <summary>
                /// <para>The number of adult passengers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("adult_passenger_num")]
                [Validation(Required=false)]
                public int? AdultPassengerNum { get; set; }

                /// <summary>
                /// <para>The number of child passengers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("child_passenger_num")]
                [Validation(Required=false)]
                public int? ChildPassengerNum { get; set; }

                /// <summary>
                /// <para>The number of infant passengers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("infant_passenger_num")]
                [Validation(Required=false)]
                public int? InfantPassengerNum { get; set; }

            }

            /// <summary>
            /// <para>The session ID used throughout the flight change process.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2ffebfe733742aab5c491d960ba3d59</para>
            /// </summary>
            [NameInMap("session_id")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
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
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>2136019116915615639457351e06ee</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
