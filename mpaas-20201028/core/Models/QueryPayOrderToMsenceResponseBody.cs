// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class QueryPayOrderToMsenceResponseBody : TeaModel {
        [NameInMap("MpaasUserGamecenterPaymentQuerystatusResponse")]
        [Validation(Required=false)]
        public QueryPayOrderToMsenceResponseBodyMpaasUserGamecenterPaymentQuerystatusResponse MpaasUserGamecenterPaymentQuerystatusResponse { get; set; }
        public class QueryPayOrderToMsenceResponseBodyMpaasUserGamecenterPaymentQuerystatusResponse : TeaModel {
            [NameInMap("CpExtra")]
            [Validation(Required=false)]
            public string CpExtra { get; set; }

            [NameInMap("OrderStatus")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMsg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
