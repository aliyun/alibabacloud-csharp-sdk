// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class UpdateModelConnectionInput : TeaModel {
        /// <summary>
        /// <para>更新绑定的消费者API密钥列表</para>
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
        /// <para>更新后的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>Updated connection description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>更新后的模型元数据配置列表</para>
        /// </summary>
        [NameInMap("modelInfoConfigs")]
        [Validation(Required=false)]
        public List<ModelInfoConfig> ModelInfoConfigs { get; set; }

        /// <summary>
        /// <para>更新后的模型提供商配置信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("providerSettings")]
        [Validation(Required=false)]
        public ModelConnectionProviderSettings ProviderSettings { get; set; }

    }

}
