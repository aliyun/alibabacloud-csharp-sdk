// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetResourceConfigurationTimelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceConfigurationTimeline")]
        [Validation(Required=false)]
        public GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline ResourceConfigurationTimeline { get; set; }
        public class GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
            [NameInMap("Limit")]
            [Validation(Required=false)]
            public int? Limit { get; set; }
            [NameInMap("ConfigurationList")]
            [Validation(Required=false)]
            public List<GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList> ConfigurationList { get; set; }
            public class GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList : TeaModel {
                public string Tags { get; set; }
                public long? AccountId { get; set; }
                public string ResourceEventType { get; set; }
                public string AvailabilityZone { get; set; }
                public string ResourceType { get; set; }
                public string ResourceCreateTime { get; set; }
                public string Region { get; set; }
                public string CaptureTime { get; set; }
                public string ConfigurationDiff { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
            }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

    }

}
