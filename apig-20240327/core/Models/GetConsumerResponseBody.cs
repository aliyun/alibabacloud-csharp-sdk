// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetConsumerResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerResponseBodyData Data { get; set; }
        public class GetConsumerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The AccessKey identity authentication configurations.</para>
            /// </summary>
            [NameInMap("akSkIdentityConfigs")]
            [Validation(Required=false)]
            public List<AkSkIdentityConfig> AkSkIdentityConfigs { get; set; }

            /// <summary>
            /// <para>The API key identity authentication configuration.</para>
            /// </summary>
            [NameInMap("apiKeyIdentityConfig")]
            [Validation(Required=false)]
            public ApiKeyIdentityConfig ApiKeyIdentityConfig { get; set; }

            /// <summary>
            /// <para>The list of consumer groups to which the API consumer belongs.</para>
            /// </summary>
            [NameInMap("consumerGroups")]
            [Validation(Required=false)]
            public List<GetConsumerResponseBodyDataConsumerGroups> ConsumerGroups { get; set; }
            public class GetConsumerResponseBodyDataConsumerGroups : TeaModel {
                /// <summary>
                /// <para>The consumer group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>csg-8c13d2b4f8a1</para>
                /// </summary>
                [NameInMap("consumerGroupId")]
                [Validation(Required=false)]
                public string ConsumerGroupId { get; set; }

                /// <summary>
                /// <para>The consumer group description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>用于线上 API 调用方分组</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The time when the API consumer joined the consumer group. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715769600000</para>
                /// </summary>
                [NameInMap("joinTimestamp")]
                [Validation(Required=false)]
                public long? JoinTimestamp { get; set; }

                /// <summary>
                /// <para>The consumer group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-consumer-group</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The API consumer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cs-cvgbtk6m1hkji5sb8dr0</para>
            /// </summary>
            [NameInMap("consumerId")]
            [Validation(Required=false)]
            public string ConsumerId { get; set; }

            /// <summary>
            /// <para>The creation timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("createTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The deployment status of the API in the current environment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("deployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试专用消费者</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the API consumer is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <para>The JWT identity authentication configuration.</para>
            /// </summary>
            [NameInMap("jwtIdentityConfig")]
            [Validation(Required=false)]
            public JwtIdentityConfig JwtIdentityConfig { get; set; }

            /// <summary>
            /// <para>The API consumer name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>consumer-1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The update timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719386834548</para>
            /// </summary>
            [NameInMap("updateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>880C61B3-7B90-5570-A3F7-D6D92C0E2D36</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
