// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetContextStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the associated AgentSpace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The context library configuration.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public GetContextStoreResponseBodyConfig Config { get; set; }
        public class GetContextStoreResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The audit configuration.</para>
            /// </summary>
            [NameInMap("audit")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigAudit Audit { get; set; }
            public class GetContextStoreResponseBodyConfigAudit : TeaModel {
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
            /// <para>The extraction policies. You can configure 1 to 10 policies. The strategyVersion parameter indicates the snapshot version of the entire library configuration.</para>
            /// </summary>
            [NameInMap("extractionPolicies")]
            [Validation(Required=false)]
            public List<GetContextStoreResponseBodyConfigExtractionPolicies> ExtractionPolicies { get; set; }
            public class GetContextStoreResponseBodyConfigExtractionPolicies : TeaModel {
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
                /// <para>Specifies whether to apply this policy to new inputs. Default value: true. Disabling the policy does not delete historical memories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

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
                public GetContextStoreResponseBodyConfigExtractionPoliciesModel Model { get; set; }
                public class GetContextStoreResponseBodyConfigExtractionPoliciesModel : TeaModel {
                    /// <summary>
                    /// <para>The name of the extraction model. Currently, only qwen3.8-flash is supported. Internal platform credentials are used.</para>
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

                [NameInMap("storagePolicy")]
                [Validation(Required=false)]
                public GetContextStoreResponseBodyConfigExtractionPoliciesStoragePolicy StoragePolicy { get; set; }
                public class GetContextStoreResponseBodyConfigExtractionPoliciesStoragePolicy : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>[&quot;ADD&quot;,&quot;UPDATE&quot;,&quot;MERGE&quot;,&quot;DELETE&quot;]</para>
                    /// </summary>
                    [NameInMap("allowedActions")]
                    [Validation(Required=false)]
                    public List<string> AllowedActions { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("dedupe")]
                    [Validation(Required=false)]
                    public bool? Dedupe { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("humanEditProtection")]
                    [Validation(Required=false)]
                    public bool? HumanEditProtection { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>semantic</para>
                    /// </summary>
                    [NameInMap("mergeKey")]
                    [Validation(Required=false)]
                    public string MergeKey { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>upsert</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.4</para>
                    /// </summary>
                    [NameInMap("similarityThreshold")]
                    [Validation(Required=false)]
                    public double? SimilarityThreshold { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ttlDays")]
                    [Validation(Required=false)]
                    public int? TtlDays { get; set; }

                }

                /// <summary>
                /// <para>The stable ID of the extraction policy. The ID must start with a letter and can contain only letters, digits, underscores, and hyphens. It can be up to 64 characters in length. The ID must be unique within the same context library. Modifying the name or instructions does not change this ID.</para>
                /// <para>This parameter is required.</para>
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
            public GetContextStoreResponseBodyConfigExtractionPolicy ExtractionPolicy { get; set; }
            public class GetContextStoreResponseBodyConfigExtractionPolicy : TeaModel {
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
                public GetContextStoreResponseBodyConfigExtractionPolicyModel Model { get; set; }
                public class GetContextStoreResponseBodyConfigExtractionPolicyModel : TeaModel {
                    /// <summary>
                    /// <para>The name of the extraction model. Currently, only qwen3.8-flash is supported. Internal platform credentials are used.</para>
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
            /// <para>The system-assigned coordinates of the event Logstore for the memory type. The Logstore is located in the Simple Log Service (SLS) project bound to the AgentSpace.</para>
            /// </summary>
            [NameInMap("innerSource")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigInnerSource InnerSource { get; set; }
            public class GetContextStoreResponseBodyConfigInnerSource : TeaModel {
                /// <summary>
                /// <para>The name of the event Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory_events_0a1b2c3d</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
                /// <para>The name of the SLS project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agentloop-xxx</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

            }

            /// <summary>
            /// <para>The metadata field mapping. The key is the business field and the value is the storage field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;userId&quot;:&quot;user_id&quot;,&quot;sessionId&quot;:&quot;session_id&quot;}</para>
            /// </summary>
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            /// <summary>
            /// <para>The interval for experience mining. Valid values: 1h, 6h, 12h, and 1d. Default value: 1d.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1d</para>
            /// </summary>
            [NameInMap("miningInterval")]
            [Validation(Required=false)]
            public string MiningInterval { get; set; }

            /// <summary>
            /// <para>The name of the internal running task associated with the server. For continuous libraries, it is used to view consumption records in read-only mode. For manual libraries, it can run limited mining. It is not inferred by the client and cannot replace the ingestion and recall criteria of the native experience library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>experience-review-library</para>
            /// </summary>
            [NameInMap("miningTaskName")]
            [Validation(Required=false)]
            public string MiningTaskName { get; set; }

            /// <summary>
            /// <para>The observability resource coordinates (memory type).</para>
            /// </summary>
            [NameInMap("observability")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigObservability Observability { get; set; }
            public class GetContextStoreResponseBodyConfigObservability : TeaModel {
                /// <summary>
                /// <para>The name of the audit Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory-audit</para>
                /// </summary>
                [NameInMap("auditLogstore")]
                [Validation(Required=false)]
                public string AuditLogstore { get; set; }

                /// <summary>
                /// <para>The name of the event Logstore.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory_events_0a1b2c3d</para>
                /// </summary>
                [NameInMap("eventsLogstore")]
                [Validation(Required=false)]
                public string EventsLogstore { get; set; }

                /// <summary>
                /// <para>The Simple Log Service (SLS) project to which both belong, which is bound to the AgentSpace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agentloop-xxx</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

            }

            /// <summary>
            /// <para>The location of the memory output dataset (memory type).</para>
            /// </summary>
            [NameInMap("outputDataset")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigOutputDataset OutputDataset { get; set; }
            public class GetContextStoreResponseBodyConfigOutputDataset : TeaModel {
                /// <summary>
                /// <para>The AgentSpace to which the dataset belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>The name of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>memory-my-context-store</para>
                /// </summary>
                [NameInMap("datasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// <para>The row schema contract of the dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MemoryRecordV1</para>
                /// </summary>
                [NameInMap("schemaContract")]
                [Validation(Required=false)]
                public string SchemaContract { get; set; }

                /// <summary>
                /// <para>The schema version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("schemaVersion")]
                [Validation(Required=false)]
                public int? SchemaVersion { get; set; }

            }

            /// <summary>
            /// <para>The scope constraint policy.</para>
            /// </summary>
            [NameInMap("scopePolicy")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigScopePolicy ScopePolicy { get; set; }
            public class GetContextStoreResponseBodyConfigScopePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies that at least one of the scope fields must be non-empty. Valid values: userId, agentId, appId, and runId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;userId&quot;]</para>
                /// </summary>
                [NameInMap("requiredAnyOf")]
                [Validation(Required=false)]
                public List<string> RequiredAnyOf { get; set; }

            }

            /// <summary>
            /// <para>The list of service names used to locate the trace data source together with source.agentSpace. This parameter cannot be modified in the current phase.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;order-service&quot;,&quot;payment-service&quot;]</para>
            /// </summary>
            [NameInMap("serviceNames")]
            [Validation(Required=false)]
            public List<string> ServiceNames { get; set; }

            /// <summary>
            /// <para>The data source configuration provided by the user, which serves only as the root identifier of the data source.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigSource Source { get; set; }
            public class GetContextStoreResponseBodyConfigSource : TeaModel {
                /// <summary>
                /// <para>The AgentSpace to which the trace data source belongs, which is the same as the AgentSpace to which it belonged when it was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>The DatasetBinding v1 shared with optimization tasks, which retains fixed column validation, supplementary column usage, and all/window selection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;version&quot;:1,&quot;selection&quot;:{&quot;mode&quot;:&quot;all&quot;}}</para>
                /// </summary>
                [NameInMap("binding")]
                [Validation(Required=false)]
                public Dictionary<string, object> Binding { get; set; }

                /// <summary>
                /// <para>The data source configuration for the memory type dataset. This parameter is required when the type is memory and source.type is dataset.</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public GetContextStoreResponseBodyConfigSourceDataset Dataset { get; set; }
                public class GetContextStoreResponseBodyConfigSourceDataset : TeaModel {
                    /// <summary>
                    /// <para>The list of custom field declarations.</para>
                    /// </summary>
                    [NameInMap("customFields")]
                    [Validation(Required=false)]
                    public List<GetContextStoreResponseBodyConfigSourceDatasetCustomFields> CustomFields { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceDatasetCustomFields : TeaModel {
                        /// <summary>
                        /// <para>The description of the field. This parameter is required when usage is extraction-input and is appended to the extraction prompt.</para>
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
                        /// <para>The target path for writing, such as metadata.customerTier.</para>
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
                    /// <para>The name of the dataset in the same AgentSpace. This parameter cannot be modified after creation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>trajectory-with-crm-profile</para>
                    /// </summary>
                    [NameInMap("datasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    /// <summary>
                    /// <para>The row filter condition.</para>
                    /// </summary>
                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public GetContextStoreResponseBodyConfigSourceDatasetFilter Filter { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceDatasetFilter : TeaModel {
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
                    /// <para>The polling interval in seconds. Valid values: 60 to 3600. Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("pollIntervalSeconds")]
                    [Validation(Required=false)]
                    public int? PollIntervalSeconds { get; set; }

                    /// <summary>
                    /// <para>The row schema contract of the dataset. In the current phase, this parameter is fixed to MemorySourceV1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MemorySourceV1</para>
                    /// </summary>
                    [NameInMap("schemaContract")]
                    [Validation(Required=false)]
                    public string SchemaContract { get; set; }

                    /// <summary>
                    /// <para>The version consumption policy of the dataset.</para>
                    /// </summary>
                    [NameInMap("versionPolicy")]
                    [Validation(Required=false)]
                    public GetContextStoreResponseBodyConfigSourceDatasetVersionPolicy VersionPolicy { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceDatasetVersionPolicy : TeaModel {
                        /// <summary>
                        /// <para>The consumption mode. Valid values: follow (incremental consumption based on __dataset_seq) and fixed (full consumption of the specified ACTIVE version at once).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>follow</para>
                        /// </summary>
                        [NameInMap("mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <para>The starting __dataset_seq for the follow mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("startSeq")]
                        [Validation(Required=false)]
                        public long? StartSeq { get; set; }

                        /// <summary>
                        /// <para>The dataset version specified for the fixed mode.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v3</para>
                        /// </summary>
                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

                /// <summary>
                /// <para>The name of the source dataset for the experience type in the current AgentSpace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reviewed_trajectories</para>
                /// </summary>
                [NameInMap("datasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// <para>The input format of the dataset. For the experience base dataset, the source is atif.</para>
                /// 
                /// <b>Example:</b>
                /// <para>atif</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The maximum number of records to read from the dataset at a time. Valid values: 1 to 1000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("maxRecords")]
                [Validation(Required=false)]
                public int? MaxRecords { get; set; }

                /// <summary>
                /// <para>The start time for data backfill in ISO 8601 UTC format.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The data source configuration for the memory type trajectory. This parameter is required when the type is memory and source.type is trajectory.</para>
                /// </summary>
                [NameInMap("trajectory")]
                [Validation(Required=false)]
                public GetContextStoreResponseBodyConfigSourceTrajectory Trajectory { get; set; }
                public class GetContextStoreResponseBodyConfigSourceTrajectory : TeaModel {
                    /// <summary>
                    /// <para>The trajectory filter condition. Multiple conditions are combined with AND, and conditions within a list are combined with OR.</para>
                    /// </summary>
                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public GetContextStoreResponseBodyConfigSourceTrajectoryFilter Filter { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceTrajectoryFilter : TeaModel {
                        /// <summary>
                        /// <para>The list of agent names. An explicit empty list returns a 400 error.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[&quot;sales-copilot&quot;]</para>
                        /// </summary>
                        [NameInMap("agentNames")]
                        [Validation(Required=false)]
                        public List<string> AgentNames { get; set; }

                        /// <summary>
                        /// <para>Specifies whether to exclude degraded trajectories. Default value: false (includes degraded trajectories).</para>
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
                        /// <para>The native Simple Log Service (SLS) query statement. This statement is combined with the preceding conditions using the AND operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tool_names:&quot;search_order&quot;</para>
                        /// </summary>
                        [NameInMap("query")]
                        [Validation(Required=false)]
                        public string Query { get; set; }

                        /// <summary>
                        /// <para>The list of service names. A single trailing asterisk (*) is supported. An explicit empty list returns a 400 error.</para>
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
                    /// <para>The polling interval in seconds. Valid values: 60 to 3600. Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("pollIntervalSeconds")]
                    [Validation(Required=false)]
                    public int? PollIntervalSeconds { get; set; }

                    /// <summary>
                    /// <para>The scope field mapping. The value is a JSONPath expression. Only the $.a.b and $.a[0] formats are supported.</para>
                    /// </summary>
                    [NameInMap("scopeMapping")]
                    [Validation(Required=false)]
                    public GetContextStoreResponseBodyConfigSourceTrajectoryScopeMapping ScopeMapping { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceTrajectoryScopeMapping : TeaModel {
                        /// <summary>
                        /// <para>The JSONPath expression for agentId. Default value: $.agent_name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.agent_name</para>
                        /// </summary>
                        [NameInMap("agentId")]
                        [Validation(Required=false)]
                        public string AgentId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath expression for appId. Default value: $.service_names[0].</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.service_names[0]</para>
                        /// </summary>
                        [NameInMap("appId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath expression for runId. Default value: $.trajectory_id.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.trajectory_id</para>
                        /// </summary>
                        [NameInMap("runId")]
                        [Validation(Required=false)]
                        public string RunId { get; set; }

                        /// <summary>
                        /// <para>The JSONPath expression for userId. By default, this field is not mapped.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>$.trajectory_extensions.user_id</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
                    /// <para>The start time for trajectory consumption in ISO 8601 UTC format. If not specified, the default value is the creation time.</para>
                    /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-10-01T00:00:00Z</para>
                    /// </summary>
                    [NameInMap("startTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                }

                /// <summary>
                /// <para>The source type, which can be trajectory or dataset. For experience, if not specified, the trajectory configuration is used. For Dataset, the datasetName, format, and binding at the current level are used. The default mode is manual. If versionPolicy.mode is set to follow, continuous processing is performed and automatically applied to the experience library. For memory, if not specified, the mode is manual (only written by AddContexts). Otherwise, the trajectory or dataset sub-configuration with the same name is used. This parameter cannot be modified after creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataset</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The continuous consumption configuration for the native experience library Dataset. The default mode is manual. The follow mode only allows binding.selection.mode to be set to all, and consumes data by append sequence number. This parameter cannot be modified after creation.</para>
                /// </summary>
                [NameInMap("versionPolicy")]
                [Validation(Required=false)]
                public GetContextStoreResponseBodyConfigSourceVersionPolicy VersionPolicy { get; set; }
                public class GetContextStoreResponseBodyConfigSourceVersionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The continuous consumption mode. The value is fixed to follow.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>follow</para>
                    /// </summary>
                    [NameInMap("mode")]
                    [Validation(Required=false)]
                    public string Mode { get; set; }

                    /// <summary>
                    /// <para>The initial consumed append sequence number. The value is a decimal string of a non-negative int64 integer. Default value: 0. The __dataset_seq field is used, and the business timestamp is not used as the consumption checkpoint.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("startSeq")]
                    [Validation(Required=false)]
                    public string StartSeq { get; set; }

                }

            }

            /// <summary>
            /// <para>The running status of the data source, applicable to the memory type and experience Dataset follow mode. The experience library submits a checkpoint only after it is published and automatically applied successfully. Pausing and restarting retain the checkpoint.</para>
            /// </summary>
            [NameInMap("sourceStatus")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigSourceStatus SourceStatus { get; set; }
            public class GetContextStoreResponseBodyConfigSourceStatus : TeaModel {
                /// <summary>
                /// <para>The processing progress. For memory trajectory, the format is {processTimeNs, watermarkMs}. For dataset, the format is {seq}. For manual, the format is {}. For experience Dataset follow, the seq field uses an exact int64 decimal string.</para>
                /// </summary>
                [NameInMap("checkpoint")]
                [Validation(Required=false)]
                public Dictionary<string, object> Checkpoint { get; set; }

                /// <summary>
                /// <para>The current reserved sequence window for experience Dataset follow, in the format of {after, until, runId}. All sequence numbers are decimal strings. If a failure occurs, the submitted checkpoint is not advanced.</para>
                /// </summary>
                [NameInMap("currentWindow")]
                [Validation(Required=false)]
                public Dictionary<string, string> CurrentWindow { get; set; }

                /// <summary>
                /// <para>The last desensitized error message. This field is empty when the status is normal.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data source read timeout</para>
                /// </summary>
                [NameInMap("lastError")]
                [Validation(Required=false)]
                public string LastError { get; set; }

                /// <summary>
                /// <para>The run ID of the last successful automatic application to the native experience library. This field is for audit purposes only.</para>
                /// 
                /// <b>Example:</b>
                /// <para>opr-example</para>
                /// </summary>
                [NameInMap("lastRunId")]
                [Validation(Required=false)]
                public string LastRunId { get; set; }

                /// <summary>
                /// <para>The last window processing time in ISO 8601 UTC format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-10-01T08:00:00Z</para>
                /// </summary>
                [NameInMap("lastWindowAt")]
                [Validation(Required=false)]
                public string LastWindowAt { get; set; }

                /// <summary>
                /// <para>The number of consecutive retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("retryCount")]
                [Validation(Required=false)]
                public int? RetryCount { get; set; }

                /// <summary>
                /// <para>The state of the data source. Valid values: Validating, Ready, Running, Retrying, Paused, SourceSchemaChanged, and Failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            [NameInMap("storageModes")]
            [Validation(Required=false)]
            public List<string> StorageModes { get; set; }

            /// <summary>
            /// <para>The storage policy for the memory type.</para>
            /// </summary>
            [NameInMap("storagePolicy")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigStoragePolicy StoragePolicy { get; set; }
            public class GetContextStoreResponseBodyConfigStoragePolicy : TeaModel {
                /// <summary>
                /// <para>The allowed storage actions. Default value: all actions. Valid values: ADD, UPDATE, MERGE, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;ADD&quot;,&quot;UPDATE&quot;,&quot;MERGE&quot;,&quot;DELETE&quot;]</para>
                /// </summary>
                [NameInMap("allowedActions")]
                [Validation(Required=false)]
                public List<string> AllowedActions { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable deduplication in event mode. Default value: true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("dedupe")]
                [Validation(Required=false)]
                public bool? Dedupe { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable human edit protection. Default value: true. When enabled, automatic extraction does not overwrite manually modified memories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("humanEditProtection")]
                [Validation(Required=false)]
                public bool? HumanEditProtection { get; set; }

                /// <summary>
                /// <para>The merge key for upsert operations. Default value: semantic. Valid values: factKey, semantic, and both.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic</para>
                /// </summary>
                [NameInMap("mergeKey")]
                [Validation(Required=false)]
                public string MergeKey { get; set; }

                /// <summary>
                /// <para>The storage mode. Default value: upsert. Valid values: event (event append) and upsert (merge update).</para>
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
                /// <para>The number of days before memories expire. A value of 0 indicates that memories do not expire.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ttlDays")]
                [Validation(Required=false)]
                public int? TtlDays { get; set; }

            }

            /// <summary>
            /// <para>The currently effective strategy version number for the memory type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("strategyVersion")]
            [Validation(Required=false)]
            public int? StrategyVersion { get; set; }

        }

        /// <summary>
        /// <para>The name of the context store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <para>The type of the context store, such as experience or memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experience</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>The time when the context store was created, in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the context store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My context store</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the region where the context store is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID used to locate the request during troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the context store, such as ACTIVE, INITIALIZING, or FAILED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the context store was last updated, in ISO 8601 UTC format.</para>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-01-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
