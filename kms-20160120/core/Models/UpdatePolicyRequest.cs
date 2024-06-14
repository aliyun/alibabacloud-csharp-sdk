// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UpdatePolicyRequest : TeaModel {
        /// <summary>
        /// The access control rule.
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
        /// The name of the permission policy that you want to update.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The operations that are supported by the updated policy. Valid values:
        /// 
        /// *   RbacPermission/Template/CryptoServiceKeyUser: allows you to perform cryptographic operations.
        /// *   RbacPermission/Template/CryptoServiceSecretUser: allows you to perform secret-related operations.
        /// 
        /// You can select both.
        /// </summary>
        [NameInMap("Permissions")]
        [Validation(Required=false)]
        public string Permissions { get; set; }

        /// <summary>
        /// The key and secret that are allowed to access after the update.
        /// 
        /// *   Key: Enter a key in the `key/${KeyId}` format. To allow access to all keys of a KMS instance, enter key/\\*.
        /// *   Secret: Enter a secret in the `secret/${SecretName}` format. To allow access to all secrets of a KMS instance, enter secret/\\*.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

    }

}
