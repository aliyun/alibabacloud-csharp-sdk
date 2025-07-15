// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainByCertificateRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The public key of the SSL certificate. You must Base64-encode the public key before you invoke the encodeURIComponent function to encode a URI component. The public key must be in the PEM format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("SSLPub")]
        [Validation(Required=false)]
        public string SSLPub { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only domain names with HTTPS enabled or disabled.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: returns only domain names with HTTPS enabled.</description></item>
        /// <item><description><b>false</b>: The rule is disabled.</description></item>
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
