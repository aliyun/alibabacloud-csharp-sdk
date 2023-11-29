// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetLogsV2Headers : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// The compression method.
        /// </summary>
        [NameInMap("Accept-Encoding")]
        [Validation(Required=false)]
        public string AcceptEncoding { get; set; }

    }

}
