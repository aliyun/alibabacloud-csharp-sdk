// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CertInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("cert_body")]
        [Validation(Required=false)]
        public string CertBody { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("cert_name")]
        [Validation(Required=false)]
        public string CertName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("cert_privatekey")]
        [Validation(Required=false)]
        public string CertPrivatekey { get; set; }

    }

}
