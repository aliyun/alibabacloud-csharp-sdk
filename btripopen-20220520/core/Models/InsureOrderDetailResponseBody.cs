// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderDetailResponseBody : TeaModel {
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

                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public string CertType { get; set; }

                [NameInMap("phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

            }

            [NameInMap("ins_order_id")]
            [Validation(Required=false)]
            public string InsOrderId { get; set; }

            [NameInMap("insure_order_detail_list")]
            [Validation(Required=false)]
            public List<InsureOrderDetailResponseBodyModuleInsureOrderDetailList> InsureOrderDetailList { get; set; }
            public class InsureOrderDetailResponseBodyModuleInsureOrderDetailList : TeaModel {
                [NameInMap("effective_end_time")]
                [Validation(Required=false)]
                public string EffectiveEndTime { get; set; }

                [NameInMap("effective_start_time")]
                [Validation(Required=false)]
                public string EffectiveStartTime { get; set; }

                [NameInMap("insure_segment")]
                [Validation(Required=false)]
                public InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsureSegment InsureSegment { get; set; }
                public class InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsureSegment : TeaModel {
                    [NameInMap("arr_airport_code")]
                    [Validation(Required=false)]
                    public string ArrAirportCode { get; set; }

                    [NameInMap("arr_city")]
                    [Validation(Required=false)]
                    public string ArrCity { get; set; }

                    [NameInMap("arr_city_code")]
                    [Validation(Required=false)]
                    public string ArrCityCode { get; set; }

                    [NameInMap("arr_time")]
                    [Validation(Required=false)]
                    public string ArrTime { get; set; }

                    [NameInMap("dep_airport_code")]
                    [Validation(Required=false)]
                    public string DepAirportCode { get; set; }

                    [NameInMap("dep_city")]
                    [Validation(Required=false)]
                    public string DepCity { get; set; }

                    [NameInMap("dep_city_code")]
                    [Validation(Required=false)]
                    public string DepCityCode { get; set; }

                    [NameInMap("dep_time")]
                    [Validation(Required=false)]
                    public string DepTime { get; set; }

                    [NameInMap("flight_no")]
                    [Validation(Required=false)]
                    public string FlightNo { get; set; }

                }

                [NameInMap("insure_time")]
                [Validation(Required=false)]
                public string InsureTime { get; set; }

                [NameInMap("insured")]
                [Validation(Required=false)]
                public InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsured Insured { get; set; }
                public class InsureOrderDetailResponseBodyModuleInsureOrderDetailListInsured : TeaModel {
                    [NameInMap("birthday")]
                    [Validation(Required=false)]
                    public string Birthday { get; set; }

                    [NameInMap("btrip_user_id")]
                    [Validation(Required=false)]
                    public string BtripUserId { get; set; }

                    [NameInMap("cert_name")]
                    [Validation(Required=false)]
                    public string CertName { get; set; }

                    [NameInMap("cert_no")]
                    [Validation(Required=false)]
                    public string CertNo { get; set; }

                    [NameInMap("cert_type")]
                    [Validation(Required=false)]
                    public string CertType { get; set; }

                    [NameInMap("gender")]
                    [Validation(Required=false)]
                    public string Gender { get; set; }

                    [NameInMap("phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

                [NameInMap("out_sub_ins_order_id")]
                [Validation(Required=false)]
                public string OutSubInsOrderId { get; set; }

                [NameInMap("policy_no")]
                [Validation(Required=false)]
                public string PolicyNo { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("product_name")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("product_no")]
                [Validation(Required=false)]
                public string ProductNo { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

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
