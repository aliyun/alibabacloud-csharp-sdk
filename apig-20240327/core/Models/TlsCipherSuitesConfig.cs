// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class TlsCipherSuitesConfig : TeaModel {
        [NameInMap("cipherSuites")]
        [Validation(Required=false)]
        public List<TlsCipherSuitesConfigCipherSuites> CipherSuites { get; set; }
        public class TlsCipherSuitesConfigCipherSuites : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("supportVersions")]
            [Validation(Required=false)]
            public List<string> SupportVersions { get; set; }

        }

        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

    }

}
