// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Flow : TeaModel {
        /// <summary>
        /// <para>工作流的创建时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>工作流的定义内容</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>工作流的描述信息，说明该工作流的用途和功能</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer service automation flow</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>工作流的环境变量配置，包含一组命名变量列表</para>
        /// </summary>
        [NameInMap("environmentConfiguration")]
        [Validation(Required=false)]
        public EnvironmentConfiguration EnvironmentConfiguration { get; set; }

        /// <summary>
        /// <para>为工作流提供访问云服务权限的执行角色ARN</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1760720386195983:role/FlowExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>工作流的外部存储位置</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path</para>
        /// </summary>
        [NameInMap("externalStorageLocation")]
        [Validation(Required=false)]
        public string ExternalStorageLocation { get; set; }

        /// <summary>
        /// <para>工作流的全局唯一资源名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:agentrun:cn-hangzhou:1760720386195983:workspaces/ws-xxx/flows/flow-xxx</para>
        /// </summary>
        [NameInMap("flowArn")]
        [Validation(Required=false)]
        public string FlowArn { get; set; }

        /// <summary>
        /// <para>工作流的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-1234567890abcdef</para>
        /// </summary>
        [NameInMap("flowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>工作流的名称，用于标识和区分不同的工作流实例</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flow</para>
        /// </summary>
        [NameInMap("flowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>工作流最后一次更新的时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>工作流的日志配置</para>
        /// </summary>
        [NameInMap("loggingConfiguration")]
        [Validation(Required=false)]
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// <para>工作流所属的资源组标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4a4b4a</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>工作流的标签信息，用于资源分类和管理</para>
        /// 
        /// <b>Example:</b>
        /// <para>production,automation</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// <para>工作流的链路追踪配置</para>
        /// </summary>
        [NameInMap("tracingConfiguration")]
        [Validation(Required=false)]
        public TracingConfiguration TracingConfiguration { get; set; }

        /// <summary>
        /// <para>工作流所属的工作空间标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
