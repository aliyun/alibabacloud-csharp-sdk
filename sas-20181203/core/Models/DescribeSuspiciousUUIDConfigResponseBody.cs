// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSuspiciousUUIDConfigResponseBody : TeaModel {
        /// <summary>
        /// The total number of servers on which proactive defense of the specified type takes effect.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The UUIDs of servers on which proactive defense of the specified type takes effect.
        /// </summary>
        [NameInMap("UUIDList")]
        [Validation(Required=false)]
        public List<string> UUIDList { get; set; }

    }

}
