// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CheckJDBCSourceNetConnectionResponseBody : TeaModel {
        /// <summary>
        /// The returned message. If the connection failed, an error message is returned. Otherwise, a pair of double quotation marks ("") is returned.
        /// </summary>
        [NameInMap("ConnectionMessage")]
        [Validation(Required=false)]
        public string ConnectionMessage { get; set; }

        /// <summary>
        /// The connection status. Valid values:
        /// 
        /// *   Success
        /// *   Failed
        /// </summary>
        [NameInMap("ConnectionStatus")]
        [Validation(Required=false)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
