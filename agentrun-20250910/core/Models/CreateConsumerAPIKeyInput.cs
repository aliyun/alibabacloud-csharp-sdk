// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateConsumerAPIKeyInput : TeaModel {
        /// <summary>
        /// <para>A custom API key. If omitted, the service generates one automatically.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>A description for the consumer API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于生产环境的API密钥</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The identifier for the model connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1234567890abcdef</para>
        /// </summary>
        [NameInMap("modelConnectionId")]
        [Validation(Required=false)]
        public string ModelConnectionId { get; set; }

    }

}
