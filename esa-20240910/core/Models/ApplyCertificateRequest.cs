// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ApplyCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The algorithm type.</para>
        /// </summary>
        [NameInMap("AlgType")]
        [Validation(Required=false)]
        public string AlgType { get; set; }

        /// <summary>
        /// <para>The list of domain names, separated by commas.</para>
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
        /// <para>The certificate type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>lets_encrypt: Let\&quot;s Encrypt certificate.</description></item>
        /// <item><description>digicert_single: DigiCert single-domain certificate.</description></item>
        /// <item><description>digicert_wildcard: DigiCert wildcard domain certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lets_encrypt</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
