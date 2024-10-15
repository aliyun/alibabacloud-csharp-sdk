// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureRefundDetailResponseBody : TeaModel {
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

        [NameInMap("module")]
        [Validation(Required=false)]
        public InsureRefundDetailResponseBodyModule Module { get; set; }
        public class InsureRefundDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1423050918202760437</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100000000001</para>
            /// </summary>
            [NameInMap("ins_order_id")]
            [Validation(Required=false)]
            public string InsOrderId { get; set; }

            [NameInMap("insure_order")]
            [Validation(Required=false)]
            public InsureRefundDetailResponseBodyModuleInsureOrder InsureOrder { get; set; }
            public class InsureRefundDetailResponseBodyModuleInsureOrder : TeaModel {
                [NameInMap("applicant")]
                [Validation(Required=false)]
                public InsureRefundDetailResponseBodyModuleInsureOrderApplicant Applicant { get; set; }
                public class InsureRefundDetailResponseBodyModuleInsureOrderApplicant : TeaModel {
                    [NameInMap("cert_name")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>300000000000000001</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>102</para>
                    /// </summary>
                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public string CertType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000000</para>
                    /// </summary>
                    [NameInMap("phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5142701029379</para>
                /// </summary>
                [NameInMap("biz_order_id")]
                [Validation(Required=false)]
                public string BizOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("biz_type")]
                [Validation(Required=false)]
                public int? BizType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-11T21:21Z</para>
                /// </summary>
                [NameInMap("close_time")]
                [Validation(Required=false)]
                public string CloseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100000000001</para>
                /// </summary>
                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>200300333333</para>
                /// </summary>
                [NameInMap("out_ins_order_id")]
                [Validation(Required=false)]
                public string OutInsOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-11T21:21Z</para>
                /// </summary>
                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>83000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("settle_type")]
                [Validation(Required=false)]
                public int? SettleType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>PAID</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>23102301010</para>
            /// </summary>
            [NameInMap("out_apply_id")]
            [Validation(Required=false)]
            public string OutApplyId { get; set; }

            [NameInMap("sub_order_refund_list")]
            [Validation(Required=false)]
            public List<InsureRefundDetailResponseBodyModuleSubOrderRefundList> SubOrderRefundList { get; set; }
            public class InsureRefundDetailResponseBodyModuleSubOrderRefundList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-17T20:25Z</para>
                /// </summary>
                [NameInMap("effective_end_time")]
                [Validation(Required=false)]
                public string EffectiveEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-17T20:25Z</para>
                /// </summary>
                [NameInMap("effective_start_time")]
                [Validation(Required=false)]
                public string EffectiveStartTime { get; set; }

                [NameInMap("insure_segment")]
                [Validation(Required=false)]
                public InsureRefundDetailResponseBodyModuleSubOrderRefundListInsureSegment InsureSegment { get; set; }
                public class InsureRefundDetailResponseBodyModuleSubOrderRefundListInsureSegment : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>WHA</para>
                    /// </summary>
                    [NameInMap("arr_airport_code")]
                    [Validation(Required=false)]
                    public string ArrAirportCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>YTY</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-05-27 23:00:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NGB</para>
                    /// </summary>
                    [NameInMap("dep_airport_code")]
                    [Validation(Required=false)]
                    public string DepAirportCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>NGB</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-05-27 20:30:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CZ3501</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-17T20:07Z</para>
                /// </summary>
                [NameInMap("insure_time")]
                [Validation(Required=false)]
                public string InsureTime { get; set; }

                [NameInMap("insured")]
                [Validation(Required=false)]
                public InsureRefundDetailResponseBodyModuleSubOrderRefundListInsured Insured { get; set; }
                public class InsureRefundDetailResponseBodyModuleSubOrderRefundListInsured : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1996-07-25</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000001</para>
                    /// </summary>
                    [NameInMap("btrip_user_id")]
                    [Validation(Required=false)]
                    public string BtripUserId { get; set; }

                    [NameInMap("cert_name")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>300000000000000000</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>102</para>
                    /// </summary>
                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public string CertType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>F</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public string Gender { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>OUT123333444</para>
                /// </summary>
                [NameInMap("out_sub_ins_order_id")]
                [Validation(Required=false)]
                public string OutSubInsOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>T230411000000140183629</para>
                /// </summary>
                [NameInMap("policy_no")]
                [Validation(Required=false)]
                public string PolicyNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024194640018002</para>
                /// </summary>
                [NameInMap("policy_refund_no")]
                [Validation(Required=false)]
                public string PolicyRefundNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>73000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("product_name")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>008801.accident.flight.104000</para>
                /// </summary>
                [NameInMap("product_no")]
                [Validation(Required=false)]
                public string ProductNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REFUND_SUCCESS</para>
                /// </summary>
                [NameInMap("refund_status")]
                [Validation(Required=false)]
                public string RefundStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-04-17T20:25Z</para>
                /// </summary>
                [NameInMap("refund_time")]
                [Validation(Required=false)]
                public string RefundTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REFUND_SUCCESS</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>s1231231344</para>
                /// </summary>
                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2103a75b16843756660655464d56a9</para>
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
        /// <para>210bc44e16818128994413918de6c1</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
