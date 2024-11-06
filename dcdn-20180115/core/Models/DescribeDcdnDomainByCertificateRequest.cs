// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainByCertificateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the domain name list to return matches the SSL certificate.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The domain name list matches the SSL certificate.</description></item>
        /// <item><description><b>false</b>: The domain name list does not match the SSL certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Exact")]
        [Validation(Required=false)]
        public bool? Exact { get; set; }

        /// <summary>
        /// <para>The public key of the certificate.</para>
        /// <para>You must use Base64 encoding schemes and then the encodeURIComponent method to encode the public key. PEM files are supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        /// <summary>
        /// <para>Specifies whether the domain name list to return contains only domain names with HTTPS enabled or disabled.</para>
        /// <list type="bullet">
        /// <item><description>true: The list contains only domain names with HTTPS enabled.</description></item>
        /// <item><description>false: The list contains only domain names with HTTPS disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SSLStatus")]
        [Validation(Required=false)]
        public bool? SSLStatus { get; set; }

    }

}
