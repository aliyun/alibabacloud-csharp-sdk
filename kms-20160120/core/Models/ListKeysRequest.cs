// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListKeysRequest : TeaModel {
        /// <summary>
        /// The CMK filter. The filter consists of one or more key-value pairs. You can specify a maximum of 10 key-value pairs.
        /// 
        /// *   Key
        /// 
        ///     *   Description: the property that you want to filter.
        /// 
        ///     *   Type: string.
        /// 
        ///     *   Valid values:
        /// 
        ///         *   KeyState: the status of the CMK.
        ///         *   KeySpec: the type of the CMK.
        ///         *   KeyUsage: the usage of the CMK.
        ///         *   ProtectionLevel: the protection level.
        ///         *   CreatorType: the type of the creator.
        /// 
        /// *   Values
        /// 
        ///     *   Description: the value to be included after filtering.
        /// 
        ///     *   Format: string array.
        /// 
        ///     *   Length: 0 to 10.
        /// 
        ///     *   Valid values:
        /// 
        ///         *   When Key is set to KeyState, the value can be Enabled, Disabled, PendingDeletion, or PendingImport.
        /// 
        ///         *   When Key is set to KeySpec, the value can be Aliyun_AES_256, Aliyun_SM4, RSA_2048, EC_P256, EC_P256K, or EC_SM2.
        /// 
        ///             Note: You can create CMKs of the EC_SM2 or Aliyun_SM4 type only in regions where State Cryptography Administration (SCA)-certified managed HSMs reside. For more information about the regions, see [Supported regions](https://help.aliyun.com/document_detail/125803.html). If your region does not support EC_SM2 or Aliyun_SM4, the two values are ignored if they are specified.
        /// 
        ///         *   When Key is set to KeyUsage, the value can be ENCRYPT/DECRYPT or SIGN/VERIFY. ENCRYPT/DECRYPT indicates that the CMK is used to encrypt and decrypt data. SIGN/VERIFY indicates that the CMK is used to generate and verify digital signatures.
        /// 
        ///         *   When Key is set to ProtectionLevel, the value can be SOFTWARE (software) or HSM (hardware).
        /// 
        ///             You can set ProtectionLevel to HSM in only specific regions. For more information about the regions, see [Supported regions](https://help.aliyun.com/document_detail/125803.html). If your region does not support the value HSM, the value is ignored if the value is specified.
        /// 
        ///         *   If Key is set to CreatorType, the value can be User or Service. User indicates that CMKs created by the current account are queried. Service indicates that CMKs automatically created by other cloud services authorized by the current account are queried.
        /// 
        /// The logical relationship between different keys is AND, and the logical relationship between multiple items in the same key is OR. Example:
        /// 
        /// `[ {"Key":"KeyState", "Values":["Enabled","Disabled"]}, {"Key":"KeyState", "Values":["PendingDeletion"]}, {"Key":"KeySpec", "Values":["Aliyun_AES_256"]}]`. In this example, the semantics are:`(KeyState=Enabled OR KeyState=Disabled OR KeyState=PendingDeletion) AND (KeySpec=Aliyun_AES_ 256)`.
        /// </summary>
        [NameInMap("Filters")]
        [Validation(Required=false)]
        public string Filters { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// 
        /// Pages start from page 1.
        /// 
        /// Default value: 1.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 10
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
