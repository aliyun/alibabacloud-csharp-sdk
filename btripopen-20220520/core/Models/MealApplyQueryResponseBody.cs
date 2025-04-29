// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public MealApplyQueryResponseBodyModule Module { get; set; }
        public class MealApplyQueryResponseBodyModule : TeaModel {
            [NameInMap("apply_user")]
            [Validation(Required=false)]
            public MealApplyQueryResponseBodyModuleApplyUser ApplyUser { get; set; }
            public class MealApplyQueryResponseBodyModuleApplyUser : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2123</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11376</para>
            /// </summary>
            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11876</para>
            /// </summary>
            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public long? InvoiceId { get; set; }

            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<MealApplyQueryResponseBodyModuleItineraryList> ItineraryList { get; set; }
            public class MealApplyQueryResponseBodyModuleItineraryList : TeaModel {
                [NameInMap("cities")]
                [Validation(Required=false)]
                public List<MealApplyQueryResponseBodyModuleItineraryListCities> Cities { get; set; }
                public class MealApplyQueryResponseBodyModuleItineraryListCities : TeaModel {
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                }

                [NameInMap("end_date")]
                [Validation(Required=false)]
                public string EndDate { get; set; }

                [NameInMap("start_date")]
                [Validation(Required=false)]
                public string StartDate { get; set; }

                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

            }

            [NameInMap("meal_amount")]
            [Validation(Required=false)]
            public long? MealAmount { get; set; }

            [NameInMap("meal_cause")]
            [Validation(Required=false)]
            public string MealCause { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>11546</para>
            /// </summary>
            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024073128454753</para>
            /// </summary>
            [NameInMap("third_part_apply_id")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>330000303010292572</para>
            /// </summary>
            [NameInMap("third_part_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdPartCostCenterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>405009</para>
            /// </summary>
            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CS-PROJECT</para>
            /// </summary>
            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
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
