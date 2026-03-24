// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class VerifyDomainOwnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F35F45B0-5D6B-4238-BE02-A62D****E840</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The verification result.</para>
        /// </summary>
        [NameInMap("VerifyResult")]
        [Validation(Required=false)]
        public VerifyDomainOwnerResponseBodyVerifyResult VerifyResult { get; set; }
        public class VerifyDomainOwnerResponseBodyVerifyResult : TeaModel {
            /// <summary>
            /// <para>The reason why the verification failed.</para>
            /// <list type="bullet">
            /// <item><description><para>DnsTxtVerifyFailed: The DNS TXT record does not match.</para>
            /// </description></item>
            /// <item><description><para>DnsServerError: The DNS server is abnormal.</para>
            /// </description></item>
            /// <item><description><para>VerifyFileNotExist: The verification file does not exist.</para>
            /// </description></item>
            /// <item><description><para>VerifyDomainNotAccess: Failed to access the domain name.</para>
            /// </description></item>
            /// <item><description><para>FileContentVerifyFailed: The file content does not match.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DnsTxtVerifyFailed</para>
            /// </summary>
            [NameInMap("FailCode")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The verification is successful.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The verification failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }

        }

    }

}
