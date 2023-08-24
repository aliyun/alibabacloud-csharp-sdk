// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyActiveOperationTaskResponseBody : TeaModel {
        /// <summary>
        /// The scheduled switchover time to be specified. Specify the time in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time must be in UTC.
        /// 
        /// >  The time cannot be later than the latest operation time. You can call the [DescribeActiveOperationTask](~~197387~~) operation. The **Deadline** parameter in the response indicates the latest operation time.
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// Modifies the scheduled switchover time of an operations and maintenance (O&M) task.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
