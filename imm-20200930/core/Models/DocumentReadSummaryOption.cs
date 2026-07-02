// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentReadSummaryOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to extract the chapter-level summary of the article.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ChapterSummarize")]
        [Validation(Required=false)]
        public bool? ChapterSummarize { get; set; }

        /// <summary>
        /// <para>The chapter-level summary options for the article.</para>
        /// </summary>
        [NameInMap("ChapterSummarizeOption")]
        [Validation(Required=false)]
        public DocumentChapterSummarizeOption ChapterSummarizeOption { get; set; }

        /// <summary>
        /// <para>Specifies whether to extract the article summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Summarize")]
        [Validation(Required=false)]
        public bool? Summarize { get; set; }

    }

}
