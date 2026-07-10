// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class MealApplyQueryResponseBody : TeaModel {
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
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("cost_center_id")]
            [Validation(Required=false)]
            public long? CostCenterId { get; set; }

            [NameInMap("extend_field")]
            [Validation(Required=false)]
            public string ExtendField { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

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

            [NameInMap("project_id")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("third_part_apply_id")]
            [Validation(Required=false)]
            public string ThirdPartApplyId { get; set; }

            [NameInMap("third_part_cost_center_id")]
            [Validation(Required=false)]
            public string ThirdPartCostCenterId { get; set; }

            [NameInMap("third_part_invoice_id")]
            [Validation(Required=false)]
            public string ThirdPartInvoiceId { get; set; }

            [NameInMap("third_part_project_id")]
            [Validation(Required=false)]
            public string ThirdPartProjectId { get; set; }

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
