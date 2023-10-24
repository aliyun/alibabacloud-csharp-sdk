// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderCreateResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public InsureOrderCreateResponseBodyModule Module { get; set; }
        public class InsureOrderCreateResponseBodyModule : TeaModel {
            [NameInMap("copies")]
            [Validation(Required=false)]
            public int? Copies { get; set; }

            [NameInMap("insure_order_detail_list")]
            [Validation(Required=false)]
            public List<InsureOrderCreateResponseBodyModuleInsureOrderDetailList> InsureOrderDetailList { get; set; }
            public class InsureOrderCreateResponseBodyModuleInsureOrderDetailList : TeaModel {
                [NameInMap("out_sub_ins_order_id")]
                [Validation(Required=false)]
                public string OutSubInsOrderId { get; set; }

                [NameInMap("policy_no")]
                [Validation(Required=false)]
                public string PolicyNo { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

            [NameInMap("insure_order_id")]
            [Validation(Required=false)]
            public string InsureOrderId { get; set; }

            [NameInMap("premium")]
            [Validation(Required=false)]
            public long? Premium { get; set; }

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
