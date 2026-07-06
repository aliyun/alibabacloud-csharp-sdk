// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The token for the next query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource to be tagged. Resource ID rules:</para>
        /// <list type="bullet">
        /// <item><description><para>Instance: instanceId</para>
        /// </description></item>
        /// <item><description><para>Topic: Kafka_alikafka_instanceId_topic</para>
        /// </description></item>
        /// <item><description><para>Group: Kafka_alikafka_instanceId_consumerGroup</para>
        /// </description></item>
        /// </list>
        /// <para>For example: If the instance ID is alikafka_post-cn-v0h1fgs2xxxx, the Topic name is test-topic, and the Group name is test-consumer-group, the resource IDs are alikafka_post-cn-v0h1fgs2xxxx, Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-topic, and Kafka_alikafka_post-cn-v0h1fgs2xxxx_test-consumer-group respectively.</para>
        /// <remarks>
        /// <para>Either the <b>ResourceId</b> or <b>Tag</b> parameter must be configured to query the tag list bound to resources. Otherwise, the API call fails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>alikafka_post-cn-v0h1fgs2****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Enumeration type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>INSTANCE</b>: instance.</para>
        /// </description></item>
        /// <item><description><para><b>TOPIC</b>: topic.</para>
        /// </description></item>
        /// <item><description><para><b>CONSUMERGROUP</b>: consumer group.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTagResourcesRequestTag> Tag { get; set; }
        public class ListTagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>If this parameter is empty, all tag keys are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http\:// or https\://.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <list type="bullet">
            /// <item><description><para>If the tag key is empty, this parameter must be empty. If this parameter is empty, all tag values are matched.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http\:// or https\://.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
