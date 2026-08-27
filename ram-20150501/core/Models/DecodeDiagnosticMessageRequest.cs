// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class DecodeDiagnosticMessageRequest : TeaModel {
        /// <summary>
        /// <para>The encoded diagnostic message obtained from the <c>AccessDeniedDetail.EncodedDiagnosticMessage</c> field in the response body when an API request is denied due to insufficient permissions. Pass this parameter to decode the permission diagnostic information when calling this operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AQEAAAAAZBgxr0U1MjA1NTM1LUM4BBktMzE5RS1CODgxLUU1QTI0RDNFQTM1****</para>
        /// </summary>
        [NameInMap("EncodedDiagnosticMessage")]
        [Validation(Required=false)]
        public string EncodedDiagnosticMessage { get; set; }

    }

}
