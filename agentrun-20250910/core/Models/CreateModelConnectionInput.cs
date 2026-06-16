// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateModelConnectionInput : TeaModel {
        /// <summary>
        /// <para>A list of consumer API keys for the model connection. If this list is empty, the connection enters open mode.</para>
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
        /// <para>A description of the model connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAI GPT-4 connection for production</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A unique name for the model connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-openai-connection</para>
        /// </summary>
        [NameInMap("modelConnectionName")]
        [Validation(Required=false)]
        public string ModelConnectionName { get; set; }

        /// <summary>
        /// <para>A list of model metadata configurations.</para>
        /// </summary>
        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        /// <summary>
        /// <para>The model provider name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>Configuration settings for the model provider, such as the base URL and a list of models.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public ModelConnectionProviderSettings ProviderSettings { get; set; }

        /// <summary>
        /// <para>The ID of the workspace containing the model connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
