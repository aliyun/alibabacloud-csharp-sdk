// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class CreateDeliveryHistoryJobResponseBody : TeaModel {
        /// <summary>
        /// The ID of the historical event delivery task.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
