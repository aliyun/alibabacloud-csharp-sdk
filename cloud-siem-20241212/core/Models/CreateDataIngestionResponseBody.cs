// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class CreateDataIngestionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>di-yxtm3l2rwa7fr5uvxtc7。</para>
        /// </summary>
        [NameInMap("DataIngestionId")]
        [Validation(Required=false)]
        public string DataIngestionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
