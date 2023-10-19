// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifySignatureRequest : TeaModel {
        /// <summary>
        /// The security token included in the WebSocket request header. The system uses this token to authenticate the request.
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the signature key that you want to manage.
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

        /// <summary>
        /// The new Key value of the key. The value must be 6 to 20 characters in length and can contain letters, digits, and underscores (\_). It must start with a letter.
        /// </summary>
        [NameInMap("SignatureKey")]
        [Validation(Required=false)]
        public string SignatureKey { get; set; }

        /// <summary>
        /// The new name of the key. The name must be 4 to 50 characters in length and can contain letters, digits, and underscores (\_). It must start with a letter.
        /// </summary>
        [NameInMap("SignatureName")]
        [Validation(Required=false)]
        public string SignatureName { get; set; }

        /// <summary>
        /// The new Secret value of the key. The value must be 6 to 30 characters in length and can contain letters, digits, and special characters. Special characters include underscores (\_), at signs (@), number signs (#), exclamation points (!), and asterisks (\*). The value must start with a letter.
        /// </summary>
        [NameInMap("SignatureSecret")]
        [Validation(Required=false)]
        public string SignatureSecret { get; set; }

    }

}
