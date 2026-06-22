// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentReadSummaryOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to generate a summary for each chapter. This setting applies only if the service can identify chapters.</para>
        /// <para><b>Default value</b>: <c>false</c>.</para>
        /// </summary>
        [NameInMap("ChapterSummarize")]
        [Validation(Required=false)]
        public bool? ChapterSummarize { get; set; }

        [NameInMap("ChapterSummarizeOption")]
        [Validation(Required=false)]
        public DocumentChapterSummarizeOption ChapterSummarizeOption { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a summary for the entire document.</para>
        /// <para><b>Default value</b>: <c>false</c>.</para>
        /// </summary>
        [NameInMap("Summarize")]
        [Validation(Required=false)]
        public bool? Summarize { get; set; }

    }

}
