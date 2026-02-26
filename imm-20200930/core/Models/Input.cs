// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Input : TeaModel {
        /// <summary>
        /// <para>The input data source from Object Storage Service (OSS).</para>
        /// </summary>
        [NameInMap("OSS")]
        [Validation(Required=false)]
        public InputOSS OSS { get; set; }

    }

}
