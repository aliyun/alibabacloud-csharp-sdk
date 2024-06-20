// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeAntChainTransactionStatisticsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeAntChainTransactionStatisticsResponseBodyResult> Result { get; set; }
        public class DescribeAntChainTransactionStatisticsResponseBodyResult : TeaModel {
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

            [NameInMap("CreatTime")]
            [Validation(Required=false)]
            public long? CreatTime { get; set; }

            [NameInMap("Dt")]
            [Validation(Required=false)]
            public string Dt { get; set; }

            [NameInMap("LastSumBlockHeight")]
            [Validation(Required=false)]
            public long? LastSumBlockHeight { get; set; }

            [NameInMap("TransCount")]
            [Validation(Required=false)]
            public long? TransCount { get; set; }

        }

    }

}
