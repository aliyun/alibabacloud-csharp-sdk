// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeInstanceRefreshesResponseBody : TeaModel {
        [NameInMap("InstanceRefreshTasks")]
        [Validation(Required=false)]
        public List<DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks> InstanceRefreshTasks { get; set; }
        public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasks : TeaModel {
            [NameInMap("DesiredConfiguration")]
            [Validation(Required=false)]
            public DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration DesiredConfiguration { get; set; }
            public class DescribeInstanceRefreshesResponseBodyInstanceRefreshTasksDesiredConfiguration : TeaModel {
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("ScalingConfigurationId")]
                [Validation(Required=false)]
                public string ScalingConfigurationId { get; set; }

            }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("FinishedUpdateCapacity")]
            [Validation(Required=false)]
            public int? FinishedUpdateCapacity { get; set; }

            [NameInMap("InstanceRefreshTaskId")]
            [Validation(Required=false)]
            public string InstanceRefreshTaskId { get; set; }

            [NameInMap("MaxHealthyPercentage")]
            [Validation(Required=false)]
            public int? MaxHealthyPercentage { get; set; }

            [NameInMap("MinHealthyPercentage")]
            [Validation(Required=false)]
            public int? MinHealthyPercentage { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TotalNeedUpdateCapacity")]
            [Validation(Required=false)]
            public int? TotalNeedUpdateCapacity { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
