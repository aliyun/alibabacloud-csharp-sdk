// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CloneModuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>mod-71012916a5a376f265ebc3774</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>78EC2EFB-AED9-5C23-AE98-6DDC6F2F96D6</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
