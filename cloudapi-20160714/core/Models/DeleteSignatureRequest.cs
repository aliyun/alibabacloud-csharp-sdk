// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DeleteSignatureRequest : TeaModel {
        /// <summary>
        /// The security token included in the WebSocket request header. The system uses this token to authenticate the request.
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The ID of the key to be deleted.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SignatureId")]
        [Validation(Required=false)]
        public string SignatureId { get; set; }

    }

}
