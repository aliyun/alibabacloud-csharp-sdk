// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteSignatureRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// *   This API is intended for API providers.
        /// *   This API operation deletes an existing backend signature key.
        /// *   You cannot delete a key that is bound to an API. To delete the key, you must unbind it first.
        /// *   The QPS limit on this operation is 50 per user.
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

    }

}
