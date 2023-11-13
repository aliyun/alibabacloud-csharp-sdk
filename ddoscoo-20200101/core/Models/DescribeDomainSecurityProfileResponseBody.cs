// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainSecurityProfileResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The returned results.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeDomainSecurityProfileResponseBodyResult> Result { get; set; }
        public class DescribeDomainSecurityProfileResponseBodyResult : TeaModel {
            /// <summary>
            /// Indicates whether the global mitigation policy is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("GlobalEnable")]
            [Validation(Required=false)]
            public bool? GlobalEnable { get; set; }

            /// <summary>
            /// The mode of the global mitigation policy. Valid values:
            /// 
            /// *   **weak**: the Low mode
            /// *   **default**: the Normal mode
            /// *   **hard**: the Strict mode
            /// </summary>
            [NameInMap("GlobalMode")]
            [Validation(Required=false)]
            public string GlobalMode { get; set; }

        }

    }

}
