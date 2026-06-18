// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ApplyCertificateRequest : TeaModel {
        /// <summary>
        /// <para>A comma-separated list of domain names.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.example.com,blog.example.com">www.example.com,blog.example.com</a></para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public string Domains { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

        /// <summary>
        /// <para>The certificate type. Valid values: <c>lets_encrypt</c> for a Let\&quot;s Encrypt certificate, <c>digicert_single</c> for a Digicert single-domain certificate, and <c>digicert_wildcard</c> for a Digicert wildcard certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lets_encrypt</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
