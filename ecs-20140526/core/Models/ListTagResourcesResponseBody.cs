// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ListTagResourcesResponseBody : TeaModel {
        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the resource and its tags, including the resource ID, the resource type, and the keys and values of the tags.
        /// </summary>
        [NameInMap("TagResources")]
        [Validation(Required=false)]
        public ListTagResourcesResponseBodyTagResources TagResources { get; set; }
        public class ListTagResourcesResponseBodyTagResources : TeaModel {
            [NameInMap("TagResource")]
            [Validation(Required=false)]
            public List<ListTagResourcesResponseBodyTagResourcesTagResource> TagResource { get; set; }
            public class ListTagResourcesResponseBodyTagResourcesTagResource : TeaModel {
                /// <summary>
                /// The resource ID.
                /// </summary>
                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// The resource type. Valid values:
                /// 
                /// *   instance: ECS instance
                /// *   disk: disk
                /// *   snapshot: snapshot
                /// *   image: image
                /// *   securitygroup: security group
                /// *   volume: storage volume
                /// *   eni: ENI
                /// *   ddh: dedicated host
                /// *   ddhcluster: dedicated host cluster
                /// *   keypair: SSH key pair
                /// *   launchtemplate: launch template
                /// *   reservedinstance: reserved instance
                /// *   snapshotpolicy: automatic snapshot policy
                /// *   elasticityassurance: elasticity assurance
                /// *   capacityreservation: capacity reservation
                /// *   command: Cloud Assistant command
                /// *   invocation: Cloud Assistant command execution result
                /// *   activation: activation code for a Cloud Assistant managed instance
                /// *   managedinstance: Cloud Assistant managed instance
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// The tag key of the resource.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value of the resource.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

    }

}
