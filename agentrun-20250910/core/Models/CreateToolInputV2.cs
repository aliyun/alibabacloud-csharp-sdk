// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateToolInputV2 : TeaModel {
        /// <summary>
        /// <para>工具部署的制品类型，支持：Code（代码包）、Container（容器镜像）</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>代码包类型工具的配置信息，包括代码位置、入口函数、运行时等，仅在制品类型为 Code 时需要提供</para>
        /// </summary>
        [NameInMap("codeConfiguration")]
        [Validation(Required=false)]
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// <para>容器类型工具的配置信息，包括镜像地址、启动命令、端口映射等，仅在制品类型为 Container 时需要提供</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>工具实例的 CPU 核心数，单位为核，支持小数，如 0.5 表示半核</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.5</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>工具的创建方式，必填项。支持：MCP_REMOTE（远程 MCP 服务器）、MCP_LOCAL_STDIO（本地 MCP 标准输入输出）、MCP_BUNDLE（MCP 打包部署）、CODE_PACKAGE（代码包部署）、OPENAPI_IMPORT（OpenAPI 导入）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP_REMOTE</para>
        /// </summary>
        [NameInMap("createMethod")]
        [Validation(Required=false)]
        public string CreateMethod { get; set; }

        /// <summary>
        /// <para>工具使用的凭证名称，用于访问需要认证的外部服务，需要提前在系统中创建凭证</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-credential</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>工具的详细描述信息，说明工具的功能和用途</para>
        /// 
        /// <b>Example:</b>
        /// <para>这是一个用于处理文档的 MCP 工具</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>工具运行时的环境变量配置，键值对形式，用于传递配置信息到工具运行环境</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ENV&quot;: &quot;production&quot;, &quot;LOG_LEVEL&quot;: &quot;info&quot;}</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>工具执行时使用的 RAM 角色 ARN，用于权限控制，格式如：acs:ram::123456789:role/AliyunFCDefaultRole</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/AliyunFCDefaultRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>工具的日志配置，包括日志存储位置（SLS）、日志级别等</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>MCP 工具的配置信息，包括会话亲和性、代理配置、绑定配置等，仅在工具类型为 MCP 时需要提供</para>
        /// </summary>
        [NameInMap("mcpConfig")]
        [Validation(Required=false)]
        public McpConfig McpConfig { get; set; }

        /// <summary>
        /// <para>工具实例的内存大小，单位为 MB，建议根据工具的实际需求配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>512</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>文件存储 NAS 的配置信息，用于工具访问 NAS 文件系统，实现持久化存储</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>工具的网络配置，包括 VPC、安全组、交换机等信息，用于配置工具的网络访问能力</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>对象存储 OSS 的挂载配置，用于工具访问 OSS 存储桶中的文件</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>工具服务监听的端口号，用于接收请求</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>工具使用的协议规范定义，JSON 格式的字符串，定义工具的接口和交互方式</para>
        /// </summary>
        [NameInMap("protocolSpec")]
        [Validation(Required=false)]
        public string ProtocolSpec { get; set; }

        /// <summary>
        /// <para>工具执行的超时时间，单位为秒，超过此时间工具调用将被终止</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>工具的名称，必填项，用于标识和引用工具，需要在工作空间内唯一</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-mcp-tool</para>
        /// </summary>
        [NameInMap("toolName")]
        [Validation(Required=false)]
        public string ToolName { get; set; }

        /// <summary>
        /// <para>工具的类型，必填项。支持：MCP（Model Context Protocol 工具）、FUNCTIONCALL（函数调用工具）、SKILL（技能工具）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP</para>
        /// </summary>
        [NameInMap("toolType")]
        [Validation(Required=false)]
        public string ToolType { get; set; }

        /// <summary>
        /// <para>工具所属的工作空间标识符，可选项，不填则使用默认工作空间</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-xyz789</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
