// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class RunCloudMetricProfilingRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The duration of the profiling process. Unit: seconds.
        /// 
        /// Value values: 10 to 300
        /// 
        /// Default value: 30
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The sampling frequency. Unit: Hz
        /// 
        /// Valid values: 1 to 2000
        /// 
        /// Default value: 2000
        /// </summary>
        [NameInMap("Freq")]
        [Validation(Required=false)]
        public int? Freq { get; set; }

        /// <summary>
        /// The name of the host.
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// The ID of the profiling process.
        /// </summary>
        [NameInMap("ProcessId")]
        [Validation(Required=false)]
        public int? ProcessId { get; set; }

        /// <summary>
        /// The ID of the region where the cluster resides.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
