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

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-18T20:26Z</para>
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

            [NameInMap("business_type")]
            [Validation(Required=false)]
            public string BusinessType { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-18T20:26Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-03-18T20:26Z</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-18T20:26Z</para>
                /// </summary>
                [NameInMap("arr_date")]
                [Validation(Required=false)]
                public string ArrDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("cost_center_id")]
                [Validation(Required=false)]
                public long? CostCenterId { get; set; }

                [NameInMap("cost_center_name")]
                [Validation(Required=false)]
                public string CostCenterName { get; set; }

                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-03-18T20:26Z</para>
                /// </summary>
                [NameInMap("dep_date")]
                [Validation(Required=false)]
                public string DepDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_id")]
                [Validation(Required=false)]
                public long? InvoiceId { get; set; }

                [NameInMap("invoice_name")]
                [Validation(Required=false)]
                public string InvoiceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("status_desc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
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
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210bcc3a16583004579056128d33d7</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
