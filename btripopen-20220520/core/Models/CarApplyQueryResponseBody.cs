// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyQueryResponseBody : TeaModel {
        [NameInMap("apply_list")]
        [Validation(Required=false)]
        public List<CarApplyQueryResponseBodyApplyList> ApplyList { get; set; }
        public class CarApplyQueryResponseBodyApplyList : TeaModel {
            [NameInMap("approver_list")]
            [Validation(Required=false)]
            public List<CarApplyQueryResponseBodyApplyListApproverList> ApproverList { get; set; }
            public class CarApplyQueryResponseBodyApplyListApproverList : TeaModel {
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                [NameInMap("operate_time")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("business_type")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<CarApplyQueryResponseBodyApplyListItineraryList> ItineraryList { get; set; }
            public class CarApplyQueryResponseBodyApplyListItineraryList : TeaModel {
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public long? InvoiceId { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

            }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("related_third_apply_id")]
            [Validation(Required=false)]
            public string RelatedThirdApplyId { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("status_desc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("traveler_standard")]
            [Validation(Required=false)]
            public List<CarApplyQueryResponseBodyApplyListTravelerStandard> TravelerStandard { get; set; }
            public class CarApplyQueryResponseBodyApplyListTravelerStandard : TeaModel {
                [NameInMap("car_city_set")]
                [Validation(Required=false)]
                public List<CarApplyQueryResponseBodyApplyListTravelerStandardCarCitySet> CarCitySet { get; set; }
                public class CarApplyQueryResponseBodyApplyListTravelerStandardCarCitySet : TeaModel {
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            [NameInMap("trip_title")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
