// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class FlowVersion : TeaModel {
        /// <summary>
        /// <para>工作流版本的创建时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>工作流版本的定义内容（完整快照，仅在 GetFlowVersion 时返回）</para>
        /// 
        /// <b>Example:</b>
        /// <para>Type: StateMachine\nName: my-flow\n...</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>工作流版本的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>Version 1.0 - Initial release</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>工作流版本的环境变量配置（完整快照，仅在 GetFlowVersion 时返回）</para>
        /// </summary>
        [NameInMap("environmentConfiguration")]
        [Validation(Required=false)]
        public EnvironmentConfiguration EnvironmentConfiguration { get; set; }

        /// <summary>
        /// <para>工作流版本的外部存储位置（完整快照，仅在 GetFlowVersion 时返回）</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path</para>
        /// </summary>
        [NameInMap("externalStorageLocation")]
        [Validation(Required=false)]
        public string ExternalStorageLocation { get; set; }

        /// <summary>
        /// <para>工作流的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-1234567890abcdef</para>
        /// </summary>
        [NameInMap("flowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        [NameInMap("flowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>工作流版本号</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("flowVersion")]
        [Validation(Required=false)]
        public string FlowVersion_ { get; set; }

        /// <summary>
        /// <para>工作流版本的日志配置（完整快照，仅在 GetFlowVersion 时返回）</para>
        /// </summary>
        [NameInMap("loggingConfiguration")]
        [Validation(Required=false)]
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// <para>工作流版本的链路追踪配置（完整快照，仅在 GetFlowVersion 时返回）</para>
        /// </summary>
        [NameInMap("tracingConfiguration")]
        [Validation(Required=false)]
        public TracingConfiguration TracingConfiguration { get; set; }

    }

}
