// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateConsumerAPIKeyOutput : TeaModel {
        /// <summary>
        /// <para>密钥是否启用</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// <para>完整的API密钥明文，仅在创建时返回一次，请妥善保存</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-xxxxxxxxxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// <para>消费者API密钥的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789abc</para>
        /// </summary>
        [NameInMap("consumerApiKeyId")]
        [Validation(Required=false)]
        public string ConsumerApiKeyId { get; set; }

        /// <summary>
        /// <para>创建时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>消费者API密钥的描述信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于生产环境的API密钥</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>更新时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>API密钥的掩码展示形式</para>
        /// 
        /// <b>Example:</b>
        /// <para>sk-****1234</para>
        /// </summary>
        [NameInMap("maskedKey")]
        [Validation(Required=false)]
        public string MaskedKey { get; set; }

        /// <summary>
        /// <para>关联的模型连接标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-1234567890abcdef</para>
        /// </summary>
        [NameInMap("modelConnectionId")]
        [Validation(Required=false)]
        public string ModelConnectionId { get; set; }

    }

}
