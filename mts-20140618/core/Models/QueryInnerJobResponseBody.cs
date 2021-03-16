// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class QueryInnerJobResponseBody : TeaModel {
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Suggestion")]
        [Validation(Required=false)]
        public string Suggestion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Video")]
        [Validation(Required=false)]
        public QueryInnerJobResponseBodyVideo Video { get; set; }
        public class QueryInnerJobResponseBodyVideo : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }
        };

        [NameInMap("Image")]
        [Validation(Required=false)]
        public QueryInnerJobResponseBodyImage Image { get; set; }
        public class QueryInnerJobResponseBodyImage : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<QueryInnerJobResponseBodyImageResult> Result { get; set; }
            public class QueryInnerJobResponseBodyImageResult : TeaModel {
                public int? Index { get; set; }
                public int? Result { get; set; }
                public string Code { get; set; }
            }
        };

    }

}
