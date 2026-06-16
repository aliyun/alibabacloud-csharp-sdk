// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateFlowInput : TeaModel {
        /// <summary>
        /// <para>The definition of the workflow in JSON or YAML format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The description of the workflow, which explains the purpose and functionality of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer service automation flow</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable public network access for the workflow. This value serves as the default policy at the workflow level. If FlowEndpoint is not specified, this value is inherited.</para>
        /// </summary>
        [NameInMap("disablePublicNetworkAccess")]
        [Validation(Required=false)]
        public bool? DisablePublicNetworkAccess { get; set; }

        /// <summary>
        /// <para>The environment variable configuration of the workflow, which contains a list of named variables.</para>
        /// </summary>
        [NameInMap("environmentConfiguration")]
        [Validation(Required=false)]
        public EnvironmentConfiguration EnvironmentConfiguration { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the execution role that grants the workflow permissions to access cloud services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789012:role/FlowExecutionRole</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The external storage location of the workflow, such as an OSS path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://bucket/path</para>
        /// </summary>
        [NameInMap("externalStorageLocation")]
        [Validation(Required=false)]
        public string ExternalStorageLocation { get; set; }

        /// <summary>
        /// <para>The unique name of the workflow, which is used to distinguish different workflow instances.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-flow</para>
        /// </summary>
        [NameInMap("flowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The logging configuration of the workflow.</para>
        /// </summary>
        [NameInMap("loggingConfiguration")]
        [Validation(Required=false)]
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the workflow belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4a4b4a</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The Tracing Analysis configuration of the workflow.</para>
        /// </summary>
        [NameInMap("tracingConfiguration")]
        [Validation(Required=false)]
        public TracingConfiguration TracingConfiguration { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the workflow belongs. This parameter is used for resource isolation and permission management.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
