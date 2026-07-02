// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetDocumentAnalysisOption : TeaModel {
        /// <summary>
        /// <para>Specifies whether to retrieve chapter-by-chapter summaries of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ChapterSummary")]
        [Validation(Required=false)]
        public bool? ChapterSummary { get; set; }

        /// <summary>
        /// <para>The options for retrieving chapter-by-chapter summaries of the document.</para>
        /// </summary>
        [NameInMap("ChapterSummaryOption")]
        [Validation(Required=false)]
        public DocumentChapterSummarizeOption ChapterSummaryOption { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve images extracted from the document, such as pictures, tables, and formulas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public bool? Images { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve keywords.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public bool? Keyword { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the layout.jsonl file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Layouts")]
        [Validation(Required=false)]
        public bool? Layouts { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the document reading guide results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Narrator")]
        [Validation(Required=false)]
        public bool? Narrator { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the generated questions and corresponding answers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public bool? Question { get; set; }

        /// <summary>
        /// <para>Specifies whether to retrieve the full-text summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public bool? Summary { get; set; }

    }

}
