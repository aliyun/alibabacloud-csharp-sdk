// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceComplianceTimelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceComplianceTimeline")]
        [Validation(Required=false)]
        public GetResourceComplianceTimelineResponseBodyResourceComplianceTimeline ResourceComplianceTimeline { get; set; }
        public class GetResourceComplianceTimelineResponseBodyResourceComplianceTimeline : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("ComplianceList")]
            [Validation(Required=false)]
            public List<GetResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList> ComplianceList { get; set; }
            public class GetResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList : TeaModel {
                public string Tags { get; set; }
                public string AccountId { get; set; }
                public string AvailabilityZone { get; set; }
                public string ResourceType { get; set; }
                public long? ResourceCreateTime { get; set; }
                public string Region { get; set; }
                public string Configuration { get; set; }
                public long? CaptureTime { get; set; }
                public string ConfigurationDiff { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string ResourceStatus { get; set; }
            }
        };

    }

}
