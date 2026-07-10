// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureRefundDetailResponseBody : TeaModel {
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
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            [NameInMap("gmt_create")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmt_modified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

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

                [NameInMap("biz_order_id")]
                [Validation(Required=false)]
                public string BizOrderId { get; set; }

                [NameInMap("biz_type")]
                [Validation(Required=false)]
                public int? BizType { get; set; }

                [NameInMap("close_time")]
                [Validation(Required=false)]
                public string CloseTime { get; set; }

                [NameInMap("ins_order_id")]
                [Validation(Required=false)]
                public string InsOrderId { get; set; }

                [NameInMap("out_ins_order_id")]
                [Validation(Required=false)]
                public string OutInsOrderId { get; set; }

                [NameInMap("pay_time")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("settle_type")]
                [Validation(Required=false)]
                public int? SettleType { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("out_apply_id")]
            [Validation(Required=false)]
            public string OutApplyId { get; set; }

            [NameInMap("sub_order_refund_list")]
            [Validation(Required=false)]
            public List<InsureRefundDetailResponseBodyModuleSubOrderRefundList> SubOrderRefundList { get; set; }
            public class InsureRefundDetailResponseBodyModuleSubOrderRefundList : TeaModel {
                [NameInMap("effective_end_time")]
                [Validation(Required=false)]
                public string EffectiveEndTime { get; set; }

                [NameInMap("effective_start_time")]
                [Validation(Required=false)]
                public string EffectiveStartTime { get; set; }

                [NameInMap("insure_segment")]
                [Validation(Required=false)]
                public InsureRefundDetailResponseBodyModuleSubOrderRefundListInsureSegment InsureSegment { get; set; }
                public class InsureRefundDetailResponseBodyModuleSubOrderRefundListInsureSegment : TeaModel {
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
                public InsureRefundDetailResponseBodyModuleSubOrderRefundListInsured Insured { get; set; }
                public class InsureRefundDetailResponseBodyModuleSubOrderRefundListInsured : TeaModel {
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

                [NameInMap("policy_refund_no")]
                [Validation(Required=false)]
                public string PolicyRefundNo { get; set; }

                [NameInMap("price")]
                [Validation(Required=false)]
                public long? Price { get; set; }

                [NameInMap("product_name")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("product_no")]
                [Validation(Required=false)]
                public string ProductNo { get; set; }

                [NameInMap("refund_status")]
                [Validation(Required=false)]
                public string RefundStatus { get; set; }

                [NameInMap("refund_time")]
                [Validation(Required=false)]
                public string RefundTime { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

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
