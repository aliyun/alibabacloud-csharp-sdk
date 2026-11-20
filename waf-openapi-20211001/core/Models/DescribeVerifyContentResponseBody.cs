// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeVerifyContentResponseBody : TeaModel {
        /// <summary>
        /// <para>The DNS verification content.</para>
        /// </summary>
        [NameInMap("DnsContent")]
        [Validation(Required=false)]
        public DescribeVerifyContentResponseBodyDnsContent DnsContent { get; set; }
        public class DescribeVerifyContentResponseBodyDnsContent : TeaModel {
            /// <summary>
            /// <para>The host record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verification</para>
            /// </summary>
            [NameInMap("RR")]
            [Validation(Required=false)]
            public string RR { get; set; }

            /// <summary>
            /// <para>The TXT record type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TXT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The TXT record value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_0a246ca99d504ba087472d***</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The file verification content.</para>
        /// </summary>
        [NameInMap("FileContent")]
        [Validation(Required=false)]
        public DescribeVerifyContentResponseBodyFileContent FileContent { get; set; }
        public class DescribeVerifyContentResponseBodyFileContent : TeaModel {
            /// <summary>
            /// <para>The file download path.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://oss.xxx.com//xxx.html">http://oss.xxx.com//xxx.html</a></para>
            /// </summary>
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <para>The file name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx.html</para>
            /// </summary>
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The primary domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aliyundemo.com</para>
            /// </summary>
            [NameInMap("TopDomain")]
            [Validation(Required=false)]
            public string TopDomain { get; set; }

            /// <summary>
            /// <para>The file content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>verify_0a246ca99d504ba08***</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            /// <summary>
            /// <para>The access path for file verification.</para>
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
        /// <para>The verification result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Verification passed.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Verification failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("VerifyResult")]
        [Validation(Required=false)]
        public bool? VerifyResult { get; set; }

    }

}
