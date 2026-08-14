// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainSecurityProfileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeDomainSecurityProfileResponseBodyResult> Result { get; set; }
        public class DescribeDomainSecurityProfileResponseBodyResult : TeaModel {
            [NameInMap("GlobalEnable")]
            [Validation(Required=false)]
            public bool? GlobalEnable { get; set; }

            [NameInMap("GlobalMode")]
            [Validation(Required=false)]
            public string GlobalMode { get; set; }

        }

    }

}
