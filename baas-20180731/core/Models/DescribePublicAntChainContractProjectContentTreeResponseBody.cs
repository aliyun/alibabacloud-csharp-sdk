// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribePublicAntChainContractProjectContentTreeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePublicAntChainContractProjectContentTreeResponseBodyResult Result { get; set; }
        public class DescribePublicAntChainContractProjectContentTreeResponseBodyResult : TeaModel {
            [NameInMap("Children")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Children { get; set; }

        }

    }

}
