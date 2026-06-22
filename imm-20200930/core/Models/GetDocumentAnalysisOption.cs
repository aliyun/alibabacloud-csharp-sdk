// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDocumentAnalysisOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to generate summaries for each chapter. Set to <c>true</c> to enable this feature. Use <c>ChapterSummaryOption</c> to configure detailed options. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("ChapterSummary")]
        [Validation(Required=false)]
        public bool? ChapterSummary { get; set; }

        [NameInMap("ChapterSummaryOption")]
        [Validation(Required=false)]
        public DocumentChapterSummarizeOption ChapterSummaryOption { get; set; }

        /// <summary>
        /// <para>Specifies whether to analyze each image within the document. Set to <c>true</c> to enable this feature. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public bool? Images { get; set; }

        /// <summary>
        /// <para>Specifies whether to extract keywords from the document. Set to <c>true</c> to enable this feature. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public bool? Keyword { get; set; }

        /// <summary>
        /// <para>Specifies whether to analyze the document layout. Set to <c>true</c> to enable this feature. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public bool? Layouts { get; set; }

        /// <summary>
        /// <para>Specifies whether to identify the narrator in the document. Set to <c>true</c> to enable this feature. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("Narrator")]
        [Validation(Required=false)]
        public bool? Narrator { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate questions based on the document content. Set to <c>true</c> to enable this feature. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public bool? Question { get; set; }

        /// <summary>
        /// <para>Specifies whether to generate a summary for the document. Set to <c>true</c> to enable this feature. Defaults to <c>false</c>.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public bool? Summary { get; set; }

    }

}
