// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class CreateTemplateInput : TeaModel {
        /// <summary>
        /// <para>The template build configuration.</para>
        /// </summary>
        [NameInMap("buildConfig")]
        [Validation(Required=false)]
        public CreateTemplateBuildConfig BuildConfig { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-template</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The template runtime configuration.</para>
        /// </summary>
        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public CreateTemplateRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// <para>The unique identifier of the team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70d1c834-0383-58d8-97ac-5336eb91abcd</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
