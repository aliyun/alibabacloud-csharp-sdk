// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAgentDownloadUrlResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ArmsAgentDownloadUrl")]
        [Validation(Required=false)]
        public string ArmsAgentDownloadUrl { get; set; }

        /// <summary>
        /// Obtains the download URL of the Application Real-Time Monitoring Service (ARMS) agent.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
