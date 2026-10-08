// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentReadOption : TeaModel {
        /// <summary>
        /// <para>The document intensive reading keyword extraction options.</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public DocumentReadKeywordOption Keyword { get; set; }

        /// <summary>
        /// <para>The document intensive reading guide options.</para>
        /// </summary>
        [NameInMap("Narrator")]
        [Validation(Required=false)]
        public DocumentReadNarratorOption Narrator { get; set; }

        /// <summary>
        /// <para>The document intensive reading question guide options.</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public DocumentReadQuestionOption Question { get; set; }

        /// <summary>
        /// <para>The document intensive reading summary options.</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DocumentReadSummaryOption Summary { get; set; }

    }

}
