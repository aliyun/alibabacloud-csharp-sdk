// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class CreateCdnDeliverTaskResponseBody : TeaModel {
        /// <summary>
        /// The ID of the tracking task.
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public string DeliverId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
