// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class ResendEmailRequest : TeaModel {
        /// <summary>
        /// Invitation ID, from interface InviteSubAccount </br>
        /// Note: This field type is Long, which may result in precision loss in serialization/deserialization process. Please ensure the value does not exceed 9007199254740991.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InviteId")]
        [Validation(Required=false)]
        public long? InviteId { get; set; }

    }

}
