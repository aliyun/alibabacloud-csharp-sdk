// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class TlsCipherSuitesConfig : TeaModel {
        [NameInMap("configType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("tlsCipherSuite")]
        [Validation(Required=false)]
        public List<TlsCipherSuitesConfigTlsCipherSuite> TlsCipherSuite { get; set; }
        public class TlsCipherSuitesConfigTlsCipherSuite : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("supportVersions")]
            [Validation(Required=false)]
            public List<string> SupportVersions { get; set; }

        }

    }

}
