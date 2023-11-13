// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeSlsLogstoreInfoResponseBody : TeaModel {
        /// <summary>
        /// The Logstore of the Anti-DDoS Pro or Anti-DDoS Premium instance.
        /// </summary>
        [NameInMap("LogStore")]
        [Validation(Required=false)]
        public string LogStore { get; set; }

        /// <summary>
        /// The Logstore project of the Anti-DDoS Pro or Anti-DDoS Premium instance.
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// The available log storage capacity. Unit: bytes.
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The log storage duration. Unit: days.
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

        /// <summary>
        /// The used log storage capacity. Unit: bytes.
        /// 
        /// > The statistics on Log Service are delayed for about two hours.
        /// </summary>
        [NameInMap("Used")]
        [Validation(Required=false)]
        public long? Used { get; set; }

    }

}
