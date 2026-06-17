// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class QueryConsumerAuthorizationRulesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
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
        public QueryConsumerAuthorizationRulesResponseBodyData Data { get; set; }
        public class QueryConsumerAuthorizationRulesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>消费者规则列表。</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<QueryConsumerAuthorizationRulesResponseBodyDataItems> Items { get; set; }
            public class QueryConsumerAuthorizationRulesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>API信息详情。</para>
                /// </summary>
                [NameInMap("apiInfo")]
                [Validation(Required=false)]
                public HttpApiApiInfo ApiInfo { get; set; }

                /// <summary>
                /// <para>消费者授权规则ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>car-csgeka5lhtggrjcprok0</para>
                /// </summary>
                [NameInMap("consumerAuthorizationRuleId")]
                [Validation(Required=false)]
                public string ConsumerAuthorizationRuleId { get; set; }

                /// <summary>
                /// <para>消费者ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs-csheiftlhtgmp0j0hp4g</para>
                /// </summary>
                [NameInMap("consumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <para>消费者信息详情。</para>
                /// </summary>
                [NameInMap("consumerInfo")]
                [Validation(Required=false)]
                public ConsumerInfo ConsumerInfo { get; set; }

                /// <summary>
                /// <para>创建时间戳。单位: 毫秒。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>API在当前环境的发布状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("deployStatus")]
                [Validation(Required=false)]
                public string DeployStatus { get; set; }

                /// <summary>
                /// <para>环境信息。</para>
                /// </summary>
                [NameInMap("environmentInfo")]
                [Validation(Required=false)]
                public EnvironmentInfo EnvironmentInfo { get; set; }

                /// <summary>
                /// <para>失效模式。LongTerm、ShortTerm，二选一。</para>
                /// 
                /// <b>Example:</b>
                /// <para>ShortTerm</para>
                /// </summary>
                [NameInMap("expireMode")]
                [Validation(Required=false)]
                public string ExpireMode { get; set; }

                /// <summary>
                /// <para>失效状态。</para>
                /// 
                /// <b>Example:</b>
                /// <para>InEffect</para>
                /// </summary>
                [NameInMap("expireStatus")]
                [Validation(Required=false)]
                public string ExpireStatus { get; set; }

                /// <summary>
                /// <para>到期时间。</para>
                /// 
                /// <b>Example:</b>
                /// <para>172086834548</para>
                /// </summary>
                [NameInMap("expireTimestamp")]
                [Validation(Required=false)]
                public long? ExpireTimestamp { get; set; }

                /// <summary>
                /// <para>网关信息。</para>
                /// </summary>
                [NameInMap("gatewayInfo")]
                [Validation(Required=false)]
                public GatewayInfo GatewayInfo { get; set; }

                /// <summary>
                /// <para>资源ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2351944</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>资源信息详情。</para>
                /// </summary>
                [NameInMap("resourceInfo")]
                [Validation(Required=false)]
                public QueryConsumerAuthorizationRulesResponseBodyDataItemsResourceInfo ResourceInfo { get; set; }
                public class QueryConsumerAuthorizationRulesResponseBodyDataItemsResourceInfo : TeaModel {
                    /// <summary>
                    /// <para>接口信息。</para>
                    /// </summary>
                    [NameInMap("operationInfo")]
                    [Validation(Required=false)]
                    public HttpApiOperationInfo OperationInfo { get; set; }

                    /// <summary>
                    /// <para>路由规则。</para>
                    /// </summary>
                    [NameInMap("route")]
                    [Validation(Required=false)]
                    public HttpRoute Route { get; set; }

                }

                /// <summary>
                /// <para>资源类型。</para>
                /// 
                /// <b>Example:</b>
                /// <para>HttpApiRoute</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>更新时间戳。单位: 毫秒。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("pageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("totalSize")]
            [Validation(Required=false)]
            public string TotalSize { get; set; }

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
        /// <para>A60EE5CA-1294-532A-9775-8D2FD1C6EFBF</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
