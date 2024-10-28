// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RegistryCertConfig : TeaModel {
        [NameInMap("insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

        [NameInMap("rootCaCertBase64")]
        [Validation(Required=false)]
        public string RootCaCertBase64 { get; set; }

    }

}
