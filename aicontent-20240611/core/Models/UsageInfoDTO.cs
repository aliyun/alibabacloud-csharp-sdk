// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class UsageInfoDTO : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("completionTokens")]
        [Validation(Required=false)]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("imageCount")]
        [Validation(Required=false)]
        public int? ImageCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("promptTokens")]
        [Validation(Required=false)]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>150</para>
        /// </summary>
        [NameInMap("totalTokens")]
        [Validation(Required=false)]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("videoCount")]
        [Validation(Required=false)]
        public int? VideoCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("videoDuration")]
        [Validation(Required=false)]
        public int? VideoDuration { get; set; }

    }

}
