// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateModelServiceInput : TeaModel {
        /// <summary>
        /// <para>The credential name for authenticating with the cloud provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialName</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>An optional description of the model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto generate task: Pipeline[pipeline-run-1742178254775] pipelineTemplate[data-export-service-online-iVnQB5] taskTemplate[serverless-runner-task], time[2025-03-17T02:24:36Z]</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A list of configurations for models in the service.</para>
        /// </summary>
        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        /// <summary>
        /// <para>The name of the model service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modelServiceName</para>
        /// </summary>
        [NameInMap("modelServiceName")]
        [Validation(Required=false)]
        public string ModelServiceName { get; set; }

        /// <summary>
        /// <para>The model type. Valid values include:</para>
        /// <list type="bullet">
        /// <item><description><para><c>system</c>: A built-in model that the service provides.</para>
        /// </description></item>
        /// <item><description><para><c>deployment</c>: A custom model that a user deploys.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>The network configuration for the model service. See <c>NetworkConfiguration</c> for details.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The cloud provider for the model service. Currently, only Alibaba Cloud is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Aliyun</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>Provider-specific configuration settings. See <c>ProviderSettings</c> for details.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public ProviderSettings ProviderSettings { get; set; }

        /// <summary>
        /// <para>The ID of the workspace in which to create the model service.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
