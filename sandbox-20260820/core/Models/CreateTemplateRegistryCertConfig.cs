// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateRegistryCertConfig : TeaModel {
        /// <summary>
        /// <para>Specifies whether to skip HTTPS certificate validation for the image repository. Enable this option only for private repositories that use self-signed certificates.</para>
        /// </summary>
        [NameInMap("insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

    }

}
