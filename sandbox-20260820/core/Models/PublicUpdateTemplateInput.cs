// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateInput : TeaModel {
        [NameInMap("buildConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateBuildConfig BuildConfig { get; set; }

        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRuntimeConfig RuntimeConfig { get; set; }

    }

}
