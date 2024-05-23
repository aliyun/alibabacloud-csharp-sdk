// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20160722.Models
{
    public class DescribeScalingActivitiesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingActivities")]
        [Validation(Required=false)]
        public DescribeScalingActivitiesResponseBodyScalingActivities ScalingActivities { get; set; }
        public class DescribeScalingActivitiesResponseBodyScalingActivities : TeaModel {
            [NameInMap("ScalingActivity")]
            [Validation(Required=false)]
            public List<DescribeScalingActivitiesResponseBodyScalingActivitiesScalingActivity> ScalingActivity { get; set; }
            public class DescribeScalingActivitiesResponseBodyScalingActivitiesScalingActivity : TeaModel {
                [NameInMap("AttachedCapacity")]
                [Validation(Required=false)]
                public string AttachedCapacity { get; set; }

                [NameInMap("AutoCreatedCapacity")]
                [Validation(Required=false)]
                public string AutoCreatedCapacity { get; set; }

                [NameInMap("Cause")]
                [Validation(Required=false)]
                public string Cause { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("Progress")]
                [Validation(Required=false)]
                public int? Progress { get; set; }

                [NameInMap("ScalingActivityId")]
                [Validation(Required=false)]
                public string ScalingActivityId { get; set; }

                [NameInMap("ScalingGroupId")]
                [Validation(Required=false)]
                public string ScalingGroupId { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("StatusCode")]
                [Validation(Required=false)]
                public string StatusCode { get; set; }

                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                [NameInMap("TotalCapacity")]
                [Validation(Required=false)]
                public string TotalCapacity { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
