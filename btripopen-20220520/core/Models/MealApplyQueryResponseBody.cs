// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyQueryResponseBody : TeaModel {
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
        /// <para>The application order object.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public MealApplyQueryResponseBodyModule Module { get; set; }
        public class MealApplyQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The applicant.</para>
            /// </summary>
            [NameInMap("apply_user")]
            [Validation(Required=false)]
            public MealApplyQueryResponseBodyModuleApplyUser ApplyUser { get; set; }
            public class MealApplyQueryResponseBodyModuleApplyUser : TeaModel {
                /// <summary>
                /// <para>The business travel employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2123</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The employee name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The internal business travel cost center ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11376</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <para>The extended information.</para>
            /// <para>You can pass supplementary descriptions into this field, and the corresponding content will be reflected in the bill. This is typically used for enterprise travel statistics and reconciliation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;extend_key&quot;:&quot;extend_value&quot;}</para>
            /// </summary>
            [NameInMap("extend_field")]
            [Validation(Required=false)]
            public string ExtendField { get; set; }

            /// <summary>
            /// <para>The creation time of the application order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The internal business travel invoice header ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11876</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            /// <summary>
            /// <para>The meal itinerary.</para>
            /// </summary>
            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<MealApplyQueryResponseBodyModuleItineraryList> ItineraryList { get; set; }
            public class MealApplyQueryResponseBodyModuleItineraryList : TeaModel {
                /// <summary>
                /// <para>The meal city.</para>
                /// </summary>
                [NameInMap("cities")]
                [Validation(Required=false)]
                public List<MealApplyQueryResponseBodyModuleItineraryListCities> Cities { get; set; }
                public class MealApplyQueryResponseBodyModuleItineraryListCities : TeaModel {
                    /// <summary>
                    /// <para>The city code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>320200</para>
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

                }

                /// <summary>
                /// <para>The end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-05-25 00:00:00</para>
                /// </summary>
                [NameInMap("end_date")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                /// <summary>
                /// <para>The start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-02-05 00:00:00</para>
                /// </summary>
                [NameInMap("start_date")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                /// <summary>
                /// <para>The third-party itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thirdpart1234</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

            }

            /// <summary>
            /// <para>The meal quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
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
            /// <para>The internal business travel project ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11546</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The application order status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the third-party application order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024073128454753</para>
            /// </summary>
            [NameInMap("third_part_apply_id")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            /// <summary>
            /// <para>The third-party cost center ID associated with the application order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>330000303010292572</para>
            /// </summary>
            [NameInMap("third_part_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdPartCostCenterId { get; set; }

            /// <summary>
            /// <para>The third-party invoice header ID associated with the application order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>405009</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <para>The third-party project ID associated with the application order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>210f07f316603757445272547d959f</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
