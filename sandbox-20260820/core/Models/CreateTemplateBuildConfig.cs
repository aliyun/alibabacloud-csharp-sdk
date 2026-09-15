// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateBuildConfig : TeaModel {
        [NameInMap("copy")]
        [Validation(Required=false)]
        public CreateTemplateCopyAction Copy { get; set; }

        [NameInMap("envdInject")]
        [Validation(Required=false)]
        public CreateTemplateEnvdInjectAction EnvdInject { get; set; }

    }

}
