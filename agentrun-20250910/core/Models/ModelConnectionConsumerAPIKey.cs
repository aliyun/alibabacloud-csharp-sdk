// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ModelConnectionConsumerAPIKey : TeaModel {
        /// <summary>
        /// <para>The unique identifier for the consumer API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789abc</para>
        /// </summary>
        [NameInMap("apiKeyId")]
        [Validation(Required=false)]
        public string ApiKeyId { get; set; }

        /// <summary>
        /// <para>The value of the consumer API key.</para>
        /// </summary>
        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
