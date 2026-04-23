// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ListSSLDetailsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListSSLDetailsResponseBodyData Data { get; set; }
        public class ListSSLDetailsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>starrocks-ssl</para>
            /// </summary>
            [NameInMap("Aliases")]
            [Validation(Required=false)]
            public string Aliases { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CustomCert")]
            [Validation(Required=false)]
            public bool? CustomCert { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableSSL")]
            [Validation(Required=false)]
            public bool? EnableSSL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsValid")]
            [Validation(Required=false)]
            public bool? IsValid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN=fe-sr-cn-xxx123-internal.starrocks.aliyuncs.com, OU=Aliyun Big Data Platform EMR StarRocks, O=Aliyun, L=BJ, ST=CN, C=CN</para>
            /// </summary>
            [NameInMap("IssuerDN")]
            [Validation(Required=false)]
            public string IssuerDN { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1751010702000</para>
            /// </summary>
            [NameInMap("NotAfter")]
            [Validation(Required=false)]
            public long? NotAfter { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1751000702000</para>
            /// </summary>
            [NameInMap("NotBefore")]
            [Validation(Required=false)]
            public long? NotBefore { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MIIJkAIBAzCCCVYGCSqGSIb3DQEHAaCCCUcEgglDMIIJPzCCA+8GCSqGSIb3DQEHBqCCA+AwggPc
            /// AgEAMIID1QYJKoZIhvcNAQcBMBwGCiqGSIb3DQEMAQYwDgQI3e4V2eXgGFMCAggAgIIDqJ/L8sA
            /// ......
            /// AB3eKpMa7rQc==</para>
            /// </summary>
            [NameInMap("SslCertificateText")]
            [Validation(Required=false)]
            public string SslCertificateText { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CN=fe-{clusterId}-internal.starrocks.aliyuncs.com, OU=Aliyun Big Data Platform EMR StarRocks, O=Aliyun, L=BJ, ST=CN, C=CN</para>
            /// </summary>
            [NameInMap("SubjectDN")]
            [Validation(Required=false)]
            public string SubjectDN { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>InvalidParams</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Invalid params: [instance not exists].</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>32A44F0D-BFF6-5664-999A-218BBDE74XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
