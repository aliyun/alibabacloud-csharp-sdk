// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyAddRequest : TeaModel {
        /// <summary>
        /// <para>The applicant information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apply_user")]
        [Validation(Required=false)]
        public MealApplyAddRequestApplyUser ApplyUser { get; set; }
        public class MealApplyAddRequestApplyUser : TeaModel {
            /// <summary>
            /// <para>The employee ID.</para>
            /// <remarks>
            /// <para>Enter the business travel employee &quot;user_id&quot;.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>userId1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The internal business travel cost center ID associated with the application. Specify either this parameter or the third-party cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("cost_center_id")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>The extended information. Pass supplementary descriptions in this field. The content is displayed in bills. This is typically used for enterprise travel statistics and reconciliation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend_key&quot;:&quot;extend_value&quot;}</para>
        /// </summary>
        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// <para>The internal business travel invoice header ID. Specify either this parameter or the third-party invoice header ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("invoice_id")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// <para>The meal itinerary list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<MealApplyAddRequestItineraryList> ItineraryList { get; set; }
        public class MealApplyAddRequestItineraryList : TeaModel {
            /// <summary>
            /// <para>The meal cities.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("cities")]
            [Validation(Required=false)]
            public List<MealApplyAddRequestItineraryListCities> Cities { get; set; }
            public class MealApplyAddRequestItineraryListCities : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Only cities in the Chinese mainland are supported (Hong Kong (China), Macao (China), and Taiwan (China) are not supported).</description></item>
                /// <item><description>For city codes, refer to <a href="https://btrip-doc.oss-cn-hangzhou.aliyuncs.com/base-data/btrip-hotel-city-data.xlsx">Domestic City Six-Letter Code Data</a>.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>330702</para>
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

            }

            /// <summary>
            /// <para>The end time. The value must be in the yyyy-MM-dd HH:mm:ss string format.</para>
            /// <remarks>
            /// <para>Time zone: China</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-05 00:00:00</para>
            /// </summary>
            [NameInMap("end_date")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            /// <summary>
            /// <para>The start time. The value must be in the yyyy-MM-dd HH:mm:ss string format.</para>
            /// <remarks>
            /// <para>Time zone: China</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-02-05 00:00:00</para>
            /// </summary>
            [NameInMap("start_date")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            /// <summary>
            /// <para>The third-party itinerary ID.</para>
            /// <remarks>
            /// <para>Enter a unique identifier. It is displayed in the application forms, orders, and bills in Alibaba Business Travel.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2134</para>
            /// </summary>
            [NameInMap("thirdpart_itinerary_id")]
            [Validation(Required=false)]
            public string ThirdpartItineraryId { get; set; }

        }

        /// <summary>
        /// <para>The meal amount limit.</para>
        /// <remarks>
        /// <para>Currency: CNY. Unit: cents.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("meal_amount")]
        [Validation(Required=false)]
        public long? MealAmount { get; set; }

        /// <summary>
        /// <para>The reason for the meal.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试</para>
        /// </summary>
        [NameInMap("meal_cause")]
        [Validation(Required=false)]
        public string MealCause { get; set; }

        /// <summary>
        /// <para>The project code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project123</para>
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
        /// <para>The status of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The third-party application ID.</para>
        /// <remarks>
        /// <para>Enter a unique identifier. It is displayed in the application forms, orders, and bills in Alibaba Business Travel.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <para>The third-party cost center ID associated with the application. Specify either this parameter or the business travel cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200F00010</para>
        /// </summary>
        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// <para>The third-party invoice header ID. Specify either this parameter or the business travel invoice header ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA15131</para>
        /// </summary>
        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

    }

}
