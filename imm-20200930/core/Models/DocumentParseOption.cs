// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DocumentParseOption : TeaModel {
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public DocumentParseKeywordOption Keyword { get; set; }

        [NameInMap("Narrator")]
        [Validation(Required=false)]
        public DocumentParseNarratorOption Narrator { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public DocumentParseQuestionOption Question { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public DocumentParseSummaryOption Summary { get; set; }

    }

}
