// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class ListSolutionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Solutions")]
        [Validation(Required=false)]
        public List<ListSolutionResponseBodySolutions> Solutions { get; set; }
        public class ListSolutionResponseBodySolutions : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public int? ContentType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("PerspectiveCodes")]
            [Validation(Required=false)]
            public List<string> PerspectiveCodes { get; set; }

            [NameInMap("PlainText")]
            [Validation(Required=false)]
            public string PlainText { get; set; }

            [NameInMap("SolutionId")]
            [Validation(Required=false)]
            public long? SolutionId { get; set; }

        }

    }

}
