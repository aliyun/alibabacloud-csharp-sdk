// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelConnection : TeaModel {
        /// <summary>
        /// <para>绑定的消费者API密钥列表</para>
        /// </summary>
        [NameInMap("consumerApiKeys")]
        [Validation(Required=false)]
        public List<ModelConnectionConsumerAPIKey> ConsumerApiKeys { get; set; }

        /// <summary>
        /// <para>模型连接的创建时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>模型连接的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAI GPT-4 connection for production</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>模型连接最后一次更新的时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>模型连接的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1234567890abcdef</para>
        /// </summary>
        [NameInMap("modelConnectionId")]
        [Validation(Required=false)]
        public string ModelConnectionId { get; set; }

        /// <summary>
        /// <para>模型连接的唯一名称标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-openai-connection</para>
        /// </summary>
        [NameInMap("modelConnectionName")]
        [Validation(Required=false)]
        public string ModelConnectionName { get; set; }

        /// <summary>
        /// <para>模型元数据配置列表，包含各个模型的功能特性和参数规则</para>
        /// </summary>
        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        /// <summary>
        /// <para>模型提供商名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>模型提供商的配置信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public ModelConnectionProviderSettings ProviderSettings { get; set; }

        /// <summary>
        /// <para>模型连接所属的工作空间标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
