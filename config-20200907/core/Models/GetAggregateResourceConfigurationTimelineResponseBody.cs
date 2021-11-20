// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceConfigurationTimelineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceConfigurationTimeline")]
        [Validation(Required=false)]
        public GetAggregateResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline ResourceConfigurationTimeline { get; set; }
        public class GetAggregateResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline : TeaModel {
            [NameInMap("ConfigurationList")]
            [Validation(Required=false)]
            public List<GetAggregateResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList> ConfigurationList { get; set; }
            public class GetAggregateResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList : TeaModel {
                public long? AccountId { get; set; }
                public string AvailabilityZone { get; set; }
                public string CaptureTime { get; set; }
                public string ConfigurationDiff { get; set; }
                public string Region { get; set; }
                public string ResourceCreateTime { get; set; }
                public string ResourceEventType { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string ResourceType { get; set; }
                public string Tags { get; set; }
            }
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }
        };

    }

}
