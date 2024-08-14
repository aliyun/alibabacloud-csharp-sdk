// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GenerateDataKeyRequest : TeaModel {
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public string DryRun { get; set; }

        /// <summary>
        /// The JSON string that consists of key-value pairs.
        /// 
        /// If you specify this parameter, an equivalent value is required when you call the [Decrypt](https://help.aliyun.com/document_detail/28950.html) operation. For more information, see [EncryptionContext](https://help.aliyun.com/document_detail/42975.html).
        /// </summary>
        [NameInMap("EncryptionContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> EncryptionContext { get; set; }

        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// You can also set this parameter to an alias that is bound to the CMK. For more information, see [Alias overview](https://help.aliyun.com/document_detail/68522.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The type of the data key that you want to generate. Valid values:
        /// 
        /// *   AES_256: a 256-bit symmetric key
        /// *   AES_128: a 128-bit symmetric key
        /// 
        /// >  We recommend that you use the KeySpec or NumberOfBytes parameter to specify the length of a data key. If none of the parameters are specified, KMS generates a 256-bit data key. If both parameters are specified, KMS ignores the KeySpec parameter.
        /// </summary>
        [NameInMap("KeySpec")]
        [Validation(Required=false)]
        public string KeySpec { get; set; }

        /// <summary>
        /// The length of the data key that you want to generate. Unit: bytes.
        /// 
        /// Valid values: 1 to 1024.
        /// 
        /// Default value:
        /// 
        /// *   If the KeySpec parameter is set to AES_256, set the value of the NumberOfBytes parameter to 32.
        /// *   If the KeySpec parameter is set to AES_128, set the value of the NumberOfBytes parameter to 16.
        /// </summary>
        [NameInMap("NumberOfBytes")]
        [Validation(Required=false)]
        public int? NumberOfBytes { get; set; }

    }

}
