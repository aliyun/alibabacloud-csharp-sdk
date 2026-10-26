// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class GetAgentConversationTimelineRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>42</para>
        /// </summary>
        [NameInMap("after")]
        [Validation(Required=false)]
        public long? After { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("includeImageData")]
        [Validation(Required=false)]
        public bool? IncludeImageData { get; set; }

    }

}
