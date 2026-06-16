// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateRateLimitRuleInput : TeaModel {
        /// <summary>
        /// <para>The descriptor ID for the rate limit rule. This parameter is required if the descriptor type is not <c>model</c>. For <c>model</c> types, the server assembles the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model:gpt-4</para>
        /// </summary>
        [NameInMap("descriptorId")]
        [Validation(Required=false)]
        public string DescriptorId { get; set; }

        /// <summary>
        /// <para>The descriptor type for the rate limit rule, such as <c>model</c> or <c>user</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model</para>
        /// </summary>
        [NameInMap("descriptorType")]
        [Validation(Required=false)]
        public string DescriptorType { get; set; }

        /// <summary>
        /// <para>Whether to enable the rate limit rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>A list of time window configurations. At least one window is required.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("windows")]
        [Validation(Required=false)]
        public List<WindowLimit> Windows { get; set; }

    }

}
