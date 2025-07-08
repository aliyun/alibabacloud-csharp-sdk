// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysms20170620.Models
{
    public class CheckSmsSignNewResponseBody : TeaModel {
        [NameInMap("Common")]
        [Validation(Required=false)]
        public bool? Common { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Verification")]
        [Validation(Required=false)]
        public bool? Verification { get; set; }

    }

}
