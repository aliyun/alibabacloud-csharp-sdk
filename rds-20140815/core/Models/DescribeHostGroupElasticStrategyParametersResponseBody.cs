// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHostGroupElasticStrategyParametersResponseBody : TeaModel {
        /// <summary>
        /// The current CPU usage rate of the instance.
        /// </summary>
        [NameInMap("CpuShar")]
        [Validation(Required=false)]
        public int? CpuShar { get; set; }

        /// <summary>
        /// The CPU usage of the instance.
        /// </summary>
        [NameInMap("CpuZoom")]
        [Validation(Required=false)]
        public int? CpuZoom { get; set; }

        /// <summary>
        /// Number of IO requests.
        /// </summary>
        [NameInMap("IopsZoom")]
        [Validation(Required=false)]
        public int? IopsZoom { get; set; }

        /// <summary>
        /// The maximum number of concurrent connections for instance specifications.
        /// </summary>
        [NameInMap("MaxConnZoom")]
        [Validation(Required=false)]
        public int? MaxConnZoom { get; set; }

        /// <summary>
        /// The total amount of memory for instances in the current exclusive cluster.
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
