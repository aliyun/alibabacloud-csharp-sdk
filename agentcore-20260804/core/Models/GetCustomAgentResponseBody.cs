// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class GetCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetCustomAgentResponseBodyData Data { get; set; }
        public class GetCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>agent-550e8400e29b41d4a716446655440000</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<GetCustomAgentResponseBodyDataAgenticFsMounts> AgenticFsMounts { get; set; }
            public class GetCustomAgentResponseBodyDataAgenticFsMounts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            [NameInMap("artifact")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataArtifact Artifact { get; set; }
            public class GetCustomAgentResponseBodyDataArtifact : TeaModel {
                [NameInMap("code")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataArtifactCode Code { get; set; }
                public class GetCustomAgentResponseBodyDataArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://my-agent-bucket/packages/agent.zip</para>
                    /// </summary>
                    [NameInMap("sourceUri")]
                    [Validation(Required=false)]
                    public string SourceUri { get; set; }

                }

                [NameInMap("container")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataArtifactContainer Container { get; set; }
                public class GetCustomAgentResponseBodyDataArtifactContainer : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>acr</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("createMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-10-10T06:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("deployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>提供对话服务的自定义智能体</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("environment")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataEnvironment Environment { get; set; }
            public class GetCustomAgentResponseBodyDataEnvironment : TeaModel {
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<GetCustomAgentResponseBodyDataEnvironmentVariables> Variables { get; set; }
                public class GetCustomAgentResponseBodyDataEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOG_LEVEL</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>info</para>
                    /// </summary>
                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataHealthCheck HealthCheck { get; set; }
            public class GetCustomAgentResponseBodyDataHealthCheck : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("healthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>可选。仅解释同一响应 latestSpecVersion/latestVersionStatus 的等待或失败；正常待处理、执行中或成功时省略。消息由 Console 白名单映射，不返回原始运行时诊断、Checkpoint 或凭证。</para>
            /// </summary>
            [NameInMap("latestExecutionError")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataLatestExecutionError LatestExecutionError { get; set; }
            public class GetCustomAgentResponseBodyDataLatestExecutionError : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>AgentExecutionFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Agent 执行失败，请检查配置后重新提交。</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("retryable")]
                [Validation(Required=false)]
                public bool? Retryable { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("latestSpecVersion")]
            [Validation(Required=false)]
            public long? LatestSpecVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>succeeded</para>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            [NameInMap("logging")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataLogging Logging { get; set; }
            public class GetCustomAgentResponseBodyDataLogging : TeaModel {
                [NameInMap("sls")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataLoggingSls Sls { get; set; }
                public class GetCustomAgentResponseBodyDataLoggingSls : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>agent-runtime</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>my-agent-logs</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("network")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataNetwork Network { get; set; }
            public class GetCustomAgentResponseBodyDataNetwork : TeaModel {
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataNetworkAccessInternet AccessInternet { get; set; }
                public class GetCustomAgentResponseBodyDataNetworkAccessInternet : TeaModel {
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataNetworkAccessVpc AccessVpc { get; set; }
                public class GetCustomAgentResponseBodyDataNetworkAccessVpc : TeaModel {
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<GetCustomAgentResponseBodyDataOssMounts> OssMounts { get; set; }
            public class GetCustomAgentResponseBodyDataOssMounts : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>my-agent-data</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>datasets/train</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public List<GetCustomAgentResponseBodyDataProtocol> Protocol { get; set; }
            public class GetCustomAgentResponseBodyDataProtocol : TeaModel {
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<GetCustomAgentResponseBodyDataProtocolPaths> Paths { get; set; }
                public class GetCustomAgentResponseBodyDataProtocolPaths : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AG-UI 对话接口</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/agui</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agui</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("runtime")]
            [Validation(Required=false)]
            public GetCustomAgentResponseBodyDataRuntime Runtime { get; set; }
            public class GetCustomAgentResponseBodyDataRuntime : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataRuntimeCompute Compute { get; set; }
                public class GetCustomAgentResponseBodyDataRuntimeCompute : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STANDARD</para>
                    /// </summary>
                    [NameInMap("computeClass")]
                    [Validation(Required=false)]
                    public string ComputeClass { get; set; }

                }

                /// <summary>
                /// <para>Agent 当前 spec 版本的 HPA 配置，与 Managed Agent 一致。开启时必须提供最小和最大 Sandbox 数；并发会话上限与会话空闲超时必须一起配置。</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataRuntimeHpa Hpa { get; set; }
                public class GetCustomAgentResponseBodyDataRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>正整数，必须与 sessionTtlSeconds 同时配置。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>开启时为正整数，关闭时为非负整数；不得小于 minSandboxCount。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>非负整数。开启弹性时必填；关闭时如提供上下限，必须成对提供。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>正整数，必须与 maxConcurrentSessionsPerSandbox 同时配置。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public GetCustomAgentResponseBodyDataRuntimeSessionPolicy SessionPolicy { get; set; }
                public class GetCustomAgentResponseBodyDataRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>X-Session-Id</para>
                    /// </summary>
                    [NameInMap("headerName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AFFINITY</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("sandboxPhaseCounts")]
            [Validation(Required=false)]
            public Dictionary<string, long?> SandboxPhaseCounts { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2026-10-10T06:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ws-a1b2c3d4e5f6</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>550E8400-E29B-41D4-A716-446655440000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
