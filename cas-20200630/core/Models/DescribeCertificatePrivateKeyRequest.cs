// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200630.Models
{
    public class DescribeCertificatePrivateKeyRequest : TeaModel {
        /// <summary>
        /// <para>The password to encrypt the private key. The password can contain uppercase letters, lowercase letters, digits, and special characters, such as <c>,.+-_#</c>. The maximum length is 32 bytes.</para>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>Remember the password you set. You need this password to decrypt the encrypted private key. If you forget the password, you cannot decrypt the private key that you get from this API call. You must call this API again to get a new encrypted key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>!Demo@WS3ed</para>
        /// </summary>
        [NameInMap("EncryptedCode")]
        [Validation(Required=false)]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// <para>The unique identifier of the client or server-side certificate for which you want to get the private key.</para>
        /// <remarks>
        /// <para>Call <a href="https://help.aliyun.com/document_detail/465990.html">ListClientCertificate</a> to query the unique identifiers of all client and server-side certificates.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bc37133bb7ed68c7938d928fd26d****</para>
        /// </summary>
        [NameInMap("Identifier")]
        [Validation(Required=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the certificate belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
