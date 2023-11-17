// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPythonFileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Syntax")]
        [Validation(Required=false)]
        public List<VerifyPythonFileResponseBodySyntax> Syntax { get; set; }
        public class VerifyPythonFileResponseBodySyntax : TeaModel {
            [NameInMap("EndColumn")]
            [Validation(Required=false)]
            public int? EndColumn { get; set; }

            [NameInMap("EndLineNumber")]
            [Validation(Required=false)]
            public int? EndLineNumber { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Severity")]
            [Validation(Required=false)]
            public int? Severity { get; set; }

            [NameInMap("StartColumn")]
            [Validation(Required=false)]
            public int? StartColumn { get; set; }

            [NameInMap("StartLineNumber")]
            [Validation(Required=false)]
            public int? StartLineNumber { get; set; }

        }

    }

}
