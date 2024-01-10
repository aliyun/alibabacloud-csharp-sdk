// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateSecretParameterShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_). For more information, see "How to ensure idempotence".
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The constraints of the encryption parameter. By default, this parameter is null. Valid values:
        /// 
        /// *   AllowedValues: The value that is allowed for the encryption parameter. It must be an array string.
        /// *   AllowedPattern: The pattern that is allowed for the encryption parameter. It must be a regular expression.
        /// *   MinLength: The minimum length of the encryption parameter.
        /// *   MaxLength: The maximum length of the encryption parameter.
        /// </summary>
        [NameInMap("Constraints")]
        [Validation(Required=false)]
        public string Constraints { get; set; }

        /// <summary>
        /// The description of the encryption parameter. The description must be 1 to 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The key ID of Key Management Service (KMS) that is used to encrypt the parameter.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The name of the parameter. The name must be 1 to 180 characters in length, and can contain letters, digits, hyphens (-), and underscores (\_). It cannot start with ALIYUN, ACS, ALIBABA, ALICLOUD, or OOS.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// The type of the parameter. Set the value to Secret.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The value of the encryption parameter. The value must be 1 to 4096 characters in length.
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
