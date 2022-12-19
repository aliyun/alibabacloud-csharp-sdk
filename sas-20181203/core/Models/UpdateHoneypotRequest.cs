// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotRequest : TeaModel {
        [NameInMap("HoneypotId")]
        [Validation(Required=false)]
        public string HoneypotId { get; set; }

        [NameInMap("HoneypotName")]
        [Validation(Required=false)]
        public string HoneypotName { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

    }

}
