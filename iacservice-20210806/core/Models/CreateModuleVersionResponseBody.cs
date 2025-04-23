// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateModuleVersionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("moduleVersion")]
        [Validation(Required=false)]
        public string ModuleVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B6ED9F71-7FA8-598E-B64D-4606FB3FCCC9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
