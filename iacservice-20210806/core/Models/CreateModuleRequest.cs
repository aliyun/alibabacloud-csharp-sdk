// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateModuleRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("sourcePath")]
        [Validation(Required=false)]
        public string SourcePath { get; set; }

        [NameInMap("statePath")]
        [Validation(Required=false)]
        public string StatePath { get; set; }

        [NameInMap("versionStrategy")]
        [Validation(Required=false)]
        public string VersionStrategy { get; set; }

    }

}
