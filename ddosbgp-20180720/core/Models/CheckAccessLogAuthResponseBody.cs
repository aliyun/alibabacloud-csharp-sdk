// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class CheckAccessLogAuthResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether Anti-DDoS Origin was authorized to access Log Service. Valid values:
        /// 
        /// *   **true**: Anti-DDoS Origin was authorized.
        /// *   **false**: Anti-DDoS Origin was not authorized.
        /// </summary>
        [NameInMap("AccessLogAuth")]
        [Validation(Required=false)]
        public bool? AccessLogAuth { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
