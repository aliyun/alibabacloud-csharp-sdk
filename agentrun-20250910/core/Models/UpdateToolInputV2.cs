// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateToolInputV2 : TeaModel {
        /// <summary>
        /// <para>更新工具部署的制品类型，支持：Code（代码包）、Container（容器镜像）</para>
        /// 
        /// <b>Example:</b>
        /// <para>Code</para>
        /// </summary>
        [NameInMap("artifactType")]
        [Validation(Required=false)]
        public string ArtifactType { get; set; }

        /// <summary>
        /// <para>更新代码包类型工具的配置信息</para>
        /// </summary>
        [NameInMap("codeConfiguration")]
        [Validation(Required=false)]
        public CodeConfiguration CodeConfiguration { get; set; }

        /// <summary>
        /// <para>更新容器类型工具的配置信息</para>
        /// </summary>
        [NameInMap("containerConfiguration")]
        [Validation(Required=false)]
        public ContainerConfiguration ContainerConfiguration { get; set; }

        /// <summary>
        /// <para>更新工具实例的 CPU 核心数，单位为核</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>更新工具的创建方式。支持：MCP_REMOTE、MCP_LOCAL_STDIO、MCP_BUNDLE、CODE_PACKAGE、OPENAPI_IMPORT</para>
        /// 
        /// <b>Example:</b>
        /// <para>MCP_REMOTE</para>
        /// </summary>
        [NameInMap("createMethod")]
        [Validation(Required=false)]
        public string CreateMethod { get; set; }

        /// <summary>
        /// <para>更新工具使用的凭证名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-credential</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>更新工具的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>更新后的工具描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>更新工具运行时的环境变量配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ENV&quot;: &quot;production&quot;}</para>
        /// </summary>
        [NameInMap("environmentVariables")]
        [Validation(Required=false)]
        public Dictionary<string, string> EnvironmentVariables { get; set; }

        /// <summary>
        /// <para>更新工具执行时使用的 RAM 角色 ARN</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/AliyunFCDefaultRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>更新工具的日志配置</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>更新 MCP 工具的配置信息，包括会话亲和性、代理配置等</para>
        /// </summary>
        [NameInMap("mcpConfig")]
        [Validation(Required=false)]
        public McpConfig McpConfig { get; set; }

        /// <summary>
        /// <para>更新工具实例的内存大小，单位为 MB</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>更新文件存储 NAS 的配置信息</para>
        /// </summary>
        [NameInMap("nasConfig")]
        [Validation(Required=false)]
        public NASConfig NasConfig { get; set; }

        /// <summary>
        /// <para>更新工具的网络配置</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>更新对象存储 OSS 的挂载配置</para>
        /// </summary>
        [NameInMap("ossMountConfig")]
        [Validation(Required=false)]
        public OSSMountConfig OssMountConfig { get; set; }

        /// <summary>
        /// <para>更新工具服务监听的端口号</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public int? Port { get; set; }

        /// <summary>
        /// <para>更新工具使用的协议规范定义</para>
        /// </summary>
        [NameInMap("protocolSpec")]
        [Validation(Required=false)]
        public string ProtocolSpec { get; set; }

        /// <summary>
        /// <para>更新工具执行的超时时间，单位为秒</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>更新工具所属的工作空间标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>workspace-xyz789</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
