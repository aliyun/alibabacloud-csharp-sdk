// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateKeyVersionRequest : TeaModel {
        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// >  You can also set the value to an alias that is bound to the CMK. For more information, see [Overview of aliases](~~68522~~).
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

    }

}
