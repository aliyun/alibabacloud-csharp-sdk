// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DisableKeyRequest : TeaModel {
        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

    }

}
