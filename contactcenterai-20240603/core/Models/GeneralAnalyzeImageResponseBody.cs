// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class GeneralAnalyzeImageResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>stop</para>
        /// </summary>
        [NameInMap("finishReason")]
        [Validation(Required=false)]
        public string FinishReason { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("inputTokens")]
        [Validation(Required=false)]
        public int? InputTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("outputTokens")]
        [Validation(Required=false)]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D718325-92F9-5588-803B-C4A69A5F0AE1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public int? TotalTokens { get; set; }

    }

}
