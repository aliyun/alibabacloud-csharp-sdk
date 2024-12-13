// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class AddExternalSAMLIdPCertificateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The X.509 certificate in the PEM format.</para>
        /// <para>The certificate is provided by the SAML IdP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MIIC8DCCAdigAwIBAgIQP9eomUYGeoND****</para>
        /// </summary>
        [NameInMap("X509Certificate")]
        [Validation(Required=false)]
        public string X509Certificate { get; set; }

    }

}
