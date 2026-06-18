// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The data structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDBInstanceSSLResponseBodyData Data { get; set; }
        public class DescribeDBInstanceSSLResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The domain name bound to the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-sddddddcym7g7w****.polarx.singapore.rds.aliyuncs.com</para>
            /// </summary>
            [NameInMap("CertCommonName")]
            [Validation(Required=false)]
            public string CertCommonName { get; set; }

            /// <summary>
            /// <para>Indicates whether SSL is enabled for the instance:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled</description></item>
            /// <item><description><b>false</b>: disabled</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SSLEnabled")]
            [Validation(Required=false)]
            public bool? SSLEnabled { get; set; }

            /// <summary>
            /// <para>The expiration time of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-11-04T09:39:07Z</para>
            /// </summary>
            [NameInMap("SSLExpiredTime")]
            [Validation(Required=false)]
            public string SSLExpiredTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
