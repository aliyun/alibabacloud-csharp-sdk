// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeScalingActivitiesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("ScalingActivities")]
        [Validation(Required=false)]
        public DescribeScalingActivitiesResponseBodyScalingActivities ScalingActivities { get; set; }
        public class DescribeScalingActivitiesResponseBodyScalingActivities : TeaModel {
            [NameInMap("ScalingActivity")]
            [Validation(Required=false)]
            public List<DescribeScalingActivitiesResponseBodyScalingActivitiesScalingActivity> ScalingActivity { get; set; }
            public class DescribeScalingActivitiesResponseBodyScalingActivitiesScalingActivity : TeaModel {
                public int? Progress { get; set; }
                public int? ScalingInstanceNumber { get; set; }
                public string AttachedCapacity { get; set; }
                public string TotalCapacity { get; set; }
                public string ScalingGroupId { get; set; }
                public string AutoCreatedCapacity { get; set; }
                public string EndTime { get; set; }
                public string StartTime { get; set; }
                public string Description { get; set; }
                public string StatusCode { get; set; }
                public string Cause { get; set; }
                public string ScalingActivityId { get; set; }
                public string StatusMessage { get; set; }
            }
        };

    }

}
