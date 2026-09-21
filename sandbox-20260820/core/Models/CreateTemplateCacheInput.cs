// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateCacheInput : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>13b721e6-8cc8-5df2-af13-80316f7508af</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>us7dxqaezw5uu7aa2cm5</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
