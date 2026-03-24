// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainVerifyDataResponseBody : TeaModel {
        /// <summary>
        /// <para>The verification content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;verifiCode&quot;: &quot;uy0-DbxL4HBmUtSUXpkXctaSnCAUKhhNH6WKl-JnJY4&quot;,
        ///     &quot;verifyKey&quot;: &quot;_acme-challenge&quot;
        ///   }</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDomainVerifyDataResponseBodyContent Content { get; set; }
        public class DescribeDomainVerifyDataResponseBodyContent : TeaModel {
            [NameInMap("RootDomain")]
            [Validation(Required=false)]
            public string RootDomain { get; set; }

            [NameInMap("verifyCode")]
            [Validation(Required=false)]
            public string VerifyCode { get; set; }

            [NameInMap("verifyKey")]
            [Validation(Required=false)]
            public string VerifyKey { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F61CDR30-E83C-4FDA-BF73-9A94CDD44229</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
