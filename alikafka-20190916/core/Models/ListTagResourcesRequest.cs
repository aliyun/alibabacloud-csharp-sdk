// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// The token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the region in which the resource is deployed.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource ID. The following items describe the formats of resource IDs:
        /// 
        /// *   Instance ID: instanceId
        /// *   Topic ID: Kafka_alikafka_instanceId_topic
        /// *   Group ID: Kafka_alikafka_instanceId_consumerGroup
        /// 
        /// For example, you create an instance whose ID is alikafka_post-cn-v0h1fgs2xxxx, a topic whose name is test-topic, and a group whose ID is test-consumer-group. In this case, the resource IDs are alikafka_post-cn-v0h1fgs2xxxx, Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-topic, and Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-consumer-group.
        /// 
        /// >  You must specify one of the **ResourceId** and **Tag** parameters to query the tags that are attached to a resource. Otherwise, the call fails.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// The type of the resource whose tags you want to query. The value is an enumerated value. Valid values:
        /// 
        /// *   **INSTANCE**
        /// *   **TOPIC**
        /// *   **CONSUMERGROUP**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// 
            /// *   If you leave this parameter empty, the keys of all tags are matched.
            /// *   The tag key must be 1 to 128 characters in length and cannot start with acs: or aliyun. The tag key cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// *   If you do not specify the tag key, you cannot specify the tag value. If you leave this parameter empty, the values of all tags are matched.
            /// *   The tag value must be 1 to 128 characters in length and cannot start with acs: or aliyun. The tag value cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
