// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateSiteResponseBody : TeaModel {
        /// <summary>
        /// <para>The nameservers assigned by ESA. The values are separated by commas (,). This parameter is returned if you set AccessType to NS. In this case, you must change the nameservers of your domain to the assigned ones. Then, you can verify the domain ownership and activate your website.</para>
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
        /// <para>The website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The verification code for the website. If you set AccessType to CNAME, you need to add a TXT record whose hostname is <b>_esaauth.[websiteDomainName]</b> and record value is the value of VerifyCode to the DNS records of your domain. ****Then, you can verify the domain ownership and activate your website.</para>
        /// 
        /// <b>Example:</b>
        /// <para>verify_aah9dioasmov****</para>
        /// </summary>
        [NameInMap("VerifyCode")]
        [Validation(Required=false)]
        public string VerifyCode { get; set; }

    }

}
