// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureRefundDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
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
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public InsureRefundDetailResponseBodyModule Module { get; set; }
        public class InsureRefundDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The refund application number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1423050918202760437</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-20T10:40Z</para>
            /// </summary>
            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-04T16:13Z</para>
            /// </summary>
            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The insurance order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100000000001</para>
            /// </summary>
            [NameInMap("ins_order_id")]
            [Validation(Required=false)]
            public string InsOrderId { get; set; }

            /// <summary>
            /// <para>The insurance order information.</para>
            /// </summary>
            [NameInMap("insure_order")]
            [Validation(Required=false)]
            public InsureRefundDetailResponseBodyModuleInsureOrder InsureOrder { get; set; }
            public class InsureRefundDetailResponseBodyModuleInsureOrder : TeaModel {
                /// <summary>
                /// <para>The policyholder information.</para>
                /// </summary>
                [NameInMap("applicant")]
                [Validation(Required=false)]
                public InsureRefundDetailResponseBodyModuleInsureOrderApplicant Applicant { get; set; }
                public class InsureRefundDetailResponseBodyModuleInsureOrderApplicant : TeaModel {
                    /// <summary>
                    /// <para>The policyholder name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("cert_name")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <para>The policyholder certificate number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000000000000001</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <para>The policyholder certificate type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>102</para>
                    /// </summary>
                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public string CertType { get; set; }

                    /// <summary>
                    /// <para>The policyholder phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000000</para>
                    /// </summary>
                    [NameInMap("phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

                /// <summary>
                /// <para>The business main order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5142701029379</para>
                /// </summary>
                [NameInMap("biz_order_id")]
                [Validation(Required=false)]
                public string BizOrderId { get; set; }

                /// <summary>
                /// <para>The business type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Flight.</description></item>
                /// <item><description>2: Hotel.</description></item>
                /// <item><description>3: Train ticket.</description></item>
                /// <item><description>4: Car service.</description></item>
                /// <item><description>6: Business travel train ticket.</description></item>
                /// <item><description>10: Fudou.</description></item>
                /// <item><description>11: International flight.</description></item>
                /// <item><description>15: International flight inquiry order.</description></item>
                /// <item><description>-1: Unknown.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("biz_type")]
                [Validation(Required=false)]
                public int? BizType { get; set; }

                /// <summary>
                /// <para>The order close time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-11T21:21Z</para>
                /// </summary>
                [NameInMap("close_time")]
                [Validation(Required=false)]
                public string CloseTime { get; set; }

                /// <summary>
                /// <para>The insurance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000000001</para>
                /// </summary>
                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                /// <summary>
                /// <para>The external insurance order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200300333333</para>
                /// </summary>
                [NameInMap("out_ins_order_id")]
                [Validation(Required=false)]
                public string OutInsOrderId { get; set; }

                /// <summary>
                /// <para>The payment time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-11T21:21Z</para>
                /// </summary>
                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                /// <summary>
                /// <para>The total insurance price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The business travel settlement method. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: Personal payment.</description></item>
                /// <item><description>2: Enterprise payment.</description></item>
                /// <item><description>4: Enterprise monthly settlement.</description></item>
                /// <item><description>8: Enterprise prepaid.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("settle_type")]
                [Validation(Required=false)]
                public int? SettleType { get; set; }

                /// <summary>
                /// <para>The insurance order status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INIT: Initialized.</description></item>
                /// <item><description>CLOSED: Order closed.</description></item>
                /// <item><description>REFUNDED: Refunded.</description></item>
                /// <item><description>WAIT_PAY: Pending payment.</description></item>
                /// <item><description>PAID: Paid.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PAID</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The external refund application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23102301010</para>
            /// </summary>
            [NameInMap("out_apply_id")]
            [Validation(Required=false)]
            public string OutApplyId { get; set; }

            /// <summary>
            /// <para>The refund details.</para>
            /// </summary>
            [NameInMap("sub_order_refund_list")]
            [Validation(Required=false)]
            public List<InsureRefundDetailResponseBodyModuleSubOrderRefundList> SubOrderRefundList { get; set; }
            public class InsureRefundDetailResponseBodyModuleSubOrderRefundList : TeaModel {
                /// <summary>
                /// <para>The coverage end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-17T20:25Z</para>
                /// </summary>
                [NameInMap("effective_end_time")]
                [Validation(Required=false)]
                public string EffectiveEndTime { get; set; }

                /// <summary>
                /// <para>The coverage start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-17T20:25Z</para>
                /// </summary>
                [NameInMap("effective_start_time")]
                [Validation(Required=false)]
                public string EffectiveStartTime { get; set; }

                /// <summary>
                /// <para>The flight segment information.</para>
                /// </summary>
                [NameInMap("insure_segment")]
                [Validation(Required=false)]
                public InsureRefundDetailResponseBodyModuleSubOrderRefundListInsureSegment InsureSegment { get; set; }
                public class InsureRefundDetailResponseBodyModuleSubOrderRefundListInsureSegment : TeaModel {
                    /// <summary>
                    /// <para>The three-letter code of the arrival airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WHA</para>
                    /// </summary>
                    [NameInMap("arr_airport_code")]
                    [Validation(Required=false)]
                    public string ArrAirportCode { get; set; }

                    /// <summary>
                    /// <para>The arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>汕头</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the arrival city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>YTY</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <para>The arrival time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-27 23:00:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure airport.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NGB</para>
                    /// </summary>
                    [NameInMap("dep_airport_code")]
                    [Validation(Required=false)]
                    public string DepAirportCode { get; set; }

                    /// <summary>
                    /// <para>The departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>北京</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <para>The three-letter code of the departure city.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>NGB</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <para>The departure time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2023-05-27 20:30:00</para>
                    /// </summary>
                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    /// <summary>
                    /// <para>The flight number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CZ3501</para>
                    /// </summary>
                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                }

                /// <summary>
                /// <para>The time when the insurance was successfully purchased.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-17T20:07Z</para>
                /// </summary>
                [NameInMap("insure_time")]
                [Validation(Required=false)]
                public string InsureTime { get; set; }

                /// <summary>
                /// <para>The insured person information.</para>
                /// </summary>
                [NameInMap("insured")]
                [Validation(Required=false)]
                public InsureRefundDetailResponseBodyModuleSubOrderRefundListInsured Insured { get; set; }
                public class InsureRefundDetailResponseBodyModuleSubOrderRefundListInsured : TeaModel {
                    /// <summary>
                    /// <para>The birthday of the insured person.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1996-07-25</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <para>The business travel user ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000001</para>
                    /// </summary>
                    [NameInMap("btrip_user_id")]
                    [Validation(Required=false)]
                    public string BtripUserId { get; set; }

                    /// <summary>
                    /// <para>The name on the certificate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("cert_name")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <para>The certificate number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300000000000000000</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <para>The certificate type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>100: Resident ID card.</description></item>
                    /// <item><description>101: Household register.</description></item>
                    /// <item><description>102: Passport.</description></item>
                    /// <item><description>103: Military officer certificate.</description></item>
                    /// <item><description>104: Soldier certificate.</description></item>
                    /// <item><description>105: Hong Kong and Macao resident travel permit to mainland China.</description></item>
                    /// <item><description>106: Taiwan compatriot travel permit to mainland China.</description></item>
                    /// <item><description>9907: Police officer certificate.</description></item>
                    /// <item><description>9908: Student ID.</description></item>
                    /// <item><description>9909: Home return permit.</description></item>
                    /// <item><description>9910: Taiwan travel permit.</description></item>
                    /// <item><description>9911: International seaman certificate.</description></item>
                    /// <item><description>9912: Foreigner permanent residence permit.</description></item>
                    /// <item><description>9913: Entry permit to Taiwan.</description></item>
                    /// <item><description>9914: Birth certificate.</description></item>
                    /// <item><description>9915: Other personal certificates.</description></item>
                    /// <item><description>9916: Unified social credit code.</description></item>
                    /// <item><description>9917: Hong Kong and Macao resident residence permit.</description></item>
                    /// <item><description>9918: Taiwan resident residence permit.</description></item>
                    /// <item><description>9919: Chinese driver license.</description></item>
                    /// <item><description>9920: Hong Kong and Macao travel permit.</description></item>
                    /// <item><description>9999: Unknown.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>102</para>
                    /// </summary>
                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public string CertType { get; set; }

                    /// <summary>
                    /// <para>The gender. Valid values: M (male) and F (female).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>F</para>
                    /// </summary>
                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public string Gender { get; set; }

                    /// <summary>
                    /// <para>The phone number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

                /// <summary>
                /// <para>The external sub-order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OUT123333444</para>
                /// </summary>
                [NameInMap("out_sub_ins_order_id")]
                [Validation(Required=false)]
                public string OutSubInsOrderId { get; set; }

                /// <summary>
                /// <para>The policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>T230411000000140183629</para>
                /// </summary>
                [NameInMap("policy_no")]
                [Validation(Required=false)]
                public string PolicyNo { get; set; }

                /// <summary>
                /// <para>The policy refund number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024194640018002</para>
                /// </summary>
                [NameInMap("policy_refund_no")]
                [Validation(Required=false)]
                public string PolicyRefundNo { get; set; }

                /// <summary>
                /// <para>The policy price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>73000</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                /// <summary>
                /// <para>The insurance product name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>安仙-泰康国内航意（商旅TOB）</para>
                /// </summary>
                [NameInMap("product_name")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                /// <summary>
                /// <para>The insurance product code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>008801.accident.flight.104000</para>
                /// </summary>
                [NameInMap("product_no")]
                [Validation(Required=false)]
                public string ProductNo { get; set; }

                /// <summary>
                /// <para>The refund status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>REFUND_SUCCESS: Refund succeeded.</description></item>
                /// <item><description>REFUNDING_AMOUNT: Refund in progress.</description></item>
                /// <item><description>REFUND_FAIL: Refund failed.</description></item>
                /// <item><description>REFUNDING_INSURE: Insurance cancellation in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>REFUND_SUCCESS</para>
                /// </summary>
                [NameInMap("refund_status")]
                [Validation(Required=false)]
                public string RefundStatus { get; set; }

                /// <summary>
                /// <para>The time when the refund succeeded.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-17T20:25Z</para>
                /// </summary>
                [NameInMap("refund_time")]
                [Validation(Required=false)]
                public string RefundTime { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>REFUND_SUCCESS</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The sub-order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s1231231344</para>
                /// </summary>
                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2103a75b16843756660655464d56a9</para>
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
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210bc44e16818128994413918de6c1</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
