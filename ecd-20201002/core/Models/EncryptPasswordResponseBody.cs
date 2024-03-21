// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class EncryptPasswordResponseBody : TeaModel {
        [NameInMap("EncryptedPassword")]
        [Validation(Required=false)]
        public string EncryptedPassword { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
