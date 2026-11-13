// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListConsumerConsoleSummariesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. A value of Ok indicates success. If the call fails, a specific business error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business data returned for the consumer operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListConsumerConsoleSummariesResponseBodyData Data { get; set; }
        public class ListConsumerConsoleSummariesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the query result is complete. A successful response returns a complete projection.</para>
            /// </summary>
            [NameInMap("complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// <para>The statistics of the complete consumer set in the local region. This value is not affected by the current pagination.</para>
            /// </summary>
            [NameInMap("counts")]
            [Validation(Required=false)]
            public ListConsumerConsoleSummariesResponseBodyDataCounts Counts { get; set; }
            public class ListConsumerConsoleSummariesResponseBodyDataCounts : TeaModel {
                /// <summary>
                /// <para>The total number of readable consumers in the local region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("all")]
                [Validation(Required=false)]
                public int? All { get; set; }

                /// <summary>
                /// <para>The number of disabled consumers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("disabled")]
                [Validation(Required=false)]
                public int? Disabled { get; set; }

                /// <summary>
                /// <para>The number of consumers that have authorization configurations in the current instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("granted")]
                [Validation(Required=false)]
                public int? Granted { get; set; }

                /// <summary>
                /// <para>The number of consumer groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("groups")]
                [Validation(Required=false)]
                public int? Groups { get; set; }

            }

            /// <summary>
            /// <para>The list of consumers returned on the current page.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<ListConsumerConsoleSummariesResponseBodyDataItems> Items { get; set; }
            public class ListConsumerConsoleSummariesResponseBodyDataItems : TeaModel {
                /// <summary>
                /// <para>Indicates whether the authorization scope of this resource includes all models.</para>
                /// </summary>
                [NameInMap("allModels")]
                [Validation(Required=false)]
                public bool? AllModels { get; set; }

                /// <summary>
                /// <para>The list of consumer groups that the consumer has joined.</para>
                /// </summary>
                [NameInMap("consumerGroups")]
                [Validation(Required=false)]
                public List<ListConsumerConsoleSummariesResponseBodyDataItemsConsumerGroups> ConsumerGroups { get; set; }
                public class ListConsumerConsoleSummariesResponseBodyDataItemsConsumerGroups : TeaModel {
                    /// <summary>
                    /// <para>The ID of the consumer group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cg-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("consumerGroupId")]
                    [Validation(Required=false)]
                    public string ConsumerGroupId { get; set; }

                    /// <summary>
                    /// <para>The description of the consumer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Consumer used for business integration</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The time when the consumer joined the consumer group. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1715769600000</para>
                    /// </summary>
                    [NameInMap("joinTimestamp")]
                    [Validation(Required=false)]
                    public long? JoinTimestamp { get; set; }

                    /// <summary>
                    /// <para>The name of the consumer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>beta-consumer</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The consumer ID returned by the create or query consumer API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs-d00000000000000000000</para>
                /// </summary>
                [NameInMap("consumerId")]
                [Validation(Required=false)]
                public string ConsumerId { get; set; }

                /// <summary>
                /// <para>The time when the consumer was created. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("createTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The summary of credential types and quantities for the consumer. The actual credential content is not returned.</para>
                /// </summary>
                [NameInMap("credentials")]
                [Validation(Required=false)]
                public List<ListConsumerConsoleSummariesResponseBodyDataItemsCredentials> Credentials { get; set; }
                public class ListConsumerConsoleSummariesResponseBodyDataItemsCredentials : TeaModel {
                    /// <summary>
                    /// <para>The number of credentials of this type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The credential type. Valid values: Apikey, Jwt, and AkSk. No keys or secrets are returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Apikey</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The deployment status of the consumer configuration. An empty string is returned if no deployment status is available.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("deployStatus")]
                [Validation(Required=false)]
                public string DeployStatus { get; set; }

                /// <summary>
                /// <para>The description of the consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Consumer used for business integration</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Indicates whether the consumer is enabled.</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The number of authorization configurations in the current gateway, counted by resource type.</para>
                /// </summary>
                [NameInMap("localAccess")]
                [Validation(Required=false)]
                public ListConsumerConsoleSummariesResponseBodyDataItemsLocalAccess LocalAccess { get; set; }
                public class ListConsumerConsoleSummariesResponseBodyDataItemsLocalAccess : TeaModel {
                    /// <summary>
                    /// <para>The number of agent APIs that have authorizations configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("agentApis")]
                    [Validation(Required=false)]
                    public int? AgentApis { get; set; }

                    /// <summary>
                    /// <para>The number of MCP servers that have authorizations configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("mcpServers")]
                    [Validation(Required=false)]
                    public int? McpServers { get; set; }

                    /// <summary>
                    /// <para>The number of model APIs that have authorizations configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("modelApis")]
                    [Validation(Required=false)]
                    public int? ModelApis { get; set; }

                }

                /// <summary>
                /// <para>The number of models.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("modelCount")]
                [Validation(Required=false)]
                public int? ModelCount { get; set; }

                /// <summary>
                /// <para>The name of the consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beta-consumer</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The summary of access configurations for the consumer in other readable gateways.</para>
                /// </summary>
                [NameInMap("otherGateways")]
                [Validation(Required=false)]
                public List<ListConsumerConsoleSummariesResponseBodyDataItemsOtherGateways> OtherGateways { get; set; }
                public class ListConsumerConsoleSummariesResponseBodyDataItemsOtherGateways : TeaModel {
                    /// <summary>
                    /// <para>The ID of the AI gateway instance to which the resource belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>gw-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("gatewayId")]
                    [Validation(Required=false)]
                    public string GatewayId { get; set; }

                    /// <summary>
                    /// <para>The name of the consumer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>beta-consumer</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The time when the consumer was updated. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1719386834548</para>
                /// </summary>
                [NameInMap("updateTimestamp")]
                [Validation(Required=false)]
                public long? UpdateTimestamp { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("maxResults")]
            [Validation(Required=false)]
            public int? MaxResults { get; set; }

            /// <summary>
            /// <para>The pagination token returned from the previous page. Do not specify this parameter when you query the first page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJvZmZzZXQiOjIwfQ==</para>
            /// </summary>
            [NameInMap("nextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The total number of entries that match the current query conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The response message that describes the result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by the system to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
