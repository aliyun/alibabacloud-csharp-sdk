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
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource. A resource ID complies with the following rules:
        /// 
        /// *   The resource ID of an instance is the value of the instanceId parameter.
        /// *   The resource ID of a topic is the value of the Kafka_alikafka_instanceId_topic parameter.
        /// *   The resource ID of a group is the value of the Kafka_alikafka_instanceId_consumerGroup parameter.
        /// 
        /// For example, the resources whose tags you want to query include the alikafka_post-cn-v0h1fgs2xxxx instance, the test-topic topic, and the test-consumer-group group. In this case, their resource IDs are alikafka_post-cn-v0h1fgs2xxxx, Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-topic, and Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-consumer-group.
        /// 
        /// >  You must set at least one of the **ResourceId** and **Tag** parameters to query the tags of a specified resource. Otherwise, the request fails.
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
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The tag list.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// The tag key.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   If this parameter is not configured, all tag keys are matched.
            /// *   The tag key can be up to 128 characters in length. The tag value cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// 
            /// *   Valid values of N: 1 to 20.
            /// *   If the Key parameter is not configured, you cannot configure this parameter. If this parameter is not configured, all tag values are matched.
            /// *   The tag value can be 1 to 128 characters in length. The tag value cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
