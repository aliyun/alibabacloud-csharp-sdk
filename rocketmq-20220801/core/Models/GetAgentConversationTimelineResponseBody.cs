// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetAgentConversationTimelineResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;seq&quot;:1,&quot;type&quot;:&quot;user&quot;}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public object Items { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("replayCursor")]
        [Validation(Required=false)]
        public long? ReplayCursor { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;run_01&quot;:&quot;up&quot;}</para>
        /// </summary>
        [NameInMap("responseFeedback")]
        [Validation(Required=false)]
        public object ResponseFeedback { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[{&quot;id&quot;:&quot;run_01&quot;,&quot;modelId&quot;:&quot;qwen3-coder&quot;}]</para>
        /// </summary>
        [NameInMap("runs")]
        [Validation(Required=false)]
        public object Runs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>events</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
