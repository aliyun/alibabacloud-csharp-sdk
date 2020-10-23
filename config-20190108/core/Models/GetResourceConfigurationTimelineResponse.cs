// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20190108.Models
{
    public class GetResourceConfigurationTimelineResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceConfigurationTimeline")]
        [Validation(Required=true)]
        public GetResourceConfigurationTimelineResponseResourceConfigurationTimeline ResourceConfigurationTimeline { get; set; }
        public class GetResourceConfigurationTimelineResponseResourceConfigurationTimeline : TeaModel {
            [NameInMap("NextToken")]
            [Validation(Required=true)]
            public string NextToken { get; set; }
            [NameInMap("Limit")]
            [Validation(Required=true)]
            public int? Limit { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public long TotalCount { get; set; }
            [NameInMap("ConfigurationList")]
            [Validation(Required=true)]
            public List<GetResourceConfigurationTimelineResponseResourceConfigurationTimelineConfigurationList> ConfigurationList { get; set; }
            public class GetResourceConfigurationTimelineResponseResourceConfigurationTimelineConfigurationList : TeaModel {
                public long AccountId { get; set; }
                public string AvailabilityZone { get; set; }
                public string CaptureTime { get; set; }
                public string ConfigurationDiff { get; set; }
                public string Region { get; set; }
                public string Relationship { get; set; }
                public string RelationshipDiff { get; set; }
                public string ResourceCreateTime { get; set; }
                public string ResourceId { get; set; }
                public string ResourceName { get; set; }
                public string ResourceType { get; set; }
                public string Tags { get; set; }
            }
        };

    }

}
