// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateInput : TeaModel {
        /// <summary>
        /// <para>The build configuration of the template. The build process is specified in blocks by action. If this parameter is not specified, the service automatically infers the configuration based on the source image: public runtime images are used directly without building, and other images automatically execute copy and envdInject.</para>
        /// </summary>
        [NameInMap("buildConfig")]
        [Validation(Required=false)]
        public CreateTemplateBuildConfig BuildConfig { get; set; }

        /// <summary>
        /// <para>The template name, which must be unique within the same team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python-data-analysis</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The runtime configuration of the template. This configuration determines the specifications and environment of sandbox instances created from this template.</para>
        /// </summary>
        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public CreateTemplateRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the template belongs, in UUID format. If this parameter is not specified, the default team of the current account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
