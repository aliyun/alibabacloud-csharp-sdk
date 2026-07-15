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
        /// <para>Specifies whether connections must be encrypted using SSL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Connections must be encrypted using SSL.</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: Connections do not need to be encrypted using SSL.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ForceEncryption")]
        [Validation(Required=false)]
        public string ForceEncryption { get; set; }

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
        /// <para>The expiration time of the SSL certificate. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format and is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-03-11T02:28:25Z</para>
        /// </summary>
        [NameInMap("SSLExpiredTime")]
        [Validation(Required=false)]
        public string SSLExpiredTime { get; set; }

        /// <summary>
        /// <para>The status of the SSL feature.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Open</b>: The SSL feature is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>Closed</b>: The SSL feature is disabled.</para>
        /// </description></item>
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
