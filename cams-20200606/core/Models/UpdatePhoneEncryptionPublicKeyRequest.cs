// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class UpdatePhoneEncryptionPublicKeyRequest : TeaModel {
        /// <summary>
        /// <para>SpaceId/instanceId of ISV sub clients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>399382882</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>Encrypt the public key.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN PUBLIC KEY-----
        /// AAA
        /// BBB
        /// CCC
        /// DDD
        /// EEE
        /// FFF
        /// GGG
        /// -----END PUBLIC KEY-----</para>
        /// </summary>
        [NameInMap("EncryptionPublicKey")]
        [Validation(Required=false)]
        public string EncryptionPublicKey { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86138000</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

    }

}
