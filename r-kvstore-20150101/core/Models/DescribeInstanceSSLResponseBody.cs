// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceSSLResponseBody : TeaModel {
        /// <summary>
        /// <para>The common name of the CA certificate. The default value is the internal endpoint of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****.redis.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CertCommonName")]
        [Validation(Required=false)]
        public string CertCommonName { get; set; }

        /// <summary>
        /// <para>The download URL of the CA certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://apsaradb-public.oss-ap-sout****-1.aliy****.com/ApsaraDB-CA-Chain.zip">https://apsaradb-public.oss-ap-sout****-1.aliy****.com/ApsaraDB-CA-Chain.zip</a></para>
        /// </summary>
        [NameInMap("CertDownloadURL")]
        [Validation(Required=false)]
        public string CertDownloadURL { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02260F96-913E-4655-9BA5-A3651CAF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the TLS (SSL) encryption feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: SSL encryption is enabled.</description></item>
        /// <item><description><b>Disable</b>: SSL encryption is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public string SSLEnabled { get; set; }

        /// <summary>
        /// <para>The time when the CA certificate expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-05T09:05:53Z</para>
        /// </summary>
        [NameInMap("SSLExpiredTime")]
        [Validation(Required=false)]
        public string SSLExpiredTime { get; set; }

    }

}
