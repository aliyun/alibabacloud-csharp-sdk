// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateModelProxyInput : TeaModel {
        /// <summary>
        /// <para>Specifies the configuration for Application Real-Time Monitoring Service (ARMS).</para>
        /// </summary>
        [NameInMap("armsConfiguration")]
        [Validation(Required=false)]
        public ArmsConfiguration ArmsConfiguration { get; set; }

        /// <summary>
        /// <para>The number of CPU cores for the proxy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The name of the credential for accessing the model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>credentialName</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        /// <summary>
        /// <para>Optional. A custom description for the model proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ARN of the execution role the service assumes to act on your behalf.</para>
        /// 
        /// <b>Example:</b>
        /// <para>executionRoleArn</para>
        /// </summary>
        [NameInMap("executionRoleArn")]
        [Validation(Required=false)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// <para>The version of LiteLLM for the proxy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>litellmVersion</para>
        /// </summary>
        [NameInMap("litellmVersion")]
        [Validation(Required=false)]
        public string LitellmVersion { get; set; }

        /// <summary>
        /// <para>The Log Service (SLS) configuration for the Agent runtime.</para>
        /// </summary>
        [NameInMap("logConfiguration")]
        [Validation(Required=false)]
        public LogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// <para>The memory size for the proxy, in GiB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// <para>The unique name for the model proxy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>modelProxyName</para>
        /// </summary>
        [NameInMap("modelProxyName")]
        [Validation(Required=false)]
        public string ModelProxyName { get; set; }

        /// <summary>
        /// <para>The model type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>system</c>: Specifies a system model.</para>
        /// </description></item>
        /// <item><description><para><c>deployment</c>: Specifies a custom deployment model.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("modelType")]
        [Validation(Required=false)]
        public string ModelType { get; set; }

        /// <summary>
        /// <para>Specifies the network configuration for the proxy.</para>
        /// </summary>
        [NameInMap("networkConfiguration")]
        [Validation(Required=false)]
        public NetworkConfiguration NetworkConfiguration { get; set; }

        /// <summary>
        /// <para>The configuration settings for the proxy.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("proxyConfig")]
        [Validation(Required=false)]
        public ProxyConfig ProxyConfig { get; set; }

        /// <summary>
        /// <para>Specifies the operational mode of the proxy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxyMode</para>
        /// </summary>
        [NameInMap("proxyMode")]
        [Validation(Required=false)]
        public string ProxyMode { get; set; }

        /// <summary>
        /// <para>The ID of the region for the model service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>serviceRegionId</para>
        /// </summary>
        [NameInMap("serviceRegionId")]
        [Validation(Required=false)]
        public string ServiceRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the model proxy.</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
