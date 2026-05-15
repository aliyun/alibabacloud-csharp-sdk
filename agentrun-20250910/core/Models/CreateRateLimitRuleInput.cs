// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateRateLimitRuleInput : TeaModel {
        /// <summary>
        /// <para>限流规则的描述符标识；非model维时必填，model维由服务端拼接</para>
        /// 
        /// <b>Example:</b>
        /// <para>model:gpt-4</para>
        /// </summary>
        [NameInMap("descriptorId")]
        [Validation(Required=false)]
        public string DescriptorId { get; set; }

        /// <summary>
        /// <para>限流规则的描述符类型，如model、user等</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("descriptorType")]
        [Validation(Required=false)]
        public string DescriptorType { get; set; }

        /// <summary>
        /// <para>是否启用该限流规则</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>限流时间窗口配置列表，至少需要一个窗口</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<WindowLimit> Windows { get; set; }

    }

}
