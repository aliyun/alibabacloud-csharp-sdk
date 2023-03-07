// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCloudMetricProfilingsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries that are returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The profiling information of a specified cluster.
        /// </summary>
        [NameInMap("Profilings")]
        [Validation(Required=false)]
        public ListCloudMetricProfilingsResponseBodyProfilings Profilings { get; set; }
        public class ListCloudMetricProfilingsResponseBodyProfilings : TeaModel {
            [NameInMap("ProfilingInfo")]
            [Validation(Required=false)]
            public List<ListCloudMetricProfilingsResponseBodyProfilingsProfilingInfo> ProfilingInfo { get; set; }
            public class ListCloudMetricProfilingsResponseBodyProfilingsProfilingInfo : TeaModel {
                /// <summary>
                /// The duration of the profiling process. Unit: seconds
                /// 
                /// Valid values: 10 to 300
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                /// <summary>
                /// The frequency of the profiling process. Unit: Hz
                /// 
                /// Valid values: 1 to 2000
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
                /// The ID of the node.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the profiling process.
                /// </summary>
                [NameInMap("Pid")]
                [Validation(Required=false)]
                public int? Pid { get; set; }

                /// <summary>
                /// The ID of the profiling process.
                /// </summary>
                [NameInMap("ProfilingId")]
                [Validation(Required=false)]
                public string ProfilingId { get; set; }

                /// <summary>
                /// The time when the profiling process is triggered.
                /// </summary>
                [NameInMap("TriggerTime")]
                [Validation(Required=false)]
                public string TriggerTime { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
