// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyListQueryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
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
            /// <summary>
            /// <b>Example:</b>
            /// <para>201710111505000464651</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("operate_time")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            [NameInMap("car_rule")]
            [Validation(Required=false)]
            public ApplyListQueryResponseBodyModuleListCarRule CarRule { get; set; }
            public class ApplyListQueryResponseBodyModuleListCarRule : TeaModel {
                [NameInMap("scenario_template_id")]
                [Validation(Required=false)]
                public string ScenarioTemplateId { get; set; }

                [NameInMap("scenario_template_name")]
                [Validation(Required=false)]
                public string ScenarioTemplateName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>corp1</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>depart1</para>
            /// </summary>
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
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("external_user_id")]
                [Validation(Required=false)]
                public string ExternalUserId { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc1234</para>
            /// </summary>
            [NameInMap("flow_code")]
            [Validation(Required=false)]
            public string FlowCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-09-19T14:03Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2018-09-19T14:03Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1476</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xm1</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                [NameInMap("thirdpart_invoice_id")]
                [Validation(Required=false)]
                public string ThirdpartInvoiceId { get; set; }

                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_way")]
                [Validation(Required=false)]
                public int? TripWay { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("itinerary_rule")]
            [Validation(Required=false)]
            public int? ItineraryRule { get; set; }

            [NameInMap("itinerary_set_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListItinerarySetList> ItinerarySetList { get; set; }
            public class ApplyListQueryResponseBodyModuleListItinerarySetList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BJS，HGH</para>
                /// </summary>
                [NameInMap("city_code_set")]
                [Validation(Required=false)]
                public string CityCodeSet { get; set; }

                [NameInMap("city_set")]
                [Validation(Required=false)]
                public string CitySet { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                [NameInMap("thirdpart_invoice_id")]
                [Validation(Required=false)]
                public string ThirdpartInvoiceId { get; set; }

                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

            }

            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("status_desc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            [NameInMap("traveler_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListTravelerList> TravelerList { get; set; }
            public class ApplyListQueryResponseBodyModuleListTravelerList : TeaModel {
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                [NameInMap("car_city_set")]
                [Validation(Required=false)]
                public List<ApplyListQueryResponseBodyModuleListTravelerListCarCitySet> CarCitySet { get; set; }
                public class ApplyListQueryResponseBodyModuleListTravelerListCarCitySet : TeaModel {
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("trip_day")]
            [Validation(Required=false)]
            public int? TripDay { get; set; }

            [NameInMap("trip_title")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("union_no")]
            [Validation(Required=false)]
            public string UnionNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user1</para>
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
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
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
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
