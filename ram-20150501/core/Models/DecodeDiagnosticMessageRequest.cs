// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DecodeDiagnosticMessageRequest : TeaModel {
        /// <summary>
        /// The encoded diagnostic information in the response that contains an access denied error. The error is caused by no RAM permissions.
        /// </summary>
        [NameInMap("EncodedDiagnosticMessage")]
        [Validation(Required=false)]
        public string EncodedDiagnosticMessage { get; set; }

    }

}
