// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderCreateRequest : TeaModel {
        /// <summary>
        /// <para>The applicant information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public InsureOrderCreateRequestApplicant Applicant { get; set; }
        public class InsureOrderCreateRequestApplicant : TeaModel {
            /// <summary>
            /// <para>The birthday of the insured person.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000-11-01</para>
            /// </summary>
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// <para>The business travel user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20202109390122</para>
            /// </summary>
            [NameInMap("btrip_user_id")]
            [Validation(Required=false)]
            public string BtripUserId { get; set; }

            /// <summary>
            /// <para>The name on the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试乘机人</para>
            /// </summary>
            [NameInMap("cert_name")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The certificate number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>110102200011018872</para>
            /// </summary>
            [NameInMap("cert_no")]
            [Validation(Required=false)]
            public string CertNo { get; set; }

            /// <summary>
            /// <para>The certificate type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("cert_type")]
            [Validation(Required=false)]
            public string CertType { get; set; }

            /// <summary>
            /// <para>The gender of the insured person. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>M: male</description></item>
            /// <item><description>F: female</description></item>
            /// </list>
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
        /// <para>The business travel user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20202109390122</para>
        /// </summary>
        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        /// <summary>
        /// <para>The name of the buyer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试乘机人</para>
        /// </summary>
        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// <para>The passenger and segment information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ins_person_and_segment_list")]
        [Validation(Required=false)]
        public List<InsureOrderCreateRequestInsPersonAndSegmentList> InsPersonAndSegmentList { get; set; }
        public class InsureOrderCreateRequestInsPersonAndSegmentList : TeaModel {
            /// <summary>
            /// <para>The flight segment information.</para>
            /// </summary>
            [NameInMap("insure_segment")]
            [Validation(Required=false)]
            public InsureOrderCreateRequestInsPersonAndSegmentListInsureSegment InsureSegment { get; set; }
            public class InsureOrderCreateRequestInsPersonAndSegmentListInsureSegment : TeaModel {
                /// <summary>
                /// <para>The three-letter code of the arrival airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>YNT</para>
                /// </summary>
                [NameInMap("arr_airport_code")]
                [Validation(Required=false)]
                public string ArrAirportCode { get; set; }

                /// <summary>
                /// <para>The arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CKG</para>
                /// </summary>
                [NameInMap("arr_city")]
                [Validation(Required=false)]
                public string ArrCity { get; set; }

                /// <summary>
                /// <para>The three-letter code of the arrival city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("arr_city_code")]
                [Validation(Required=false)]
                public string ArrCityCode { get; set; }

                /// <summary>
                /// <para>The arrival time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-31 13:10:00</para>
                /// </summary>
                [NameInMap("arr_time")]
                [Validation(Required=false)]
                public string ArrTime { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure airport.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_airport_code")]
                [Validation(Required=false)]
                public string DepAirportCode { get; set; }

                /// <summary>
                /// <para>The departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HGH</para>
                /// </summary>
                [NameInMap("dep_city")]
                [Validation(Required=false)]
                public string DepCity { get; set; }

                /// <summary>
                /// <para>The three-letter code of the departure city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CAN</para>
                /// </summary>
                [NameInMap("dep_city_code")]
                [Validation(Required=false)]
                public string DepCityCode { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-10-31 10:55:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The flight number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ZH9891</para>
                /// </summary>
                [NameInMap("flight_no")]
                [Validation(Required=false)]
                public string FlightNo { get; set; }

            }

            /// <summary>
            /// <para>The insured person.</para>
            /// </summary>
            [NameInMap("insured")]
            [Validation(Required=false)]
            public InsureOrderCreateRequestInsPersonAndSegmentListInsured Insured { get; set; }
            public class InsureOrderCreateRequestInsPersonAndSegmentListInsured : TeaModel {
                /// <summary>
                /// <para>The birthday of the insured person.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000-11-01</para>
                /// </summary>
                [NameInMap("birthday")]
                [Validation(Required=false)]
                public string Birthday { get; set; }

                /// <summary>
                /// <para>The business travel user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20202109390122</para>
                /// </summary>
                [NameInMap("btrip_user_id")]
                [Validation(Required=false)]
                public string BtripUserId { get; set; }

                /// <summary>
                /// <para>The name on the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试乘机人</para>
                /// </summary>
                [NameInMap("cert_name")]
                [Validation(Required=false)]
                public string CertName { get; set; }

                /// <summary>
                /// <para>The certificate number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>110102200011018872</para>
                /// </summary>
                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                /// <summary>
                /// <para>The certificate type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                /// <summary>
                /// <para>The gender of the insured person. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>M: male</description></item>
                /// <item><description>F: female</description></item>
                /// </list>
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
            /// <para>12399992002002010</para>
            /// </summary>
            [NameInMap("out_sub_ins_order_id")]
            [Validation(Required=false)]
            public string OutSubInsOrderId { get; set; }

        }

        /// <summary>
        /// <para>The user-defined channel name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostalSavingsBank</para>
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        /// <summary>
        /// <para>The external insurance order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000320302020</para>
        /// </summary>
        [NameInMap("out_ins_order_id")]
        [Validation(Required=false)]
        public string OutInsOrderId { get; set; }

        /// <summary>
        /// <para>The flight order ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202310101026030</para>
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        /// <summary>
        /// <para>The change order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1020030003332000</para>
        /// </summary>
        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        /// <summary>
        /// <para>The supplier code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fliggy</para>
        /// </summary>
        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

    }

}
