// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteResponseBody : TeaModel {
        /// <summary>
        /// <para>A comma-separated list of name servers assigned to the site. This parameter is returned only if the site uses NS-based access. To activate the site, you must change your domain\&quot;s DNS servers to these name servers. This verifies your ownership of the site and activates it.</para>
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
        /// <para>The ID of the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The verification code for the site. This parameter is returned only if the site uses CNAME-based access. To activate the site, you must add a TXT record to your domain\&quot;s DNS settings. Set the record\&quot;s host to <b>_esaauth.[your_site_name]</b> and its value to this <b>verification code</b>. This verifies your ownership of the site and activates it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_aah9dioasmov****</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
