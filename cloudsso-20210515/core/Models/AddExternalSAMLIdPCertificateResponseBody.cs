// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class AddExternalSAMLIdPCertificateResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the SAML signing certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>idp-c-00wk2fb4foracls0****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12B3E332-DD16-515B-B695-39BA233AA172</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
