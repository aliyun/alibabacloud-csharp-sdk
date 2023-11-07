// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class DeleteDeliveryHistoryJobRequest : TeaModel {
        /// <summary>
        /// The ID of the historical event delivery task to be deleted.
        /// 
        /// You can call the [ListDeliveryHistoryJobs](~~188101~~) operation to query task IDs.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public int? JobId { get; set; }

    }

}
