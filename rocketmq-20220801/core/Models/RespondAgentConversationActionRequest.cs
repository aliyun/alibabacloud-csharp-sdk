// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class RespondAgentConversationActionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;请选择实例地域&quot;:&quot;华东 1（杭州）&quot;}</para>
        /// </summary>
        [NameInMap("answers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Answers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>allow</para>
        /// </summary>
        [NameInMap("decision")]
        [Validation(Required=false)]
        public string Decision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>允许执行只读查询</para>
        /// </summary>
        [NameInMap("note")]
        [Validation(Required=false)]
        public string Note { get; set; }

    }

}
