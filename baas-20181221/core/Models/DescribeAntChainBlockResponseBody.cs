// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainBlockResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeAntChainBlockResponseBodyResult Result { get; set; }
        public class DescribeAntChainBlockResponseBodyResult : TeaModel {
            [NameInMap("PreviousHash")]
            [Validation(Required=false)]
            public string PreviousHash { get; set; }
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }
            [NameInMap("TransactionSize")]
            [Validation(Required=false)]
            public int? TransactionSize { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("RootTxHash")]
            [Validation(Required=false)]
            public string RootTxHash { get; set; }
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }
            [NameInMap("BlockHash")]
            [Validation(Required=false)]
            public string BlockHash { get; set; }
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }
            [NameInMap("TransSummaryList")]
            [Validation(Required=false)]
            public string TransSummaryList { get; set; }
        };

    }

}
