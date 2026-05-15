// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ConsumerAPIKey : TeaModel {
        /// <summary>
        /// <para>密钥是否启用，true表示启用，false表示禁用</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("active")]
        [Validation(Required=false)]
        public bool? Active { get; set; }

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
        /// <para>消费者API密钥的创建时间，采用ISO 8601格式</para>
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
        /// <para>消费者API密钥最后一次更新的时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>API密钥的掩码展示形式，仅显示前后几位字符</para>
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
