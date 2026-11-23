// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetConsumerAccessOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. It returns Ok for a successful request or a specific business error code for a failed request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the consumer operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;gateway&quot;:{&quot;gatewayId&quot;:&quot;gw-example01&quot;,&quot;name&quot;:&quot;team-ai-gateway&quot;},&quot;identityDescription&quot;:&quot;Consumer used by the conversation service&quot;,&quot;resources&quot;:[{&quot;resourceId&quot;:&quot;api-example01&quot;,&quot;name&quot;:&quot;team-chat&quot;,&quot;resourceType&quot;:&quot;ModelApi&quot;,&quot;models&quot;:[],&quot;modelGroups&quot;:[]}],&quot;quotas&quot;:[],&quot;impacts&quot;:[{&quot;gateway&quot;:{&quot;gatewayId&quot;:&quot;gw-example01&quot;,&quot;name&quot;:&quot;team-ai-gateway&quot;},&quot;resources&quot;:[&quot;team-chat&quot;],&quot;authorizationCounts&quot;:{&quot;modelApis&quot;:1,&quot;mcpServers&quot;:0,&quot;agentApis&quot;:0}}],&quot;modelTpmLimits&quot;:[{&quot;modelId&quot;:&quot;msc-example01&quot;,&quot;consumerTpm&quot;:300,&quot;globalTpm&quot;:1800}],&quot;complete&quot;:true}</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetConsumerAccessOverviewResponseBodyData Data { get; set; }
        public class GetConsumerAccessOverviewResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the query result is complete. A successful response returns a complete projection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("complete")]
            [Validation(Required=false)]
            public bool? Complete { get; set; }

            /// <summary>
            /// <para>The gateway identifier and name in the current context.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;gatewayId&quot;:&quot;gw-example01&quot;,&quot;name&quot;:&quot;team-ai-gateway&quot;}</para>
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
            /// <para>The description text of the consumer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Consumer for business applications</para>
            /// </summary>
            [NameInMap("identityDescription")]
            [Validation(Required=false)]
            public string IdentityDescription { get; set; }

            /// <summary>
            /// <para>The impact of authorization configurations for the consumer in readable gateways within the local region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;gateway&quot;:{&quot;gatewayId&quot;:&quot;gw-example01&quot;,&quot;name&quot;:&quot;team-ai-gateway&quot;},&quot;resources&quot;:[&quot;team-chat&quot;],&quot;authorizationCounts&quot;:{&quot;modelApis&quot;:1,&quot;mcpServers&quot;:0,&quot;agentApis&quot;:0}}]</para>
            /// </summary>
            [NameInMap("impacts")]
            [Validation(Required=false)]
            public List<GetConsumerAccessOverviewResponseBodyDataImpacts> Impacts { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataImpacts : TeaModel {
                /// <summary>
                /// <para>The number of authorization configurations by resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;modelApis&quot;:1,&quot;mcpServers&quot;:0,&quot;agentApis&quot;:0}</para>
                /// </summary>
                [NameInMap("authorizationCounts")]
                [Validation(Required=false)]
                public GetConsumerAccessOverviewResponseBodyDataImpactsAuthorizationCounts AuthorizationCounts { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataImpactsAuthorizationCounts : TeaModel {
                    /// <summary>
                    /// <para>The number of agent APIs with configured authorizations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("agentApis")]
                    [Validation(Required=false)]
                    public int? AgentApis { get; set; }

                    /// <summary>
                    /// <para>The number of MCP services with configured authorizations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("mcpServers")]
                    [Validation(Required=false)]
                    public int? McpServers { get; set; }

                    /// <summary>
                    /// <para>The number of model APIs with configured authorizations.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("modelApis")]
                    [Validation(Required=false)]
                    public int? ModelApis { get; set; }

                }

                /// <summary>
                /// <para>The gateway identifier and name in the current context.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;gatewayId&quot;:&quot;gw-example01&quot;,&quot;name&quot;:&quot;team-ai-gateway&quot;}</para>
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
                /// <para>The collection of resources for which the consumer has been granted authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;team-chat&quot;]</para>
                /// </summary>
                [NameInMap("resources")]
                [Validation(Required=false)]
                public List<string> Resources { get; set; }

            }

            /// <summary>
            /// <para>The list of models with configured global or current consumer TPM limits in the target dedicated instance. Returned when includeModelTpm is set to true, and an empty array when no matching models exist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;modelId&quot;:&quot;msc-example01&quot;,&quot;consumerTpm&quot;:300,&quot;globalTpm&quot;:1800}]</para>
            /// </summary>
            [NameInMap("modelTpmLimits")]
            [Validation(Required=false)]
            public List<GetConsumerAccessOverviewResponseBodyDataModelTpmLimits> ModelTpmLimits { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataModelTpmLimits : TeaModel {
                /// <summary>
                /// <para>The maximum tokens per minute for the current consumer using this model. Returned only when a rule is configured for the consumer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("consumerTpm")]
                [Validation(Required=false)]
                public long? ConsumerTpm { get; set; }

                /// <summary>
                /// <para>The maximum tokens per minute shared by all consumers for this model within the instance. Returned only when a global limit is configured.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1800</para>
                /// </summary>
                [NameInMap("globalTpm")]
                [Validation(Required=false)]
                public long? GlobalTpm { get; set; }

                /// <summary>
                /// <para>The actual model card ID starting with msc- or the logical model ID starting with vm-.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-example01</para>
                /// </summary>
                [NameInMap("modelId")]
                [Validation(Required=false)]
                public string ModelId { get; set; }

            }

            /// <summary>
            /// <para>The quota rules and usage for the consumer and its associated consumer group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;ruleId&quot;:&quot;rule-example01&quot;,&quot;subjectId&quot;:&quot;cs-example01&quot;,&quot;subjectType&quot;:&quot;consumer&quot;,&quot;subjectName&quot;:&quot;team-app&quot;,&quot;name&quot;:&quot;daily-tokens&quot;,&quot;limit&quot;:100000,&quot;used&quot;:1250,&quot;unit&quot;:&quot;Token&quot;,&quot;periodType&quot;:&quot;day&quot;,&quot;windowAlignment&quot;:&quot;calendar&quot;}]</para>
            /// </summary>
            [NameInMap("quotas")]
            [Validation(Required=false)]
            public List<GetConsumerAccessOverviewResponseBodyDataQuotas> Quotas { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataQuotas : TeaModel {
                /// <summary>
                /// <para>The quota limit for the current rule, using the same unit of measurement as the unit field.</para>
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
                /// <para>The used quota within the period corresponding to the current rule, using the same unit of measurement as the unit field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("used")]
                [Validation(Required=false)]
                public double? Used { get; set; }

                /// <summary>
                /// <para>The alignment of the period window. Valid values: calendar for natural periods and epoch for custom base periods.</para>
                /// 
                /// <b>Example:</b>
                /// <para>calendar</para>
                /// </summary>
                [NameInMap("windowAlignment")]
                [Validation(Required=false)]
                public string WindowAlignment { get; set; }

            }

            /// <summary>
            /// <para>The collection of resources for which the consumer has been granted authorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;resourceId&quot;:&quot;api-example01&quot;,&quot;name&quot;:&quot;team-chat&quot;,&quot;resourceType&quot;:&quot;ModelApi&quot;,&quot;models&quot;:[{&quot;modelCardId&quot;:&quot;msc-example01&quot;,&quot;name&quot;:&quot;text-chat&quot;,&quot;modelType&quot;:&quot;Model&quot;,&quot;modelSourceId&quot;:&quot;ms-example01&quot;,&quot;modelSourceName&quot;:&quot;team-model-source&quot;}],&quot;modelGroups&quot;:[]}]</para>
            /// </summary>
            [NameInMap("resources")]
            [Validation(Required=false)]
            public List<GetConsumerAccessOverviewResponseBodyDataResources> Resources { get; set; }
            public class GetConsumerAccessOverviewResponseBodyDataResources : TeaModel {
                /// <summary>
                /// <para>Specifies whether the authorization scope of the resource includes all models.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("allModels")]
                [Validation(Required=false)]
                public bool? AllModels { get; set; }

                /// <summary>
                /// <para>Specifies whether the authorization scope of the MCP resource includes all tools.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// 
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("allTools")]
                [Validation(Required=false)]
                public bool? AllTools { get; set; }

                /// <summary>
                /// <para>The name of the consumer group that grants this authorization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>beta-consumer-group</para>
                /// </summary>
                [NameInMap("consumerGroupName")]
                [Validation(Required=false)]
                public string ConsumerGroupName { get; set; }

                /// <summary>
                /// <para>The existing desired and applied states of the model entitlement projection. Omitted when no state row exists.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;desiredRevision&quot;:2,&quot;appliedRevision&quot;:1,&quot;status&quot;:&quot;Pending&quot;}</para>
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
                    /// <para>The expected authorization revision number to be delivered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("desiredRevision")]
                    [Validation(Required=false)]
                    public long? DesiredRevision { get; set; }

                    /// <summary>
                    /// <para>The error description when processing fails. Empty when no error occurs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Configuration delivery failed</para>
                    /// </summary>
                    [NameInMap("errorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The status of the entitlement delivery. Valid values: Pending, Applying, Committed, and Failed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Committed</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The expiration time. The value is null for long-term authorizations, an RFC 3339 formatted string for short-term authorizations with lossless projection, and omitted when unknown.</para>
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
                /// <para>The accessible model groups and their model collections.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;modelGroupId&quot;:&quot;mg-example01&quot;,&quot;name&quot;:&quot;chat-models&quot;,&quot;models&quot;:[{&quot;modelCardId&quot;:&quot;msc-example01&quot;,&quot;name&quot;:&quot;text-chat&quot;,&quot;modelType&quot;:&quot;Model&quot;,&quot;modelSourceId&quot;:&quot;ms-example01&quot;,&quot;modelSourceName&quot;:&quot;team-model-source&quot;}]}]</para>
                /// </summary>
                [NameInMap("modelGroups")]
                [Validation(Required=false)]
                public List<GetConsumerAccessOverviewResponseBodyDataResourcesModelGroups> ModelGroups { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataResourcesModelGroups : TeaModel {
                    /// <summary>
                    /// <para>The name of the consumer group that grants this authorization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>beta-consumer-group</para>
                    /// </summary>
                    [NameInMap("consumerGroupName")]
                    [Validation(Required=false)]
                    public string ConsumerGroupName { get; set; }

                    /// <summary>
                    /// <para>The model group ID. Use the modelGroupId returned by CreateModelGroup.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mg-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelGroupId")]
                    [Validation(Required=false)]
                    public string ModelGroupId { get; set; }

                    /// <summary>
                    /// <para>The list of accessible model endpoints within the current resource scope.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[{&quot;modelCardId&quot;:&quot;msc-example01&quot;,&quot;name&quot;:&quot;text-chat&quot;,&quot;modelType&quot;:&quot;Model&quot;,&quot;modelSourceId&quot;:&quot;ms-example01&quot;,&quot;modelSourceName&quot;:&quot;team-model-source&quot;}]</para>
                    /// </summary>
                    [NameInMap("models")]
                    [Validation(Required=false)]
                    public List<GetConsumerAccessOverviewResponseBodyDataResourcesModelGroupsModels> Models { get; set; }
                    public class GetConsumerAccessOverviewResponseBodyDataResourcesModelGroupsModels : TeaModel {
                        /// <summary>
                        /// <para>The name of the consumer group that grants this authorization.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>beta-consumer-group</para>
                        /// </summary>
                        [NameInMap("consumerGroupName")]
                        [Validation(Required=false)]
                        public string ConsumerGroupName { get; set; }

                        /// <summary>
                        /// <para>The model identifier. A standard model uses the source model card ID, while a logical model endpoint uses a vm- prefix.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>msc-d00000000000000000000</para>
                        /// </summary>
                        [NameInMap("modelCardId")]
                        [Validation(Required=false)]
                        public string ModelCardId { get; set; }

                        /// <summary>
                        /// <para>The model source ID. Use the modelSourceId returned by CreateAiModelSource.</para>
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
                        /// <para>The model type. Valid values: Model and LogicalModel.</para>
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
                /// <para>The list of accessible model endpoints within the current resource scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;modelCardId&quot;:&quot;msc-example01&quot;,&quot;name&quot;:&quot;text-chat&quot;,&quot;modelType&quot;:&quot;Model&quot;,&quot;modelSourceId&quot;:&quot;ms-example01&quot;,&quot;modelSourceName&quot;:&quot;team-model-source&quot;}]</para>
                /// </summary>
                [NameInMap("models")]
                [Validation(Required=false)]
                public List<GetConsumerAccessOverviewResponseBodyDataResourcesModels> Models { get; set; }
                public class GetConsumerAccessOverviewResponseBodyDataResourcesModels : TeaModel {
                    /// <summary>
                    /// <para>The name of the consumer group that grants this authorization.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>beta-consumer-group</para>
                    /// </summary>
                    [NameInMap("consumerGroupName")]
                    [Validation(Required=false)]
                    public string ConsumerGroupName { get; set; }

                    /// <summary>
                    /// <para>The model identifier. A standard model uses the source model card ID, while a logical model endpoint uses a vm- prefix.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                    /// <summary>
                    /// <para>The model source ID. Use the modelSourceId returned by CreateAiModelSource.</para>
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
                    /// <para>The model type. Valid values: Model and LogicalModel.</para>
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
                /// <para>The resource type. Valid values: ModelApi, MCP, and Agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ModelApi</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The list of MCP tool names that are allowed to be called within the resource scope.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;search&quot;]</para>
                /// </summary>
                [NameInMap("tools")]
                [Validation(Required=false)]
                public List<string> Tools { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message that describes the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request generated by the system to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
