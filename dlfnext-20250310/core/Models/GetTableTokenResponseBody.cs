// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetTableTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The expiration time of the temporary access credential.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1749160909000</para>
        /// </summary>
        [NameInMap("expiresAtMillis")]
        [Validation(Required=false)]
        public long? ExpiresAtMillis { get; set; }

        /// <summary>
        /// <para>The temporary access credential for the catalog hosting the table.</para>
        /// </summary>
        [NameInMap("token")]
        [Validation(Required=false)]
        public Dictionary<string, string> Token { get; set; }

    }

}
