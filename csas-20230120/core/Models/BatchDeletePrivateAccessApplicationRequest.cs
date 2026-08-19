// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class BatchDeletePrivateAccessApplicationRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of internal-facing access applications. You can specify up to 100 application IDs.</para>
        /// </summary>
        [NameInMap("ApplicationIds")]
        [Validation(Required=false)]
        public List<string> ApplicationIds { get; set; }

    }

}
