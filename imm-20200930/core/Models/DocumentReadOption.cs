// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentReadOption : TeaModel {
        /// <summary>
        /// <para>Configuration for extracting keywords from the document.</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public DocumentReadKeywordOption Keyword { get; set; }

        /// <summary>
        /// <para>Configuration for the text-to-speech (TTS) narrator.</para>
        /// </summary>
        [NameInMap("Narrator")]
        [Validation(Required=false)]
        public DocumentReadNarratorOption Narrator { get; set; }

        /// <summary>
        /// <para>Configuration for the question-answering (Q\&amp;A) feature, which answers questions based on the document\&quot;s content.</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public DocumentReadQuestionOption Question { get; set; }

        /// <summary>
        /// <para>Configuration for generating a document summary.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DocumentReadSummaryOption Summary { get; set; }

    }

}
