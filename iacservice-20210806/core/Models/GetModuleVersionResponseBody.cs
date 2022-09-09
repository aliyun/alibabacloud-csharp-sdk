// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetModuleVersionResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public GetModuleVersionResponseBodyVersion Version { get; set; }
        public class GetModuleVersionResponseBodyVersion : TeaModel {
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("moduleId")]
            [Validation(Required=false)]
            public string ModuleId { get; set; }

            [NameInMap("moduleVersion")]
            [Validation(Required=false)]
            public string ModuleVersion { get; set; }

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

            [NameInMap("terraformContext")]
            [Validation(Required=false)]
            public Dictionary<string, object> TerraformContext { get; set; }

            [NameInMap("versionStrategy")]
            [Validation(Required=false)]
            public string VersionStrategy { get; set; }

        }

    }

}
