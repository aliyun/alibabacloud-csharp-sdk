// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutComponentsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryLinkeBahamutComponentsResponseBodyResult> Result { get; set; }
        public class QueryLinkeBahamutComponentsResponseBodyResult : TeaModel {
            [NameInMap("AllowSkip")]
            [Validation(Required=false)]
            public bool? AllowSkip { get; set; }

            [NameInMap("Disable")]
            [Validation(Required=false)]
            public bool? Disable { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("Expression")]
            [Validation(Required=false)]
            public string Expression { get; set; }

            [NameInMap("ExpressionDesc")]
            [Validation(Required=false)]
            public string ExpressionDesc { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("GmtModify")]
            [Validation(Required=false)]
            public long? GmtModify { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Manual")]
            [Validation(Required=false)]
            public bool? Manual { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RestUrl")]
            [Validation(Required=false)]
            public string RestUrl { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
