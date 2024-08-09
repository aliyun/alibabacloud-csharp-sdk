// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JarArtifact : TeaModel {
        [NameInMap("additionalDependencies")]
        [Validation(Required=false)]
        public List<string> AdditionalDependencies { get; set; }

        [NameInMap("entryClass")]
        [Validation(Required=false)]
        public string EntryClass { get; set; }

        [NameInMap("jarUri")]
        [Validation(Required=false)]
        public string JarUri { get; set; }

        [NameInMap("mainArgs")]
        [Validation(Required=false)]
        public string MainArgs { get; set; }

    }

}
