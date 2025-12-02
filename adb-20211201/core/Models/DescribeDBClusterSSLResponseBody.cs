// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeDBClusterSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoint that is protected by SSL encryption.</para>
        /// 
        /// <b>Example:</b>
        /// <para>amv-*********.ads.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The validity period of the SSL certificate. Format: yyyy-MM-ddTHH:mm:ssZ(UTC time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-10-11T08:16:43Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348303D8-6F42-5141-9B00-A6EECA1E37B6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether SSL encryption is enabled. Default value: true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enabled</description></item>
        /// <item><description>false: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public bool? SSLEnabled { get; set; }

    }

}
