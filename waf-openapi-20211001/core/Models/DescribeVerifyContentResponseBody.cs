// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeVerifyContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The DNS-based verification content, including the TXT record details.</para>
        /// </summary>
        [NameInMap("DnsContent")]
        [Validation(Required=false)]
        public DescribeVerifyContentResponseBodyDnsContent DnsContent { get; set; }
        public class DescribeVerifyContentResponseBodyDnsContent : TeaModel {
            /// <summary>
            /// <para>The host record of the DNS TXT record used for domain ownership verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verification</para>
            /// </summary>
            [NameInMap("RR")]
            [Validation(Required=false)]
            public string RR { get; set; }

            /// <summary>
            /// <para>The type of the DNS record used for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TXT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of the DNS TXT record used for verification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_0a246ca99d504ba087472d***</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The file-based verification content, including the file name, path, and download URL.</para>
        /// </summary>
        [NameInMap("FileContent")]
        [Validation(Required=false)]
        public DescribeVerifyContentResponseBodyFileContent FileContent { get; set; }
        public class DescribeVerifyContentResponseBodyFileContent : TeaModel {
            /// <summary>
            /// <para>The download URL of the verification file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://oss.xxx.com//xxx.html">http://oss.xxx.com//xxx.html</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The name of the verification file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.html</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The root domain of the domain name to be verified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundemo.com</para>
            /// </summary>
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public string TopDomain { get; set; }

            /// <summary>
            /// <para>The content of the verification file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_0a246ca99d504ba08***</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The URL that is used to access the verification file.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx.xxx.com//xxx.html">http://xxx.xxx.com//xxx.html</a></para>
            /// </summary>
            [NameInMap("VerifyPath")]
            [Validation(Required=false)]
            public string VerifyPath { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-***</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the domain ownership verification is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VerifyResult")]
        [Validation(Required=false)]
        public bool? VerifyResult { get; set; }

    }

}
