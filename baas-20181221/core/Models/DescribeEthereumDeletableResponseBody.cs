// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeEthereumDeletableResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeEthereumDeletableResponseBodyResult Result { get; set; }
        public class DescribeEthereumDeletableResponseBodyResult : TeaModel {
            [NameInMap("Deletable")]
            [Validation(Required=false)]
            public bool? Deletable { get; set; }

            [NameInMap("EthereumId")]
            [Validation(Required=false)]
            public string EthereumId { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
