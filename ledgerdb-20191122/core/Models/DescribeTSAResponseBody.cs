// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ledgerdb20191122.Models
{
    public class DescribeTSAResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TSADetail")]
        [Validation(Required=false)]
        public DescribeTSAResponseBodyTSADetail TSADetail { get; set; }
        public class DescribeTSAResponseBodyTSADetail : TeaModel {
            [NameInMap("TS")]
            [Validation(Required=false)]
            public long? TS { get; set; }
            [NameInMap("SN")]
            [Validation(Required=false)]
            public string SN { get; set; }
            [NameInMap("RootHash")]
            [Validation(Required=false)]
            public string RootHash { get; set; }
            [NameInMap("BlockNumber")]
            [Validation(Required=false)]
            public long? BlockNumber { get; set; }
            [NameInMap("CTSR")]
            [Validation(Required=false)]
            public string CTSR { get; set; }
        };

    }

}
