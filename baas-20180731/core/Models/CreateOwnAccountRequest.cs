// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class CreateOwnAccountRequest : TeaModel {
        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        [NameInMap("Identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("PublicKey")]
        [Validation(Required=false)]
        public string PublicKey { get; set; }

        [NameInMap("RecoveryKey")]
        [Validation(Required=false)]
        public string RecoveryKey { get; set; }

    }

}
