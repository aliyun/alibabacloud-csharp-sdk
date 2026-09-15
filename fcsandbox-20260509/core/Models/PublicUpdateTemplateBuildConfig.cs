// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicUpdateTemplateBuildConfig : TeaModel {
        /// <summary>
        /// <para>The image copy action configuration.</para>
        /// </summary>
        [NameInMap("copy")]
        [Validation(Required=false)]
        public PublicUpdateTemplateCopyAction Copy { get; set; }

        /// <summary>
        /// <para>The envd injection action configuration.</para>
        /// </summary>
        [NameInMap("envdInject")]
        [Validation(Required=false)]
        public PublicUpdateTemplateEnvdInjectAction EnvdInject { get; set; }

    }

}
