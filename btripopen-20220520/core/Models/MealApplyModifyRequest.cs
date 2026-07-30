// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyModifyRequest : TeaModel {
        /// <summary>
        /// <para>The applicant.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("apply_user")]
        [Validation(Required=false)]
        public MealApplyModifyRequestApplyUser ApplyUser { get; set; }
        public class MealApplyModifyRequestApplyUser : TeaModel {
            /// <summary>
            /// <para>The employee ID.</para>
            /// <remarks>
            /// <para>Enter the user_id of the business travel employee.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>userId1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The internal cost center ID in Alibaba Business Travel associated with the application. You can specify either this parameter or the third-party cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("cost_center_id")]
        [Validation(Required=false)]
        public long? CostCenterId { get; set; }

        /// <summary>
        /// <para>The extended information.</para>
        /// <para>You can pass supplementary descriptions in this field. The corresponding content is displayed in the bill. This field is typically used for enterprise travel statistics and reconciliation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;extend_key&quot;:&quot;extend_value&quot;}</para>
        /// </summary>
        [NameInMap("extend_field")]
        [Validation(Required=false)]
        public string ExtendField { get; set; }

        /// <summary>
        /// <para>The internal invoice header ID in Alibaba Business Travel. You can specify either this parameter or the third-party invoice header ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("invoice_id")]
        [Validation(Required=false)]
        public long? InvoiceId { get; set; }

        /// <summary>
        /// <para>The meal itinerary.</para>
        /// </summary>
        [NameInMap("itinerary_list")]
        [Validation(Required=false)]
        public List<MealApplyModifyRequestItineraryList> ItineraryList { get; set; }
        public class MealApplyModifyRequestItineraryList : TeaModel {
            /// <summary>
            /// <para>The meal city.</para>
            /// </summary>
            [NameInMap("cities")]
            [Validation(Required=false)]
            public List<MealApplyModifyRequestItineraryListCities> Cities { get; set; }
            public class MealApplyModifyRequestItineraryListCities : TeaModel {
                /// <summary>
                /// <para>The city code.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Only cities in the Chinese mainland are supported. Cities in Hong Kong (China), Macao (China), and Taiwan (China) are not supported.</description></item>
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
            /// <para>The end time. The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</para>
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
            /// <para>The start time. The time parameter must be in the yyyy-MM-dd HH:mm:ss string format.</para>
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
            /// <para>We recommend that you enter a unique identifier. It is displayed in the application, order, and bill in Alibaba Business Travel.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The third-party approval ID.</para>
        /// <remarks>
        /// <para>We recommend that you enter a unique identifier. It is displayed in the application, order, and bill in Alibaba Business Travel.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        /// <summary>
        /// <para>The third-party cost center ID associated with the application. You can specify either this parameter or the Alibaba Business Travel cost center ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200F00010</para>
        /// </summary>
        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        /// <summary>
        /// <para>The third-party invoice header ID. You can specify either this parameter or the Alibaba Business Travel invoice header ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GA15131</para>
        /// </summary>
        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

    }

}
