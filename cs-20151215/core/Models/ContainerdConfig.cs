// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class ContainerdConfig : TeaModel {
        [NameInMap("ignoreImageDefinedVolume")]
        [Validation(Required=false)]
        public bool? IgnoreImageDefinedVolume { get; set; }

        [NameInMap("insecureRegistries")]
        [Validation(Required=false)]
        public List<string> InsecureRegistries { get; set; }

        [NameInMap("limitCore")]
        [Validation(Required=false)]
        public long? LimitCore { get; set; }

        [NameInMap("limitMemLock")]
        [Validation(Required=false)]
        public long? LimitMemLock { get; set; }

        [NameInMap("limitNoFile")]
        [Validation(Required=false)]
        public long? LimitNoFile { get; set; }

        [NameInMap("maxConcurrentDownloads")]
        [Validation(Required=false)]
        public long? MaxConcurrentDownloads { get; set; }

        [NameInMap("registryMirrors")]
        [Validation(Required=false)]
        public List<string> RegistryMirrors { get; set; }

    }

}
