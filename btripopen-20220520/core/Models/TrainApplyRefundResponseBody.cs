// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainApplyRefundResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// module
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainApplyRefundResponseBodyModule Module { get; set; }
        public class TrainApplyRefundResponseBodyModule : TeaModel {
            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

        }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// traceId
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
