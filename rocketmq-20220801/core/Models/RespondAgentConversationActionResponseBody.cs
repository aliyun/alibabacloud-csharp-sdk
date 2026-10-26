// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RocketMQ20220801.Models
{
    public class RespondAgentConversationActionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("accepted")]
        [Validation(Required=false)]
        public bool? Accepted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("continuationCreated")]
        [Validation(Required=false)]
        public bool? ContinuationCreated { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0198c8a91f4d7f01a3c21e98</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

    }

}
