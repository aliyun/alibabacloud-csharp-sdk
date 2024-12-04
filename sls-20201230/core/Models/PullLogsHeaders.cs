// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class PullLogsHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lz4</para>
        /// </summary>
        [NameInMap("Accept-Encoding")]
        [Validation(Required=false)]
        public string AcceptEncoding { get; set; }

    }

}
