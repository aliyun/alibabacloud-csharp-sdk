// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderDetailResponseBody : TeaModel {
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
        public InsureOrderDetailResponseBodyModule Module { get; set; }
        public class InsureOrderDetailResponseBodyModule : TeaModel {
            [NameInMap("applicant")]
            [Validation(Required=false)]
            public InsureOrderDetailResponseBodyModuleApplicant Applicant { get; set; }
            public class InsureOrderDetailResponseBodyModuleApplicant : TeaModel {
                [NameInMap("cert_name")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3300000000000</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13000000000</para>
                /// </summary>
                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1021000196440356901</para>
            /// </summary>
            [NameInMap("ins_order_id")]
            [Validation(Required=false)]
            public string InsOrderId { get; set; }

            [NameInMap("insure_order_detail_list")]
            [Validation(Required=false)]
            public List<InsureOrderDetailResponseBodyModuleInsureOrderDetailList> InsureOrderDetailList { get; set; }
            public class InsureOrderDetailResponseBodyModuleInsureOrderDetailList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-12 10:00:00</para>
                /// </summary>
                [NameInMap("effective_end_time")]
                [Validation(Required=false)]
                public string EffectiveEndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-10-11 10:00:00</para>
                /// </summary>
                [NameInMap("effective_start_time")]
                [Validation(Required=false)]
                public string EffectiveStartTime { get; set; }

                [NameInMap("insure_segment")]
                [Validation(Required=false)]
                public InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsureSegment InsureSegment { get; set; }
                public class InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsureSegment : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TYN</para>
                    /// </summary>
                    [NameInMap("arr_airport_code")]
                    [Validation(Required=false)]
                    public string ArrAirportCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HYN</para>
                    /// </summary>
                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SYX</para>
                    /// </summary>
                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-10-11 11:30:00</para>
                    /// </summary>
                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TYN</para>
                    /// </summary>
                    [NameInMap("dep_airport_code")]
                    [Validation(Required=false)]
                    public string DepAirportCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CTU</para>
                    /// </summary>
                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LXA</para>
                    /// </summary>
                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2023-10-11 11:30:00</para>
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
                /// <para>2023-10-11 11:30:00</para>
                /// </summary>
                [NameInMap("insure_time")]
                [Validation(Required=false)]
                public string InsureTime { get; set; }

                [NameInMap("insured")]
                [Validation(Required=false)]
                public InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsured Insured { get; set; }
                public class InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsured : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1983-11-25</para>
                    /// </summary>
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100001</para>
                    /// </summary>
                    [NameInMap("btrip_user_id")]
                    [Validation(Required=false)]
                    public string BtripUserId { get; set; }

                    [NameInMap("cert_name")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30000000000</para>
                    /// </summary>
                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>100</para>
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
                    /// <para>130000000</para>
                    /// </summary>
                    [NameInMap("phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1021000196440356922</para>
                /// </summary>
                [NameInMap("out_sub_ins_order_id")]
                [Validation(Required=false)]
                public string OutSubInsOrderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22222222222</para>
                /// </summary>
                [NameInMap("policy_no")]
                [Validation(Required=false)]
                public string PolicyNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
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
                /// <para>CLOSED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1021000196440356901</para>
                /// </summary>
                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CLOSED</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4498BDAB-2AAF-5B6F-942A-3C1C935345C9</para>
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
