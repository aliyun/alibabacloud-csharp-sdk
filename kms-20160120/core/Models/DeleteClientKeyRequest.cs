// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DeleteClientKeyRequest : TeaModel {
        /// <summary>
        /// The ID of the client key.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClientKeyId")]
        [Validation(Required=false)]
        public string ClientKeyId { get; set; }

    }

}
