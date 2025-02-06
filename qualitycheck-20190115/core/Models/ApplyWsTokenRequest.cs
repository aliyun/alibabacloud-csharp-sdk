// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class ApplyWsTokenRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("BaseMeAgentId")]
        [Validation(Required=false)]
        public long? BaseMeAgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;business&quot;: &quot;test&quot;,
        ///     &quot;callType&quot;: 1,
        ///     &quot;callee&quot;: &quot;13111111111&quot;,
        ///     &quot;caller&quot;: &quot;13800000000&quot;,
        ///     &quot;skillGroupId&quot;: 1,
        ///     &quot;skillGroupName&quot;: &quot;test&quot;,
        ///     &quot;taskConfigId&quot;: 399,
        ///     &quot;tid&quot;: &quot;2025012412cb129e-1579-46b5-9326-1b2ececf8f30&quot;
        /// }</para>
        /// </summary>
        [NameInMap("JsonStr")]
        [Validation(Required=false)]
        public string JsonStr { get; set; }

    }

}
