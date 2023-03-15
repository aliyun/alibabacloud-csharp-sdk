// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackDriftDetectionStatusRequest : TeaModel {
        /// <summary>
        /// The ID of the drift detection operation.
        /// 
        /// You can call the [ListStackResourceDrifts](~~155098~~) operation to obtain the ID of the drift detection operation.
        /// </summary>
        [NameInMap("DriftDetectionId")]
        [Validation(Required=false)]
        public string DriftDetectionId { get; set; }

        /// <summary>
        /// The region ID of the stack to be detected for drift.
        /// 
        /// You can call the [DescribeRegions](~~131035~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
