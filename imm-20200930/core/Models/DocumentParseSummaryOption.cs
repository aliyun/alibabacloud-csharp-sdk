// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentParseSummaryOption : TeaModel {
        /// <summary>
        /// <para>Document chapter summary</para>
        /// </summary>
        [NameInMap("ChapterSummarize")]
        [Validation(Required=false)]
        public bool? ChapterSummarize { get; set; }

        /// <summary>
        /// <para>Article summary</para>
        /// </summary>
        [NameInMap("Summarize")]
        [Validation(Required=false)]
        public bool? Summarize { get; set; }

    }

}
