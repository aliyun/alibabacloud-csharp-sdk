// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ApplyCoordinationForMonitoringRequest : TeaModel {
        /// <summary>
        /// The coordination policy.
        /// 
        /// Set the value to FULL_CONTROL.
        /// 
        /// *   The value FULL_CONTROL specifies that the cloud desktop is shared and remote access to the cloud desktop is allowed.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CoordinatePolicyType")]
        [Validation(Required=false)]
        public string CoordinatePolicyType { get; set; }

        /// <summary>
        /// The ID of the end user who initiates the stream collaboration. If the initiator is the administrator, do not specify this parameter.
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        /// <summary>
        /// The type of the initiator.
        /// 
        /// Set the value to ADMIN_INITIATE.
        /// 
        /// *   The value ADMIN_INITIATE specifies that the administrator initiates the coordination request.
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("InitiatorType")]
        [Validation(Required=false)]
        public string InitiatorType { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](https://next.api.aliyun.com/document/ecd/2020-09-30/DescribeRegions) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of cloud desktops that run the collaboration task at the same time.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceCandidates")]
        [Validation(Required=false)]
        public List<ApplyCoordinationForMonitoringRequestResourceCandidates> ResourceCandidates { get; set; }
        public class ApplyCoordinationForMonitoringRequestResourceCandidates : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account to which the current cloud desktop belongs.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("OwnerAliUid")]
            [Validation(Required=false)]
            public long? OwnerAliUid { get; set; }

            /// <summary>
            /// The ID of the current end user.
            /// </summary>
            [NameInMap("OwnerEndUserId")]
            [Validation(Required=false)]
            public string OwnerEndUserId { get; set; }

            /// <summary>
            /// The ID of the cloud desktop.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// The name of the cloud desktop.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// The properties of the cloud desktop.
            /// </summary>
            [NameInMap("ResourceProperties")]
            [Validation(Required=false)]
            public string ResourceProperties { get; set; }

            /// <summary>
            /// The region where the resource resides.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceRegionId")]
            [Validation(Required=false)]
            public string ResourceRegionId { get; set; }

            /// <summary>
            /// The resource type.
            /// 
            /// Set the value to CLOUD_DESKTOP.
            /// 
            /// *   The value CLOUD_DESKTOP specifies that the resource is a cloud desktop.
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

        /// <summary>
        /// The universally unique identifier (UUID) of the device.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
