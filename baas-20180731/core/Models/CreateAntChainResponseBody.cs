// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateAntChainResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateAntChainResponseBodyResult Result { get; set; }
        public class CreateAntChainResponseBodyResult : TeaModel {
            [NameInMap("AntChainId")]
            [Validation(Required=false)]
            public string AntChainId { get; set; }

        }

    }

}
