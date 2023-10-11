// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GrantHonorResponseBody : TeaModel {
        [NameInMap("failedUserIds")]
        [Validation(Required=false)]
        public List<string> FailedUserIds { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("successUserIds")]
        [Validation(Required=false)]
        public List<string> SuccessUserIds { get; set; }

    }

}
