// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateInput : TeaModel {
        [NameInMap("buildConfig")]
        [Validation(Required=false)]
        public CreateTemplateBuildConfig BuildConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>python-data-analysis</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("runtimeConfig")]
        [Validation(Required=false)]
        public CreateTemplateRuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5f4a2c18-****</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

    }

}
