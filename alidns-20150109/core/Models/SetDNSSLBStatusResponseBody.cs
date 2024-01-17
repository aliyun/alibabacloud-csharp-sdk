// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SetDNSSLBStatusResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether weighted round-robin is enabled for the subdomain name.
        /// </summary>
        [NameInMap("Open")]
        [Validation(Required=false)]
        public bool? Open { get; set; }

        /// <summary>
        /// The number of A records that are matched.
        /// </summary>
        [NameInMap("RecordCount")]
        [Validation(Required=false)]
        public long? RecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
