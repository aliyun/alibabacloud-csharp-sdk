// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class RunCompletionMessageResponseBody : TeaModel {
        [NameInMap("FinishReason")]
        [Validation(Required=false)]
        public string FinishReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>17204B98-xxxx-4F9A-8464-2446A84821CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("inputTokens")]
        [Validation(Required=false)]
        public string InputTokens { get; set; }

        [NameInMap("outputTokens")]
        [Validation(Required=false)]
        public string OutputTokens { get; set; }

        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public string TotalTokens { get; set; }

    }

}
