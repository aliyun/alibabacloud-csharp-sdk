// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHostGroupElasticStrategyParametersResponseBody : TeaModel {
        /// <summary>
        /// The CPU utilization of the instance. Unit: percentage.
        /// </summary>
        [NameInMap("CpuShar")]
        [Validation(Required=false)]
        public int? CpuShar { get; set; }

        /// <summary>
        /// The number of CPU cores used by the instance. Unit: cores.
        /// </summary>
        [NameInMap("CpuZoom")]
        [Validation(Required=false)]
        public int? CpuZoom { get; set; }

        /// <summary>
        /// The number of I/O requests.
        /// </summary>
        [NameInMap("IopsZoom")]
        [Validation(Required=false)]
        public int? IopsZoom { get; set; }

        /// <summary>
        /// The maximum number of concurrent connections supported by the instance type.
        /// </summary>
        [NameInMap("MaxConnZoom")]
        [Validation(Required=false)]
        public int? MaxConnZoom { get; set; }

        /// <summary>
        /// The total memory size of the instance in the dedicated cluster. Unit: MB.
        /// </summary>
        [NameInMap("MemoryZoom")]
        [Validation(Required=false)]
        public int? MemoryZoom { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
