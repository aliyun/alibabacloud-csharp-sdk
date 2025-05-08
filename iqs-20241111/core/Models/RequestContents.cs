// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class RequestContents : TeaModel {
        [NameInMap("mainText")]
        [Validation(Required=false)]
        public bool? MainText { get; set; }

        [NameInMap("markdownText")]
        [Validation(Required=false)]
        public bool? MarkdownText { get; set; }

        [NameInMap("rerankScore")]
        [Validation(Required=false)]
        public bool? RerankScore { get; set; }

        [NameInMap("summary")]
        [Validation(Required=false)]
        public bool? Summary { get; set; }

    }

}
