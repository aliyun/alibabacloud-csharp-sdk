// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the SSL certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bpxxxxxxxx.mongodb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CertCommonName")]
        [Validation(Required=false)]
        public string CertCommonName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36BB1BC2-789C-4BBA-A519-C5B388E4B0D4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The time when the SSL certificate expires. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in Coordinated Universal Time (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-11T02:28:25Z</para>
        /// </summary>
        [NameInMap("SSLExpiredTime")]
        [Validation(Required=false)]
        public string SSLExpiredTime { get; set; }

        /// <summary>
        /// <para>The status of the SSL feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Open</b>: The SSL feature is enabled.</description></item>
        /// <item><description><b>Closed</b>: The SSL feature is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Open</para>
        /// </summary>
        [NameInMap("SSLStatus")]
        [Validation(Required=false)]
        public string SSLStatus { get; set; }

    }

}
