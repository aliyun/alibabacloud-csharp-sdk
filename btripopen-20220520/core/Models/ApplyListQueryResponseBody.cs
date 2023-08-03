// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyListQueryResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module_list")]
        [Validation(Required=false)]
        public List<ApplyListQueryResponseBodyModuleList> ModuleList { get; set; }
        public class ApplyListQueryResponseBodyModuleList : TeaModel {
            [NameInMap("apply_show_id")]
            [Validation(Required=false)]
            public string ApplyShowId { get; set; }

            [NameInMap("approver_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListApproverList> ApproverList { get; set; }
            public class ApplyListQueryResponseBodyModuleListApproverList : TeaModel {
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

            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            [NameInMap("external_traveler_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListExternalTravelerList> ExternalTravelerList { get; set; }
            public class ApplyListQueryResponseBodyModuleListExternalTravelerList : TeaModel {
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("flow_code")]
            [Validation(Required=false)]
            public string FlowCode { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListItineraryList> ItineraryList { get; set; }
            public class ApplyListQueryResponseBodyModuleListItineraryList : TeaModel {
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

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

                [NameInMap("trip_way")]
                [Validation(Required=false)]
                public int? TripWay { get; set; }

            }

            [NameInMap("itinerary_rule")]
            [Validation(Required=false)]
            public int? ItineraryRule { get; set; }

            [NameInMap("itinerary_set_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListItinerarySetList> ItinerarySetList { get; set; }
            public class ApplyListQueryResponseBodyModuleListItinerarySetList : TeaModel {
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("city_code_set")]
                [Validation(Required=false)]
                public string CityCodeSet { get; set; }

                [NameInMap("city_set")]
                [Validation(Required=false)]
                public string CitySet { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

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

            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("status_desc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("traveler_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListTravelerList> TravelerList { get; set; }
            public class ApplyListQueryResponseBodyModuleListTravelerList : TeaModel {
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            [NameInMap("trip_day")]
            [Validation(Required=false)]
            public int? TripDay { get; set; }

            [NameInMap("trip_title")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            [NameInMap("union_no")]
            [Validation(Required=false)]
            public string UnionNo { get; set; }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

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
