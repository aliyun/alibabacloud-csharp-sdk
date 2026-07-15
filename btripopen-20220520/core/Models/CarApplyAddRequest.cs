// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyAddRequest : TeaModel {
        /// <summary>
        /// <para>The reason for the business trip.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>访问客户</para>
        /// </summary>
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        /// <summary>
        /// <para>The car service cities. Separate multiple cities with Chinese commas (，).
        /// Note: A maximum of 10 cities can be specified. The values in city and city_code_set must correspond one-to-one.</para>
        /// 
        /// <b>Example:</b>
        /// <para>北京，杭州</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The set of city codes for intra-city car service. Separate multiple cities with Chinese commas (，).
        /// Note: 1) Either city_code_set or city is required. If both are specified, city_code_set takes precedence.
        /// A maximum of 10 cities can be specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110100，330100</para>
        /// </summary>
        [NameInMap("city_code_set")]
        [Validation(Required=false)]
        public string CityCodeSet { get; set; }

        /// <summary>
        /// <para>The car service date. Access is controlled on a daily basis. For example, a value of 2021-03-18 20:26:56 indicates that the car service is available on 2021-03-18. For cross-day scenarios, use this parameter together with the finished_date parameter. The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12 14:52:52</para>
        /// </summary>
        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        /// <summary>
        /// <para>The car service end date. Access is controlled on a daily basis. For example, if date is set to 2021-03-18 20:26:56 and finished_date is set to 2021-03-30 20:26:56, the car service is available from 2021-03-18 (inclusive) to 2021-03-30 (inclusive). If this parameter is not specified, the value of date is used as the end date. The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12 18:51:25</para>
        /// </summary>
        [NameInMap("finished_date")]
        [Validation(Required=false)]
        public string FinishedDate { get; set; }

        /// <summary>
        /// <para>The intra-city car service itinerary.</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<CarApplyAddRequestItineraryList> ItineraryList { get; set; }
        public class CarApplyAddRequestItineraryList : TeaModel {
            /// <summary>
            /// <para>The car service cities. Separate multiple cities with Chinese commas (，).
            /// Note: A maximum of 10 cities can be specified. The values in city and city_code_set must correspond one-to-one.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京，杭州</para>
            /// </summary>
            [NameInMap("city")]
            [Validation(Required=false)]
            public string City { get; set; }

            /// <summary>
            /// <para>The set of city codes for intra-city car service. Separate multiple cities with Chinese commas (，).
            /// Note: 1) Either city_code_set or city is required. If both are specified, city_code_set takes precedence.
            /// A maximum of 10 cities can be specified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>440600，440100</para>
            /// </summary>
            [NameInMap("city_code_set")]
            [Validation(Required=false)]
            public string CityCodeSet { get; set; }

            /// <summary>
            /// <para>The car service date. Access is controlled on a daily basis. For example, a value of 2021-03-18 20:26:56 indicates that the car service is available on 2021-03-18. For cross-day scenarios, use this parameter together with the finished_date parameter. The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12 14:52:52</para>
            /// </summary>
            [NameInMap("date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The car service end date. Access is controlled on a daily basis. For example, if date is set to 2021-03-18 20:26:56 and finished_date is set to 2021-03-30 20:26:56, the car service is available from 2021-03-18 (inclusive) to 2021-03-30 (inclusive). If this parameter is not specified, the value of date is used as the end date. The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-25 21:00:00</para>
            /// </summary>
            [NameInMap("finished_date")]
            [Validation(Required=false)]
            public string FinishedDate { get; set; }

        }

        /// <summary>
        /// <para>The project code associated with the approval form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project1413</para>
        /// </summary>
        [NameInMap("project_code")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        /// <summary>
        /// <para>The project name associated with the approval form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>项目1</para>
        /// </summary>
        [NameInMap("project_name")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The approval status.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The ID of the third-party approval form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IRGS1413</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <para>The ID of the third-party cost center associated with the approval form.</para>
        /// <remarks>
        /// <para>Warning: This field is required. To configure it as optional, contact operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>QA1411</para>
        /// </summary>
        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// <para>The ID of the third-party invoice header associated with the approval form.</para>
        /// <remarks>
        /// <para>Warning: This field is required. To configure it as optional, contact operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>GA15131</para>
        /// </summary>
        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

        /// <summary>
        /// <para>The total available count for the approval form.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("times_total")]
        [Validation(Required=false)]
        public int? TimesTotal { get; set; }

        /// <summary>
        /// <para>The type of available usage count for the approval form. If the enterprise does not need to limit the number of times the approval form can be used, set this parameter to 1 (unlimited) and set both times_total and times_used to 0.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: Unlimited.</description></item>
        /// <item><description>2: User-specified count.</description></item>
        /// <item><description>3: Admin-limited count.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("times_type")]
        [Validation(Required=false)]
        public int? TimesType { get; set; }

        /// <summary>
        /// <para>The number of times the approval form has been used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("times_used")]
        [Validation(Required=false)]
        public int? TimesUsed { get; set; }

        /// <summary>
        /// <para>The title of the approval form.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>访问客户</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The intra-city car service rules.</para>
        /// </summary>
        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public List<CarApplyAddRequestTravelerStandard> TravelerStandard { get; set; }
        public class CarApplyAddRequestTravelerStandard : TeaModel {
            /// <summary>
            /// <para>The cross-city car service rules. Optional. If specified, cross-city rules are read from the approval form data.</para>
            /// </summary>
            [NameInMap("car_city_set")]
            [Validation(Required=false)]
            public List<CarApplyAddRequestTravelerStandardCarCitySet> CarCitySet { get; set; }
            public class CarApplyAddRequestTravelerStandardCarCitySet : TeaModel {
                /// <summary>
                /// <para>The cross-city city code. Only 6-digit codes are supported. Separate multiple values with Chinese commas.
                /// Note: A maximum of 10 cities can be specified. The values in city_code and city_name must correspond one-to-one.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110100，330100</para>
                /// </summary>
                [NameInMap("city_code")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                /// <summary>
                /// <para>The cross-city city name. Separate multiple values with Chinese commas.
                /// Note: A maximum of 10 cities can be specified. The values in city_code and city_name must correspond one-to-one.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京，杭州</para>
                /// </summary>
                [NameInMap("city_name")]
                [Validation(Required=false)]
                public string CityName { get; set; }

            }

            /// <summary>
            /// <para>The user ID of the traveler.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userid</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The third-party employee ID of the user who initiates the approval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN1415614</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
