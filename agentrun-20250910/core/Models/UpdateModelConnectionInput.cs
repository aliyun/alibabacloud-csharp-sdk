// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateModelConnectionInput : TeaModel {
        /// <summary>
        /// <para>A list of consumer API keys to associate with the model connection.</para>
        /// </summary>
        [NameInMap("consumerApiKeys")]
        [Validation(Required=false)]
        public List<UpdateModelConnectionInputConsumerApiKeys> ConsumerApiKeys { get; set; }
        public class UpdateModelConnectionInputConsumerApiKeys : TeaModel {
            [NameInMap("apiKeyId")]
            [Validation(Required=false)]
            public string ApiKeyId { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>A new description for the model connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Updated connection description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A new list of model metadata configurations.</para>
        /// </summary>
        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        /// <summary>
        /// <para>A new configuration for the model provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public ModelConnectionProviderSettings ProviderSettings { get; set; }

    }

}
