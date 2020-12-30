// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class TransferInCheckMailTokenResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessList")]
        [Validation(Required=false)]
        public TransferInCheckMailTokenResponseBodySuccessList SuccessList { get; set; }
        public class TransferInCheckMailTokenResponseBodySuccessList : TeaModel {
            [NameInMap("SuccessDomain")]
            [Validation(Required=false)]
            public List<string> SuccessDomain { get; set; }
        };

        [NameInMap("FailList")]
        [Validation(Required=false)]
        public TransferInCheckMailTokenResponseBodyFailList FailList { get; set; }
        public class TransferInCheckMailTokenResponseBodyFailList : TeaModel {
            [NameInMap("FailDomain")]
            [Validation(Required=false)]
            public List<string> FailDomain { get; set; }
        };

    }

}
