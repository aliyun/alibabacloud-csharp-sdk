// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class PublicUpdateTemplateInput : TeaModel {
        /// <summary>
        /// <para>The build configuration.</para>
        /// </summary>
        [NameInMap("buildConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateBuildConfig BuildConfig { get; set; }

        /// <summary>
        /// <para>The runtime configuration.</para>
        /// </summary>
        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRuntimeConfig RuntimeConfig { get; set; }

    }

}
