// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeAvailableCpuResourceResponseBody : TeaModel {
        /// <summary>
        /// The CPU resources available.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAvailableCpuResourceResponseBodyData> Data { get; set; }
        public class DescribeAvailableCpuResourceResponseBodyData : TeaModel {
            /// <summary>
            /// The maximum number of CPU cores per resource unit.
            /// </summary>
            [NameInMap("MaxCpu")]
            [Validation(Required=false)]
            public long? MaxCpu { get; set; }

            /// <summary>
            /// The minimum number of CPU cores per resource unit.
            /// </summary>
            [NameInMap("MinCpu")]
            [Validation(Required=false)]
            public long? MinCpu { get; set; }

            /// <summary>
            /// The number of resource units in the tenant.
            /// </summary>
            [NameInMap("UnitNum")]
            [Validation(Required=false)]
            public long? UnitNum { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
