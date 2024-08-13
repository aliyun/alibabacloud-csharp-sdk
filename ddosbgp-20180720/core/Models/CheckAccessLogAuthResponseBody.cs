// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class CheckAccessLogAuthResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether Anti-DDoS Origin was authorized to access Simple Log Service. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("AccessLogAuth")]
        [Validation(Required=false)]
        public bool? AccessLogAuth { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
