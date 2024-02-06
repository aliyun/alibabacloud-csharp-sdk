// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeApplicationResourceSummaryRequest : TeaModel {
        /// <summary>
        /// The region level. The value must be of the enumerated data type. Valid values:
        /// 
        /// *   **National** (default): Chinese mainland
        /// *   **Big**: area
        /// *   **Middle**: province
        /// *   **Small**: city
        /// *   **RegionId**: edge node
        /// </summary>
        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        /// <summary>
        /// The resource type.
        /// 
        /// Valid value:
        /// 
        /// *   Ens
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
