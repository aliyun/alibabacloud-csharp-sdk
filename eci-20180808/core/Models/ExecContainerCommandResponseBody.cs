// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class ExecContainerCommandResponseBody : TeaModel {
        /// <summary>
        /// The HTTP URL. You can use this URL to enter the container within 30 seconds after this operation is called. For more information, see [Use and integrate the Elastic Container Instance terminal](~~202846~~).
        /// </summary>
        [NameInMap("HttpUrl")]
        [Validation(Required=false)]
        public string HttpUrl { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The output of the command. This parameter is returned only if Sync is set to true.
        /// </summary>
        [NameInMap("SyncResponse")]
        [Validation(Required=false)]
        public string SyncResponse { get; set; }

        /// <summary>
        /// The WebSocket URL. You can use this URL to establish a WebSocket connection with the container.
        /// </summary>
        [NameInMap("WebSocketUri")]
        [Validation(Required=false)]
        public string WebSocketUri { get; set; }

    }

}
