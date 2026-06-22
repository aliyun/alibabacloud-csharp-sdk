// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class VideoReadOption : TeaModel {
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public VideoReadKeywordOption Keyword { get; set; }

        [NameInMap("PPT")]
        [Validation(Required=false)]
        public VideoReadPPTOption PPT { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public VideoReadQuestionOption Question { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public VideoReadSummaryOption Summary { get; set; }

    }

}
