// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateContextStoreRequest : TeaModel {
        /// <summary>
        /// <para>The description of the policy change. A new policy version is created when policy fields in the configuration are modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Relax similarity threshold</para>
        /// </summary>
        [NameInMap("changeNote")]
        [Validation(Required=false)]
        public string ChangeNote { get; set; }

        /// <summary>
        /// <para>The context library configuration. If provided, it fully overwrites the existing configuration. If omitted, the original configuration is retained.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public UpdateContextStoreRequestConfig Config { get; set; }
        public class UpdateContextStoreRequestConfig : TeaModel {
            /// <summary>
            /// <para>The audit configuration.</para>
            /// </summary>
            [NameInMap("audit")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigAudit Audit { get; set; }
            public class UpdateContextStoreRequestConfigAudit : TeaModel {
                /// <summary>
                /// <para>Specifies whether to write item events for dropped recall candidates. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("droppedCandidates")]
                [Validation(Required=false)]
                public bool? DroppedCandidates { get; set; }

                /// <summary>
                /// <para>The recording mode for recall queries. Valid values: raw (plaintext) and hash (HMAC only). Default value: raw.</para>
                /// 
                /// <b>Example:</b>
                /// <para>raw</para>
                /// </summary>
                [NameInMap("queryMode")]
                [Validation(Required=false)]
                public string QueryMode { get; set; }

                /// <summary>
                /// <para>The number of days to retain audit logs. Valid values: 1 to 180. Default value: 30.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("retentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

            }

            /// <summary>
            /// <para>The extraction policy for the memory type.</para>
            /// </summary>
            [NameInMap("extractionPolicy")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigExtractionPolicy ExtractionPolicy { get; set; }
            public class UpdateContextStoreRequestConfigExtractionPolicy : TeaModel {
                /// <summary>
                /// <para>The list of memory categories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;preference&quot;,&quot;profile&quot;]</para>
                /// </summary>
                [NameInMap("categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                /// <summary>
                /// <para>The custom extraction instructions. This parameter is required when preset is set to custom. Length: 1 to 8000 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Extract only user product preferences</para>
                /// </summary>
                [NameInMap("customInstructions")]
                [Validation(Required=false)]
                public string CustomInstructions { get; set; }

                /// <summary>
                /// <para>The list of exclusion rules. Content that matches these rules is not extracted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;Password&quot;,&quot;ID number&quot;]</para>
                /// </summary>
                [NameInMap("excludeRules")]
                [Validation(Required=false)]
                public List<string> ExcludeRules { get; set; }

                /// <summary>
                /// <para>The extraction model configuration.</para>
                /// </summary>
                [NameInMap("model")]
                [Validation(Required=false)]
                public UpdateContextStoreRequestConfigExtractionPolicyModel Model { get; set; }
                public class UpdateContextStoreRequestConfigExtractionPolicyModel : TeaModel {
                    /// <summary>
                    /// <para>The name of the extraction model. Currently, only qwen3.8-flash is supported, which uses internal platform credentials.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen3.8-flash</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The preset policy. Valid values: fact, toc-profile, tob-digital-twin, and custom. Default value: fact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fact</para>
                /// </summary>
                [NameInMap("preset")]
                [Validation(Required=false)]
                public string Preset { get; set; }

            }

            /// <summary>
            /// <para>The metadata field mapping. The key is the business field, and the value is the storage field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;userId&quot;:&quot;user_id&quot;,&quot;sessionId&quot;:&quot;session_id&quot;}</para>
            /// </summary>
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            /// <summary>
            /// <para>The scope constraint policy.</para>
            /// </summary>
            [NameInMap("scopePolicy")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigScopePolicy ScopePolicy { get; set; }
            public class UpdateContextStoreRequestConfigScopePolicy : TeaModel {
                /// <summary>
                /// <para>The list of scope fields where at least one must be non-empty. Valid element values: userId, agentId, appId, and runId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;userId&quot;]</para>
                /// </summary>
                [NameInMap("requiredAnyOf")]
                [Validation(Required=false)]
                public List<string> RequiredAnyOf { get; set; }

            }

            /// <summary>
            /// <para>The datasource config, which serves only as the root identity for the data source.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigSource Source { get; set; }
            public class UpdateContextStoreRequestConfigSource : TeaModel {
                /// <summary>
                /// <para>The AgentSpace where the trace data source is located. Cross-AgentSpace is not supported in the current phase. If provided, it must be equal to the path AgentSpace. Otherwise, a 400 parameter error is returned. The AgentSpace cannot be changed after creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>The updatable items for the Dataset data source. The datasetName cannot be changed after creation.</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public UpdateContextStoreRequestConfigSourceDataset Dataset { get; set; }
                public class UpdateContextStoreRequestConfigSourceDataset : TeaModel {
                    /// <summary>
                    /// <para>The list of custom field declarations. If provided, it fully overwrites the existing declarations.</para>
                    /// </summary>
                    [NameInMap("customFields")]
                    [Validation(Required=false)]
                    public List<UpdateContextStoreRequestConfigSourceDatasetCustomFields> CustomFields { get; set; }
                    public class UpdateContextStoreRequestConfigSourceDatasetCustomFields : TeaModel {
                        /// <summary>
                        /// <para>The description of the field. This parameter is required when usage is set to extraction-input.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Customer tier</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the field is a sensitive field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("sensitive")]
                        [Validation(Required=false)]
                        public bool? Sensitive { get; set; }

                        /// <summary>
                        /// <para>The name of the source field.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>customerTier</para>
                        /// </summary>
                        [NameInMap("sourceField")]
                        [Validation(Required=false)]
                        public string SourceField { get; set; }

                        /// <summary>
                        /// <para>The target write path, such as metadata.customerTier.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>metadata.customerTier</para>
                        /// </summary>
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public string Target { get; set; }

                        /// <summary>
                        /// <para>The usage of the field. Valid values: extraction-input (participates in extraction) and ignore (ignored).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>extraction-input</para>
                        /// </summary>
                        [NameInMap("usage")]
                        [Validation(Required=false)]
                        public string Usage { get; set; }

                    }

                    /// <summary>
                    /// <para>The row filter conditions.</para>
                    /// </summary>
                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public UpdateContextStoreRequestConfigSourceDatasetFilter Filter { get; set; }
                    public class UpdateContextStoreRequestConfigSourceDatasetFilter : TeaModel {
                        /// <summary>
                        /// <para>The subset of the Pipeline where clause, which is pushed down to SQL.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>appId = \&quot;crm-service\&quot;</para>
                        /// </summary>
                        [NameInMap("where")]
                        [Validation(Required=false)]
                        public string Where { get; set; }

                    }

                    /// <summary>
                    /// <para>The polling interval in seconds. Valid values: 60 to 3600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("pollIntervalSeconds")]
                    [Validation(Required=false)]
                    public int? PollIntervalSeconds { get; set; }

                }

                /// <summary>
                /// <para>The start time for data backfill, in ISO 8601 UTC format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The updatable items for the trajectory data source. The source.type cannot be changed after creation.</para>
                /// </summary>
                [NameInMap("trajectory")]
                [Validation(Required=false)]
                public UpdateContextStoreRequestConfigSourceTrajectory Trajectory { get; set; }
                public class UpdateContextStoreRequestConfigSourceTrajectory : TeaModel {
                    /// <summary>
                    /// <para>The trajectory filter conditions. Conditions are combined with AND, while items within a list are combined with OR.</para>
                    /// </summary>
                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public UpdateContextStoreRequestConfigSourceTrajectoryFilter Filter { get; set; }
                    public class UpdateContextStoreRequestConfigSourceTrajectoryFilter : TeaModel {
                        /// <summary>
                        /// <para>The list of agent names. An explicitly empty list returns a 400 error.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;sales-copilot&quot;]</para>
                        /// </summary>
                        [NameInMap("agentNames")]
                        [Validation(Required=false)]
                        public List<string> AgentNames { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to exclude degraded trajectories. Default value: false (degraded trajectories are included).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("excludeDegraded")]
                        [Validation(Required=false)]
                        public bool? ExcludeDegraded { get; set; }

                        /// <summary>
                        /// <para>The minimum number of steps, which must be greater than or equal to 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("minStepCount")]
                        [Validation(Required=false)]
                        public int? MinStepCount { get; set; }

                        /// <summary>
                        /// <para>The native SLS query statement. This statement is combined with the preceding conditions by using the AND operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tool_names:&quot;search_order&quot;</para>
                        /// </summary>
                        [NameInMap("query")]
                        [Validation(Required=false)]
                        public string Query { get; set; }

                        /// <summary>
                        /// <para>The list of service names. A single trailing asterisk (*) is supported. Specifying an explicitly empty list returns a 400 error.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;crm-service&quot;,&quot;app-*&quot;]</para>
                        /// </summary>
                        [NameInMap("serviceNames")]
                        [Validation(Required=false)]
                        public List<string> ServiceNames { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the trajectory Logstore. Default value: agent-trajectory. This parameter cannot be modified after creation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent-trajectory</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The polling interval in seconds. Valid values: 60 to 3600.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("pollIntervalSeconds")]
                    [Validation(Required=false)]
                    public int? PollIntervalSeconds { get; set; }

                    /// <summary>
                    /// <para>The scope field mapping. The value must be a JSONPath expression. Only the $.a.b and $.a[0] formats are supported.</para>
                    /// </summary>
                    [NameInMap("scopeMapping")]
                    [Validation(Required=false)]
                    public UpdateContextStoreRequestConfigSourceTrajectoryScopeMapping ScopeMapping { get; set; }
                    public class UpdateContextStoreRequestConfigSourceTrajectoryScopeMapping : TeaModel {
                        /// <summary>
                        /// <para>The JSONPath expression for the agentId field. Default value: $.agent_name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.agent_name</para>
                        /// </summary>
                        [NameInMap("agentId")]
                        [Validation(Required=false)]
                        public string AgentId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath expression for the appId field. Default value: $.service_names[0].</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.service_names[0]</para>
                        /// </summary>
                        [NameInMap("appId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath expression for the runId field. Default value: $.trajectory_id.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.trajectory_id</para>
                        /// </summary>
                        [NameInMap("runId")]
                        [Validation(Required=false)]
                        public string RunId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath expression for the userId field. By default, this field is not mapped.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.trajectory_extensions.user_id</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                }

            }

            /// <summary>
            /// <para>The storage policy for the memory type.</para>
            /// </summary>
            [NameInMap("storagePolicy")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigStoragePolicy StoragePolicy { get; set; }
            public class UpdateContextStoreRequestConfigStoragePolicy : TeaModel {
                /// <summary>
                /// <para>The allowed storage actions. By default, all actions are allowed: ADD, UPDATE, MERGE, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ADD&quot;,&quot;UPDATE&quot;,&quot;MERGE&quot;,&quot;DELETE&quot;]</para>
                /// </summary>
                [NameInMap("allowedActions")]
                [Validation(Required=false)]
                public List<string> AllowedActions { get; set; }

                /// <summary>
                /// <para>Specifies whether to deduplicate events in event mode. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("dedupe")]
                [Validation(Required=false)]
                public bool? Dedupe { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable human edit protection. Default value: true. When this feature is enabled, automatic extraction does not overwrite manually modified memories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("humanEditProtection")]
                [Validation(Required=false)]
                public bool? HumanEditProtection { get; set; }

                /// <summary>
                /// <para>The merge key for upsert operations. Valid values: factKey, semantic, and both. Default value: semantic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic</para>
                /// </summary>
                [NameInMap("mergeKey")]
                [Validation(Required=false)]
                public string MergeKey { get; set; }

                /// <summary>
                /// <para>The storage mode. Valid values: event (append events) and upsert (merge and update). Default value: upsert.</para>
                /// 
                /// <b>Example:</b>
                /// <para>upsert</para>
                /// </summary>
                [NameInMap("mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <para>The similarity threshold for semantic merging. Valid values: 0 to 1. Default value: 0.4.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.4</para>
                /// </summary>
                [NameInMap("similarityThreshold")]
                [Validation(Required=false)]
                public double? SimilarityThreshold { get; set; }

                /// <summary>
                /// <para>The number of days before the memory expires. A value of 0 indicates that the memory never expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ttlDays")]
                [Validation(Required=false)]
                public int? TtlDays { get; set; }

            }

        }

        /// <summary>
        /// <para>The context library type. This field is typically immutable after creation and is provided only for exception correction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experience</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>The description of the context library, which helps business users understand its purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My context library</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The running status. For the memory type, valid values are Active (running) and Paused (data source consumption and extraction paused). For the experience type, it indicates the mining status of the experience library. The specific valid values and combination constraints are defined by the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The idempotency token. It is a unique string generated by the client to ensure the idempotence of the update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
