/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class BatchCheckSessionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<BatchCheckSessionRequestRecords> Records { get; set; }
        public class BatchCheckSessionRequestRecords : TeaModel {
            [NameInMap("CustomSessionId")]
            [Validation(Required=false)]
            public string CustomSessionId { get; set; }

            [NameInMap("PlatformSessionId")]
            [Validation(Required=false)]
            public string PlatformSessionId { get; set; }

            [NameInMap("ReferenceInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ReferenceInfo { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
