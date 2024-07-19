// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceDiagnosisResponseBody : TeaModel {
        /// <summary>
        /// The diagnostics list.
        /// </summary>
        [NameInMap("DiagnosisList")]
        [Validation(Required=false)]
        public List<DescribeServiceDiagnosisResponseBodyDiagnosisList> DiagnosisList { get; set; }
        public class DescribeServiceDiagnosisResponseBodyDiagnosisList : TeaModel {
            /// <summary>
            /// The suggestions about how to handle the errors.
            /// </summary>
            [NameInMap("Advices")]
            [Validation(Required=false)]
            public List<string> Advices { get; set; }

            /// <summary>
            /// The causes of the errors.
            /// </summary>
            [NameInMap("Causes")]
            [Validation(Required=false)]
            public List<string> Causes { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
