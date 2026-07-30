// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyModifyRequest : TeaModel {
        /// <summary>
        /// <para>The total budget.</para>
        /// <para>Includes domestic flights, domestic hotels, train tickets, and car service.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("budget")]
        [Validation(Required=false)]
        public long? Budget { get; set; }

        /// <summary>
        /// <para>Specifies whether to merge budgets of multiple business trip approval forms.</para>
        /// <para>Multiple approval forms with the same union_no can have their budgets merged and used interchangeably.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("budget_merge")]
        [Validation(Required=false)]
        public int? BudgetMerge { get; set; }

        /// <summary>
        /// <para>The business travel car service rule.</para>
        /// </summary>
        [NameInMap("car_rule")]
        [Validation(Required=false)]
        public ApplyModifyRequestCarRule CarRule { get; set; }
        public class ApplyModifyRequestCarRule : TeaModel {
            /// <summary>
            /// <para>The car service scenario template ID. Query address: <a href="https://open.alibtrip.com/#/document/server/carscene-query-query-enterprise-car-scene-template?handbookId=development-support">Car Scene Template Query</a>.</para>
            /// <ol>
            /// <item><description>Optional.</description></item>
            /// <item><description>If specified, the approval form can only be used in this scenario.</description></item>
            /// <item><description>If not specified, all business travel car service scenarios are available.</description></item>
            /// <item><description>Only applicable to business travel car service.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("scenario_template_id")]
            [Validation(Required=false)]
            public string ScenarioTemplateId { get; set; }

            /// <summary>
            /// <para>The car service scenario template name. Query address: Car Scene Template Query.</para>
            /// <ol>
            /// <item><description>Optional.</description></item>
            /// <item><description>If specified, the approval form can only be used in this scenario.</description></item>
            /// <item><description>If not specified, all business travel car service scenarios are available.</description></item>
            /// <item><description>Only applicable to business travel car service.</description></item>
            /// </ol>
            /// 
            /// <b>Example:</b>
            /// <para>测试场景模板</para>
            /// </summary>
            [NameInMap("scenario_template_name")]
            [Validation(Required=false)]
            public string ScenarioTemplateName { get; set; }

        }

        /// <summary>
        /// <para>The enterprise name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里巴巴</para>
        /// </summary>
        [NameInMap("corp_name")]
        [Validation(Required=false)]
        public string CorpName { get; set; }

        /// <summary>
        /// <para>The default travel standards for the approval form.</para>
        /// <para>If the travelers are not determined when the approval form is submitted but you need to control the travel standards for subsequently added travelers, set the default travel standards for the approval form.</para>
        /// </summary>
        [NameInMap("default_standard")]
        [Validation(Required=false)]
        public ApplyModifyRequestDefaultStandard DefaultStandard { get; set; }
        public class ApplyModifyRequestDefaultStandard : TeaModel {
            /// <summary>
            /// <para>The business class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("business_discount")]
            [Validation(Required=false)]
            public int? BusinessDiscount { get; set; }

            /// <summary>
            /// <para>The economy class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("economy_discount")]
            [Validation(Required=false)]
            public int? EconomyDiscount { get; set; }

            /// <summary>
            /// <para>The first class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("first_discount")]
            [Validation(Required=false)]
            public int? FirstDiscount { get; set; }

            /// <summary>
            /// <para>The domestic flight cabin class. Multiple values separated by commas. If a cabin class is specified, the corresponding discount field is required. (For example, if P is specified, the premium economy class discount field is required.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("flight_cabins")]
            [Validation(Required=false)]
            public string FlightCabins { get; set; }

            /// <summary>
            /// <para>The rule code for international flight travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The rule code for domestic flight travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            /// <summary>
            /// <para>The city code. Pass 0 to represent all other cities.</para>
            /// </summary>
            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestDefaultStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyModifyRequestDefaultStandardHotelCitys : TeaModel {
                /// <summary>
                /// <para>The three-letter code of the check-in city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500100</para>
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
                /// <para>The hotel room rate per night, in cents. Set to 99999999 for no limit. Note: Travel standards can only be controlled down to the yuan. Jiao and fen are truncated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The hotel room-night amount in cents. Pass 99999999 for unlimited. Note: The travel standard can only control amounts down to the yuan level. Jiao and fen values are.</para>
            /// </summary>
            [NameInMap("hotel_intl_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestDefaultStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyModifyRequestDefaultStandardHotelIntlCitys : TeaModel {
                /// <summary>
                /// <para>The three-letter city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>510100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>城市名称</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The fee, in cents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The rule code for international hotel travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The rule code for domestic hotel travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <para>The international flight cabin classes. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("international_flight_cabins")]
            [Validation(Required=false)]
            public string InternationalFlightCabins { get; set; }

            /// <summary>
            /// <para>The premium economy class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            /// <summary>
            /// <para>The travel standard restriction type. 0: no restriction on travel standards. 1: restricted by travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            /// <summary>
            /// <para>The rule code for domestic train travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            /// <summary>
            /// <para>The train seat classes. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

        }

        /// <summary>
        /// <para>The department ID. If not specified, the system retrieves the department information based on the user information. If an incorrect department ID is specified, cost allocation to the department cannot be performed. The department ID must be numeric.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("depart_id")]
        [Validation(Required=false)]
        public string DepartId { get; set; }

        /// <summary>
        /// <para>The department name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>采购部</para>
        /// </summary>
        [NameInMap("depart_name")]
        [Validation(Required=false)]
        public string DepartName { get; set; }

        /// <summary>
        /// <para>Pass supplementary descriptions in this field. The value appears in bills and can be used for enterprise statistics and reconciliation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cost_center&quot;:&quot;成本中心&quot;}</para>
        /// </summary>
        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// <para>The external traveler list.</para>
        /// </summary>
        [NameInMap("external_traveler_list")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestExternalTravelerList> ExternalTravelerList { get; set; }
        public class ApplyModifyRequestExternalTravelerList : TeaModel {
            /// <summary>
            /// <para>The extended field.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The business travel cost center ID. Specify either this or the third-party cost center ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>144224</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The external traveler ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>371164</para>
            /// </summary>
            [NameInMap("external_user_id")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            /// <summary>
            /// <para>The invoice header ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>11411</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The cost allocation department ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>11422</para>
            /// </summary>
            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            /// <summary>
            /// <para>The cost allocation department name.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“一级事业部”</para>
            /// </summary>
            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

            /// <summary>
            /// <para>The project code.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project name.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“成本项目”</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The third-party invoice ID. Specify either this or the business travel invoice ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>91140100688069283J</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>HD4451224</para>
            /// </summary>
            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>The third-party department ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>6281</para>
            /// </summary>
            [NameInMap("thirdpart_depart_id")]
            [Validation(Required=false)]
            public string ThirdpartDepartId { get; set; }

            /// <summary>
            /// <para>The traveler name. For English names, use &quot;/&quot; as a separator with no spaces. Format: last-name/first-name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>王武</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The traveler English name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wu/wang</para>
            /// </summary>
            [NameInMap("user_name_en")]
            [Validation(Required=false)]
            public string UserNameEn { get; set; }

        }

        /// <summary>
        /// <para>The external traveler travel standard.</para>
        /// </summary>
        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public ApplyModifyRequestExternalTravelerStandard ExternalTravelerStandard { get; set; }
        public class ApplyModifyRequestExternalTravelerStandard : TeaModel {
            /// <summary>
            /// <para>The business class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("business_discount")]
            [Validation(Required=false)]
            public int? BusinessDiscount { get; set; }

            /// <summary>
            /// <para>The economy class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("economy_discount")]
            [Validation(Required=false)]
            public int? EconomyDiscount { get; set; }

            /// <summary>
            /// <para>The first class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("first_discount")]
            [Validation(Required=false)]
            public int? FirstDiscount { get; set; }

            /// <summary>
            /// <para>The domestic flight cabin class. Multiple values separated by commas. If a cabin class is specified, the corresponding discount field is required. (For example, if P is specified, the premium economy class discount field is required.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("flight_cabins")]
            [Validation(Required=false)]
            public string FlightCabins { get; set; }

            /// <summary>
            /// <para>The rule code for international flight travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The rule code for domestic flight travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            /// <summary>
            /// <para>The hotel city cost list.</para>
            /// </summary>
            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestExternalTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyModifyRequestExternalTravelerStandardHotelCitys : TeaModel {
                /// <summary>
                /// <para>The city code. Pass 0 to represent all other cities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>The hotel room-night amount in cents. Pass 99999999 for unlimited. Note: The travel standard can only control amounts down to the yuan level. Jiao and fen values are.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The list of international hotel city fees.</para>
            /// </summary>
            [NameInMap("hotel_intl_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestExternalTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyModifyRequestExternalTravelerStandardHotelIntlCitys : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>330100</para>
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
                /// <para>The hotel room-night amount in cents. Pass 99999999 for unlimited. Note: The travel standard can only control amounts down to the yuan level. Jiao and fen values are.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1009</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The rule code for international hotel travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The rule code for domestic hotel travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <para>The international flight cabin classes. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("international_flight_cabins")]
            [Validation(Required=false)]
            public string InternationalFlightCabins { get; set; }

            /// <summary>
            /// <para>The premium economy class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            /// <summary>
            /// <para>The travel standard restriction type. 0: no restriction on travel standards. 1: restricted by travel standards. Note: All travelers in the same approval form must either all be restricted or all be unrestricted. Otherwise, the call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            /// <summary>
            /// <para>The rule code for domestic train travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            /// <summary>
            /// <para>The train seat class. Multiple values separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

        }

        /// <summary>
        /// <para>The domestic flight budget.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        /// <summary>
        /// <para>The domestic hotel budget.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// <remarks>
        /// <para>Warning: Miscellaneous charges incurred by specially authorized guests during their stay (meals, in-room items, etc.) are deducted at checkout and paid by the enterprise.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        /// <summary>
        /// <para>The hotel room-sharing rule.</para>
        /// </summary>
        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public ApplyModifyRequestHotelShare HotelShare { get; set; }
        public class ApplyModifyRequestHotelShare : TeaModel {
            /// <summary>
            /// <para>Pass an integer. When the room-sharing type is 1/2/3, the API converts the value to x%.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>The room-sharing formula.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The international/Hong Kong (China), Macao (China), Taiwan (China) flight budget (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_flight_budget")]
        [Validation(Required=false)]
        public long? IntlFlightBudget { get; set; }

        /// <summary>
        /// <para>The international hotel budget (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_hotel_budget")]
        [Validation(Required=false)]
        public long? IntlHotelBudget { get; set; }

        /// <summary>
        /// <para>The itinerary list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestItineraryList> ItineraryList { get; set; }
        public class ApplyModifyRequestItineraryList : TeaModel {
            /// <summary>
            /// <para>The arrival city.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州</para>
            /// </summary>
            [NameInMap("arr_city")]
            [Validation(Required=false)]
            public string ArrCity { get; set; }

            /// <summary>
            /// <para>The arrival city code. Pass 0 to disable arrival city restrictions. Note: Departure and arrival locations must either both be unrestricted or both be restricted. When cities are unrestricted, ensure hotel travel standards are passed for all cities.
            /// When traffic_type is 0/6/21/25, pass the three-letter airport code. For all other traffic_type values, pass the six-digit city code.</para>
            /// <para><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-flight-city-data.xlsx">Three-letter airport code data</a>
            /// <a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">Administrative division city code data</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>The arrival date in the format yyyy-MM-dd HH:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12 00:00:00</para>
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            /// <summary>
            /// <para>The extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The business travel cost center ID. Specify either this or the third-party cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021413</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The departure city.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京</para>
            /// </summary>
            [NameInMap("dep_city")]
            [Validation(Required=false)]
            public string DepCity { get; set; }

            /// <summary>
            /// <para>The departure city code. Pass 0 to disable departure city restrictions. Note: Departure and arrival locations must either both be unrestricted or both be restricted. When cities are unrestricted, ensure hotel travel standards are passed for all cities.
            /// When traffic_type is 0/6/21/25, pass the three-letter airport code. For all other traffic_type values, pass the six-digit city code.</para>
            /// <para><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-flight-city-data.xlsx">Three-letter airport code data</a>
            /// <a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">Administrative division city code data</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>The departure date in the format yyyy-MM-dd HH:mm:ss.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12 00:00:00</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// <para>The business travel invoice ID. Specify either this or the third-party invoice ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>614141</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The itinerary ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000131</para>
            /// </summary>
            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            /// <summary>
            /// <para>The itinerary travel standard.</para>
            /// </summary>
            [NameInMap("itinerary_travel_standard")]
            [Validation(Required=false)]
            public ApplyModifyRequestItineraryListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyModifyRequestItineraryListItineraryTravelStandard : TeaModel {
                /// <summary>
                /// <para>The number of available room nights per day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("hotel_available_nights_per_day")]
                [Validation(Required=false)]
                public int? HotelAvailableNightsPerDay { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether the itinerary requires hotel booking. Default value: true. (Deprecated)
            /// Deprecated. Refer to the traffic_type field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("need_hotel")]
            [Validation(Required=false)]
            public bool? NeedHotel { get; set; }

            /// <summary>
            /// <para>Specifies whether the itinerary requires transportation booking. Default value: true. (Deprecated)
            /// Deprecated. Refer to the traffic_type field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("need_traffic")]
            [Validation(Required=false)]
            public bool? NeedTraffic { get; set; }

            /// <summary>
            /// <para>The project code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>projectone</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目1</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The city set that can be elevated to province level.</para>
            /// <para>This is a control field.</para>
            /// </summary>
            [NameInMap("province_travel_city_adcodes")]
            [Validation(Required=false)]
            public List<string> ProvinceTravelCityAdcodes { get; set; }

            /// <summary>
            /// <para>The third-party invoice ID. Specify either this or the business travel invoice ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZG14131</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID. Specify either this or the business travel cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thirdpart5151</para>
            /// </summary>
            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>The transportation type. needTraffic and needHotel are optional.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("traffic_type")]
            [Validation(Required=false)]
            public int? TrafficType { get; set; }

            /// <summary>
            /// <para>The trip type.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("trip_way")]
            [Validation(Required=false)]
            public int? TripWay { get; set; }

        }

        /// <summary>
        /// <para>The approval form city rule:
        /// 0: One-to-one departure and destination, pass itineraries as a list. 
        /// 1: Select N cities, city set itinerary.
        /// Default value: 0.
        /// When the approval form city rule is 0, itinerary_list is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("itinerary_rule")]
        [Validation(Required=false)]
        public int? ItineraryRule { get; set; }

        /// <summary>
        /// <para>The city set itinerary list.</para>
        /// </summary>
        [NameInMap("itinerary_set_list")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestItinerarySetList> ItinerarySetList { get; set; }
        public class ApplyModifyRequestItinerarySetList : TeaModel {
            /// <summary>
            /// <para>The arrival date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            /// <summary>
            /// <para>The extended field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The departure and arrival city codes, separated by Chinese commas &quot;，&quot;.
            /// Pass 0 to disable city restrictions. Note: When cities are unrestricted, ensure hotel travel standards are passed for all cities.
            /// When the allowed booking category is 0/6/21/25, three-letter airport codes or six-digit city codes are accepted.
            /// When the allowed booking category is any other value, only six-digit city codes are accepted.
            /// city_set and city_code_set must have a one-to-one correspondence.
            /// Note: When the itinerary includes a flight-type itinerary, if the specified city has no airport, flight itineraries cannot be booked.</para>
            /// <para><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-flight-city-data.xlsx">Three-letter airport code data</a>
            /// <a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">Administrative division city code data</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS，SHA</para>
            /// </summary>
            [NameInMap("city_code_set")]
            [Validation(Required=false)]
            public string CityCodeSet { get; set; }

            /// <summary>
            /// <para>The departure and arrival city names, separated by Chinese commas &quot;，&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京，上海</para>
            /// </summary>
            [NameInMap("city_set")]
            [Validation(Required=false)]
            public string CitySet { get; set; }

            /// <summary>
            /// <para>The business travel cost center ID. Specify either this or the third-party cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123455</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The departure date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("dep_date")]
            [Validation(Required=false)]
            public string DepDate { get; set; }

            /// <summary>
            /// <para>The business travel invoice ID. Specify either this or the third-party invoice ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12344</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The itinerary ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20220722001</para>
            /// </summary>
            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            /// <summary>
            /// <para>The itinerary travel standard.</para>
            /// </summary>
            [NameInMap("itinerary_travel_standard")]
            [Validation(Required=false)]
            public ApplyModifyRequestItinerarySetListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyModifyRequestItinerarySetListItineraryTravelStandard : TeaModel {
                /// <summary>
                /// <para>The number of available room nights per day.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("hotel_available_nights_per_day")]
                [Validation(Required=false)]
                public int? HotelAvailableNightsPerDay { get; set; }

            }

            /// <summary>
            /// <para>The project code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>projecttow</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>项目1</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The city set that can be elevated to province level.</para>
            /// <para>This is a control field.</para>
            /// </summary>
            [NameInMap("province_travel_city_adcodes")]
            [Validation(Required=false)]
            public List<string> ProvinceTravelCityAdcodes { get; set; }

            /// <summary>
            /// <para>The third-party invoice ID. Specify either this or the business travel invoice ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thridpart12138</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID. Specify either this or the business travel cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thridpart12138</para>
            /// </summary>
            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>The transportation type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("traffic_type")]
            [Validation(Required=false)]
            public int? TrafficType { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to restrict travelers.</para>
        /// <para>0: Do not restrict travelers. 1: Restrict to travelers on the approval form.</para>
        /// <remarks>
        /// <para>Warning: If the approval form does not restrict travelers and no default travel standard (default_standard) is passed, the traveler information on the approval form is not stored, and actual travelers are not subject to travel standard restrictions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

        /// <summary>
        /// <para>The meal budget (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("meal_budget")]
        [Validation(Required=false)]
        public long? MealBudget { get; set; }

        /// <summary>
        /// <para>The cost allocation department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>141125</para>
        /// </summary>
        [NameInMap("payment_department_id")]
        [Validation(Required=false)]
        public string PaymentDepartmentId { get; set; }

        /// <summary>
        /// <para>The cost allocation department name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>产品部</para>
        /// </summary>
        [NameInMap("payment_department_name")]
        [Validation(Required=false)]
        public string PaymentDepartmentName { get; set; }

        /// <summary>
        /// <para>The approval form status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para><del>Sub-enterprise ID</del>
        /// Deprecated. Use <a href="/#/document/server/groupcorptoken-group-enterprise-certificate?handbookId=development-support">Group Enterprise Credential</a> instead.</para>
        /// 
        /// <b>Example:</b>
        /// <para>btrip123</para>
        /// </summary>
        [NameInMap("sub_corp_id")]
        [Validation(Required=false)]
        public string SubCorpId { get; set; }

        /// <summary>
        /// <para>The external approval form ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0001A1100000007EX08O</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>The external approval form ID displayed to users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202201413141</para>
        /// </summary>
        [NameInMap("thirdpart_business_id")]
        [Validation(Required=false)]
        public string ThirdpartBusinessId { get; set; }

        /// <summary>
        /// <para>The third-party department ID.</para>
        /// <para>If either the third-party department ID or the department ID is specified, the specified field takes precedence.</para>
        /// <para>If both are specified, the third-party department ID takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>三方部门id</para>
        /// </summary>
        [NameInMap("thirdpart_depart_id")]
        [Validation(Required=false)]
        public string ThirdpartDepartId { get; set; }

        /// <summary>
        /// <para>The simultaneous booking (flight &amp; train) rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("together_book_rule")]
        [Validation(Required=false)]
        public int? TogetherBookRule { get; set; }

        /// <summary>
        /// <para>The train ticket budget.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// <remarks>
        /// <para>Warning: For the same seat class such as &quot;hard sleeper&quot;, upper/middle/lower berths have price differences. During booking, the budget balance is validated against the highest price.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("train_budget")]
        [Validation(Required=false)]
        public long? TrainBudget { get; set; }

        /// <summary>
        /// <para>The traveler list.</para>
        /// </summary>
        [NameInMap("traveler_list")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestTravelerList> TravelerList { get; set; }
        public class ApplyModifyRequestTravelerList : TeaModel {
            /// <summary>
            /// <para>The extended field.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The business travel cost center ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>12211</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The internal business travel invoice header ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>11412</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The cost allocation department ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>11633</para>
            /// </summary>
            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            /// <summary>
            /// <para>The cost allocation department name.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“一级事业部”</para>
            /// </summary>
            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

            /// <summary>
            /// <para>The project code.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project name.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“成本项目”</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The third-party invoice header ID associated with the approval form.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>517492</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>HD424333</para>
            /// </summary>
            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>The third-party department ID.<notice>&quot;To use this field, contact customer operations.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>1001A11000000000O7YC</para>
            /// </summary>
            [NameInMap("thirdpart_depart_id")]
            [Validation(Required=false)]
            public string ThirdpartDepartId { get; set; }

            /// <summary>
            /// <para>The traveler ID (third-party user ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>GS641312</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The traveler name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The list of travel standards for internal personnel.</para>
        /// </summary>
        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public List<ApplyModifyRequestTravelerStandard> TravelerStandard { get; set; }
        public class ApplyModifyRequestTravelerStandard : TeaModel {
            /// <summary>
            /// <para>The business class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("business_discount")]
            [Validation(Required=false)]
            public int? BusinessDiscount { get; set; }

            /// <summary>
            /// <para>The cross-city rules for business travel car services.</para>
            /// </summary>
            [NameInMap("car_city_set")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestTravelerStandardCarCitySet> CarCitySet { get; set; }
            public class ApplyModifyRequestTravelerStandardCarCitySet : TeaModel {
                /// <summary>
                /// <para>The cross-city city code. Only 6-digit codes are supported. Separate multiple values with Chinese commas. Note: A maximum of 10 cities can be specified. The city_code and city_name values must correspond one-to-one.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100，330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The cross-city city name. Separate multiple values with Chinese commas. Note: A maximum of 10 cities can be specified. The city_code and city_name values must correspond one-to-one.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京，杭州</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

            }

            [NameInMap("car_standard")]
            [Validation(Required=false)]
            public ApplyModifyRequestTravelerStandardCarStandard CarStandard { get; set; }
            public class ApplyModifyRequestTravelerStandardCarStandard : TeaModel {
                [NameInMap("book_allow_info")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardBookAllowInfo BookAllowInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardBookAllowInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("book_allow")]
                    [Validation(Required=false)]
                    public bool? BookAllow { get; set; }

                }

                [NameInMap("car_helper")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardCarHelper CarHelper { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCarHelper : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("car_helper_type")]
                    [Validation(Required=false)]
                    public string CarHelperType { get; set; }

                }

                [NameInMap("car_time_control")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardCarTimeControl CarTimeControl { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCarTimeControl : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("time_limit")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardCarTimeControlTimeLimit> TimeLimit { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardCarTimeControlTimeLimit : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("end_time")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("start_time")]
                        [Validation(Required=false)]
                        public string StartTime { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("time_switch")]
                    [Validation(Required=false)]
                    public bool? TimeSwitch { get; set; }

                }

                [NameInMap("city_control_info")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardCityControlInfo CityControlInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCityControlInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("city_control_type")]
                    [Validation(Required=false)]
                    public int? CityControlType { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("city_infos")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardCityControlInfoCityInfos> CityInfos { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardCityControlInfoCityInfos : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("adcode")]
                        [Validation(Required=false)]
                        public string Adcode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("city_code")]
                        [Validation(Required=false)]
                        public string CityCode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("city_name")]
                        [Validation(Required=false)]
                        public string CityName { get; set; }

                    }

                }

                [NameInMap("cross_city_info")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardCrossCityInfo CrossCityInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardCrossCityInfo : TeaModel {
                    [NameInMap("cross_city_list")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardCrossCityInfoCrossCityList> CrossCityList { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardCrossCityInfoCrossCityList : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("from_adcode")]
                        [Validation(Required=false)]
                        public string FromAdcode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("from_city_code")]
                        [Validation(Required=false)]
                        public string FromCityCode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("from_city_name")]
                        [Validation(Required=false)]
                        public string FromCityName { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("to_adcode")]
                        [Validation(Required=false)]
                        public string ToAdcode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("to_city_code")]
                        [Validation(Required=false)]
                        public string ToCityCode { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("to_city_name")]
                        [Validation(Required=false)]
                        public string ToCityName { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("cross_city_type")]
                    [Validation(Required=false)]
                    public int? CrossCityType { get; set; }

                }

                [NameInMap("electronic_fence_info")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfo ElectronicFenceInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_locations_from")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom> ElectronicFenceLocationsFrom { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("latitude")]
                        [Validation(Required=false)]
                        public string Latitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("longitude")]
                        [Validation(Required=false)]
                        public string Longitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("radius")]
                        [Validation(Required=false)]
                        public int? Radius { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_locations_to")]
                    [Validation(Required=false)]
                    public List<ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo> ElectronicFenceLocationsTo { get; set; }
                    public class ApplyModifyRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo : TeaModel {
                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("address")]
                        [Validation(Required=false)]
                        public string Address { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("latitude")]
                        [Validation(Required=false)]
                        public string Latitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("longitude")]
                        [Validation(Required=false)]
                        public string Longitude { get; set; }

                        /// <summary>
                        /// <para>This parameter is required.</para>
                        /// </summary>
                        [NameInMap("radius")]
                        [Validation(Required=false)]
                        public int? Radius { get; set; }

                    }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_type")]
                    [Validation(Required=false)]
                    public int? ElectronicFenceType { get; set; }

                }

                [NameInMap("level_codes")]
                [Validation(Required=false)]
                public string LevelCodes { get; set; }

                [NameInMap("modify_destination_info")]
                [Validation(Required=false)]
                public ApplyModifyRequestTravelerStandardCarStandardModifyDestinationInfo ModifyDestinationInfo { get; set; }
                public class ApplyModifyRequestTravelerStandardCarStandardModifyDestinationInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("modify_destination")]
                    [Validation(Required=false)]
                    public bool? ModifyDestination { get; set; }

                }

                [NameInMap("times_total")]
                [Validation(Required=false)]
                public int? TimesTotal { get; set; }

                [NameInMap("times_type")]
                [Validation(Required=false)]
                public int? TimesType { get; set; }

            }

            /// <summary>
            /// <para>The economy class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("economy_discount")]
            [Validation(Required=false)]
            public int? EconomyDiscount { get; set; }

            /// <summary>
            /// <para>The first class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("first_discount")]
            [Validation(Required=false)]
            public int? FirstDiscount { get; set; }

            /// <summary>
            /// <para>The domestic flight cabin class. Multiple values separated by commas. If a cabin class is specified, the corresponding discount field is required. (For example, if P is specified, the premium economy class discount field is required.)</para>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("flight_cabins")]
            [Validation(Required=false)]
            public string FlightCabins { get; set; }

            /// <summary>
            /// <para>The rule code for international flight travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The rule code for domestic flight travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            /// <summary>
            /// <para>The hotel city cost list.</para>
            /// </summary>
            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyModifyRequestTravelerStandardHotelCitys : TeaModel {
                /// <summary>
                /// <para>The city code. Pass 0 to represent all other cities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>The hotel room-night amount in cents. Pass 99999999 for unlimited. Note: The travel standard can only control amounts down to the yuan level. Jiao and fen values are.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1014</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The set of international hotel cities.</para>
            /// </summary>
            [NameInMap("hotel_intl_citys")]
            [Validation(Required=false)]
            public List<ApplyModifyRequestTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyModifyRequestTravelerStandardHotelIntlCitys : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100</para>
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
                /// <para>The hotel room-night amount in cents. Pass 99999999 for unlimited. Note: The travel standard can only control amounts down to the yuan level. Jiao and fen values are.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1009</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The rule code for international hotel travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The rule code for domestic hotel travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <para>The international flight cabin classes. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("international_flight_cabins")]
            [Validation(Required=false)]
            public string InternationalFlightCabins { get; set; }

            /// <summary>
            /// <para>The premium economy class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>1 means 10% of the full price. 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            /// <summary>
            /// <para>The travel standard restriction type. 0: no restriction on travel standards. 1: restricted by travel standards. Note: All travelers in the same approval form must either all be restricted or all be unrestricted. Otherwise, the call fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            /// <summary>
            /// <para>The rule code for domestic train travel standards.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10032</para>
            /// </summary>
            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            /// <summary>
            /// <para>The train seat class. Multiple values separated by commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

            /// <summary>
            /// <para>The traveler ID (third-party user ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>thirdpart12138</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The reason for the business trip.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>访问客户</para>
        /// </summary>
        [NameInMap("trip_cause")]
        [Validation(Required=false)]
        public string TripCause { get; set; }

        /// <summary>
        /// <para>The number of business trip days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("trip_day")]
        [Validation(Required=false)]
        public int? TripDay { get; set; }

        /// <summary>
        /// <para>The title of the approval form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>访问客户</para>
        /// </summary>
        [NameInMap("trip_title")]
        [Validation(Required=false)]
        public string TripTitle { get; set; }

        /// <summary>
        /// <para>The associated order number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union51415</para>
        /// </summary>
        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <para>The applicant ID (third-party user ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thirdpart12138</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username. If specified, it must be the real name. If not specified, the system uses the name associated with the current userId for booking.</para>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The car service budget.</para>
        /// <para>Currency unit: CNY, in cents.</para>
        /// <remarks>
        /// <para>Warning: Uncontrollable factors in ride-hailing scenarios may cause the actual price to exceed the estimated price: 1. The passenger changes the destination offline. 2. Traffic congestion or other road incidents. 3. The driver adds surcharges such as tolls, highway fees, or waiting fees.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("vehicle_budget")]
        [Validation(Required=false)]
        public long? VehicleBudget { get; set; }

    }

}
