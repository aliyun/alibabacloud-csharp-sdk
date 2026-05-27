// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.STAROps20260428.Models
{
    public class FetchRemoteMcpToolsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0B9377D9-C56B-5C2E-A8A4-************</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;jsonrpc&quot;:&quot;2.0&quot;,&quot;id&quot;:1,&quot;result&quot;:{&quot;tools&quot;:[]}}</para>
        /// </summary>
        [NameInMap("tools")]
        [Validation(Required=false)]
        public string Tools { get; set; }

    }

}
