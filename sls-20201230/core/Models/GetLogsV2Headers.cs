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
        /// <para>The compression format.</para>
        /// <list type="bullet">
        /// <item><description>For Java, Python, and Go, only the lz4 and gzip algorithms are supported for decompression.</description></item>
        /// <item><description>For PHP, JavaScript, and C#, only the gzip algorithm is supported for decompression.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lz4</para>
        /// </summary>
        [NameInMap("Accept-Encoding")]
        [Validation(Required=false)]
        public string AcceptEncoding { get; set; }

    }

}
