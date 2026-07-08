// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class EncryptResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique identifier of the certificate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef1da5f-38ed-69b3-****-037781890265</para>
        /// </summary>
        [NameInMap("CertIdentifier")]
        [Validation(Required=false)]
        public string CertIdentifier { get; set; }

        /// <summary>
        /// <para>The encrypted data. The data is Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ZOyIygCyaOW6Gj****MlNKiuyjfzw=</para>
        /// </summary>
        [NameInMap("CiphertextBlob")]
        [Validation(Required=false)]
        public string CiphertextBlob { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5979d897-d69f-4fc9-87dd-f3bb73c40b80</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
