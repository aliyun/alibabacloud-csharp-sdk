// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateEnvdInjectAction : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the envd injection action. This parameter is required when this action block is specified.</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
