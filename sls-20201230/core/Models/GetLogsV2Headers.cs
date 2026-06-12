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
        /// <para>The compression method.</para>
        /// <list type="bullet">
        /// <item><description><para>Java, Python, and Go support lz4 and gzip decompression.</para>
        /// </description></item>
        /// <item><description><para>PHP, JavaScript, and C# support gzip decompression only.</para>
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
