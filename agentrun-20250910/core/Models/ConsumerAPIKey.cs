// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ConsumerAPIKey : TeaModel {
        /// <summary>
        /// <para>Specifies if the key is enabled (true) or disabled (false).</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

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
        /// <para>The creation time of the consumer API key, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>A user-defined description for the consumer API key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于生产环境的API密钥</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The last update time of the consumer API key, in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>The masked API key, showing only the first and last few characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-****1234</para>
        /// </summary>
        [NameInMap("maskedKey")]
        [Validation(Required=false)]
        public string MaskedKey { get; set; }

        /// <summary>
        /// <para>The identifier of the associated model connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1234567890abcdef</para>
        /// </summary>
        [NameInMap("modelConnectionId")]
        [Validation(Required=false)]
        public string ModelConnectionId { get; set; }

    }

}
