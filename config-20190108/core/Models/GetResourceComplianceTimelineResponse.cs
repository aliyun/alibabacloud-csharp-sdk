// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetResourceComplianceTimelineResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceComplianceTimeline")]
        [Validation(Required=true)]
        public GetResourceComplianceTimelineResponseResourceComplianceTimeline ResourceComplianceTimeline { get; set; }
        public class GetResourceComplianceTimelineResponseResourceComplianceTimeline : TeaModel {
            [NameInMap("Limit")]
            [Validation(Required=true)]
            public int? Limit { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=true)]
            public string NextToken { get; set; }
            [NameInMap("ComplianceList")]
            [Validation(Required=true)]
            public List<GetResourceComplianceTimelineResponseResourceComplianceTimelineComplianceList> ComplianceList { get; set; }
            public class GetResourceComplianceTimelineResponseResourceComplianceTimelineComplianceList : TeaModel {
                public string AccountId { get; set; }
                public string AvailabilityZone { get; set; }
                public long CaptureTime { get; set; }
                public string Configuration { get; set; }
                public string ConfigurationDiff { get; set; }
                public string Region { get; set; }
                public long ResourceCreateTime { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string ResourceStatus { get; set; }
                public string ResourceType { get; set; }
                public string Tags { get; set; }
            }
        };

    }

}
