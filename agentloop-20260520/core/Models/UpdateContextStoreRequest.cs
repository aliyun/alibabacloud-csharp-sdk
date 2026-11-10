// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateContextStoreRequest : TeaModel {
        /// <summary>
        /// <para>The description of the policy change. A new policy version is written when a policy field in the config changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Relax the similarity threshold</para>
        /// </summary>
        [NameInMap("changeNote")]
        [Validation(Required=false)]
        public string ChangeNote { get; set; }

        /// <summary>
        /// <para>The context library configuration. If passed, the configuration is completely overwritten. If not passed, the original configuration is retained.</para>
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
                /// <para>Specifies whether to write item events for dropped candidates during retrieval. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("droppedCandidates")]
                [Validation(Required=false)]
                public bool? DroppedCandidates { get; set; }

                /// <summary>
                /// <para>The method used to record retrieved queries. Valid values: raw (plaintext) and hash (HMAC only). Default value: raw.</para>
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
            /// <para>The list of extraction policies. You can specify 1 to 10 policies. During an update, compatible fields returned as-is are ignored. The strategyVersion parameter indicates the snapshot version of the entire database configuration.</para>
            /// </summary>
            [NameInMap("extractionPolicies")]
            [Validation(Required=false)]
            public List<UpdateContextStoreRequestConfigExtractionPolicies> ExtractionPolicies { get; set; }
            public class UpdateContextStoreRequestConfigExtractionPolicies : TeaModel {
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
                /// <para>The custom extraction instructions. This parameter is required when preset is set to custom. The length must be 1 to 8,000 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Extract only user product preferences</para>
                /// </summary>
                [NameInMap("customInstructions")]
                [Validation(Required=false)]
                public string CustomInstructions { get; set; }

                /// <summary>
                /// <para>Specifies whether to execute this policy for new input. Default value: true. Disabling the policy does not delete historical memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

                /// <summary>
                /// <para>The list of exclude rules. Content that matches these rules is not extracted.</para>
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
                public UpdateContextStoreRequestConfigExtractionPoliciesModel Model { get; set; }
                public class UpdateContextStoreRequestConfigExtractionPoliciesModel : TeaModel {
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
                /// <para>The display name of the extraction policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>User preferences</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The preset policy. Valid values: fact, toc-profile, tob-digital-twin, and custom. Default value: fact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fact</para>
                /// </summary>
                [NameInMap("preset")]
                [Validation(Required=false)]
                public string Preset { get; set; }

                /// <summary>
                /// <para>The independent storage rules for this policy. If omitted, the original value is retained. New policies use the default value. Repeatedly confirmed memory refreshes the validity period by default.</para>
                /// </summary>
                [NameInMap("storagePolicy")]
                [Validation(Required=false)]
                public UpdateContextStoreRequestConfigExtractionPoliciesStoragePolicy StoragePolicy { get; set; }
                public class UpdateContextStoreRequestConfigExtractionPoliciesStoragePolicy : TeaModel {
                    /// <summary>
                    /// <para>The allowed storage actions. Default value: all actions (ADD, UPDATE, MERGE, and DELETE).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[&quot;ADD&quot;,&quot;UPDATE&quot;,&quot;MERGE&quot;,&quot;DELETE&quot;]</para>
                    /// </summary>
                    [NameInMap("allowedActions")]
                    [Validation(Required=false)]
                    public List<string> AllowedActions { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to deduplicate data in event mode. Default value: true.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("dedupe")]
                    [Validation(Required=false)]
                    public bool? Dedupe { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable human edit protection. Default value: true. When enabled, automatic extraction does not overwrite manually modified memory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("humanEditProtection")]
                    [Validation(Required=false)]
                    public bool? HumanEditProtection { get; set; }

                    /// <summary>
                    /// <para>The merge key for the upsert mode. Valid values: factKey, semantic, and both. Default value: semantic.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>semantic</para>
                    /// </summary>
                    [NameInMap("mergeKey")]
                    [Validation(Required=false)]
                    public string MergeKey { get; set; }

                    /// <summary>
                    /// <para>The storage mode. Valid values: event (event append) and upsert (merge and update). Default value: upsert.</para>
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
                    /// <para>The number of days before memory expires. A value of 0 indicates that the memory does not expire.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ttlDays")]
                    [Validation(Required=false)]
                    public int? TtlDays { get; set; }

                }

                /// <summary>
                /// <para>The ID of the extraction policy. This parameter is optional. If omitted, the default value is used. The ID must start with a letter and can contain only letters, digits, underscores, and hyphens. It can be up to 64 characters in length. After default processing, the ID must be unique within the same database. Modifying the name or instructions does not change this ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>preferences</para>
                /// </summary>
                [NameInMap("strategyId")]
                [Validation(Required=false)]
                public string StrategyId { get; set; }

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
                /// <para>The custom extraction instructions. This parameter is required when preset is set to custom. The length must be 1 to 8,000 characters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Extract only user product preferences</para>
                /// </summary>
                [NameInMap("customInstructions")]
                [Validation(Required=false)]
                public string CustomInstructions { get; set; }

                /// <summary>
                /// <para>The list of exclude rules. Content that matches these rules is not extracted.</para>
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
            /// <para>The metadata field mapping, where the key is the business field and the value is the storage field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;userId&quot;:&quot;user_id&quot;,&quot;sessionId&quot;:&quot;session_id&quot;}</para>
            /// </summary>
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            /// <summary>
            /// <para>Specifies whether the experience library allows runtime recall. When modifying this property, you must pass expectedRuntimeRecallRevision and submit only this property in the config.</para>
            /// </summary>
            [NameInMap("runtimeRecallEnabled")]
            [Validation(Required=false)]
            public bool? RuntimeRecallEnabled { get; set; }

            /// <summary>
            /// <para>The scope constraint policy.</para>
            /// </summary>
            [NameInMap("scopePolicy")]
            [Validation(Required=false)]
            public UpdateContextStoreRequestConfigScopePolicy ScopePolicy { get; set; }
            public class UpdateContextStoreRequestConfigScopePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies that at least one scope field must be non-empty. Valid values: userId, agentId, appId, and runId.</para>
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
                /// <para>The AgentSpace where the trace data source is located. Cross-AgentSpace is not supported in the current phase. If passed, it must be equal to the path AgentSpace. Otherwise, a 400 parameter error is returned. The AgentSpace cannot be changed after creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>The updatable items of the dataset data source. The datasetName cannot be changed after creation.</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public UpdateContextStoreRequestConfigSourceDataset Dataset { get; set; }
                public class UpdateContextStoreRequestConfigSourceDataset : TeaModel {
                    /// <summary>
                    /// <para>The list of custom field declarations. If passed, the list is completely overwritten.</para>
                    /// </summary>
                    [NameInMap("customFields")]
                    [Validation(Required=false)]
                    public List<UpdateContextStoreRequestConfigSourceDatasetCustomFields> CustomFields { get; set; }
                    public class UpdateContextStoreRequestConfigSourceDatasetCustomFields : TeaModel {
                        /// <summary>
                        /// <para>The field description. This parameter is required when usage is set to extraction-input.</para>
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
                        /// <para>The source field name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>customerTier</para>
                        /// </summary>
                        [NameInMap("sourceField")]
                        [Validation(Required=false)]
                        public string SourceField { get; set; }

                        /// <summary>
                        /// <para>The write target path, such as metadata.customerTier.</para>
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
                        /// <para>The subset of the pipeline where clause, which is pushed down to SQL.</para>
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
                /// <para>The data backfill start time in ISO 8601 UTC format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The updatable items of the trajectory data source. The source.type cannot be changed after creation.</para>
                /// </summary>
                [NameInMap("trajectory")]
                [Validation(Required=false)]
                public UpdateContextStoreRequestConfigSourceTrajectory Trajectory { get; set; }
                public class UpdateContextStoreRequestConfigSourceTrajectory : TeaModel {
                    /// <summary>
                    /// <para>The trajectory filter conditions. Conditions are combined with AND, and items within a list are combined with OR.</para>
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
                        /// <para>Specifies whether to exclude degraded trajectories. Default value: false, which includes degraded trajectories.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("excludeDegraded")]
                        [Validation(Required=false)]
                        public bool? ExcludeDegraded { get; set; }

                        /// <summary>
                        /// <para>The minimum step count, which must be greater than or equal to 0.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("minStepCount")]
                        [Validation(Required=false)]
                        public int? MinStepCount { get; set; }

                        /// <summary>
                        /// <para>The native Simple Log Service (SLS) query statement, which is combined with the preceding conditions using AND.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tool_names:&quot;search_order&quot;</para>
                        /// </summary>
                        [NameInMap("query")]
                        [Validation(Required=false)]
                        public string Query { get; set; }

                        /// <summary>
                        /// <para>The list of service names. A single trailing asterisk (*) is supported. An explicitly empty list returns a 400 error.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;crm-service&quot;,&quot;app-*&quot;]</para>
                        /// </summary>
                        [NameInMap("serviceNames")]
                        [Validation(Required=false)]
                        public List<string> ServiceNames { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the trajectory Logstore. Default value: agent-trajectory. It cannot be changed after creation.</para>
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
                    /// <para>The scope field mapping. Dot paths, array indices, and quoted property keys are supported. An empty string indicates no mapping.</para>
                    /// </summary>
                    [NameInMap("scopeMapping")]
                    [Validation(Required=false)]
                    public UpdateContextStoreRequestConfigSourceTrajectoryScopeMapping ScopeMapping { get; set; }
                    public class UpdateContextStoreRequestConfigSourceTrajectoryScopeMapping : TeaModel {
                        /// <summary>
                        /// <para>The JSONPath for agentId. Default value: $.agent_name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.agent_name</para>
                        /// </summary>
                        [NameInMap("agentId")]
                        [Validation(Required=false)]
                        public string AgentId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath for appId. Default value: $.service_names[0].</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.service_names[0]</para>
                        /// </summary>
                        [NameInMap("appId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath for runId. It is not mapped by default to avoid isolating memory by a single trajectory.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.trajectory_id</para>
                        /// </summary>
                        [NameInMap("runId")]
                        [Validation(Required=false)]
                        public string RunId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath for userId. In version 1, it is not mapped by default. In version 2, it defaults to user.id and then enduser.id from agent attributes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.trajectory_extensions.user_id</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// <para>The default mapping version for trajectory identity. Version 1 retains the old rules. Version 2 reads user.id or enduser.id from agent attributes. The version is frozen upon creation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("scopeMappingVersion")]
                    [Validation(Required=false)]
                    public int? ScopeMappingVersion { get; set; }

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
                /// <para>The allowed storage actions. Default value: all actions (ADD, UPDATE, MERGE, and DELETE).</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ADD&quot;,&quot;UPDATE&quot;,&quot;MERGE&quot;,&quot;DELETE&quot;]</para>
                /// </summary>
                [NameInMap("allowedActions")]
                [Validation(Required=false)]
                public List<string> AllowedActions { get; set; }

                /// <summary>
                /// <para>Specifies whether to deduplicate data in event mode. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("dedupe")]
                [Validation(Required=false)]
                public bool? Dedupe { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable human edit protection. Default value: true. When enabled, automatic extraction does not overwrite manually modified memory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("humanEditProtection")]
                [Validation(Required=false)]
                public bool? HumanEditProtection { get; set; }

                /// <summary>
                /// <para>The merge key for the upsert mode. Valid values: factKey, semantic, and both. Default value: semantic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic</para>
                /// </summary>
                [NameInMap("mergeKey")]
                [Validation(Required=false)]
                public string MergeKey { get; set; }

                /// <summary>
                /// <para>The storage mode. Valid values: event (event append) and upsert (merge and update). Default value: upsert.</para>
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
                /// <para>The number of days before memory expires. A value of 0 indicates that the memory does not expire.</para>
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
        /// <para>The description of the context store, which helps business users understand its purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My context store</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Required when modifying the runtime recall switch. The value must be equal to the config.runtimeRecallRevision value returned by GetContextStore. A 409 error is returned if a conflict occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expectedRuntimeRecallRevision")]
        [Validation(Required=false)]
        public long? ExpectedRuntimeRecallRevision { get; set; }

        /// <summary>
        /// <para>The audit reason for modifying the runtime recall switch. The maximum length is 2,000 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Suspend runtime recall while adjusting experience content</para>
        /// </summary>
        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The running status. Valid values: Active and Paused. For the memory type, Paused suspends data source reading and extraction. For the experience Dataset follow type, Paused retains committed and in-flight checkpoints, and resuming continues to process new records without skipping history from the current time. You do not need to pass back the source parameter if you only update the status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The idempotency token. This is a unique string generated by the client to ensure the idempotence of the update operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
