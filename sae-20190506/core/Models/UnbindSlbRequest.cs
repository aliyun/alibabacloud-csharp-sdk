// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class UnbindSlbRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("Internet")]
        [Validation(Required=false)]
        public bool? Internet { get; set; }

        [NameInMap("Intranet")]
        [Validation(Required=false)]
        public bool? Intranet { get; set; }

    }

}
