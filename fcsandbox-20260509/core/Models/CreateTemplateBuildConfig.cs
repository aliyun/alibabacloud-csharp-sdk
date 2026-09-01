// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateTemplateBuildConfig : TeaModel {
        /// <summary>
        /// <para>The image copy build action.</para>
        /// </summary>
        [NameInMap("copy")]
        [Validation(Required=false)]
        public CreateTemplateCopyAction Copy { get; set; }

        /// <summary>
        /// <para>The envd injection build action.</para>
        /// </summary>
        [NameInMap("envdInject")]
        [Validation(Required=false)]
        public CreateTemplateEnvdInjectAction EnvdInject { get; set; }

    }

}
