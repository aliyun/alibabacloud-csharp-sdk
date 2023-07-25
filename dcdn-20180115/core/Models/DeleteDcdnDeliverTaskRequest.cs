// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DeleteDcdnDeliverTaskRequest : TeaModel {
        /// <summary>
        /// The IDs of the tracking tasks that you want to delete. You can call the [DescribeCdnDeliverList](~~270043~~) operation to query task IDs.
        /// </summary>
        [NameInMap("DeliverId")]
        [Validation(Required=false)]
        public long? DeliverId { get; set; }

    }

}
