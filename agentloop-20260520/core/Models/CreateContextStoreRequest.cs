// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateContextStoreRequest : TeaModel {
        /// <summary>
        /// <para>The context library configuration, including data sources and metadata field mappings.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public CreateContextStoreRequestConfig Config { get; set; }
        public class CreateContextStoreRequestConfig : TeaModel {
            /// <summary>
            /// <para>The audit configuration.</para>
            /// </summary>
            [NameInMap("audit")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigAudit Audit { get; set; }
            public class CreateContextStoreRequestConfigAudit : TeaModel {
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
                /// <para>The logging mode for recall queries. Valid values: raw (plaintext) and hash (HMAC only). Default value: raw.</para>
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
            /// <para>The extraction policies. You can specify 1 to 10 policies. In a request, you can specify either this field or the compatible extractionPolicy field, but not both. The strategyVersion parameter indicates the snapshot version of the entire library configuration.</para>
            /// </summary>
            [NameInMap("extractionPolicies")]
            [Validation(Required=false)]
            public List<CreateContextStoreRequestConfigExtractionPolicies> ExtractionPolicies { get; set; }
            public class CreateContextStoreRequestConfigExtractionPolicies : TeaModel {
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
                /// <para>Specifies whether to execute this policy for new inputs. Default value: true. Disabling the policy does not delete historical memories.</para>
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
                public CreateContextStoreRequestConfigExtractionPoliciesModel Model { get; set; }
                public class CreateContextStoreRequestConfigExtractionPoliciesModel : TeaModel {
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

                [NameInMap("storagePolicy")]
                [Validation(Required=false)]
                public CreateContextStoreRequestConfigExtractionPoliciesStoragePolicy StoragePolicy { get; set; }
                public class CreateContextStoreRequestConfigExtractionPoliciesStoragePolicy : TeaModel {
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
                /// <para>The ID of the extraction policy. This parameter is optional. If omitted, the default value is used. The ID must start with a letter and can contain only letters, digits, underscores, and hyphens. The maximum length is 64 characters. After default value processing, the ID must be unique within the same library. Modifying the name or instructions does not change this ID.</para>
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
            public CreateContextStoreRequestConfigExtractionPolicy ExtractionPolicy { get; set; }
            public class CreateContextStoreRequestConfigExtractionPolicy : TeaModel {
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
                public CreateContextStoreRequestConfigExtractionPolicyModel Model { get; set; }
                public class CreateContextStoreRequestConfigExtractionPolicyModel : TeaModel {
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
            /// <para>The metadata field mapping. The key is the business field and the value is the storage field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;userId&quot;:&quot;user_id&quot;,&quot;sessionId&quot;:&quot;session_id&quot;}</para>
            /// </summary>
            [NameInMap("metadataField")]
            [Validation(Required=false)]
            public Dictionary<string, string> MetadataField { get; set; }

            /// <summary>
            /// <para>The experience mining interval, which controls how often experience mining is executed. Valid values: 1h, 6h, 12h, and 1d. Default value: 1d. This parameter cannot be modified after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1d</para>
            /// </summary>
            [NameInMap("miningInterval")]
            [Validation(Required=false)]
            public string MiningInterval { get; set; }

            /// <summary>
            /// <para>The scope constraint policy.</para>
            /// </summary>
            [NameInMap("scopePolicy")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigScopePolicy ScopePolicy { get; set; }
            public class CreateContextStoreRequestConfigScopePolicy : TeaModel {
                /// <summary>
                /// <para>Specifies that at least one of the specified scope fields must be non-empty. Valid values for elements: userId, agentId, appId, and runId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;userId&quot;]</para>
                /// </summary>
                [NameInMap("requiredAnyOf")]
                [Validation(Required=false)]
                public List<string> RequiredAnyOf { get; set; }

            }

            /// <summary>
            /// <para>The list of service names. This parameter is required and cannot be empty. It works with source.agentSpace to locate the trace data source. The trajectory extraction service uses agentSpace to query the bound CMS workspace and project or logstore, and then filters by serviceName. This parameter cannot be modified after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;order-service&quot;,&quot;payment-service&quot;]</para>
            /// </summary>
            [NameInMap("serviceNames")]
            [Validation(Required=false)]
            public List<string> ServiceNames { get; set; }

            /// <summary>
            /// <para>The data source configuration, which serves only as the root identifier for the data source. This block is optional.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigSource Source { get; set; }
            public class CreateContextStoreRequestConfigSource : TeaModel {
                /// <summary>
                /// <para>The AgentSpace where the trace data source is located. If not specified, the default value is the AgentSpace in the current path. Cross-AgentSpace operations are not supported in the current phase. If specified, the value must be identical to the path AgentSpace. Otherwise, a 400 parameter error is returned. This parameter cannot be modified after creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <para>The DatasetBinding v1 configuration shared with optimization tasks. It includes version, selection (all/window and structured filters), and customFields. It is validated by the server and does not accept SQL or column mappings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;version&quot;:1,&quot;selection&quot;:{&quot;mode&quot;:&quot;all&quot;}}</para>
                /// </summary>
                [NameInMap("binding")]
                [Validation(Required=false)]
                public Dictionary<string, object> Binding { get; set; }

                /// <summary>
                /// <para>The Dataset data source configuration. This parameter is required when source.type is set to dataset.</para>
                /// </summary>
                [NameInMap("dataset")]
                [Validation(Required=false)]
                public CreateContextStoreRequestConfigSourceDataset Dataset { get; set; }
                public class CreateContextStoreRequestConfigSourceDataset : TeaModel {
                    /// <summary>
                    /// <para>The list of custom field declarations.</para>
                    /// </summary>
                    [NameInMap("customFields")]
                    [Validation(Required=false)]
                    public List<CreateContextStoreRequestConfigSourceDatasetCustomFields> CustomFields { get; set; }
                    public class CreateContextStoreRequestConfigSourceDatasetCustomFields : TeaModel {
                        /// <summary>
                        /// <para>The field description. This parameter is required when usage is set to extraction-input and is appended to the extraction prompt.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Customer tier</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>Specifies whether the field is sensitive.</para>
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
                        /// <para>The target path for writing data, such as metadata.customerTier.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>metadata.customerTier</para>
                        /// </summary>
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public string Target { get; set; }

                        /// <summary>
                        /// <para>The usage of the field. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>extraction-input: Participates in extraction.</description></item>
                        /// <item><description>ignore: Ignored.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>extraction-input</para>
                        /// </summary>
                        [NameInMap("usage")]
                        [Validation(Required=false)]
                        public string Usage { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the Dataset in the same AgentSpace. This parameter cannot be modified after creation.</para>
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
                    public CreateContextStoreRequestConfigSourceDatasetFilter Filter { get; set; }
                    public class CreateContextStoreRequestConfigSourceDatasetFilter : TeaModel {
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
                    /// <para>The polling interval in seconds. Valid values: 60 to 3600. Default value: 300.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("pollIntervalSeconds")]
                    [Validation(Required=false)]
                    public int? PollIntervalSeconds { get; set; }

                    /// <summary>
                    /// <para>The row schema contract for the Dataset. The value is fixed to MemorySourceV1 in the current phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MemorySourceV1</para>
                    /// </summary>
                    [NameInMap("schemaContract")]
                    [Validation(Required=false)]
                    public string SchemaContract { get; set; }

                    /// <summary>
                    /// <para>The version consumption policy for the Dataset.</para>
                    /// </summary>
                    [NameInMap("versionPolicy")]
                    [Validation(Required=false)]
                    public CreateContextStoreRequestConfigSourceDatasetVersionPolicy VersionPolicy { get; set; }
                    public class CreateContextStoreRequestConfigSourceDatasetVersionPolicy : TeaModel {
                        /// <summary>
                        /// <para>The consumption mode. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>follow: Consumes data incrementally based on __dataset_seq.</description></item>
                        /// <item><description>fixed: Consumes the specified ACTIVE version in full once.</description></item>
                        /// </list>
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
                        /// <para>The Dataset version specified for the fixed mode.</para>
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
                /// <para>The source name of the experience Dataset, which must be located in the current AgentSpace. This parameter is provided only when the type is experience and source.type is set to dataset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reviewed_trajectories</para>
                /// </summary>
                [NameInMap("datasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// <para>The input format of the Dataset. For experience library Dataset sources, only atif is supported, and the fixed columns are consistent with those of optimization tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>atif</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                /// <summary>
                /// <para>The maximum number of Dataset records to read per batch. Valid values: 1 to 1000. Default value: 1000. In manual mode, exceeding the limit causes a failure. In follow mode, bounded pagination is used to continue consumption.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("maxRecords")]
                [Validation(Required=false)]
                public int? MaxRecords { get; set; }

                /// <summary>
                /// <para>The start time for data backfill in ISO 8601 UTC format. If this parameter is not specified, the current time is used.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The trajectory data source configuration. This parameter is required when source.type is set to trajectory.</para>
                /// </summary>
                [NameInMap("trajectory")]
                [Validation(Required=false)]
                public CreateContextStoreRequestConfigSourceTrajectory Trajectory { get; set; }
                public class CreateContextStoreRequestConfigSourceTrajectory : TeaModel {
                    /// <summary>
                    /// <para>The trajectory filter condition. Conditions are combined with AND, and items within a list are combined with OR.</para>
                    /// </summary>
                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public CreateContextStoreRequestConfigSourceTrajectoryFilter Filter { get; set; }
                    public class CreateContextStoreRequestConfigSourceTrajectoryFilter : TeaModel {
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
                        /// <para>The minimum number of steps. The value must be greater than or equal to 0.</para>
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
                    public CreateContextStoreRequestConfigSourceTrajectoryScopeMapping ScopeMapping { get; set; }
                    public class CreateContextStoreRequestConfigSourceTrajectoryScopeMapping : TeaModel {
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
                    /// <para>The start time for trajectory consumption in ISO 8601 UTC format. If this parameter is not specified, the creation time is used by default.</para>
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
                /// <para>The data source type for the memory type. Valid values: trajectory, dataset. If this parameter is not specified, the default value is manual, which means data is written only through AddContexts. This parameter cannot be modified after creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>trajectory</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The continuous consumption configuration for the native experience dataset. The default value is manual. The follow mode is allowed only when binding.selection.mode is set to all. In this mode, data is consumed by append sequence number. This configuration cannot be modified after creation.</para>
                /// </summary>
                [NameInMap("versionPolicy")]
                [Validation(Required=false)]
                public CreateContextStoreRequestConfigSourceVersionPolicy VersionPolicy { get; set; }
                public class CreateContextStoreRequestConfigSourceVersionPolicy : TeaModel {
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
            /// <para>The storage policy for the memory type.</para>
            /// </summary>
            [NameInMap("storagePolicy")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigStoragePolicy StoragePolicy { get; set; }
            public class CreateContextStoreRequestConfigStoragePolicy : TeaModel {
                /// <summary>
                /// <para>The allowed storage actions. Default value: all. Valid values: ADD, UPDATE, MERGE, DELETE.</para>
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
                /// <para>Specifies whether to enable manual edit protection. Default value: true. If this feature is enabled, automatic extraction does not overwrite manually modified memories.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("humanEditProtection")]
                [Validation(Required=false)]
                public bool? HumanEditProtection { get; set; }

                /// <summary>
                /// <para>The merge key for upsert operations. Default value: semantic. Valid values: factKey, semantic, both.</para>
                /// 
                /// <b>Example:</b>
                /// <para>semantic</para>
                /// </summary>
                [NameInMap("mergeKey")]
                [Validation(Required=false)]
                public string MergeKey { get; set; }

                /// <summary>
                /// <para>The storage mode. Default value: upsert. Valid values: event (event append), upsert (merge update).</para>
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
                /// <para>The number of days before a memory expires. A value of 0 indicates that the memory does not expire.</para>
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
        /// <para>The name of the context store. The name must be globally unique within AgentSpace and 2 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <para>The type of the context store. Valid values include experience (experience store) and memory (memory store).</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The idempotency token. This is a unique string generated by the client to ensure the idempotency of the creation operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
