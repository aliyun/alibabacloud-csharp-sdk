// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class ListInstanceVncUrlResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The Virtual Network Computing (VNC) connection URL.
        /// </summary>
        [NameInMap("VncUrl")]
        [Validation(Required=false)]
        public string VncUrl { get; set; }

        /// <summary>
        /// The token that is used for WebRTC logon.
        /// </summary>
        [NameInMap("WebRtcToken")]
        [Validation(Required=false)]
        public string WebRtcToken { get; set; }

    }

}
