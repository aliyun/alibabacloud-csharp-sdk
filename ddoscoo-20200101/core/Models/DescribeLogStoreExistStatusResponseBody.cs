// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeLogStoreExistStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether a Logstore is created for Anti-DDoS Pro or Anti-DDoS Premium. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("ExistStatus")]
        [Validation(Required=false)]
        public bool? ExistStatus { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
