// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AkSkIdentityConfig : TeaModel {
        [NameInMap("ak")]
        [Validation(Required=false)]
        public string Ak { get; set; }

        [NameInMap("generateMode")]
        [Validation(Required=false)]
        public string GenerateMode { get; set; }

        [NameInMap("sk")]
        [Validation(Required=false)]
        public string Sk { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
