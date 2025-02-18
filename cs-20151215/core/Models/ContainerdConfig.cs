// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ContainerdConfig : TeaModel {
        [NameInMap("insecureRegistries")]
        [Validation(Required=false)]
        public List<string> InsecureRegistries { get; set; }

        [NameInMap("registryMirrors")]
        [Validation(Required=false)]
        public List<string> RegistryMirrors { get; set; }

    }

}
