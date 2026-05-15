// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateModelConnectionInput : TeaModel {
        /// <summary>
        /// <para>要绑定的消费者API密钥列表；空表示开放模式</para>
        /// </summary>
        [NameInMap("consumerApiKeys")]
        [Validation(Required=false)]
        public List<CreateModelConnectionInputConsumerApiKeys> ConsumerApiKeys { get; set; }
        public class CreateModelConnectionInputConsumerApiKeys : TeaModel {
            [NameInMap("apiKeyId")]
            [Validation(Required=false)]
            public string ApiKeyId { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
        /// <para>模型连接的唯一名称标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-openai-connection</para>
        /// </summary>
        [NameInMap("modelConnectionName")]
        [Validation(Required=false)]
        public string ModelConnectionName { get; set; }

        /// <summary>
        /// <para>模型元数据配置列表</para>
        /// </summary>
        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        /// <summary>
        /// <para>模型提供商名称</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>模型提供商的配置信息，包括基础URL、模型列表等</para>
        /// <para>This parameter is required.</para>
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
