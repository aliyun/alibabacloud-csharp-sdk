// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UntagResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// <remarks>
        /// <para>You must specify one and only one of the KeyId, SecretName, and CertificateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>770dbe42-e146-43d1-a55a-1355db86****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// <para>The ID of the key. This is the globally unique identifier (GUID) of the master key (CMK).</para>
        /// <remarks>
        /// <para>You must specify one and only one of the KeyId, SecretName, and CertificateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddf****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The name of the credential.</para>
        /// <remarks>
        /// <para>You must specify one and only one of the KeyId, SecretName, and CertificateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyDbC****</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>One or more tag keys. Separate multiple tag keys with commas (,).<br> You need to specify only tag keys, not tag values.<br> The tag key can be 1 to 128 bytes in length.<br><br></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;tagkey1&quot;,&quot;tagkey2&quot;]</para>
        /// </summary>
        [NameInMap("TagKeys")]
        [Validation(Required=false)]
        public string TagKeys { get; set; }

    }

}
