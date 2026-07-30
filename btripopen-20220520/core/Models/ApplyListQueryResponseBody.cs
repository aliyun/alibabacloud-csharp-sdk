// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyListQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
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
        /// <para>The list of approval forms.</para>
        /// </summary>
        [NameInMap("module_list")]
        [Validation(Required=false)]
        public List<ApplyListQueryResponseBodyModuleList> ModuleList { get; set; }
        public class ApplyListQueryResponseBodyModuleList : TeaModel {
            /// <summary>
            /// <para>The business travel approval display ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>201710111505000464651</para>
            /// </summary>
            [NameInMap("apply_show_id")]
            [Validation(Required=false)]
            public string ApplyShowId { get; set; }

            /// <summary>
            /// <para>The approver list.</para>
            /// </summary>
            [NameInMap("approver_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListApproverList> ApproverList { get; set; }
            public class ApplyListQueryResponseBodyModuleListApproverList : TeaModel {
                /// <summary>
                /// <para>The approval comment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The operation time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("operate_time")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                /// <summary>
                /// <para>The order of the approver.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("order")]
                [Validation(Required=false)]
                public int? Order { get; set; }

                /// <summary>
                /// <para>The approval status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// <para>The description of the approval status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("status_desc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// <para>The approver ID (third-party user ID).</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The approver name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The business travel car service rules.</para>
            /// </summary>
            [NameInMap("car_rule")]
            [Validation(Required=false)]
            public ApplyListQueryResponseBodyModuleListCarRule CarRule { get; set; }
            public class ApplyListQueryResponseBodyModuleListCarRule : TeaModel {
                /// <summary>
                /// <para>The car service scenario template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("scenario_template_id")]
                [Validation(Required=false)]
                public string ScenarioTemplateId { get; set; }

                /// <summary>
                /// <para>The car service scenario template name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试场景模板</para>
                /// </summary>
                [NameInMap("scenario_template_name")]
                [Validation(Required=false)]
                public string ScenarioTemplateName { get; set; }

            }

            /// <summary>
            /// <para>The enterprise ID on the open platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>corp1</para>
            /// </summary>
            [NameInMap("corp_id")]
            [Validation(Required=false)]
            public string CorpId { get; set; }

            /// <summary>
            /// <para>The enterprise name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("corp_name")]
            [Validation(Required=false)]
            public string CorpName { get; set; }

            /// <summary>
            /// <para>The department ID of the applicant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>depart1</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <para>The department name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>淘宝</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The external traveler list.</para>
            /// </summary>
            [NameInMap("external_traveler_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListExternalTravelerList> ExternalTravelerList { get; set; }
            public class ApplyListQueryResponseBodyModuleListExternalTravelerList : TeaModel {
                /// <summary>
                /// <para>The extension field.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The cost center name.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>商旅成本中心</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The department ID of the user.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>010000009</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

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
                /// <para>The invoice title name.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>HD10002411</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <para>The name of the department to which the expense is attributed.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>一级事业部</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <para>The project code.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project name.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>项目xxx</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <para>The third-party department ID.<notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>DHDI2212201N1DGZDD</para>
                /// </summary>
                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The flow code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc1234</para>
            /// </summary>
            [NameInMap("flow_code")]
            [Validation(Required=false)]
            public string FlowCode { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-19T14:03Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The update time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2018-09-19T14:03Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The business travel approval form ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1476</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The itinerary list.</para>
            /// </summary>
            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListItineraryList> ItineraryList { get; set; }
            public class ApplyListQueryResponseBodyModuleListItineraryList : TeaModel {
                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The arrival date.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <para>The cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里巴巴</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The departure date.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>阿里巴巴</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <para>The itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xm1</para>
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
                /// <para>The third-party cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <para>The third-party invoice title ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_invoice_id")]
                [Validation(Required=false)]
                public string ThirdpartInvoiceId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thirdpart1234</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <para>The transportation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

                /// <summary>
                /// <para>The trip type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("trip_way")]
                [Validation(Required=false)]
                public int? TripWay { get; set; }

            }

            /// <summary>
            /// <para>The city rule of the application form:
            /// 0: One-to-one departure and destination. Itineraries are passed as a list. 
            /// 1: Multiple cities selected. Itineraries are passed as a city set.
            /// When the city rule is 0, the itinerary_list field is required.
            /// When the city rule is 1, the itinerary_set_list field is required.</para>
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
            public List<ApplyListQueryResponseBodyModuleListItinerarySetList> ItinerarySetList { get; set; }
            public class ApplyListQueryResponseBodyModuleListItinerarySetList : TeaModel {
                /// <summary>
                /// <para>The arrival date.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <para>The departure and arrival city codes, separated by Chinese commas (，). A value of 0 indicates no city restriction.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BJS，HGH</para>
                /// </summary>
                [NameInMap("city_code_set")]
                [Validation(Required=false)]
                public string CityCodeSet { get; set; }

                /// <summary>
                /// <para>The departure and arrival city names, separated by Chinese commas (，).</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京，杭州</para>
                /// </summary>
                [NameInMap("city_set")]
                [Validation(Required=false)]
                public string CitySet { get; set; }

                /// <summary>
                /// <para>The cost center name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The departure date.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-19T14:03Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试发票抬头</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <para>The itinerary ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd</para>
                /// </summary>
                [NameInMap("itinerary_id")]
                [Validation(Required=false)]
                public string ItineraryId { get; set; }

                /// <summary>
                /// <para>The project code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>项目名称</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <para>The third-party cost center ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_cost_center_id")]
                [Validation(Required=false)]
                public string ThirdpartCostCenterId { get; set; }

                /// <summary>
                /// <para>The third-party invoice title ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("thirdpart_invoice_id")]
                [Validation(Required=false)]
                public string ThirdpartInvoiceId { get; set; }

                /// <summary>
                /// <para>The third-party itinerary number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>thirdpart1234</para>
                /// </summary>
                [NameInMap("thirdpart_itinerary_id")]
                [Validation(Required=false)]
                public string ThirdpartItineraryId { get; set; }

                /// <summary>
                /// <para>The transportation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

            }

            /// <summary>
            /// <para>The employee ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567</para>
            /// </summary>
            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            /// <summary>
            /// <para>The ID of the department to which the expense is attributed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1142256</para>
            /// </summary>
            [NameInMap("payment_department_id")]
            [Validation(Required=false)]
            public string PaymentDepartmentId { get; set; }

            /// <summary>
            /// <para>The name of the department to which the expense is attributed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>一级事业部</para>
            /// </summary>
            [NameInMap("payment_department_name")]
            [Validation(Required=false)]
            public string PaymentDepartmentName { get; set; }

            /// <summary>
            /// <para>The status of the application form.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The description of the approval form status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>同意</para>
            /// </summary>
            [NameInMap("status_desc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <para>The third-party business ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("thirdpart_business_id")]
            [Validation(Required=false)]
            public string ThirdpartBusinessId { get; set; }

            /// <summary>
            /// <para>The third-party approval form ID. This field is empty if the form is not a third-party approval form.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            /// <summary>
            /// <para>The traveler list.</para>
            /// </summary>
            [NameInMap("traveler_list")]
            [Validation(Required=false)]
            public List<ApplyListQueryResponseBodyModuleListTravelerList> TravelerList { get; set; }
            public class ApplyListQueryResponseBodyModuleListTravelerList : TeaModel {
                /// <summary>
                /// <para>The extension field.
                /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>“{&quot;name&quot;:&quot;张三&quot;}”</para>
                /// </summary>
                [NameInMap("attribute")]
                [Validation(Required=false)]
                public string Attribute { get; set; }

                /// <summary>
                /// <para>The cross-city car service rules.</para>
                /// </summary>
                [NameInMap("car_city_set")]
                [Validation(Required=false)]
                public List<ApplyListQueryResponseBodyModuleListTravelerListCarCitySet> CarCitySet { get; set; }
                public class ApplyListQueryResponseBodyModuleListTravelerListCarCitySet : TeaModel {
                    /// <summary>
                    /// <para>The cross-city code (6-digit city code). Multiple values are separated by Chinese commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>110100,330100</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <para>The cross-city name. Multiple values are separated by Chinese commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京，杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                }

                /// <summary>
                /// <para>The cost center name.
                /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>“成本中心”</para>
                /// </summary>
                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                /// <summary>
                /// <para>The department ID of the user.
                /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>330920003106</para>
                /// </summary>
                [NameInMap("depart_id")]
                [Validation(Required=false)]
                public string DepartId { get; set; }

                /// <summary>
                /// <para>The invoice title name.
                /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>HD55226</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <para>The employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("job_no")]
                [Validation(Required=false)]
                public string JobNo { get; set; }

                /// <summary>
                /// <para>The name of the department to which the expense is attributed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>“一级事业部”</para>
                /// </summary>
                [NameInMap("payment_department_name")]
                [Validation(Required=false)]
                public string PaymentDepartmentName { get; set; }

                /// <summary>
                /// <para>The project code.
                /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>acs</para>
                /// </summary>
                [NameInMap("project_code")]
                [Validation(Required=false)]
                public string ProjectCode { get; set; }

                /// <summary>
                /// <para>The project name.
                /// <notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>“成本项目”</para>
                /// </summary>
                [NameInMap("project_title")]
                [Validation(Required=false)]
                public string ProjectTitle { get; set; }

                /// <summary>
                /// <para>The third-party department ID.</para>
                /// <para>Either the third-party department ID or the department ID can be specified. The specified field takes precedence.</para>
                /// <para>If both the third-party department ID and the department ID are specified, the third-party department ID takes precedence.</para>
                /// <para><notice>&quot;To use this field, contact your customer operations representative.&quot;</notice></para>
                /// 
                /// <b>Example:</b>
                /// <para>10225</para>
                /// </summary>
                [NameInMap("thirdpart_depart_id")]
                [Validation(Required=false)]
                public string ThirdpartDepartId { get; set; }

                /// <summary>
                /// <para>The traveler ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The reason for the business trip.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京出差</para>
            /// </summary>
            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            /// <summary>
            /// <para>The number of business travel days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("trip_day")]
            [Validation(Required=false)]
            public int? TripDay { get; set; }

            /// <summary>
            /// <para>The title of the application form.</para>
            /// 
            /// <b>Example:</b>
            /// <para>北京出差</para>
            /// </summary>
            [NameInMap("trip_title")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            /// <summary>
            /// <para>The submission type of the application form. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: Submitted on behalf of another person.</description></item>
            /// <item><description>2: Submitted by the applicant.</description></item>
            /// </list>
            /// <para>Note: When the application form is submitted on behalf of another person, the submitter cannot place orders for themselves.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

            /// <summary>
            /// <para>The third-party associated order number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("union_no")]
            [Validation(Required=false)]
            public string UnionNo { get; set; }

            /// <summary>
            /// <para>The applicant ID (third-party user ID).</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
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
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
