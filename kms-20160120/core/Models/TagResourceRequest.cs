// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class TagResourceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the certificate.</para>
        /// <remarks>
        /// <para> You can configure only one of the KeyId, SecretName, and CertificateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>770dbe42-e146-43d1-a55a-1355db86****</para>
        /// </summary>
        [NameInMap("CertificateId")]
        [Validation(Required=false)]
        public string CertificateId { get; set; }

        /// <summary>
        /// <para>The ID of the customer master key (CMK). The ID must be globally unique.</para>
        /// <remarks>
        /// <para> You can configure only one of the KeyId, SecretName, and CertificateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>08c33a6f-4e0a-4a1b-a3fa-7ddf****</para>
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// <remarks>
        /// <para> You can configure only one of the KeyId, SecretName, and CertificateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyDbC****</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>One or more tags that you want to add. The value is in the array format.</para>
        /// <para>Tag attributes:</para>
        /// <list type="bullet">
        /// <item><description>TagKey: the tag key.</description></item>
        /// <item><description>TagValue: the tag value.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;TagKey&quot;:&quot;S1key1&quot;,&quot;TagValue&quot;:&quot;S1val1&quot;},{&quot;TagKey&quot;:&quot;S1key2&quot;,&quot;TagValue&quot;:&quot;S2val2&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
