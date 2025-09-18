// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetTableTokenResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1749160909000</para>
        /// </summary>
        [NameInMap("expiresAtMillis")]
        [Validation(Required=false)]
        public long? ExpiresAtMillis { get; set; }

        [NameInMap("token")]
        [Validation(Required=false)]
        public Dictionary<string, string> Token { get; set; }

    }

}
