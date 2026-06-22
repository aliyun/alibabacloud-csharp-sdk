// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentParseOption : TeaModel {
        /// <summary>
        /// <para>Document parsing keyword extraction options</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public DocumentParseKeywordOption Keyword { get; set; }

        /// <summary>
        /// <para>Document parsing guidance options</para>
        /// </summary>
        [NameInMap("Narrator")]
        [Validation(Required=false)]
        public DocumentParseNarratorOption Narrator { get; set; }

        /// <summary>
        /// <para>Document parsing question generation options</para>
        /// </summary>
        [NameInMap("Question")]
        [Validation(Required=false)]
        public DocumentParseQuestionOption Question { get; set; }

        /// <summary>
        /// <para>Document parsing summary options</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DocumentParseSummaryOption Summary { get; set; }

    }

}
