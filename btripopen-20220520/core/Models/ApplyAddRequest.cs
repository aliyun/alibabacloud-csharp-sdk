// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyAddRequest : TeaModel {
        /// <summary>
        /// <para>The total budget, including domestic flights, domestic hotels, train tickets, and car service.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("budget")]
        [Validation(Required=false)]
        public long? Budget { get; set; }

        /// <summary>
        /// <para>Specifies whether to merge budgets of multiple business trip approval forms.</para>
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
        public ApplyAddRequestCarRule CarRule { get; set; }
        public class ApplyAddRequestCarRule : TeaModel {
            /// <summary>
            /// <para>The car service scenario template ID. Obtain it through the <a href="https://open.alibtrip.com/#/document/server/carscene-query-query-enterprise-car-scene-template?handbookId=development-support">Car scenario template query</a> operation.</para>
            /// <list type="bullet">
            /// <item><description>Optional.</description></item>
            /// <item><description>If specified, the approval form is bound to the car service scenario.</description></item>
            /// <item><description>Only applicable to business travel car service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("scenario_template_id")]
            [Validation(Required=false)]
            public string ScenarioTemplateId { get; set; }

            /// <summary>
            /// <para>The car service scenario template name. Obtain it through the <a href="https://open.alibtrip.com/#/document/server/carscene-query-query-enterprise-car-scene-template?handbookId=development-support">Car scenario template query</a> operation.</para>
            /// <list type="bullet">
            /// <item><description>Optional.</description></item>
            /// <item><description>If specified, the approval form is bound to the car service scenario.</description></item>
            /// <item><description>Only applicable to business travel car service.</description></item>
            /// </list>
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
        /// <para>The default travel standard for the approval form.</para>
        /// <para>If the travelers are not determined when the approval form is submitted but you need to control the travel standard for subsequently added travelers, set the default travel standard for the approval form.</para>
        /// </summary>
        [NameInMap("default_standard")]
        [Validation(Required=false)]
        public ApplyAddRequestDefaultStandard DefaultStandard { get; set; }
        public class ApplyAddRequestDefaultStandard : TeaModel {
            /// <summary>
            /// <para>The business class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("economy_discount")]
            [Validation(Required=false)]
            public int? EconomyDiscount { get; set; }

            /// <summary>
            /// <para>The first class discount. An integer from 1 to 10.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("first_discount")]
            [Validation(Required=false)]
            public int? FirstDiscount { get; set; }

            /// <summary>
            /// <para>The domestic flight cabin class. Multiple values are separated by commas.</para>
            /// <remarks>
            /// <para>If a cabin class is specified, the corresponding discount field is required. (Example: If P is specified, the premium economy class discount field is required.)</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("flight_cabins")]
            [Validation(Required=false)]
            public string FlightCabins { get; set; }

            /// <summary>
            /// <para>The ruleCode for the international flight travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic flight travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            /// <summary>
            /// <para>The list of hotel city fees.</para>
            /// </summary>
            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestDefaultStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyAddRequestDefaultStandardHotelCitys : TeaModel {
                /// <summary>
                /// <para>The city code. Set this parameter to 0 to indicate all other cities.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360100</para>
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
                /// <para>The hotel room-night amount, in cents.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To set an unlimited amount, pass 99999999.</description></item>
                /// <item><description>The travel standard can only control amounts down to the yuan level. Jiao and fen values are truncated. Avoid passing values with jiao or fen.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
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
            public List<ApplyAddRequestDefaultStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyAddRequestDefaultStandardHotelIntlCitys : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>210200</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>香港</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The hotel room-night amount, in cents.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To set an unlimited amount, pass 99999999.</description></item>
                /// <item><description>The travel standard can only control amounts down to the yuan level. Jiao and fen values are truncated. Avoid passing values with jiao or fen.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The ruleCode for the international hotel travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic hotel travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <para>The international flight cabin class. Multiple values are separated by commas.</para>
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            /// <summary>
            /// <para>Specifies whether to restrict the travel standard.</para>
            /// <remarks>
            /// <para>All travelers in the same approval form must either all have travel standard restrictions or none at all. Otherwise, the call fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic train travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            /// <summary>
            /// <para>The train seat class. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

        }

        /// <summary>
        /// <para>The department ID.</para>
        /// <list type="bullet">
        /// <item><description>If not specified, the system retrieves the department information based on the user information.</description></item>
        /// <item><description>Ensure that the correct department ID is passed. Otherwise, the cost attribution of the employee\&quot;s travel expenses may be affected.</description></item>
        /// <item><description>The department ID must be numeric.</description></item>
        /// </list>
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
        /// <para>The extension information.</para>
        /// <list type="bullet">
        /// <item><description>Pass supplementary descriptions in this field. The corresponding content is displayed in the bill. This is typically used for enterprise travel statistics and reconciliation.</description></item>
        /// </list>
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
        public List<ApplyAddRequestExternalTravelerList> ExternalTravelerList { get; set; }
        public class ApplyAddRequestExternalTravelerList : TeaModel {
            /// <summary>
            /// <para>The extension field.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The cost center ID.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>414522</para>
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
            /// <para>The business travel invoice ID.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>4451</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The cost attribution department ID.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>141125</para>
            /// </summary>
            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            /// <summary>
            /// <para>The cost attribution department name.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品部</para>
            /// </summary>
            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

            /// <summary>
            /// <para>The project code.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project name.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“成本项目”</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The third-party invoice header ID.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>91130124566177980M</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>HD155</para>
            /// </summary>
            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>The third-party department ID.</para>
            /// <list type="bullet">
            /// <item><description>Specify either the third-party department ID or the department ID.</description></item>
            /// <item><description>If both are specified, the third-party department ID takes precedence.</description></item>
            /// </list>
            /// <para><notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>DHDI2208051REIO6BK</para>
            /// </summary>
            [NameInMap("thirdpart_depart_id")]
            [Validation(Required=false)]
            public string ThirdpartDepartId { get; set; }

            /// <summary>
            /// <para>The Chinese name of the user.</para>
            /// <list type="bullet">
            /// <item><description>If an English name is provided, it is processed as an English name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>李四</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <para>The English name of the user.</para>
            /// <list type="bullet">
            /// <item><description>Separate the English name with &quot;/&quot;. No spaces are allowed.</description></item>
            /// <item><description>Pass in the order: last-name/first-name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUN/MENGXUAN</para>
            /// </summary>
            [NameInMap("user_name_en")]
            [Validation(Required=false)]
            public string UserNameEn { get; set; }

        }

        /// <summary>
        /// <para>The travel standard for external travelers.</para>
        /// </summary>
        [NameInMap("external_traveler_standard")]
        [Validation(Required=false)]
        public ApplyAddRequestExternalTravelerStandard ExternalTravelerStandard { get; set; }
        public class ApplyAddRequestExternalTravelerStandard : TeaModel {
            /// <summary>
            /// <para>The business class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("first_discount")]
            [Validation(Required=false)]
            public int? FirstDiscount { get; set; }

            /// <summary>
            /// <para>The domestic flight cabin class. Separate multiple values with commas.</para>
            /// <list type="bullet">
            /// <item><description>If a cabin class is specified, the corresponding discount field is required. (For example, if P is specified, the premium economy discount field is required.)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>F</para>
            /// </summary>
            [NameInMap("flight_cabins")]
            [Validation(Required=false)]
            public string FlightCabins { get; set; }

            /// <summary>
            /// <para>The ruleCode for the international flight travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic flight travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            /// <summary>
            /// <para>The list of hotel city fees.</para>
            /// </summary>
            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestExternalTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyAddRequestExternalTravelerStandardHotelCitys : TeaModel {
                /// <summary>
                /// <para>The city code. Set this parameter to 0 to indicate all other cities.</para>
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
                /// <para>The hotel room-night amount, in cents.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To set an unlimited amount, pass 99999999.</description></item>
                /// <item><description>The travel standard can only control amounts down to the yuan level. Jiao and fen values are truncated. Avoid passing values with jiao or fen.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1009</para>
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
            public List<ApplyAddRequestExternalTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyAddRequestExternalTravelerStandardHotelIntlCitys : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
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
                /// <para>The hotel room-night amount, in cents.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To set an unlimited amount, pass 99999999.</description></item>
                /// <item><description>The travel standard can only control amounts down to the yuan level. Jiao and fen values are truncated. Avoid passing values with jiao or fen.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The ruleCode for the international hotel travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic hotel travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <para>The international flight cabin class. Multiple values are separated by commas.</para>
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            /// <summary>
            /// <para>Specifies whether to restrict the travel standard.</para>
            /// <remarks>
            /// <para>All travelers in the same approval form must either all have travel standard restrictions or none at all. Otherwise, the call fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic train travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            /// <summary>
            /// <para>The train seat class. Separate multiple values with commas.</para>
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
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("flight_budget")]
        [Validation(Required=false)]
        public long? FlightBudget { get; set; }

        /// <summary>
        /// <para>The domestic hotel budget.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: Miscellaneous charges incurred by specially authorized guests during their stay (such as meals and in-room products) are deducted at checkout and paid by the enterprise.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("hotel_budget")]
        [Validation(Required=false)]
        public long? HotelBudget { get; set; }

        /// <summary>
        /// <para>The travel standard calculation rule for hotel room-sharing scenarios.</para>
        /// </summary>
        [NameInMap("hotel_share")]
        [Validation(Required=false)]
        public ApplyAddRequestHotelShare HotelShare { get; set; }
        public class ApplyAddRequestHotelShare : TeaModel {
            /// <summary>
            /// <para>The numeric value in the calculation formula.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer. When the calculation formula is 1/2/3, the API processes it automatically.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>The travel standard calculation formula.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Deprecated field.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("international_flight_cabins")]
        [Validation(Required=false)]
        public string InternationalFlightCabins { get; set; }

        /// <summary>
        /// <para>The international/Hong Kong, Macao, Taiwan (China) flight budget of the approval form (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_flight_budget")]
        [Validation(Required=false)]
        public long? IntlFlightBudget { get; set; }

        /// <summary>
        /// <para>The international hotel budget of the approval form (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("intl_hotel_budget")]
        [Validation(Required=false)]
        public long? IntlHotelBudget { get; set; }

        /// <summary>
        /// <para>The itinerary list.</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<ApplyAddRequestItineraryList> ItineraryList { get; set; }
        public class ApplyAddRequestItineraryList : TeaModel {
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
            /// <para>The arrival city code. Optional.</para>
            /// <list type="bullet">
            /// <item><description>When set to 0, city restrictions are not enforced. Ensure that hotel travel standards are passed for all cities.</description></item>
            /// <item><description>When <c>traffic_type</c> is set to 0/6/21/25, you can pass either an airport three-letter code or a six-digit city code. For other enum values, pass a six-digit city code.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Warning: When <c>traffic_type</c> includes flight, if the specified city has no airport, flight tickets cannot be booked.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Business travel city data:</para>
            /// <list type="bullet">
            /// <item><description><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-flight-city-data.xlsx">Airport three-letter code data</a>;</description></item>
            /// <item><description><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">Six-digit city code data</a>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HGH</para>
            /// </summary>
            [NameInMap("arr_city_code")]
            [Validation(Required=false)]
            public string ArrCityCode { get; set; }

            /// <summary>
            /// <para>The arrival date. Format: <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-02 00:00:00</para>
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            /// <summary>
            /// <para>The extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{&quot;name&quot;:&quot;张三&quot;}&quot;</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The business travel cost center ID. Specify either this or the third-party cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12138</para>
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
            /// <para>The departure city code. Optional.</para>
            /// <list type="bullet">
            /// <item><description>When set to 0, city restrictions are not enforced. Ensure that hotel travel standards are passed for all cities.</description></item>
            /// <item><description>When <c>traffic_type</c> is set to 0/6/21/25, you can pass either an airport three-letter code or a six-digit city code. For other enum values, pass a six-digit city code.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Warning: When <c>traffic_type</c> includes flight, if the specified city has no airport, flight tickets cannot be booked.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Business travel city data:</para>
            /// <list type="bullet">
            /// <item><description><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-flight-city-data.xlsx">Airport three-letter code data</a>;</description></item>
            /// <item><description><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">Six-digit city code data</a>.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>BJS</para>
            /// </summary>
            [NameInMap("dep_city_code")]
            [Validation(Required=false)]
            public string DepCityCode { get; set; }

            /// <summary>
            /// <para>The departure date. Format: <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// <para>This parameter is required.</para>
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
            /// <para>34711</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The itinerary ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            /// <summary>
            /// <para>The itinerary travel standard.</para>
            /// </summary>
            [NameInMap("itinerary_travel_standard")]
            [Validation(Required=false)]
            public ApplyAddRequestItineraryListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyAddRequestItineraryListItineraryTravelStandard : TeaModel {
                /// <summary>
                /// <para>The number of room nights that can be booked per night.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("hotel_available_nights_per_day")]
                [Validation(Required=false)]
                public int? HotelAvailableNightsPerDay { get; set; }

            }

            /// <summary>
            /// <para><b>Deprecated</b>. Use <c>traffic_type</c> instead.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("need_hotel")]
            [Validation(Required=false)]
            public bool? NeedHotel { get; set; }

            /// <summary>
            /// <para><b>Deprecated</b>. Use <c>traffic_type</c> instead.</para>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("need_traffic")]
            [Validation(Required=false)]
            public bool? NeedTraffic { get; set; }

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
            /// <para>The city set that can be expanded to province level.</para>
            /// <para>This is a control field.</para>
            /// </summary>
            [NameInMap("province_travel_city_adcodes")]
            [Validation(Required=false)]
            public List<string> ProvinceTravelCityAdcodes { get; set; }

            /// <summary>
            /// <para>The third-party invoice ID. Specify either this or the business travel invoice ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>thirdpart34711</para>
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
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
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
        /// <para>The city rule for the approval form.</para>
        /// <list type="bullet">
        /// <item><description>When set to 0, the <c>itinerary_list</c> field is required.</description></item>
        /// <item><description>When set to 1, the <c>itinerary_set_list</c> field is required.</description></item>
        /// </list>
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
        public List<ApplyAddRequestItinerarySetList> ItinerarySetList { get; set; }
        public class ApplyAddRequestItinerarySetList : TeaModel {
            /// <summary>
            /// <para>The arrival date. Format: <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-01-01 00:00:00</para>
            /// </summary>
            [NameInMap("arr_date")]
            [Validation(Required=false)]
            public string ArrDate { get; set; }

            /// <summary>
            /// <para>The extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{&quot;name&quot;:&quot;张三&quot;}&quot;</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The departure and arrival city codes, separated by Chinese commas.</para>
            /// <list type="bullet">
            /// <item><description>When set to 0, city restrictions are not enforced. Ensure that hotel travel standards are passed for all cities.</description></item>
            /// <item><description>When <c>traffic_type</c> is set to 0/6/21/25, you can pass either an airport three-letter code or a six-digit city code. For other enum values, pass a six-digit city code.</description></item>
            /// <item><description>The <c>city_set</c> and <c>city_code_set</c> values must correspond one-to-one.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Warning: When <c>traffic_type</c> includes flight, if the specified city has no airport, flight tickets cannot be booked.</para>
            /// </remarks>
            /// <remarks>
            /// <para>Business travel city data:</para>
            /// <list type="bullet">
            /// <item><description><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-flight-city-data.xlsx">Airport three-letter code data</a>;</description></item>
            /// <item><description><a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">Six-digit city code data</a>.</description></item>
            /// </list>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BJS，HGH</para>
            /// </summary>
            [NameInMap("city_code_set")]
            [Validation(Required=false)]
            public string CityCodeSet { get; set; }

            /// <summary>
            /// <para>The departure and arrival city names.</para>
            /// <list type="bullet">
            /// <item><description>Separate multiple cities with Chinese commas.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京，杭州</para>
            /// </summary>
            [NameInMap("city_set")]
            [Validation(Required=false)]
            public string CitySet { get; set; }

            /// <summary>
            /// <para>The business travel cost center ID. Specify either this or the third-party cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The departure date. Format: <c>yyyy-MM-dd HH:mm:ss</c>.</para>
            /// <para>This parameter is required.</para>
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
            /// <para>12345</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The itinerary ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("itinerary_id")]
            [Validation(Required=false)]
            public string ItineraryId { get; set; }

            /// <summary>
            /// <para>The itinerary travel standard.</para>
            /// </summary>
            [NameInMap("itinerary_travel_standard")]
            [Validation(Required=false)]
            public ApplyAddRequestItinerarySetListItineraryTravelStandard ItineraryTravelStandard { get; set; }
            public class ApplyAddRequestItinerarySetListItineraryTravelStandard : TeaModel {
                /// <summary>
                /// <para>The number of room nights that can be booked per night.</para>
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
            /// <para>The city set that can be expanded to province level.</para>
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
            /// <para>This parameter is required.</para>
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
        /// <remarks>
        /// <para>Warning: If the approval form does not restrict travelers and no default travel standard (default_standard) is passed, the traveler information passed in the approval form is not stored, and actual travelers are not subject to travel standard restrictions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("limit_traveler")]
        [Validation(Required=false)]
        public int? LimitTraveler { get; set; }

        /// <summary>
        /// <para>The meal budget of the approval form (in cents).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("meal_budget")]
        [Validation(Required=false)]
        public long? MealBudget { get; set; }

        /// <summary>
        /// <para>The cost attribution department ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>41155</para>
        /// </summary>
        [NameInMap("payment_department_id")]
        [Validation(Required=false)]
        public string PaymentDepartmentId { get; set; }

        /// <summary>
        /// <para>The cost attribution department name.</para>
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
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para><b>Deprecated</b>. The enterprise ID. Use <a href="/#/document/server/groupcorptoken-group-enterprise-certificate?handbookId=development-support">Group enterprise credential</a> instead.</para>
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
        /// <para>12345</para>
        /// </summary>
        [NameInMap("thirdpart_apply_id")]
        [Validation(Required=false)]
        public string ThirdpartApplyId { get; set; }

        /// <summary>
        /// <para>The external approval form ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00714131</para>
        /// </summary>
        [NameInMap("thirdpart_business_id")]
        [Validation(Required=false)]
        public string ThirdpartBusinessId { get; set; }

        /// <summary>
        /// <para>The third-party department ID.</para>
        /// <list type="bullet">
        /// <item><description>Specify either the third-party department ID or the department ID.</description></item>
        /// <item><description>If both are specified, the third-party department ID takes precedence.</description></item>
        /// </list>
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
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Warning: For example, when the seat class is &quot;hard sleeper&quot;, upper/middle/lower berths have different prices. The budget balance is validated against the highest price.</para>
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
        public List<ApplyAddRequestTravelerList> TravelerList { get; set; }
        public class ApplyAddRequestTravelerList : TeaModel {
            /// <summary>
            /// <para>The extension field.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
            /// </summary>
            [NameInMap("attribute")]
            [Validation(Required=false)]
            public string Attribute { get; set; }

            /// <summary>
            /// <para>The business travel cost center ID.</para>
            /// <remarks>
            /// <para>Notice: &quot;To use this field, contact your customer operations representative.&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>112711</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The business travel invoice ID.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>11251</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The cost attribution department ID.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>1142</para>
            /// </summary>
            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            /// <summary>
            /// <para>The cost attribution department name.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>产品部</para>
            /// </summary>
            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

            /// <summary>
            /// <para>The project code.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs</para>
            /// </summary>
            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            /// <summary>
            /// <para>The project name.
            /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;成本项目&quot;</para>
            /// </summary>
            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            /// <summary>
            /// <para>The third-party invoice ID.</para>
            /// <remarks>
            /// <para>Notice: &quot;To use this field, contact your customer operations representative.&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>517492</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID.</para>
            /// <remarks>
            /// <para>Notice: &quot;To use this field, contact your customer operations representative.&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>441154</para>
            /// </summary>
            [NameInMap("thirdpart_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdpartCostCenterId { get; set; }

            /// <summary>
            /// <para>The third-party department ID.</para>
            /// <list type="bullet">
            /// <item><description>Specify either the third-party department ID or the department ID.</description></item>
            /// <item><description>If both are specified, the third-party department ID takes precedence.</description></item>
            /// </list>
            /// <para><notice>&quot;To use this field, contact your customer operations representative.&quot;</para>
            /// 
            /// <b>Example:</b>
            /// <para>101128</para>
            /// </summary>
            [NameInMap("thirdpart_depart_id")]
            [Validation(Required=false)]
            public string ThirdpartDepartId { get; set; }

            /// <summary>
            /// <para>The third-party user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wu51531</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>王武</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The list of internal personnel travel standards.</para>
        /// </summary>
        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public List<ApplyAddRequestTravelerStandard> TravelerStandard { get; set; }
        public class ApplyAddRequestTravelerStandard : TeaModel {
            /// <summary>
            /// <para>The business class discount.</para>
            /// <list type="bullet">
            /// <item><description>Pass an integer from 1 to 10.</description></item>
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("business_discount")]
            [Validation(Required=false)]
            public int? BusinessDiscount { get; set; }

            /// <summary>
            /// <para>The cross-city rules for business travel car service.</para>
            /// </summary>
            [NameInMap("car_city_set")]
            [Validation(Required=false)]
            public List<ApplyAddRequestTravelerStandardCarCitySet> CarCitySet { get; set; }
            public class ApplyAddRequestTravelerStandardCarCitySet : TeaModel {
                /// <summary>
                /// <para>The cross-city city code.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Only 6-digit city codes are supported. Multiple values are separated by Chinese commas.</description></item>
                /// <item><description>A maximum of 10 cities can be specified. city_code and city_name must correspond one-to-one.</description></item>
                /// <item><description>To obtain business travel city data, see <a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">City 6-digit code data</a>.</description></item>
                /// </list>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100，330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The cross-city city name.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Multiple values are separated by Chinese commas.</description></item>
                /// <item><description>A maximum of 10 cities can be specified. city_code and city_name must correspond one-to-one.</description></item>
                /// </list>
                /// </remarks>
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
            public ApplyAddRequestTravelerStandardCarStandard CarStandard { get; set; }
            public class ApplyAddRequestTravelerStandardCarStandard : TeaModel {
                [NameInMap("book_allow_info")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardBookAllowInfo BookAllowInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardBookAllowInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("book_allow")]
                    [Validation(Required=false)]
                    public bool? BookAllow { get; set; }

                }

                [NameInMap("car_helper")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardCarHelper CarHelper { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCarHelper : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("car_helper_type")]
                    [Validation(Required=false)]
                    public string CarHelperType { get; set; }

                }

                [NameInMap("car_time_control")]
                [Validation(Required=false)]
                public ApplyAddRequestTravelerStandardCarStandardCarTimeControl CarTimeControl { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCarTimeControl : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("time_limit")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardCarTimeControlTimeLimit> TimeLimit { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardCarTimeControlTimeLimit : TeaModel {
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
                public ApplyAddRequestTravelerStandardCarStandardCityControlInfo CityControlInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCityControlInfo : TeaModel {
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
                    public List<ApplyAddRequestTravelerStandardCarStandardCityControlInfoCityInfos> CityInfos { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardCityControlInfoCityInfos : TeaModel {
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
                public ApplyAddRequestTravelerStandardCarStandardCrossCityInfo CrossCityInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardCrossCityInfo : TeaModel {
                    [NameInMap("cross_city_list")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardCrossCityInfoCrossCityList> CrossCityList { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardCrossCityInfoCrossCityList : TeaModel {
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
                public ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfo ElectronicFenceInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfo : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("electronic_fence_locations_from")]
                    [Validation(Required=false)]
                    public List<ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom> ElectronicFenceLocationsFrom { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsFrom : TeaModel {
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
                    public List<ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo> ElectronicFenceLocationsTo { get; set; }
                    public class ApplyAddRequestTravelerStandardCarStandardElectronicFenceInfoElectronicFenceLocationsTo : TeaModel {
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
                public ApplyAddRequestTravelerStandardCarStandardModifyDestinationInfo ModifyDestinationInfo { get; set; }
                public class ApplyAddRequestTravelerStandardCarStandardModifyDestinationInfo : TeaModel {
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("first_discount")]
            [Validation(Required=false)]
            public int? FirstDiscount { get; set; }

            /// <summary>
            /// <para>The domestic flight cabin class. Multiple values are separated by commas.</para>
            /// <remarks>
            /// <para>If a cabin class is specified, the corresponding discount field is required. (Example: If P is specified, the premium economy class discount field is required.)</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("flight_cabins")]
            [Validation(Required=false)]
            public string FlightCabins { get; set; }

            /// <summary>
            /// <para>The ruleCode for the international flight travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("flight_intl_rule_code")]
            [Validation(Required=false)]
            public long? FlightIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic flight travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("flight_rule_code")]
            [Validation(Required=false)]
            public long? FlightRuleCode { get; set; }

            /// <summary>
            /// <para>The list of hotel city fees.</para>
            /// </summary>
            [NameInMap("hotel_citys")]
            [Validation(Required=false)]
            public List<ApplyAddRequestTravelerStandardHotelCitys> HotelCitys { get; set; }
            public class ApplyAddRequestTravelerStandardHotelCitys : TeaModel {
                /// <summary>
                /// <para>The city code. Set this parameter to 0 to indicate all other cities.</para>
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
                /// <para>The hotel room-night amount, in cents.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To set an unlimited amount, pass 99999999.</description></item>
                /// <item><description>The travel standard can only control amounts down to the yuan level. Jiao and fen values are truncated. Avoid passing values with jiao or fen.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
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
            public List<ApplyAddRequestTravelerStandardHotelIntlCitys> HotelIntlCitys { get; set; }
            public class ApplyAddRequestTravelerStandardHotelIntlCitys : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
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
                /// <para>The hotel room-night amount, in cents.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>To set an unlimited amount, pass 99999999.</description></item>
                /// <item><description>The travel standard can only control amounts down to the yuan level. Jiao and fen values are truncated. Avoid passing values with jiao or fen.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1009</para>
                /// </summary>
                [NameInMap("fee")]
                [Validation(Required=false)]
                public long? Fee { get; set; }

            }

            /// <summary>
            /// <para>The ruleCode for the international hotel travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("hotel_intl_rule_code")]
            [Validation(Required=false)]
            public long? HotelIntlRuleCode { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic hotel travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("hotel_rule_code")]
            [Validation(Required=false)]
            public long? HotelRuleCode { get; set; }

            /// <summary>
            /// <para>The international flight cabin class. Multiple values are separated by commas.</para>
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
            /// <item><description>A value of 1 means 10% of the original price. A value of 10 means no discount.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("premium_economy_discount")]
            [Validation(Required=false)]
            public int? PremiumEconomyDiscount { get; set; }

            /// <summary>
            /// <para>Specifies whether to restrict the travel standard.</para>
            /// <remarks>
            /// <para>All travelers in the same approval form must either all have travel standard restrictions or none at all. Otherwise, the call fails.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("reserve_type")]
            [Validation(Required=false)]
            public int? ReserveType { get; set; }

            /// <summary>
            /// <para>The ruleCode for the domestic train travel standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100132</para>
            /// </summary>
            [NameInMap("train_rule_code")]
            [Validation(Required=false)]
            public long? TrainRuleCode { get; set; }

            /// <summary>
            /// <para>The train seat class. Separate multiple values with commas.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("train_seats")]
            [Validation(Required=false)]
            public string TrainSeats { get; set; }

            /// <summary>
            /// <para>The traveler ID (third-party traveler ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_000002102</para>
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
        /// <para>客服培训</para>
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
        /// <para>客服培训</para>
        /// </summary>
        [NameInMap("trip_title")]
        [Validation(Required=false)]
        public string TripTitle { get; set; }

        /// <summary>
        /// <para>The applicant type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The associated order number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>union001</para>
        /// </summary>
        [NameInMap("union_no")]
        [Validation(Required=false)]
        public string UnionNo { get; set; }

        /// <summary>
        /// <para>The applicant ID (third-party user ID).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>thridpart12138</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The username.</para>
        /// <list type="bullet">
        /// <item><description>Pass the real name of the employee.</description></item>
        /// <item><description>If not specified, the system uses the name corresponding to the current userId for booking.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>张三</para>
        /// </summary>
        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        /// <summary>
        /// <para>The car service budget.</para>
        /// <list type="bullet">
        /// <item><description>Currency unit: CNY, in cents.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Ride-hailing scenarios involve uncontrollable factors that may exceed the original estimated price:</para>
        /// <list type="bullet">
        /// <item><description>The passenger changes the destination offline.</description></item>
        /// <item><description>Traffic congestion or other road incidents. </description></item>
        /// <item><description>The driver adds surcharges such as tolls, highway fees, or waiting fees.</description></item>
        /// </list>
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
