// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelConnection : TeaModel {
        /// <summary>
        /// <para>A list of consumer API keys bound to this model connection.</para>
        /// </summary>
        [NameInMap("consumerApiKeys")]
        [Validation(Required=false)]
        public List<ModelConnectionConsumerAPIKey> ConsumerApiKeys { get; set; }

        /// <summary>
        /// <para>The time the model connection was created, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

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
        /// <para>The time the model connection was last updated, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The model connection\&quot;s unique identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1234567890abcdef</para>
        /// </summary>
        [NameInMap("modelConnectionId")]
        [Validation(Required=false)]
        public string ModelConnectionId { get; set; }

        /// <summary>
        /// <para>A unique name identifying the model connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-openai-connection</para>
        /// </summary>
        [NameInMap("modelConnectionName")]
        [Validation(Required=false)]
        public string ModelConnectionName { get; set; }

        /// <summary>
        /// <para>A list of model metadata configurations. Each configuration includes the features and parameter rules for a specific model.</para>
        /// </summary>
        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        /// <summary>
        /// <para>The model provider\&quot;s name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openai</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The settings for the model provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public ModelConnectionProviderSettings ProviderSettings { get; set; }

        /// <summary>
        /// <para>The identifier of the workspace containing the model connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ws-1234567890abcdef</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
