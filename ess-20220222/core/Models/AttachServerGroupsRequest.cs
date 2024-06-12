// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachServerGroupsRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [Ensure idempotence](https://help.aliyun.com/document_detail/25965.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to add the existing Elastic Compute Service (ECS) instances or elastic container instances in the scaling group to the server group. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceAttach")]
        [Validation(Required=false)]
        public bool? ForceAttach { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// The information about the server groups.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<AttachServerGroupsRequestServerGroups> ServerGroups { get; set; }
        public class AttachServerGroupsRequestServerGroups : TeaModel {
            /// <summary>
            /// The port used by ECS instances or elastic container instances after being added as backend servers to the server group.
            /// 
            /// Valid values: 1 to 65535.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// The ID of the server group.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// The type of the server group. Valid values:
            /// 
            /// *   ALB
            /// *   NLB
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The weight of an ECS instance or elastic container instance as a backend server of the server group. Valid values: 0 to 100.
            /// 
            /// If you assign a higher weight to an instance, the instance is allocated a larger proportion of access requests. If you assign zero weight to an instance, the instance is allocated no access requests.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
