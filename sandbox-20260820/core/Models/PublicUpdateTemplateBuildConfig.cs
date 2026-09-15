// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateBuildConfig : TeaModel {
        [NameInMap("copy")]
        [Validation(Required=false)]
        public PublicUpdateTemplateCopyAction Copy { get; set; }

        [NameInMap("envdInject")]
        [Validation(Required=false)]
        public PublicUpdateTemplateEnvdInjectAction EnvdInject { get; set; }

    }

}
