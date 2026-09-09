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
        /// <para>The compression method for the response content. SDK users do not need to specify this parameter because the SDK automatically handles compression and decompression.</para>
        /// <list type="bullet">
        /// <item><description><para>Java, Python, and Go currently support lz4 and gzip decompression.</para>
        /// </description></item>
        /// <item><description><para>php, JavaScript, and C# currently support only gzip decompression.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lz4</para>
        /// </summary>
        [NameInMap("Accept-Encoding")]
        [Validation(Required=false)]
        public string AcceptEncoding { get; set; }

    }

}
