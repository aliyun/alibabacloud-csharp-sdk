// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateAuditCallbackRequest : TeaModel {
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        [NameInMap("CryptType")]
        [Validation(Required=false)]
        public int? CryptType { get; set; }

        [NameInMap("Seed")]
        [Validation(Required=false)]
        public string Seed { get; set; }

    }

}
