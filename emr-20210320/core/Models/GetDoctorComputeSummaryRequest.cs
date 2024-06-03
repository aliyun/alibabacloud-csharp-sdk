// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorComputeSummaryRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The resource information, which is used to filter the results.
        /// </summary>
        [NameInMap("ComponentInfo")]
        [Validation(Required=false)]
        public GetDoctorComputeSummaryRequestComponentInfo ComponentInfo { get; set; }
        public class GetDoctorComputeSummaryRequestComponentInfo : TeaModel {
            /// <summary>
            /// Set the filter condition name based on the value of ComponentType. For example, if you set ComponentType to queue, you can specify a specific queue name to obtain the resource usage of a specific queue.
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// The resource type for filtering. Valid values:
            /// 
            /// *   engine: filters results by engine.
            /// *   queue: filters results by queue.
            /// *   cluster: displays the results at the cluster level.
            /// 
            /// If you do not specify this parameter, the information at the cluster level is displayed by default.
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public string ComponentType { get; set; }

        }

        /// <summary>
        /// Specify the date in the ISO 8601 standard. For example, 2023-01-01 represents January 1, 2023.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DateTime")]
        [Validation(Required=false)]
        public string DateTime { get; set; }

        /// <summary>
        /// The region ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
