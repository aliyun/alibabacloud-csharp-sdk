// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class RateLimitRule : TeaModel {
        /// <summary>
        /// <para>限流规则的创建时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T10:30:00Z</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>限流规则的描述符标识，用于关联具体的限流对象</para>
        /// 
        /// <b>Example:</b>
        /// <para>model:gpt-4</para>
        /// </summary>
        [NameInMap("descriptorId")]
        [Validation(Required=false)]
        public string DescriptorId { get; set; }

        /// <summary>
        /// <para>限流规则的描述符类型，如model、user等</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("descriptorType")]
        [Validation(Required=false)]
        public string DescriptorType { get; set; }

        /// <summary>
        /// <para>限流规则是否启用，true表示启用，false表示禁用</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>限流规则最后一次更新的时间，采用ISO 8601格式</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-01-10T11:45:00Z</para>
        /// </summary>
        [NameInMap("lastUpdatedAt")]
        [Validation(Required=false)]
        public string LastUpdatedAt { get; set; }

        /// <summary>
        /// <para>限流规则的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678-1234-1234-1234-123456789abc</para>
        /// </summary>
        [NameInMap("rateLimitRuleId")]
        [Validation(Required=false)]
        public string RateLimitRuleId { get; set; }

        /// <summary>
        /// <para>限流时间窗口配置列表，支持多个窗口叠加限流</para>
        /// </summary>
        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<WindowLimit> Windows { get; set; }

    }

}
