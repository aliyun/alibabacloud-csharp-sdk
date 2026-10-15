// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateRegistryCertConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to skip repository certificate verification.</para>
        /// </summary>
        [NameInMap("insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

    }

}
