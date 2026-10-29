// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateCustomAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result code. The value is SUCCESS if the request is successful.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The latest submitted configuration and status of the custom agent. A successful response indicates that the request is accepted, but the configuration may not have taken effect yet.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateCustomAgentResponseBodyData Data { get; set; }
        public class CreateCustomAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the custom agent. You can obtain this ID from the response of CreateCustomAgent or ListCustomAgents.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-550e8400e29b41d4a716446655440000</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The latest submitted list of additional AgenticFS mounts.</para>
            /// </summary>
            [NameInMap("agenticFsMounts")]
            [Validation(Required=false)]
            public List<CreateCustomAgentResponseBodyDataAgenticFsMounts> AgenticFsMounts { get; set; }
            public class CreateCustomAgentResponseBodyDataAgenticFsMounts : TeaModel {
                /// <summary>
                /// <para>The AgenticFS mount directory in the container, located under /mnt/agenticfs/.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/agenticfs/data</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The relative directory in the mounted access point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workspace/data</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Read-only.</description></item>
                /// <item><description>false: Read and write.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

                /// <summary>
                /// <para>The domain name of the AgenticFS access point used for the mount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-0123456789abcdef0.0123456789-vlm36.cn-hangzhou.nas.aliyuncs.com</para>
                /// </summary>
                [NameInMap("server")]
                [Validation(Required=false)]
                public string Server { get; set; }

            }

            /// <summary>
            /// <para>The latest submitted deployment artifact configuration, including the service listening port and the ACR container image. To check whether the configuration has taken effect, refer to latestVersionStatus.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataArtifact Artifact { get; set; }
            public class CreateCustomAgentResponseBodyDataArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration. This parameter is mutually exclusive with container. Code packages use the ZIP or TAR.GZ format. Dependencies must be packaged by the user. The platform does not install dependencies or perform online builds.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataArtifactCode Code { get; set; }
                public class CreateCustomAgentResponseBodyDataArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup command for the code package. This parameter is required in code package mode. The working directory is the extracted code root directory /code, such as python main.py. Quotes and escapes are supported. Environment variables, pipes, and logical operations are not automatically expanded. Use scripts within the package for complex commands.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python main.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The identifier of the code runtime environment in the currently saved configuration. The runtime image uses the saved snapshot. Adding a new version to the directory does not automatically change the existing configuration.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python3.12</para>
                    /// </summary>
                    [NameInMap("languageRuntime")]
                    [Validation(Required=false)]
                    public string LanguageRuntime { get; set; }

                    /// <summary>
                    /// <para>The oss:// address of the platform-fixed code package referenced by the currently saved configuration. This address does not include the signature parameters of the source HTTPS link. You can use this address to reuse an existing code package. To download the content, call GetAgentCodePackageDownloadUrl.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss://agentcore-platform-example/code-packages/workspaces/ws-a1b2c3d4e5f6/550e8400-e29b-41d4-a716-446655440000/package.zip</para>
                    /// </summary>
                    [NameInMap("sourceUri")]
                    [Validation(Required=false)]
                    public string SourceUri { get; set; }

                }

                /// <summary>
                /// <para>The latest submitted ACR container image configuration.</para>
                /// </summary>
                [NameInMap("container")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataArtifactContainer Container { get; set; }
                public class CreateCustomAgentResponseBodyDataArtifactContainer : TeaModel {
                    /// <summary>
                    /// <para>The custom executable program and startup parameters. If not configured, the default startup method of the image is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python app.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACR instance to which the image repository belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-a1b2c3d4e5f6</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The namespace to which the ACR image repository belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the image repository in the ACR namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>chat-agent</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The latest submitted image tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The image source type. A value of acr indicates Alibaba Cloud Container Registry (ACR).</para>
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
                /// <para>The TCP port listened on by the agent service.</para>
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
            /// <para>The currently saved code package information.</para>
            /// </summary>
            [NameInMap("codePackageInfo")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataCodePackageInfo CodePackageInfo { get; set; }
            public class CreateCustomAgentResponseBodyDataCodePackageInfo : TeaModel {
                /// <summary>
                /// <para>The CRC64 value of the code package object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>456</para>
                /// </summary>
                [NameInMap("crc64")]
                [Validation(Required=false)]
                public string Crc64 { get; set; }

                /// <summary>
                /// <para>The ETag of the code package object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fixed-etag</para>
                /// </summary>
                [NameInMap("etag")]
                [Validation(Required=false)]
                public string Etag { get; set; }

                /// <summary>
                /// <para>The original file name of the code package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>main.zip</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The compressed size of the code package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("fileSize")]
                [Validation(Required=false)]
                public long? FileSize { get; set; }

                /// <summary>
                /// <para>The format of the code package.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zip</para>
                /// </summary>
                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

            }

            /// <summary>
            /// <para>The creation method of the agent. The value is CUSTOM for custom agents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("createMode")]
            [Validation(Required=false)]
            public string CreateMode { get; set; }

            /// <summary>
            /// <para>The creation time of the agent. The time is in ISO 8601 format. The trailing Z indicates the UTC time zone. Fractional seconds may be included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T06:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The image source snapshot of the current active configuration version. The value is null before the first configuration takes effect. This field does not indicate the health status.</para>
            /// </summary>
            [NameInMap("currentImage")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataCurrentImage CurrentImage { get; set; }
            public class CreateCustomAgentResponseBodyDataCurrentImage : TeaModel {
                /// <summary>
                /// <para>The original image address for the custom source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.example.com/team/agent:v1</para>
                /// </summary>
                [NameInMap("image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The instance ID for the ACR source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cri-example</para>
                /// </summary>
                [NameInMap("instanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The namespace for the ACR source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>team</para>
                /// </summary>
                [NameInMap("namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The dedicated pull network for the custom source.</para>
                /// </summary>
                [NameInMap("pullNetwork")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataCurrentImagePullNetwork PullNetwork { get; set; }
                public class CreateCustomAgentResponseBodyDataCurrentImagePullNetwork : TeaModel {
                    /// <summary>
                    /// <para>The ID of the security group. This parameter is required when type is set to vpc. The security group must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-example</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The type of the pull network. This parameter is required when you submit pullNetwork and is verified by the backend. The default value is public network, which is independent of the agent runtime network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group. This parameter is required when type is set to vpc. The security group must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-example</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC. This parameter is required when type is set to vpc. The account and region to which the VPC belongs are verified by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-example</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The repository name for the ACR source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent</para>
                /// </summary>
                [NameInMap("repo")]
                [Validation(Required=false)]
                public string Repo { get; set; }

                /// <summary>
                /// <para>The certificate exception option for the custom source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipTlsVerify")]
                [Validation(Required=false)]
                public bool? SkipTlsVerify { get; set; }

                /// <summary>
                /// <para>The image source type of the current active version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("sourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

                /// <summary>
                /// <para>The tag of the ACR source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>The source snapshot from the current active configuration version. Omitted for anonymous sources. A new source failure does not overwrite this username, and the password is not returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reader</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The recently saved source and the verified username for this source. The source may be in preparation or failed, and the password is not returned.</para>
            /// </summary>
            [NameInMap("customImage")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataCustomImage CustomImage { get; set; }
            public class CreateCustomAgentResponseBodyDataCustomImage : TeaModel {
                /// <summary>
                /// <para>The latest saved source address, which may still be in preparation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>registry.example.com/team/agent:v1</para>
                /// </summary>
                [NameInMap("image")]
                [Validation(Required=false)]
                public string Image { get; set; }

                /// <summary>
                /// <para>The saved dedicated pull network.</para>
                /// </summary>
                [NameInMap("pullNetwork")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataCustomImagePullNetwork PullNetwork { get; set; }
                public class CreateCustomAgentResponseBodyDataCustomImagePullNetwork : TeaModel {
                    /// <summary>
                    /// <para>The ID of the security group. This parameter is required when type is set to vpc. The security group must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sg-example</para>
                    /// </summary>
                    [NameInMap("securityGroupId")]
                    [Validation(Required=false)]
                    public string SecurityGroupId { get; set; }

                    /// <summary>
                    /// <para>The type of the pull network. This parameter is required when you submit pullNetwork and is verified by the backend. The default value is public network, which is independent of the agent runtime network.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>public</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The ID of the security group. This parameter is required when type is set to vpc. The security group must belong to the selected VPC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vsw-example</para>
                    /// </summary>
                    [NameInMap("vSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <para>The ID of the VPC. This parameter is required when type is set to vpc. The account and region to which the VPC belongs are verified by the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>vpc-example</para>
                    /// </summary>
                    [NameInMap("vpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                }

                /// <summary>
                /// <para>The saved HTTPS certificate exception option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("skipTlsVerify")]
                [Validation(Required=false)]
                public bool? SkipTlsVerify { get; set; }

                /// <summary>
                /// <para>The username saved after the source is successfully prepared. Omitted for anonymous or unverified sources. This does not indicate the existence of a reusable password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>reader</para>
                /// </summary>
                [NameInMap("username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            /// <summary>
            /// <para>The deployment method of the agent. Custom agents are deployed and managed by the platform, and MANAGED is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MANAGED</para>
            /// </summary>
            [NameInMap("deployType")]
            [Validation(Required=false)]
            public string DeployType { get; set; }

            /// <summary>
            /// <para>The description of the agent\&quot;s purpose.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom agent that provides conversation services</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The active configuration version.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("effectiveSpecVersion")]
            [Validation(Required=false)]
            public long? EffectiveSpecVersion { get; set; }

            /// <summary>
            /// <para>The environment variable configuration for the agent process.</para>
            /// </summary>
            [NameInMap("environment")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataEnvironment Environment { get; set; }
            public class CreateCustomAgentResponseBodyDataEnvironment : TeaModel {
                /// <summary>
                /// <para>The list of recently submitted environment variables.</para>
                /// </summary>
                [NameInMap("variables")]
                [Validation(Required=false)]
                public List<CreateCustomAgentResponseBodyDataEnvironmentVariables> Variables { get; set; }
                public class CreateCustomAgentResponseBodyDataEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <para>The name of the environment variable.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOG_LEVEL</para>
                    /// </summary>
                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The string value of the environment variable. Empty strings are allowed.</para>
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

            /// <summary>
            /// <para>The HTTP health check configuration for the agent. Empty if not configured.</para>
            /// </summary>
            [NameInMap("healthCheck")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataHealthCheck HealthCheck { get; set; }
            public class CreateCustomAgentResponseBodyDataHealthCheck : TeaModel {
                /// <term><b>Obsolete</b></term>
                /// 
                /// <summary>
                /// <para>This parameter does not take effect.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("healthyThreshold")]
                [Validation(Required=false)]
                [Obsolete]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The interval between two health checks, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("intervalSeconds")]
                [Validation(Required=false)]
                public int? IntervalSeconds { get; set; }

                /// <summary>
                /// <para>The HTTP health check path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/healthz</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The port accessed for the HTTP health check.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8080</para>
                /// </summary>
                [NameInMap("port")]
                [Validation(Required=false)]
                public int? Port { get; set; }

                /// <summary>
                /// <para>The timeout period for a single health check, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("timeoutSeconds")]
                [Validation(Required=false)]
                public int? TimeoutSeconds { get; set; }

                /// <summary>
                /// <para>The number of consecutive health check failures required to mark the agent as unhealthy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("unhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The ID of the currently associated image cache.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>img-example</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("imageCacheId")]
            [Validation(Required=false)]
            public string ImageCacheId { get; set; }

            /// <summary>
            /// <para>The acceptance summary for the current cache preparation.</para>
            /// </summary>
            [NameInMap("imageCachePreparation")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataImageCachePreparation ImageCachePreparation { get; set; }
            public class CreateCustomAgentResponseBodyDataImageCachePreparation : TeaModel {
                /// <summary>
                /// <para>The ID of the cache associated with this request.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>img-example</para>
                /// </summary>
                [NameInMap("imageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The cache status at the time of acceptance.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PENDING</para>
                /// </summary>
                [NameInMap("statusAtAcceptance")]
                [Validation(Required=false)]
                public string StatusAtAcceptance { get; set; }

                /// <summary>
                /// <para>The acceptance status of the cache preparation.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACCEPTED</para>
                /// </summary>
                [NameInMap("submissionStatus")]
                [Validation(Required=false)]
                public string SubmissionStatus { get; set; }

            }

            /// <summary>
            /// <para>The currently associated image preparation task. The phase indicates acceptance. Query the preparation API for real-time progress. A regular save does not create an image preparation task.</para>
            /// </summary>
            [NameInMap("imagePreparation")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataImagePreparation ImagePreparation { get; set; }
            public class CreateCustomAgentResponseBodyDataImagePreparation : TeaModel {
                /// <summary>
                /// <para>The image preparation phase for this request. Configuration acceptance does not mean successful deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QUEUED</para>
                /// </summary>
                [NameInMap("phase")]
                [Validation(Required=false)]
                public string Phase { get; set; }

                /// <summary>
                /// <para>The ID of the task submitted from the console. This is not the RM operationId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent-example:1</para>
                /// </summary>
                [NameInMap("preparationId")]
                [Validation(Required=false)]
                public string PreparationId { get; set; }

            }

            /// <summary>
            /// <para>The wait or execution error of the latest configuration version. Returned only when this version is waiting for a retry or has failed to execute.</para>
            /// </summary>
            [NameInMap("latestExecutionError")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataLatestExecutionError LatestExecutionError { get; set; }
            public class CreateCustomAgentResponseBodyDataLatestExecutionError : TeaModel {
                /// <summary>
                /// <para>The reason code for the wait or execution failure of the latest configuration, used to determine subsequent processing methods.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>AgentExecutionFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The description of the reason why the latest configuration is waiting or failed to execute. Refer to the code and retryable fields to determine what to do next.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent execution failed. Check the configuration and resubmit</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Specifies whether the system automatically retries the operation. If the value is true, you can query again later. If the value is false, check and fix the configuration based on the reason, and then resubmit.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("retryable")]
                [Validation(Required=false)]
                public bool? Retryable { get; set; }

            }

            /// <summary>
            /// <para>The latest configuration version number. Updates with the same configuration may retain the original version number. This field does not indicate that the configuration has taken effect.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("latestSpecVersion")]
            [Validation(Required=false)]
            public long? LatestSpecVersion { get; set; }

            /// <summary>
            /// <para>The execution status corresponding to latestSpecVersion. pending indicates waiting for execution. processing indicates executing. waiting_retry indicates waiting for a retry. succeeded indicates execution succeeded. failed indicates execution failed. superseded indicates replaced by a subsequent version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>succeeded</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("latestVersionStatus")]
            [Validation(Required=false)]
            public string LatestVersionStatus { get; set; }

            /// <summary>
            /// <para>The recently submitted log delivery configuration.</para>
            /// </summary>
            [NameInMap("logging")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataLogging Logging { get; set; }
            public class CreateCustomAgentResponseBodyDataLogging : TeaModel {
                /// <summary>
                /// <para>The Simple Log Service (SLS) log delivery destination.</para>
                /// </summary>
                [NameInMap("sls")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataLoggingSls Sls { get; set; }
                public class CreateCustomAgentResponseBodyDataLoggingSls : TeaModel {
                    /// <summary>
                    /// <para>The name of the SLS Logstore that receives agent logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>agent-runtime</para>
                    /// </summary>
                    [NameInMap("logstore")]
                    [Validation(Required=false)]
                    public string Logstore { get; set; }

                    /// <summary>
                    /// <para>The name of the SLS project that receives agent logs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>my-agent-logs</para>
                    /// </summary>
                    [NameInMap("project")]
                    [Validation(Required=false)]
                    public string Project { get; set; }

                }

            }

            /// <summary>
            /// <para>The name of the custom agent.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The network access configuration of the agent. The actual access scope is also restricted by the network configuration of the workspace.</para>
            /// </summary>
            [NameInMap("network")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataNetwork Network { get; set; }
            public class CreateCustomAgentResponseBodyDataNetwork : TeaModel {
                /// <summary>
                /// <para>The Internet access configuration of the agent. If this parameter is not configured, Internet access is allowed on the agent side but is still restricted by the workspace.</para>
                /// </summary>
                [NameInMap("accessInternet")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataNetworkAccessInternet AccessInternet { get; set; }
                public class CreateCustomAgentResponseBodyDataNetworkAccessInternet : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether Internet access is allowed on the agent side. The actual access is still restricted by the workspace.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

                /// <summary>
                /// <para>The user VPC access configuration of the agent. If this parameter is not configured, user VPC access is allowed on the agent side but is still restricted by the workspace.</para>
                /// </summary>
                [NameInMap("accessVpc")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataNetworkAccessVpc AccessVpc { get; set; }
                public class CreateCustomAgentResponseBodyDataNetworkAccessVpc : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether access to the user VPC configured for the workspace is allowed on the agent side. The actual access is still restricted by the workspace.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                }

            }

            /// <summary>
            /// <para>The high-code agent observability configuration.</para>
            /// </summary>
            [NameInMap("observability")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataObservability Observability { get; set; }
            public class CreateCustomAgentResponseBodyDataObservability : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable agent observability.</para>
                /// </summary>
                [NameInMap("enabled")]
                [Validation(Required=false)]
                public bool? Enabled { get; set; }

            }

            /// <summary>
            /// <para>The list of OSS directory mounts in the latest submission.</para>
            /// </summary>
            [NameInMap("ossMounts")]
            [Validation(Required=false)]
            public List<CreateCustomAgentResponseBodyDataOssMounts> OssMounts { get; set; }
            public class CreateCustomAgentResponseBodyDataOssMounts : TeaModel {
                /// <summary>
                /// <para>The name of the mounted OSS bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-agent-data</para>
                /// </summary>
                [NameInMap("bucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para>The OSS mount directory in the container, which is located under /mnt/oss/.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/mnt/oss/train</para>
                /// </summary>
                [NameInMap("mountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

                /// <summary>
                /// <para>The object directory prefix in the mounted bucket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>datasets/train</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>Specifies whether the mount is read-only. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: Read-only.</description></item>
                /// <item><description>false: Read and write.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("readOnly")]
                [Validation(Required=false)]
                public bool? ReadOnly { get; set; }

            }

            /// <summary>
            /// <para>The list of invocation protocol configurations for the agent.</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public List<CreateCustomAgentResponseBodyDataProtocol> Protocol { get; set; }
            public class CreateCustomAgentResponseBodyDataProtocol : TeaModel {
                /// <summary>
                /// <para>The request header configuration for the current protocol. The key is the header name and the value is a string.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The list of API paths corresponding to the current protocol.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<CreateCustomAgentResponseBodyDataProtocolPaths> Paths { get; set; }
                public class CreateCustomAgentResponseBodyDataProtocolPaths : TeaModel {
                    /// <summary>
                    /// <para>The purpose description of the current API path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AG-UI conversation API</para>
                    /// </summary>
                    [NameInMap("description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The API path corresponding to the current protocol.</para>
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
                /// <para>The invocation protocol type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>agui: AG-UI protocol.</description></item>
                /// <item><description>openai-chat-completion: OpenAI Chat Completions compatible protocol.</description></item>
                /// <item><description>custom: Custom protocol.</description></item>
                /// </list>
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
            /// <para>The region ID of the workspace to which the agent belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The ARN of the RAM role used by the agent to access user cloud resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::1234567890123456:role/agentcore-runtime-role</para>
            /// </summary>
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The runtime configuration in the latest commit, including compute specifications, session policy, and elastic policy.</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public CreateCustomAgentResponseBodyDataRuntime Runtime { get; set; }
            public class CreateCustomAgentResponseBodyDataRuntime : TeaModel {
                /// <summary>
                /// <para>The compute resource configuration for the agent runtime instance.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("compute")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataRuntimeCompute Compute { get; set; }
                public class CreateCustomAgentResponseBodyDataRuntimeCompute : TeaModel {
                    /// <summary>
                    /// <para>The compute specification. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>INTERACTIVE: 1 vCPU and 2 GiB of memory.</description></item>
                    /// <item><description>STANDARD: 2 vCPUs and 4 GiB of memory.</description></item>
                    /// <item><description>HEAVY: 4 vCPUs and 8 GiB of memory.</description></item>
                    /// </list>
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
                /// <para>The elastic policy configuration of the agent.</para>
                /// </summary>
                [NameInMap("hpa")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataRuntimeHpa Hpa { get; set; }
                public class CreateCustomAgentResponseBodyDataRuntimeHpa : TeaModel {
                    /// <summary>
                    /// <para>Specifies whether elastic scaling is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>true: Enabled.</description></item>
                    /// <item><description>false: Disabled.</description></item>
                    /// </list>
                    /// <para>This parameter is required.</para>
                    /// </summary>
                    [NameInMap("enabled")]
                    [Validation(Required=false)]
                    public bool? Enabled { get; set; }

                    /// <summary>
                    /// <para>The maximum number of concurrent sessions configured for a single running instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("maxConcurrentSessionsPerSandbox")]
                    [Validation(Required=false)]
                    public int? MaxConcurrentSessionsPerSandbox { get; set; }

                    /// <summary>
                    /// <para>The maximum number of running instances configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("maxSandboxCount")]
                    [Validation(Required=false)]
                    public int? MaxSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The minimum number of running instances configured.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("minSandboxCount")]
                    [Validation(Required=false)]
                    public int? MinSandboxCount { get; set; }

                    /// <summary>
                    /// <para>The maximum idle time configured for a session, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("sessionTtlSeconds")]
                    [Validation(Required=false)]
                    public int? SessionTtlSeconds { get; set; }

                }

                /// <summary>
                /// <para>The session policy configuration of the agent.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("sessionPolicy")]
                [Validation(Required=false)]
                public CreateCustomAgentResponseBodyDataRuntimeSessionPolicy SessionPolicy { get; set; }
                public class CreateCustomAgentResponseBodyDataRuntimeSessionPolicy : TeaModel {
                    /// <summary>
                    /// <para>The name of the HTTP request header used by the session policy. This parameter applies to ISOLATED_HEADER_FIELD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>X-Session-Id</para>
                    /// </summary>
                    [NameInMap("headerName")]
                    [Validation(Required=false)]
                    public string HeaderName { get; set; }

                    /// <summary>
                    /// <para>The type of the session policy. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>AFFINITY: Session affinity.</description></item>
                    /// <item><description>ISOLATED_HEADER_FIELD: Uses the request header specified by headerName to associate sessions.
                    /// ISOLATED_COOKIE is not recommended. The compatible value DISABLED in a request is returned as AFFINITY.</description></item>
                    /// </list>
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

            /// <summary>
            /// <para>The number of instances counted by running instance phase. Keys include PENDING (creating or initializing), RUNNING (running), HIBERNATING (hibernating), HIBERNATED (hibernated), RESUMING (resuming), TERMINATING (terminating), and FAILED (failed). Only phases that actually occur are returned. Missing keys are treated as 0.</para>
            /// </summary>
            [NameInMap("sandboxPhaseCounts")]
            [Validation(Required=false)]
            public Dictionary<string, long?> SandboxPhaseCounts { get; set; }

            /// <summary>
            /// <para>The overall status of the agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The agent is being created.</description></item>
            /// <item><description>Running: The agent is running.</description></item>
            /// <item><description>Failed: The agent failed.</description></item>
            /// <item><description>Updating: The agent is being updated.</description></item>
            /// <item><description>Deleting: The agent is being deleted.</description></item>
            /// <item><description>Deleted: The agent is deleted.
            /// To check the execution progress of the latest configuration, query latestVersionStatus.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the agent was last updated. The time is in ISO 8601 format. A trailing Z indicates the UTC time zone. Fractional seconds may be included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T06:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The image cache toggle.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("useImageCache")]
            [Validation(Required=false)]
            public bool? UseImageCache { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the custom agent belongs.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-a1b2c3d4e5f6</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code of the request. A value of 200 indicates success.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The description of the processing result for the request. The value is success if the request is successful.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request, which is used to locate and troubleshoot issues.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550E8400-E29B-41D4-A716-446655440000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. A value of true indicates that the request was processed successfully. A successful creation, update, or deletion does not mean that the background operation is complete.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
