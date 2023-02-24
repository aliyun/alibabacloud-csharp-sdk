// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeKeyRequest : TeaModel {
        /// <summary>
        /// The ID of the CMK. The ID must be globally unique.
        /// 
        /// You can also set this parameter to an alias that is bound to the CMK. For more information, see [Overview of aliases](~~68522~~).
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

    }

}
