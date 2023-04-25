// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// *   If you want to configure this parameter, specify at least one tag key and at most 20 tag keys.
        /// *   If this parameter is not configured and the All parameter is set to true, all tag keys are matched.
        /// *   The tag key can be up to 128 characters in length. The tag key cannot start with acs: or aliyun or contain [http:// or https://.](http://或者https://。)
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// The IDs of the resources from which you want to detach tags.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// Take note of the following rules when you specify a resource ID:
        /// 
        /// *   The resource ID of an instance is the value of the instanceId parameter.
        /// *   The resource ID of a topic is the value of the Kafka_instanceId_topic parameter.
        /// *   The resource ID of a group is the value of the Kafka_instanceId_consumerGroup parameter.
        /// 
        /// For example, the resources from which you want to detach tags include the alikafka_post-cn-v0h1fgs2xxxx instance, the test-topic topic, and the test-consumer-group consumer group. In this case, their resource IDs are alikafka_post-cn-v0h1fgs2xxxx, Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-topic, and Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-consumer-group.
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Detaches tags from a specified resource.
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
