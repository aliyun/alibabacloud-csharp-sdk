// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAgentDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// The download URL of the ARMS agent.
        /// </summary>
        [NameInMap("ArmsAgentDownloadUrl")]
        [Validation(Required=false)]
        public string ArmsAgentDownloadUrl { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
