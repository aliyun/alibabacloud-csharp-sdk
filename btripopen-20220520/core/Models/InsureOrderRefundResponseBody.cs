// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderRefundResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public InsureOrderRefundResponseBodyModule Module { get; set; }
        public class InsureOrderRefundResponseBodyModule : TeaModel {
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            [NameInMap("ins_order_id")]
            [Validation(Required=false)]
            public string InsOrderId { get; set; }

            [NameInMap("ins_refund_list")]
            [Validation(Required=false)]
            public List<InsureOrderRefundResponseBodyModuleInsRefundList> InsRefundList { get; set; }
            public class InsureOrderRefundResponseBodyModuleInsRefundList : TeaModel {
                [NameInMap("policy_refund_no")]
                [Validation(Required=false)]
                public string PolicyRefundNo { get; set; }

                [NameInMap("refund_status")]
                [Validation(Required=false)]
                public string RefundStatus { get; set; }

                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

            [NameInMap("out_apply_id")]
            [Validation(Required=false)]
            public string OutApplyId { get; set; }

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
