// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreatePolicyRequest : TeaModel {
        /// <summary>
        /// The name of the access control rule.
        /// 
        /// > For more information about how to query created access control rules, see [ListNetworkRules](https://help.aliyun.com/document_detail/2539433.html).
        /// </summary>
        [NameInMap("AccessControlRules")]
        [Validation(Required=false)]
        public string AccessControlRules { get; set; }

        /// <summary>
        /// The description.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The scope of the permission policy. You need to specify the KMS instance that you want to access.
        /// </summary>
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public string KmsInstance { get; set; }

        /// <summary>
        /// The name of the permission policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The operations that can be performed. Valid values:
        /// 
        /// *   RbacPermission/Template/CryptoServiceKeyUser: allows you to perform cryptographic operations.
        /// *   RbacPermission/Template/CryptoServiceSecretUser: allows you to perform secret-related operations.
        /// 
        /// You can select both.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// The key and secret that are allowed to access.
        /// 
        /// *   Key: Enter a key in the `key/${KeyId}` format. To allow access to all keys of a KMS instance, enter key/\\*.
        /// *   Secret: Enter a secret in the `secret/${SecretName}` format. To allow access to all secrets of a KMS instance, enter secret/\\*.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
