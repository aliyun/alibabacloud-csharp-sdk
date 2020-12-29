// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainTransactionReceiptResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainTransactionReceiptResponseBodyResult Result { get; set; }
        public class DescribeAntChainTransactionReceiptResponseBodyResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public string Data { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public long? Result { get; set; }
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<string> Logs { get; set; }
            [NameInMap("GasUsed")]
            [Validation(Required=false)]
            public string GasUsed { get; set; }
        };

    }

}
