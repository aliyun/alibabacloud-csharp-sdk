// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateConsumerAPIKeyOutput : TeaModel {
        /// <summary>
        /// <para>Indicates whether the consumer API key is active.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>The complete plaintext API key. This key is returned only upon creation and cannot be retrieved again. Store it securely.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>The unique identifier of the consumer API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789abc</para>
        /// </summary>
        [NameInMap("consumerApiKeyId")]
        [Validation(Required=false)]
        public string ConsumerApiKeyId { get; set; }

        /// <summary>
        /// <para>The creation time, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>A description of the consumer API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于生产环境的API密钥</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The last update time, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>A masked version of the API key for display purposes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-****1234</para>
        /// </summary>
        [NameInMap("maskedKey")]
        [Validation(Required=false)]
        public string MaskedKey { get; set; }

        /// <summary>
        /// <para>The associated model connection identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1234567890abcdef</para>
        /// </summary>
        [NameInMap("modelConnectionId")]
        [Validation(Required=false)]
        public string ModelConnectionId { get; set; }

    }

}
