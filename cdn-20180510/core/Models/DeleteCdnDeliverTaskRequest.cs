// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DeleteCdnDeliverTaskRequest : TeaModel {
        /// <summary>
        /// The ID of the tracking task that you want to delete. You can call the [DescribeCdnDeliverList](~~270877~~) operation to query task IDs.
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

    }

}
