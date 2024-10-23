// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class AddFingerprintToOIDCProviderRequest : TeaModel {
        /// <summary>
        /// <para>The fingerprint of the HTTPS certificate.</para>
        /// <para>The fingerprint can contain letters and digits.</para>
        /// <para>The fingerprint can be up to 40 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>902ef2deeb3c5b13ea4c3d5193629309e231****</para>
        /// </summary>
        [NameInMap("Fingerprint")]
        [Validation(Required=false)]
        public string Fingerprint { get; set; }

        /// <summary>
        /// <para>The name of the OIDC IdP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOIDCProvider</para>
        /// </summary>
        [NameInMap("OIDCProviderName")]
        [Validation(Required=false)]
        public string OIDCProviderName { get; set; }

    }

}
