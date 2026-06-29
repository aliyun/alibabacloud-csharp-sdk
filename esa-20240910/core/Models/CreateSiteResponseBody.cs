// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of name servers assigned to the site, separated by commas (,). This field has a value when the access type of the site is NS. You need to change the DNS servers of the site to these name servers. Then you can verify the site ownership and activate the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1.example.com,ns2.example.com</para>
        /// </summary>
        [NameInMap("NameServerList")]
        [Validation(Required=false)]
        public string NameServerList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-3C82-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The verification code of the site. When the access type of the site is CNAME, you need to add a TXT record with the record name <b>_esaauth.[site name]</b> and the record value set to the <b>verification code</b> on the DNS server of the site. Then you can verify the site ownership and activate the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_aah9dioasmov****</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
