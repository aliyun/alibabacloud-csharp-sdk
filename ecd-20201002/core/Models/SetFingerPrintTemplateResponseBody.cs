// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class SetFingerPrintTemplateResponseBody : TeaModel {
        [NameInMap("EncryptedPassword")]
        [Validation(Required=false)]
        public string EncryptedPassword { get; set; }

        [NameInMap("Index")]
        [Validation(Required=false)]
        public int? Index { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
