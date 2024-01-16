// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class VerifyPythonFileResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The verification result. If the parameter is left empty, the syntax of the code snippet is correct.
        /// </summary>
        [NameInMap("Syntax")]
        [Validation(Required=false)]
        public List<VerifyPythonFileResponseBodySyntax> Syntax { get; set; }
        public class VerifyPythonFileResponseBodySyntax : TeaModel {
            /// <summary>
            /// The number that indicates the end column of the error code.
            /// </summary>
            [NameInMap("EndColumn")]
            [Validation(Required=false)]
            public int? EndColumn { get; set; }

            /// <summary>
            /// The number that indicates the end line of the error code.
            /// </summary>
            [NameInMap("EndLineNumber")]
            [Validation(Required=false)]
            public int? EndLineNumber { get; set; }

            /// <summary>
            /// The error message for the error code.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The severity level of the error code. Valid values:
            /// 
            /// *   4: moderate
            /// *   8: serious
            /// </summary>
            [NameInMap("Severity")]
            [Validation(Required=false)]
            public int? Severity { get; set; }

            /// <summary>
            /// The number that indicates the start column of the error code.
            /// </summary>
            [NameInMap("StartColumn")]
            [Validation(Required=false)]
            public int? StartColumn { get; set; }

            /// <summary>
            /// The number that indicates the start line of the error code.
            /// </summary>
            [NameInMap("StartLineNumber")]
            [Validation(Required=false)]
            public int? StartLineNumber { get; set; }

        }

    }

}
