// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterSSLResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>amv-*********.ads.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-10-11T08:16:43Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>348303D8-6F42-5141-9B00-A6EECA1E37B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public bool? SSLEnabled { get; set; }

    }

}
