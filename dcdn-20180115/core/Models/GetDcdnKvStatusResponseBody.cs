// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class GetDcdnKvStatusResponseBody : TeaModel {
        /// <summary>
        /// Specifies whether the configured key has taken effect on all points of presence (POPs).
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Complete")]
        [Validation(Required=false)]
        public bool? Complete { get; set; }

        /// <summary>
        /// The timeout period of the configured key. The value is an absolute timestamp, such as 2023-09-11T15:39:44+08:00. This parameter is not returned if the key is permanently stored.
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public string Expire { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
