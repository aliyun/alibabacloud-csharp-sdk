// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnDomainByCertificateRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the domain name list to return match the SSL certificate.</para>
        /// <list type="bullet">
        /// <item><description>true: The domain name list match the SSL certificate.</description></item>
        /// <item><description>false: The domain name list do not match the SSL certificate.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Exact")]
        [Validation(Required=false)]
        public bool? Exact { get; set; }

        /// <summary>
        /// <para>The public key of the SSL certificate. You must encode the public key in Base64 and then call the encodeURIComponent function to encode the public key again.</para>
        /// <para>The public key must be in the PEM format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        /// <summary>
        /// <para>Specifies whether the domain name list to return contains only domain names with HTTPS enabled or disabled.</para>
        /// <list type="bullet">
        /// <item><description>true: The domain name list contains only domain names with HTTPS enabled.</description></item>
        /// <item><description>false: The domain name list contains only domain names with HTTPS disabled.</description></item>
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
