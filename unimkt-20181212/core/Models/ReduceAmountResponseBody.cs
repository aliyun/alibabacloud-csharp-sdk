// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class ReduceAmountResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ReduceAmountResponseBodyData Data { get; set; }
        public class ReduceAmountResponseBodyData : TeaModel {
            [NameInMap("ChargeDetail")]
            [Validation(Required=false)]
            public string ChargeDetail { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
