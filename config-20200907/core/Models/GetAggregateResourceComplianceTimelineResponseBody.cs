// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateResourceComplianceTimelineResponseBody : TeaModel {
        /// <summary>
        /// The type of the resource.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timestamp when the resource was created. Unit: milliseconds.
        /// </summary>
        [NameInMap("ResourceComplianceTimeline")]
        [Validation(Required=false)]
        public GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimeline ResourceComplianceTimeline { get; set; }
        public class GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimeline : TeaModel {
            /// <summary>
            /// The timestamp when the compliance evaluation was recorded. Unit: milliseconds.
            /// </summary>
            [NameInMap("ComplianceList")]
            [Validation(Required=false)]
            public List<GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList> ComplianceList { get; set; }
            public class GetAggregateResourceComplianceTimelineResponseBodyResourceComplianceTimelineComplianceList : TeaModel {
                /// <summary>
                /// The ID of the resource.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The name of the resource.
                /// </summary>
                [NameInMap("AvailabilityZone")]
                [Validation(Required=false)]
                public string AvailabilityZone { get; set; }

                [NameInMap("CaptureTime")]
                [Validation(Required=false)]
                public long? CaptureTime { get; set; }

                [NameInMap("Configuration")]
                [Validation(Required=false)]
                public string Configuration { get; set; }

                [NameInMap("ConfigurationDiff")]
                [Validation(Required=false)]
                public string ConfigurationDiff { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ResourceCreateTime")]
                [Validation(Required=false)]
                public long? ResourceCreateTime { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                /// <summary>
                /// The status of the resource. The parameter value varies based on the resource type and may be left empty. Examples:
                /// 
                /// *   If the ResourceType parameter is set to ACS::ECS::Instance, the resource is an Elastic Compute Service (ECS) instance that has a specific state. In this case, the valid values of this parameter are Running and Stopped.
                /// *   If the ResourceType parameter is set to ACS::OSS::Bucket, the resource is an OSS bucket that does not have a specific state. In this case, this parameter is left empty.
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The details of the resource change that triggered the compliance evaluation.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

            }

            /// <summary>
            /// The information about the rules that evaluated the resource and the compliance evaluation result.
            /// </summary>
            [NameInMap("MaxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// The ID of the region in which the resource resides.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

    }

}
