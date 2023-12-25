// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeOSSStorageResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether tiered storage of hot data and cold data is supported. Valid values:
        /// 
        /// *   **true**: Tiered storage of hot data and cold data is supported.
        /// *   **false**: Tiered storage of hot data and cold data is not supported.
        /// </summary>
        [NameInMap("ColdStorage")]
        [Validation(Required=false)]
        public bool? ColdStorage { get; set; }

        /// <summary>
        /// The parameters for tiered storage of hot data and cold data.
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The state of tiered storage of hot data and cold data. Valid values:
        /// 
        /// *   **CREATING**: Tiered storage of hot data and cold data is being enabled.
        /// *   **DISABLE**: Tiered storage of hot data and cold data is not enabled.
        /// *   **ENABLE**: Tiered storage of hot data and cold data is enabled.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The space used for tiered storage of hot data and cold data. Unit: GB.
        /// </summary>
        [NameInMap("StorageUsage")]
        [Validation(Required=false)]
        public string StorageUsage { get; set; }

    }

}
