// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ApiKeyIdentityConfig : TeaModel {
        [NameInMap("apikey")]
        [Validation(Required=false)]
        public string Apikey { get; set; }

        [NameInMap("apikeySource")]
        [Validation(Required=false)]
        public ApiKeyIdentityConfigApikeySource ApikeySource { get; set; }
        public class ApiKeyIdentityConfigApikeySource : TeaModel {
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("generateMode")]
        [Validation(Required=false)]
        public string GenerateMode { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
