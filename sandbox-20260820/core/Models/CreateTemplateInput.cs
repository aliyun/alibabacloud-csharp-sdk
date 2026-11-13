// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateInput : TeaModel {
        /// <summary>
        /// <para>The build configuration of the template. This configuration specifies the build process in action-based chunks. If this parameter is not specified, the service automatically derives the configuration based on the source image. Public runtime images are used directly without building. For other images, the copy and envdInject actions are automatically executed.</para>
        /// </summary>
        [NameInMap("buildConfig")]
        [Validation(Required=false)]
        public CreateTemplateBuildConfig BuildConfig { get; set; }

        /// <summary>
        /// <para>The name of the template. The name must be unique within the same team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python-data-analysis</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The resource tags.</para>
        /// </summary>
        [NameInMap("resourceTags")]
        [Validation(Required=false)]
        public List<CreateTemplateInputResourceTags> ResourceTags { get; set; }
        public class CreateTemplateInputResourceTags : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>project</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The runtime configuration of the template. This configuration determines the specifications and environment of the sandbox instances created from the template.</para>
        /// </summary>
        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public CreateTemplateRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// <para>The ID of the team to which the template belongs. The ID must be in UUID format. If this parameter is not specified, the default team of the current account is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The templatetype. Set this parameter to layer to build a layer template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>layer</para>
        /// </summary>
        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
