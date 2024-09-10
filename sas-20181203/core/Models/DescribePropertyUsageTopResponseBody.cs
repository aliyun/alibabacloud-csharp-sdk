// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyUsageTopResponseBody : TeaModel {
        /// <summary>
        /// The number of fingerprints.
        /// </summary>
        [NameInMap("ItemCount")]
        [Validation(Required=false)]
        public int? ItemCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The statistical results.
        /// </summary>
        [NameInMap("TopStatisticItems")]
        [Validation(Required=false)]
        public List<DescribePropertyUsageTopResponseBodyTopStatisticItems> TopStatisticItems { get; set; }
        public class DescribePropertyUsageTopResponseBodyTopStatisticItems : TeaModel {
            /// <summary>
            /// The quantity.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The statistical item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// The type of the asset fingerprint. Valid value:
        /// 
        /// *   **port**: port
        /// *   **process**: process
        /// *   **software**: software
        /// *   **user**: account
        /// *   **sca**: middleware
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
