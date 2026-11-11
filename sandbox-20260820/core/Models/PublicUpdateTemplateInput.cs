// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateInput : TeaModel {
        /// <summary>
        /// <para>The build configuration.</para>
        /// </summary>
        [NameInMap("buildConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateBuildConfig BuildConfig { get; set; }

        /// <summary>
        /// <para>The subscription plan for the team. Valid values: eco, std, and pro.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pro</para>
        /// </summary>
        [NameInMap("plan")]
        [Validation(Required=false)]
        public string Plan { get; set; }

        /// <summary>
        /// <para>The runtime configuration.</para>
        /// </summary>
        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRuntimeConfig RuntimeConfig { get; set; }

    }

}
