// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DecodeDiagnosticMessageRequest : TeaModel {
        /// <summary>
        /// <para>The encoded diagnostic information in the response that contains an access denied error. The error is caused by no RAM permissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AQEAAAAAZBgxr0U1MjA1NTM1LUM4BBktMzE5RS1CODgxLUU1QTI0RDNFQTM1****</para>
        /// </summary>
        [NameInMap("EncodedDiagnosticMessage")]
        [Validation(Required=false)]
        public string EncodedDiagnosticMessage { get; set; }

    }

}
