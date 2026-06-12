// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class SubmitAsyncSqlHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// <para>The data format of the response. The value must be application/x-protobuf.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application/x-protobuf</para>
        /// </summary>
        [NameInMap("Accept")]
        [Validation(Required=false)]
        public string Accept { get; set; }

        /// <summary>
        /// <para>The compression format of the response. The value can be lz4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lz4</para>
        /// </summary>
        [NameInMap("Accept-Encoding")]
        [Validation(Required=false)]
        public string AcceptEncoding { get; set; }

    }

}
