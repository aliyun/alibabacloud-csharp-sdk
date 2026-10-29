// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class ListCustomAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request result code. The value is SUCCESS if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code of the request. The value is 200 if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The list of custom agent summaries on the current page. To query the complete configuration and the execution result of the latest version, call the GetCustomAgent operation.</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListCustomAgentsResponseBodyItems> Items { get; set; }
        public class ListCustomAgentsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The unique identifier of the custom agent. You can obtain this ID from the response of the CreateCustomAgent or ListCustomAgents operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-550e8400e29b41d4a716446655440000</para>
            /// </summary>
            [NameInMap("agentId")]
            [Validation(Required=false)]
            public string AgentId { get; set; }

            /// <summary>
            /// <para>The agent artifact.</para>
            /// </summary>
            [NameInMap("artifact")]
            [Validation(Required=false)]
            public ListCustomAgentsResponseBodyItemsArtifact Artifact { get; set; }
            public class ListCustomAgentsResponseBodyItemsArtifact : TeaModel {
                /// <summary>
                /// <para>The code package deployment configuration. This parameter is mutually exclusive with container. The code package uses the ZIP or TAR.GZ format. Dependencies are packaged by the user. The platform does not install dependencies or perform online builds.</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public ListCustomAgentsResponseBodyItemsArtifactCode Code { get; set; }
                public class ListCustomAgentsResponseBodyItemsArtifactCode : TeaModel {
                    /// <summary>
                    /// <para>The startup command for the code package. This parameter is required in code package mode. The working directory is the root directory of the extracted code, which is /code. Example: python main.py. Quotes and escape characters are supported. Environment variables, pipes, and logical operations are not automatically expanded. For complex commands, use a script within the package.</para>
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
                    /// <para>The fixed oss:// address of the platform code package referenced by the currently saved configuration. This address does not include the signature parameters of the source HTTPS link. You can use this address to reuse an existing code package. To download the content, call the GetAgentCodePackageDownloadUrl operation.</para>
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
                /// <para>The container image deployment configuration.</para>
                /// </summary>
                [NameInMap("container")]
                [Validation(Required=false)]
                public ListCustomAgentsResponseBodyItemsArtifactContainer Container { get; set; }
                public class ListCustomAgentsResponseBodyItemsArtifactContainer : TeaModel {
                    /// <summary>
                    /// <para>The custom container startup command and parameters. If this parameter is not configured, the default startup method of the image is used.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>python main.py</para>
                    /// </summary>
                    [NameInMap("entrypoint")]
                    [Validation(Required=false)]
                    public string Entrypoint { get; set; }

                    /// <summary>
                    /// <para>The ID of the ACR Enterprise instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cri-example</para>
                    /// </summary>
                    [NameInMap("instanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The ACR namespace.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>team</para>
                    /// </summary>
                    [NameInMap("namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The name of the ACR image repository.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>app</para>
                    /// </summary>
                    [NameInMap("repo")]
                    [Validation(Required=false)]
                    public string Repo { get; set; }

                    /// <summary>
                    /// <para>The image tag.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1</para>
                    /// </summary>
                    [NameInMap("tag")]
                    [Validation(Required=false)]
                    public string Tag { get; set; }

                    /// <summary>
                    /// <para>The source type of the container image.</para>
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
                /// <para>The listening port of the agent service.</para>
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
            public ListCustomAgentsResponseBodyItemsCodePackageInfo CodePackageInfo { get; set; }
            public class ListCustomAgentsResponseBodyItemsCodePackageInfo : TeaModel {
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
            /// <para>The time when the agent was created. The time is in ISO 8601 format. The trailing Z indicates the UTC time zone. Fractional seconds may be included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T06:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The deployment method of the agent. Custom agents are deployed and managed by the platform. The value is MANAGED for custom agents.</para>
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
            /// <para>The latest configuration version number. Updates with the same configuration may retain the original version number. This field does not indicate that the configuration has taken effect.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("latestSpecVersion")]
            [Validation(Required=false)]
            public long? LatestSpecVersion { get; set; }

            /// <summary>
            /// <para>The name of the custom agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-custom-agent</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of invocation protocol configurations for the agent.</para>
            /// </summary>
            [NameInMap("protocol")]
            [Validation(Required=false)]
            public List<ListCustomAgentsResponseBodyItemsProtocol> Protocol { get; set; }
            public class ListCustomAgentsResponseBodyItemsProtocol : TeaModel {
                /// <summary>
                /// <para>The request header configuration of the current protocol. The key is the header name and the value is a string.</para>
                /// </summary>
                [NameInMap("headers")]
                [Validation(Required=false)]
                public Dictionary<string, string> Headers { get; set; }

                /// <summary>
                /// <para>The list of API paths corresponding to the current protocol.</para>
                /// </summary>
                [NameInMap("paths")]
                [Validation(Required=false)]
                public List<ListCustomAgentsResponseBodyItemsProtocolPaths> Paths { get; set; }
                public class ListCustomAgentsResponseBodyItemsProtocolPaths : TeaModel {
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
                /// <para>The invoke Protocol Type. Valid values:</para>
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
            /// <para>The compute specifications of the agent. Valid values: INTERACTIVE, STANDARD, and HEAVY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STANDARD</para>
            /// </summary>
            [NameInMap("runtime")]
            [Validation(Required=false)]
            public string Runtime { get; set; }

            /// <summary>
            /// <para>The overall status of the agent. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The agent is being created.</description></item>
            /// <item><description>Running: The agent is running.</description></item>
            /// <item><description>Failed: The agent failed.</description></item>
            /// <item><description>Updating: The agent is being updated.</description></item>
            /// <item><description>Deleting: The agent is being deleted.</description></item>
            /// <item><description>Deleted: The agent is deleted.
            /// To query the execution progress of the latest configuration, call the GetCustomAgent operation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the agent was last updated. The time is in ISO 8601 format. The trailing Z indicates the UTC time zone. Fractional seconds may be included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-10T06:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the custom agent belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-a1b2c3d4e5f6</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of results returned per page for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message that describes the result of the request. The value is success if the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The opaque token used to query the next page. An empty value indicates that no more pages are available. Pass this token as-is in subsequent requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>djE6YWdlbnRjb3JlLmFnZW50Lmxpc3QuY3VzdG9tOjIw</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. You can use this ID to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>550E8400-E29B-41D4-A716-446655440000</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. A value of true indicates that the request was successful. A successful creation, update, or deletion response does not mean that the background operation is complete.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of custom agents that meet the query conditions in the specified workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
