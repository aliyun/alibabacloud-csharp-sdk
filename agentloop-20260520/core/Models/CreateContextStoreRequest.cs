// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class CreateContextStoreRequest : TeaModel {
        /// <summary>
        /// <para>The context store configuration, including the datasource config and metadata field mapping.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public CreateContextStoreRequestConfig Config { get; set; }
        public class CreateContextStoreRequestConfig : TeaModel {
            [NameInMap("audit")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigAudit Audit { get; set; }
            public class CreateContextStoreRequestConfigAudit : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("droppedCandidates")]
                [Validation(Required=false)]
                public bool? DroppedCandidates { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>raw</para>
                /// </summary>
                [NameInMap("queryMode")]
                [Validation(Required=false)]
                public string QueryMode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("retentionDays")]
                [Validation(Required=false)]
                public int? RetentionDays { get; set; }

            }

            [NameInMap("extractionPolicy")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigExtractionPolicy ExtractionPolicy { get; set; }
            public class CreateContextStoreRequestConfigExtractionPolicy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;preference&quot;,&quot;profile&quot;]</para>
                /// </summary>
                [NameInMap("categories")]
                [Validation(Required=false)]
                public List<string> Categories { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>只抽取用户的产品偏好</para>
                /// </summary>
                [NameInMap("customInstructions")]
                [Validation(Required=false)]
                public string CustomInstructions { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;密码&quot;,&quot;证件号&quot;]</para>
                /// </summary>
                [NameInMap("excludeRules")]
                [Validation(Required=false)]
                public List<string> ExcludeRules { get; set; }

                [NameInMap("model")]
                [Validation(Required=false)]
                public CreateContextStoreRequestConfigExtractionPolicyModel Model { get; set; }
                public class CreateContextStoreRequestConfigExtractionPolicyModel : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>qwen3.8-flash</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
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
            /// <para>The experience mining interval, which specifies how often experience mining is performed. Valid values: 1h, 6h, 12h, and 1d. Default value: 1d. This value cannot be changed after creation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1d</para>
            /// </summary>
            [NameInMap("miningInterval")]
            [Validation(Required=false)]
            public string MiningInterval { get; set; }

            [NameInMap("scopePolicy")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigScopePolicy ScopePolicy { get; set; }
            public class CreateContextStoreRequestConfigScopePolicy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;userId&quot;]</para>
                /// </summary>
                [NameInMap("requiredAnyOf")]
                [Validation(Required=false)]
                public List<string> RequiredAnyOf { get; set; }

            }

            /// <summary>
            /// <para>The list of service names. This parameter is required and cannot be empty. It works with source.agentSpace to locate the trace data source. The trajectory extraction service uses the AgentSpace to look up the bound CMS workspace and project/logstore, and then filters by service name. This value cannot be changed after creation. No modification entry is available in the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;order-service&quot;,&quot;payment-service&quot;]</para>
            /// </summary>
            [NameInMap("serviceNames")]
            [Validation(Required=false)]
            public List<string> ServiceNames { get; set; }

            /// <summary>
            /// <para>The datasource config, which serves only as the root identifier for the data source. This is an optional block.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigSource Source { get; set; }
            public class CreateContextStoreRequestConfigSource : TeaModel {
                /// <summary>
                /// <para>The AgentSpace where the trace data source resides. If not specified, the AgentSpace in the current path is used by default. Cross-AgentSpace access is not supported in the current version. If specified, the value must match the AgentSpace in the path. Otherwise, a 400 parameter error is returned. This value cannot be changed after creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                [NameInMap("dataset")]
                [Validation(Required=false)]
                public CreateContextStoreRequestConfigSourceDataset Dataset { get; set; }
                public class CreateContextStoreRequestConfigSourceDataset : TeaModel {
                    [NameInMap("customFields")]
                    [Validation(Required=false)]
                    public List<CreateContextStoreRequestConfigSourceDatasetCustomFields> CustomFields { get; set; }
                    public class CreateContextStoreRequestConfigSourceDatasetCustomFields : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>客户等级</para>
                        /// </summary>
                        [NameInMap("description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("sensitive")]
                        [Validation(Required=false)]
                        public bool? Sensitive { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>customerTier</para>
                        /// </summary>
                        [NameInMap("sourceField")]
                        [Validation(Required=false)]
                        public string SourceField { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>metadata.customerTier</para>
                        /// </summary>
                        [NameInMap("target")]
                        [Validation(Required=false)]
                        public string Target { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>extraction-input</para>
                        /// </summary>
                        [NameInMap("usage")]
                        [Validation(Required=false)]
                        public string Usage { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>trajectory-with-crm-profile</para>
                    /// </summary>
                    [NameInMap("datasetName")]
                    [Validation(Required=false)]
                    public string DatasetName { get; set; }

                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public CreateContextStoreRequestConfigSourceDatasetFilter Filter { get; set; }
                    public class CreateContextStoreRequestConfigSourceDatasetFilter : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>appId = \&quot;crm-service\&quot;</para>
                        /// </summary>
                        [NameInMap("where")]
                        [Validation(Required=false)]
                        public string Where { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("pollIntervalSeconds")]
                    [Validation(Required=false)]
                    public int? PollIntervalSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MemorySourceV1</para>
                    /// </summary>
                    [NameInMap("schemaContract")]
                    [Validation(Required=false)]
                    public string SchemaContract { get; set; }

                    [NameInMap("versionPolicy")]
                    [Validation(Required=false)]
                    public CreateContextStoreRequestConfigSourceDatasetVersionPolicy VersionPolicy { get; set; }
                    public class CreateContextStoreRequestConfigSourceDatasetVersionPolicy : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>follow</para>
                        /// </summary>
                        [NameInMap("mode")]
                        [Validation(Required=false)]
                        public string Mode { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("startSeq")]
                        [Validation(Required=false)]
                        public long? StartSeq { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>v3</para>
                        /// </summary>
                        [NameInMap("version")]
                        [Validation(Required=false)]
                        public string Version { get; set; }

                    }

                }

                /// <summary>
                /// <para>The start time for data backfill, in ISO 8601 UTC format. If not specified, the current time is used.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ssZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-01-01T00:00:00Z</para>
                /// </summary>
                [NameInMap("startTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("trajectory")]
                [Validation(Required=false)]
                public CreateContextStoreRequestConfigSourceTrajectory Trajectory { get; set; }
                public class CreateContextStoreRequestConfigSourceTrajectory : TeaModel {
                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public CreateContextStoreRequestConfigSourceTrajectoryFilter Filter { get; set; }
                    public class CreateContextStoreRequestConfigSourceTrajectoryFilter : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[&quot;sales-copilot&quot;]</para>
                        /// </summary>
                        [NameInMap("agentNames")]
                        [Validation(Required=false)]
                        public List<string> AgentNames { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("excludeDegraded")]
                        [Validation(Required=false)]
                        public bool? ExcludeDegraded { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("minStepCount")]
                        [Validation(Required=false)]
                        public int? MinStepCount { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>tool_names:&quot;search_order&quot;</para>
                        /// </summary>
                        [NameInMap("query")]
                        [Validation(Required=false)]
                        public string Query { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>[&quot;crm-service&quot;,&quot;app-*&quot;]</para>
                        /// </summary>
                        [NameInMap("serviceNames")]
                        [Validation(Required=false)]
                        public List<string> ServiceNames { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent-trajectory</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>300</para>
                    /// </summary>
                    [NameInMap("pollIntervalSeconds")]
                    [Validation(Required=false)]
                    public int? PollIntervalSeconds { get; set; }

                    [NameInMap("scopeMapping")]
                    [Validation(Required=false)]
                    public CreateContextStoreRequestConfigSourceTrajectoryScopeMapping ScopeMapping { get; set; }
                    public class CreateContextStoreRequestConfigSourceTrajectoryScopeMapping : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>$.agent_name</para>
                        /// </summary>
                        [NameInMap("agentId")]
                        [Validation(Required=false)]
                        public string AgentId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>$.service_names[0]</para>
                        /// </summary>
                        [NameInMap("appId")]
                        [Validation(Required=false)]
                        public string AppId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>$.trajectory_id</para>
                        /// </summary>
                        [NameInMap("runId")]
                        [Validation(Required=false)]
                        public string RunId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>$.trajectory_extensions.user_id</para>
                        /// </summary>
                        [NameInMap("userId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                    /// <summary>
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
                /// <b>Example:</b>
                /// <para>trajectory</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("storagePolicy")]
            [Validation(Required=false)]
            public CreateContextStoreRequestConfigStoragePolicy StoragePolicy { get; set; }
            public class CreateContextStoreRequestConfigStoragePolicy : TeaModel {
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

        }

        /// <summary>
        /// <para>The context store name, which must be globally unique within the AgentSpace. The name must be 2 to 64 characters in length.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-context-store</para>
        /// </summary>
        [NameInMap("contextStoreName")]
        [Validation(Required=false)]
        public string ContextStoreName { get; set; }

        /// <summary>
        /// <para>The context store type. Valid values: experience and memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>experience</para>
        /// </summary>
        [NameInMap("contextType")]
        [Validation(Required=false)]
        public string ContextType { get; set; }

        /// <summary>
        /// <para>The description of the context store, which helps users understand its purpose.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的上下文库</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The idempotency token, which is a unique string generated by the client to ensure the idempotence of the create operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
