// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class VerifyDomainOwnerResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
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
            /// <para>The reasons why the verification fails. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DnsTxtVerifyFailed: The DNS TXT record and the domain name do not match.</description></item>
            /// <item><description>DnsServerError: The DNS server is abnormal.</description></item>
            /// <item><description>VerifyFileNotExist: The verification file does not exist.</description></item>
            /// <item><description>VerifyDomainNotAccess: The access to the domain name failed.</description></item>
            /// <item><description>FileContentVerifyFailed: The content of the verification file and the domain name do not match.</description></item>
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
            /// <item><description><b>true</b>: The verification succeeds.</description></item>
            /// <item><description><b>false</b>: The verification fails.</description></item>
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
