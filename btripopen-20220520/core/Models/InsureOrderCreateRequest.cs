// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderCreateRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public InsureOrderCreateRequestApplicant Applicant { get; set; }
        public class InsureOrderCreateRequestApplicant : TeaModel {
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

        [NameInMap("btrip_user_id")]
        [Validation(Required=false)]
        public string BtripUserId { get; set; }

        [NameInMap("buyer_name")]
        [Validation(Required=false)]
        public string BuyerName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ins_person_and_segment_list")]
        [Validation(Required=false)]
        public List<InsureOrderCreateRequestInsPersonAndSegmentList> InsPersonAndSegmentList { get; set; }
        public class InsureOrderCreateRequestInsPersonAndSegmentList : TeaModel {
            [NameInMap("insure_segment")]
            [Validation(Required=false)]
            public InsureOrderCreateRequestInsPersonAndSegmentListInsureSegment InsureSegment { get; set; }
            public class InsureOrderCreateRequestInsPersonAndSegmentListInsureSegment : TeaModel {
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

            [NameInMap("insured")]
            [Validation(Required=false)]
            public InsureOrderCreateRequestInsPersonAndSegmentListInsured Insured { get; set; }
            public class InsureOrderCreateRequestInsPersonAndSegmentListInsured : TeaModel {
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

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("out_ins_order_id")]
        [Validation(Required=false)]
        public string OutInsOrderId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("out_sub_order_id")]
        [Validation(Required=false)]
        public string OutSubOrderId { get; set; }

        [NameInMap("supplier_code")]
        [Validation(Required=false)]
        public string SupplierCode { get; set; }

    }

}
