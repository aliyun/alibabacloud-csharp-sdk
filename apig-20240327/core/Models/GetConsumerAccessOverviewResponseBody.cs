// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetConsumerAccessOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned for a successful request, and a specific business error code is returned for a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned for the consumer operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerAccessOverviewResponseBodyData Data { get; set; }
        public class GetConsumerAccessOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the query result is complete. A successful response returns a complete projection.</para>
            /// </summary>
            [NameInMap("complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// <para>The identifier and name of the gateway in the current context.</para>
            /// </summary>
            [NameInMap("gateway")]
            [Validation(Required=false)]
            public GetConsumerAccessOverviewResponseBodyDataGateway Gateway { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataGateway : TeaModel {
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
            /// <para>The description of the consumer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Consumer for business applications</para>
            /// </summary>
            [NameInMap("identityDescription")]
            [Validation(Required=false)]
            public string IdentityDescription { get; set; }

            /// <summary>
            /// <para>The impact of the authorization configuration of this consumer on readable gateways in the local region.</para>
            /// </summary>
            [NameInMap("impacts")]
            [Validation(Required=false)]
            public List<GetConsumerAccessOverviewResponseBodyDataImpacts> Impacts { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataImpacts : TeaModel {
                /// <summary>
                /// <para>The number of authorization configurations categorized by resource type.</para>
                /// </summary>
                [NameInMap("authorizationCounts")]
                [Validation(Required=false)]
                public GetConsumerAccessOverviewResponseBodyDataImpactsAuthorizationCounts AuthorizationCounts { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataImpactsAuthorizationCounts : TeaModel {
                    /// <summary>
                    /// <para>The number of agent APIs for which authorization is configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("agentApis")]
                    [Validation(Required=false)]
                    public int? AgentApis { get; set; }

                    /// <summary>
                    /// <para>The number of MCP servers for which authorization is configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("mcpServers")]
                    [Validation(Required=false)]
                    public int? McpServers { get; set; }

                    /// <summary>
                    /// <para>The number of model APIs for which authorization is configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("modelApis")]
                    [Validation(Required=false)]
                    public int? ModelApis { get; set; }

                }

                /// <summary>
                /// <para>The identifier and name of the gateway in the current context.</para>
                /// </summary>
                [NameInMap("gateway")]
                [Validation(Required=false)]
                public GetConsumerAccessOverviewResponseBodyDataImpactsGateway Gateway { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataImpactsGateway : TeaModel {
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
                /// <para>The set of resources authorized for the consumer.</para>
                /// </summary>
                [NameInMap("resources")]
                [Validation(Required=false)]
                public List<string> Resources { get; set; }

            }

            /// <summary>
            /// <para>The quota rules and usage of the consumer and the consumer group to which it belongs.</para>
            /// </summary>
            [NameInMap("quotas")]
            [Validation(Required=false)]
            public List<GetConsumerAccessOverviewResponseBodyDataQuotas> Quotas { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataQuotas : TeaModel {
                /// <summary>
                /// <para>The quota limit for the current rule. This value uses the same unit of measurement as the unit field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("limit")]
                [Validation(Required=false)]
                public long? Limit { get; set; }

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
                /// <para>The multiplier for the custom period.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("periodMultiplier")]
                [Validation(Required=false)]
                public long? PeriodMultiplier { get; set; }

                /// <summary>
                /// <para>The type of the quota period. Valid values: day, week, and month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>day</para>
                /// </summary>
                [NameInMap("periodType")]
                [Validation(Required=false)]
                public string PeriodType { get; set; }

                /// <summary>
                /// <para>The ID of the quota rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qr-d00000000000000000000</para>
                /// </summary>
                [NameInMap("ruleId")]
                [Validation(Required=false)]
                public string RuleId { get; set; }

                /// <summary>
                /// <para>The ID of the subject to which the quota belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cs-d00000000000000000000</para>
                /// </summary>
                [NameInMap("subjectId")]
                [Validation(Required=false)]
                public string SubjectId { get; set; }

                /// <summary>
                /// <para>The name of the subject to which the quota belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beta-consumer</para>
                /// </summary>
                [NameInMap("subjectName")]
                [Validation(Required=false)]
                public string SubjectName { get; set; }

                /// <summary>
                /// <para>The type of the quota subject. Valid values: consumer and consumer_group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>consumer</para>
                /// </summary>
                [NameInMap("subjectType")]
                [Validation(Required=false)]
                public string SubjectType { get; set; }

                /// <summary>
                /// <para>The unit of measurement for the quota.</para>
                /// 
                /// <b>Example:</b>
                /// <para>token</para>
                /// </summary>
                [NameInMap("unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                /// <summary>
                /// <para>The used quota within the period corresponding to the current rule. This value uses the same unit of measurement as the unit field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("used")]
                [Validation(Required=false)]
                public double? Used { get; set; }

                /// <summary>
                /// <para>The alignment method of the period window. Valid values: calendar for natural periods and epoch for custom base periods.</para>
                /// 
                /// <b>Example:</b>
                /// <para>calendar</para>
                /// </summary>
                [NameInMap("windowAlignment")]
                [Validation(Required=false)]
                public string WindowAlignment { get; set; }

            }

            /// <summary>
            /// <para>The set of resources authorized for the consumer.</para>
            /// </summary>
            [NameInMap("resources")]
            [Validation(Required=false)]
            public List<GetConsumerAccessOverviewResponseBodyDataResources> Resources { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataResources : TeaModel {
                /// <summary>
                /// <para>Indicates whether the authorization scope of this resource includes all models.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("allModels")]
                [Validation(Required=false)]
                public bool? AllModels { get; set; }

                /// <summary>
                /// <para>Indicates whether the authorization scope of this MCP resource includes all tools.</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("allTools")]
                [Validation(Required=false)]
                public bool? AllTools { get; set; }

                /// <summary>
                /// <para>The name of the consumer group that provides this authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beta-consumer-group</para>
                /// </summary>
                [NameInMap("consumerGroupName")]
                [Validation(Required=false)]
                public string ConsumerGroupName { get; set; }

                /// <summary>
                /// <para>The existing desired or applied state of the model entitlement projection. This field is omitted when no state row exists.</para>
                /// </summary>
                [NameInMap("entitlementState")]
                [Validation(Required=false)]
                public GetConsumerAccessOverviewResponseBodyDataResourcesEntitlementState EntitlementState { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataResourcesEntitlementState : TeaModel {
                    /// <summary>
                    /// <para>The applied authorization revision number.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("appliedRevision")]
                    [Validation(Required=false)]
                    public long? AppliedRevision { get; set; }

                    /// <summary>
                    /// <para>The desired authorization revision number to be distributed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("desiredRevision")]
                    [Validation(Required=false)]
                    public long? DesiredRevision { get; set; }

                    /// <summary>
                    /// <para>The error description when processing fails. This field is empty when no error occurs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Configuration delivery failed</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The status. Valid values: Pending, Applying, Committed, and Failed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Committed</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The expiration time. The value is null for long-term authorization, an RFC 3339 formatted string for short-term authorization that can be losslessly projected, and omitted when unknown.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-12-31T23:59:59Z</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("expireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The model groups and their model collections that are accessible.</para>
                /// </summary>
                [NameInMap("modelGroups")]
                [Validation(Required=false)]
                public List<GetConsumerAccessOverviewResponseBodyDataResourcesModelGroups> ModelGroups { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataResourcesModelGroups : TeaModel {
                    /// <summary>
                    /// <para>The name of the consumer group that provides this authorization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>beta-consumer-group</para>
                    /// </summary>
                    [NameInMap("consumerGroupName")]
                    [Validation(Required=false)]
                    public string ConsumerGroupName { get; set; }

                    /// <summary>
                    /// <para>The ID of the model group. Use the modelGroupId returned by CreateModelGroup.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mg-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelGroupId")]
                    [Validation(Required=false)]
                    public string ModelGroupId { get; set; }

                    /// <summary>
                    /// <para>The list of model endpoints accessible within the current resource scope.</para>
                    /// </summary>
                    [NameInMap("models")]
                    [Validation(Required=false)]
                    public List<GetConsumerAccessOverviewResponseBodyDataResourcesModelGroupsModels> Models { get; set; }
                    public class GetConsumerAccessOverviewResponseBodyDataResourcesModelGroupsModels : TeaModel {
                        /// <summary>
                        /// <para>The name of the consumer group that provides this authorization.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>beta-consumer-group</para>
                        /// </summary>
                        [NameInMap("consumerGroupName")]
                        [Validation(Required=false)]
                        public string ConsumerGroupName { get; set; }

                        /// <summary>
                        /// <para>The identifier of the model. Standard models use the source model card ID, and logical model endpoints use an identifier prefixed with vm-.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>msc-d00000000000000000000</para>
                        /// </summary>
                        [NameInMap("modelCardId")]
                        [Validation(Required=false)]
                        public string ModelCardId { get; set; }

                        /// <summary>
                        /// <para>The ID of the model source. Use the modelSourceId returned by CreateAiModelSource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ms-d00000000000000000000</para>
                        /// </summary>
                        [NameInMap("modelSourceId")]
                        [Validation(Required=false)]
                        public string ModelSourceId { get; set; }

                        /// <summary>
                        /// <para>The display name of the model source.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Model Studio model source</para>
                        /// </summary>
                        [NameInMap("modelSourceName")]
                        [Validation(Required=false)]
                        public string ModelSourceName { get; set; }

                        /// <summary>
                        /// <para>The type of the model. Valid values: Model and LogicalModel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Model</para>
                        /// </summary>
                        [NameInMap("modelType")]
                        [Validation(Required=false)]
                        public string ModelType { get; set; }

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
                /// <para>The list of model endpoints accessible within the current resource scope.</para>
                /// </summary>
                [NameInMap("models")]
                [Validation(Required=false)]
                public List<GetConsumerAccessOverviewResponseBodyDataResourcesModels> Models { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataResourcesModels : TeaModel {
                    /// <summary>
                    /// <para>The name of the consumer group that provides this authorization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>beta-consumer-group</para>
                    /// </summary>
                    [NameInMap("consumerGroupName")]
                    [Validation(Required=false)]
                    public string ConsumerGroupName { get; set; }

                    /// <summary>
                    /// <para>The identifier of the model. Standard models use the source model card ID, and logical model endpoints use an identifier prefixed with vm-.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                    /// <summary>
                    /// <para>The ID of the model source. Use the modelSourceId returned by CreateAiModelSource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ms-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelSourceId")]
                    [Validation(Required=false)]
                    public string ModelSourceId { get; set; }

                    /// <summary>
                    /// <para>The display name of the model source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Model Studio model source</para>
                    /// </summary>
                    [NameInMap("modelSourceName")]
                    [Validation(Required=false)]
                    public string ModelSourceName { get; set; }

                    /// <summary>
                    /// <para>The type of the model. Valid values: Model and LogicalModel.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Model</para>
                    /// </summary>
                    [NameInMap("modelType")]
                    [Validation(Required=false)]
                    public string ModelType { get; set; }

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
                /// <para>The name of the consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beta-consumer</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The immutable identifier of the authorized resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>api-d00000000000000000000</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The type of the resource. Valid values: ModelApi, MCP, and Agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ModelApi</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The list of MCP tool names that can be called within the resource scope.</para>
                /// </summary>
                [NameInMap("tools")]
                [Validation(Required=false)]
                public List<string> Tools { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message that describes the processing result of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. This ID is generated by the system to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
