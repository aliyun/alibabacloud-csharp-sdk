// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of approval orders.</para>
        /// </summary>
        [NameInMap("apply_list")]
        [Validation(Required=false)]
        public List<CarApplyQueryResponseBodyApplyList> ApplyList { get; set; }
        public class CarApplyQueryResponseBodyApplyList : TeaModel {
            /// <summary>
            /// <para>The list of approvers.</para>
            /// </summary>
            [NameInMap("approver_list")]
            [Validation(Required=false)]
            public List<CarApplyQueryResponseBodyApplyListApproverList> ApproverList { get; set; }
            public class CarApplyQueryResponseBodyApplyListApproverList : TeaModel {
                /// <summary>
                /// <para>The approval remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>同意</para>
                /// </summary>
                [NameInMap("note")]
                [Validation(Required=false)]
                public string Note { get; set; }

                /// <summary>
                /// <para>The approval time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-18T20:26Z</para>
                /// </summary>
                [NameInMap("operate_time")]
                [Validation(Required=false)]
                public string OperateTime { get; set; }

                /// <summary>
                /// <para>The sort order value of the approver.</para>
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
                /// <para>The approver employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The approver employee name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("user_name")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

            /// <summary>
            /// <para>The car service approval type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BEFORE: Before using the car service.</description></item>
            /// <item><description>AFTER: After using the car service.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AFTER</para>
            /// </summary>
            [NameInMap("business_type")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

            /// <summary>
            /// <para>The ID of the department to which the employee belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>depart1</para>
            /// </summary>
            [NameInMap("depart_id")]
            [Validation(Required=false)]
            public string DepartId { get; set; }

            /// <summary>
            /// <para>The name of the department to which the employee belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>部门1</para>
            /// </summary>
            [NameInMap("depart_name")]
            [Validation(Required=false)]
            public string DepartName { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T20:26Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// <remarks>
            /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-03-18T20:26Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The itineraries associated with the approval order.</para>
            /// </summary>
            [NameInMap("itinerary_list")]
            [Validation(Required=false)]
            public List<CarApplyQueryResponseBodyApplyListItineraryList> ItineraryList { get; set; }
            public class CarApplyQueryResponseBodyApplyListItineraryList : TeaModel {
                /// <summary>
                /// <para>The destination city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>北京</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The three-letter code of the destination city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival time at the destination city.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-18T20:26Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <para>The internal cost center ID in the business travel system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                /// <summary>
                /// <para>The name of the cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>成本中心1</para>
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
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// <remarks>
                /// <para>Notice: Time format: yyyy-MM-dd\&quot;T\&quot;HH:mm\&quot;Z\&quot;</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-18T20:26Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <para>The internal invoice header ID in the business travel system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public long? InvoiceId { get; set; }

                /// <summary>
                /// <para>The name of the invoice header.</para>
                /// 
                /// <b>Example:</b>
                /// <para>发票抬头1</para>
                /// </summary>
                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <para>The internal itinerary ID in the business travel system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <para>The transportation type. 4: intra-city transportation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("traffic_type")]
                [Validation(Required=false)]
                public int? TrafficType { get; set; }

            }

            /// <summary>
            /// <para>The order ID associated with the car service approval.</para>
            /// </summary>
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// <para>The third-party business trip approval ID associated with the car service approval.</para>
            /// </summary>
            [NameInMap("related_third_apply_id")]
            [Validation(Required=false)]
            public string RelatedThirdApplyId { get; set; }

            /// <summary>
            /// <para>The status of the approval order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
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
            /// <para>The third-party approval order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("thirdpart_id")]
            [Validation(Required=false)]
            public string ThirdpartId { get; set; }

            /// <summary>
            /// <para>The intra-city car service rules.</para>
            /// </summary>
            [NameInMap("traveler_standard")]
            [Validation(Required=false)]
            public List<CarApplyQueryResponseBodyApplyListTravelerStandard> TravelerStandard { get; set; }
            public class CarApplyQueryResponseBodyApplyListTravelerStandard : TeaModel {
                /// <summary>
                /// <para>The cross-city car service rules.</para>
                /// </summary>
                [NameInMap("car_city_set")]
                [Validation(Required=false)]
                public List<CarApplyQueryResponseBodyApplyListTravelerStandardCarCitySet> CarCitySet { get; set; }
                public class CarApplyQueryResponseBodyApplyListTravelerStandardCarCitySet : TeaModel {
                    /// <summary>
                    /// <para>The cross-city code. Only 6-digit codes are supported. Separate multiple values with Chinese commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>110100,330100</para>
                    /// </summary>
                    [NameInMap("city_code")]
                    [Validation(Required=false)]
                    public string CityCode { get; set; }

                    /// <summary>
                    /// <para>The cross-city name. Separate multiple values with Chinese commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京，杭州</para>
                    /// </summary>
                    [NameInMap("city_name")]
                    [Validation(Required=false)]
                    public string CityName { get; set; }

                }

                /// <summary>
                /// <para>The traveler user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userid</para>
                /// </summary>
                [NameInMap("user_id")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            /// <summary>
            /// <para>The reason for the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州出差</para>
            /// </summary>
            [NameInMap("trip_cause")]
            [Validation(Required=false)]
            public string TripCause { get; set; }

            /// <summary>
            /// <para>The title of the approval order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>杭州出差</para>
            /// </summary>
            [NameInMap("trip_title")]
            [Validation(Required=false)]
            public string TripTitle { get; set; }

            /// <summary>
            /// <para>The ID of the employee who initiated the approval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user1</para>
            /// </summary>
            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The name of the employee who initiated the approval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("user_name")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

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
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
