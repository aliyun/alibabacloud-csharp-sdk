// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetContextStoreResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the AgentSpace to which the context store belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-space</para>
        /// </summary>
        [NameInMap("agentSpace")]
        [Validation(Required=false)]
        public string AgentSpace { get; set; }

        /// <summary>
        /// <para>The configuration of the context store.</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public GetContextStoreResponseBodyConfig Config { get; set; }
        public class GetContextStoreResponseBodyConfig : TeaModel {
            [NameInMap("audit")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigAudit Audit { get; set; }
            public class GetContextStoreResponseBodyConfigAudit : TeaModel {
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
            public GetContextStoreResponseBodyConfigExtractionPolicy ExtractionPolicy { get; set; }
            public class GetContextStoreResponseBodyConfigExtractionPolicy : TeaModel {
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
                public GetContextStoreResponseBodyConfigExtractionPolicyModel Model { get; set; }
                public class GetContextStoreResponseBodyConfigExtractionPolicyModel : TeaModel {
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

            [NameInMap("innerSource")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigInnerSource InnerSource { get; set; }
            public class GetContextStoreResponseBodyConfigInnerSource : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>memory_events_0a1b2c3d</para>
                /// </summary>
                [NameInMap("logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                /// <summary>
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
            /// <para>The experience mining interval. Valid values: 1h, 6h, 12h, and 1d. Default value: 1d.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1d</para>
            /// </summary>
            [NameInMap("miningInterval")]
            [Validation(Required=false)]
            public string MiningInterval { get; set; }

            [NameInMap("observability")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigObservability Observability { get; set; }
            public class GetContextStoreResponseBodyConfigObservability : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>memory-audit</para>
                /// </summary>
                [NameInMap("auditLogstore")]
                [Validation(Required=false)]
                public string AuditLogstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>memory_events_0a1b2c3d</para>
                /// </summary>
                [NameInMap("eventsLogstore")]
                [Validation(Required=false)]
                public string EventsLogstore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>agentloop-xxx</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

            }

            [NameInMap("outputDataset")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigOutputDataset OutputDataset { get; set; }
            public class GetContextStoreResponseBodyConfigOutputDataset : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>memory-my-context-store</para>
                /// </summary>
                [NameInMap("datasetName")]
                [Validation(Required=false)]
                public string DatasetName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MemoryRecordV1</para>
                /// </summary>
                [NameInMap("schemaContract")]
                [Validation(Required=false)]
                public string SchemaContract { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("schemaVersion")]
                [Validation(Required=false)]
                public int? SchemaVersion { get; set; }

            }

            [NameInMap("scopePolicy")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigScopePolicy ScopePolicy { get; set; }
            public class GetContextStoreResponseBodyConfigScopePolicy : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;userId&quot;]</para>
                /// </summary>
                [NameInMap("requiredAnyOf")]
                [Validation(Required=false)]
                public List<string> RequiredAnyOf { get; set; }

            }

            /// <summary>
            /// <para>The list of service names. This works together with source.agentSpace to locate the trace data source. This value cannot be changed in the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;order-service&quot;,&quot;payment-service&quot;]</para>
            /// </summary>
            [NameInMap("serviceNames")]
            [Validation(Required=false)]
            public List<string> ServiceNames { get; set; }

            /// <summary>
            /// <para>The datasource config passed in by the user. This serves only as the root identifier of the data source.</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigSource Source { get; set; }
            public class GetContextStoreResponseBodyConfigSource : TeaModel {
                /// <summary>
                /// <para>The AgentSpace where the trace data source resides. This is the same as the AgentSpace specified during creation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-space</para>
                /// </summary>
                [NameInMap("agentSpace")]
                [Validation(Required=false)]
                public string AgentSpace { get; set; }

                [NameInMap("dataset")]
                [Validation(Required=false)]
                public GetContextStoreResponseBodyConfigSourceDataset Dataset { get; set; }
                public class GetContextStoreResponseBodyConfigSourceDataset : TeaModel {
                    [NameInMap("customFields")]
                    [Validation(Required=false)]
                    public List<GetContextStoreResponseBodyConfigSourceDatasetCustomFields> CustomFields { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceDatasetCustomFields : TeaModel {
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
                    public GetContextStoreResponseBodyConfigSourceDatasetFilter Filter { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceDatasetFilter : TeaModel {
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
                    public GetContextStoreResponseBodyConfigSourceDatasetVersionPolicy VersionPolicy { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceDatasetVersionPolicy : TeaModel {
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
                /// <para>The start time for data backfill, in ISO 8601 UTC format.</para>
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
                public GetContextStoreResponseBodyConfigSourceTrajectory Trajectory { get; set; }
                public class GetContextStoreResponseBodyConfigSourceTrajectory : TeaModel {
                    [NameInMap("filter")]
                    [Validation(Required=false)]
                    public GetContextStoreResponseBodyConfigSourceTrajectoryFilter Filter { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceTrajectoryFilter : TeaModel {
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
                    public GetContextStoreResponseBodyConfigSourceTrajectoryScopeMapping ScopeMapping { get; set; }
                    public class GetContextStoreResponseBodyConfigSourceTrajectoryScopeMapping : TeaModel {
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

            [NameInMap("sourceStatus")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigSourceStatus SourceStatus { get; set; }
            public class GetContextStoreResponseBodyConfigSourceStatus : TeaModel {
                [NameInMap("checkpoint")]
                [Validation(Required=false)]
                public Dictionary<string, object> Checkpoint { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>读取数据源超时</para>
                /// </summary>
                [NameInMap("lastError")]
                [Validation(Required=false)]
                public string LastError { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2026-10-01T08:00:00Z</para>
                /// </summary>
                [NameInMap("lastWindowAt")]
                [Validation(Required=false)]
                public string LastWindowAt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("retryCount")]
                [Validation(Required=false)]
                public int? RetryCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("state")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            [NameInMap("storagePolicy")]
            [Validation(Required=false)]
            public GetContextStoreResponseBodyConfigStoragePolicy StoragePolicy { get; set; }
            public class GetContextStoreResponseBodyConfigStoragePolicy : TeaModel {
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
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("strategyVersion")]
            [Validation(Required=false)]
            public int? StrategyVersion { get; set; }

        }

        /// <summary>
        /// <para>The context store name.</para>
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
        /// <para>我的上下文库</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The region ID of the context store.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9ACFB10A-1B2C-3D4E-5F6G-7H8I9J0K1L2M</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the context store. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ACTIVE</description></item>
        /// <item><description>INITIALIZING</description></item>
        /// <item><description>FAILED</description></item>
        /// </list>
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
