// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetResourceConfigurationTimelineResponseBody : TeaModel {
        /// <summary>
        /// The configuration changes on the configuration timeline.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tags of the resource.
        /// </summary>
        [NameInMap("ResourceConfigurationTimeline")]
        [Validation(Required=false)]
        public GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline ResourceConfigurationTimeline { get; set; }
        public class GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimeline : TeaModel {
            /// <summary>
            /// The ID of the zone.
            /// </summary>
            [NameInMap("ConfigurationList")]
            [Validation(Required=false)]
            public List<GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList> ConfigurationList { get; set; }
            public class GetResourceConfigurationTimelineResponseBodyResourceConfigurationTimelineConfigurationList : TeaModel {
                /// <summary>
                /// The timestamp when the resource was created. Unit: milliseconds.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public long? AccountId { get; set; }

                /// <summary>
                /// The timestamp when the resource change snapshot was recorded. Unit: milliseconds.
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                /// <summary>
                /// The details of each resource that is associated with the current resource, including the region ID, resource relationship, resource ID, and resource type.
                /// </summary>
                [NameInMap("CaptureTime")]
                [Validation(Required=false)]
                public string CaptureTime { get; set; }

                /// <summary>
                /// The change records of the resource relationship.
                /// </summary>
                [NameInMap("ConfigurationDiff")]
                [Validation(Required=false)]
                public string ConfigurationDiff { get; set; }

                /// <summary>
                /// The name of the resource.
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Relationship")]
                [Validation(Required=false)]
                public string Relationship { get; set; }

                [NameInMap("RelationshipDiff")]
                [Validation(Required=false)]
                public string RelationshipDiff { get; set; }

                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("ResourceCreateTime")]
                [Validation(Required=false)]
                public string ResourceCreateTime { get; set; }

                /// <summary>
                /// The ID of the region in which the resource resides.
                /// </summary>
                [NameInMap("ResourceEventType")]
                [Validation(Required=false)]
                public string ResourceEventType { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// The details of the resource change that triggered the compliance evaluation.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The type of the resource.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// The type of the resource change event involved. Valid values:
            /// 
            /// *   DISCOVERED: A resource is created.
            /// *   DISCOVERED_REVISED: A resource is created by periodic remediation tasks.
            /// *   MODIFY: A resource is modified.
            /// *   MODIFY_REVISED: A resource is modified by periodic remediation tasks.
            /// *   REMOVE: A resource is deleted.
            /// 
            /// > 
            /// *   To ensure the integrity of resources, periodic remediation tasks are executed to check data and generate events that indicate the creation of new resources. Such events are infrequent.
            /// *   The time when a resource change event is generated by a periodic remediation task is considered as the detection time of Cloud Config. The detection time is later than the time when the resource is modified.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the resource belongs.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
