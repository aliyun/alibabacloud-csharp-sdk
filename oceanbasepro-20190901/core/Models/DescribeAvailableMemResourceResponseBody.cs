// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableMemResourceResponseBody : TeaModel {
        /// <summary>
        /// The available memory size.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAvailableMemResourceResponseBodyData Data { get; set; }
        public class DescribeAvailableMemResourceResponseBodyData : TeaModel {
            /// <summary>
            /// The maximum memory size for each resource unit, in GB.
            /// </summary>
            [NameInMap("MaxMem")]
            [Validation(Required=false)]
            public long? MaxMem { get; set; }

            /// <summary>
            /// The minimum memory size required for each resource unit, in GB.
            /// </summary>
            [NameInMap("MinMem")]
            [Validation(Required=false)]
            public long? MinMem { get; set; }

            /// <summary>
            /// The maximum allowed memory usage, in GB.
            /// </summary>
            [NameInMap("SafeMem")]
            [Validation(Required=false)]
            public string SafeMem { get; set; }

            /// <summary>
            /// The number of resource units in the tenant.
            /// </summary>
            [NameInMap("UsedMem")]
            [Validation(Required=false)]
            public long? UsedMem { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
