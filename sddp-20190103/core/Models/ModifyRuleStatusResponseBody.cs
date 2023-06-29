// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ModifyRuleStatusResponseBody : TeaModel {
        /// <summary>
        /// The IDs of sensitive data detection rules whose status failed to be changed. Multiple IDs are separated with commas (,).
        /// </summary>
        [NameInMap("FailedIds")]
        [Validation(Required=false)]
        public string FailedIds { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
