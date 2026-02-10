// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class QueryConsumerAuthorizationRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response payload.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public QueryConsumerAuthorizationRulesResponseBodyData Data { get; set; }
        public class QueryConsumerAuthorizationRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The rules.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<QueryConsumerAuthorizationRulesResponseBodyDataItems> Items { get; set; }
            public class QueryConsumerAuthorizationRulesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>The API details.</para>
                /// </summary>
                [NameInMap("apiInfo")]
                [Validation(Required=false)]
                public HttpApiApiInfo ApiInfo { get; set; }

                /// <summary>
                /// <para>The rule ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>car-csgeka5lhtggrjcprok0</para>
                /// </summary>
                [NameInMap("consumerAuthorizationRuleId")]
                [Validation(Required=false)]
                public string ConsumerAuthorizationRuleId { get; set; }

                /// <summary>
                /// <para>The consumer ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs-csheiftlhtgmp0j0hp4g</para>
                /// </summary>
                [NameInMap("consumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <para>The consumer information.</para>
                /// </summary>
                [NameInMap("consumerInfo")]
                [Validation(Required=false)]
                public ConsumerInfo ConsumerInfo { get; set; }

                /// <summary>
                /// <para>The creation timestamp. Unit: milliseconds.</para>
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
                /// <para>{}</para>
                /// </summary>
                [NameInMap("deployStatus")]
                [Validation(Required=false)]
                public string DeployStatus { get; set; }

                /// <summary>
                /// <para>The environment information.</para>
                /// </summary>
                [NameInMap("environmentInfo")]
                [Validation(Required=false)]
                public EnvironmentInfo EnvironmentInfo { get; set; }

                /// <summary>
                /// <para>The expiry mode. Valid values: LongTerm and ShortTerm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ShortTerm</para>
                /// </summary>
                [NameInMap("expireMode")]
                [Validation(Required=false)]
                public string ExpireMode { get; set; }

                /// <summary>
                /// <para>The rule status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InEffect</para>
                /// </summary>
                [NameInMap("expireStatus")]
                [Validation(Required=false)]
                public string ExpireStatus { get; set; }

                /// <summary>
                /// <para>The time when the rule expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172086834548</para>
                /// </summary>
                [NameInMap("expireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// <para>The instance information.</para>
                /// </summary>
                [NameInMap("gatewayInfo")]
                [Validation(Required=false)]
                public GatewayInfo GatewayInfo { get; set; }

                /// <summary>
                /// <para>The resource IDs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2351944</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource information.</para>
                /// </summary>
                [NameInMap("resourceInfo")]
                [Validation(Required=false)]
                public QueryConsumerAuthorizationRulesResponseBodyDataItemsResourceInfo ResourceInfo { get; set; }
                public class QueryConsumerAuthorizationRulesResponseBodyDataItemsResourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The operation information.</para>
                    /// </summary>
                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public HttpApiOperationInfo OperationInfo { get; set; }

                    /// <summary>
                    /// <para>The route.</para>
                    /// </summary>
                    [NameInMap("route")]
                    [Validation(Required=false)]
                    public HttpRoute Route { get; set; }

                }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HttpApiRoute</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The update timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A60EE5CA-1294-532A-9775-8D2FD1C6EFBF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
