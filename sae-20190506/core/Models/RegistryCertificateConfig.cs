// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RegistryCertificateConfig : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>LS0tLS1CRUdJTiBDRVJUSUZJQ0FURS0tLS0tCmZha2VDZXJ0aWZpY2F0ZQotLS0tLUVORCBDRVJUSUZJQ0FURS0tLS0t</para>
        /// </summary>
        [NameInMap("CertBase64")]
        [Validation(Required=false)]
        public string CertBase64 { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Insecure")]
        [Validation(Required=false)]
        public bool? Insecure { get; set; }

    }

}
