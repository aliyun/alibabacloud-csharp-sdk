// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ScheduleKeyDeletionRequest : TeaModel {
        /// <summary>
        /// The ID of the customer master key (CMK). The ID must be globally unique.
        /// </summary>
        [NameInMap("KeyId")]
        [Validation(Required=false)]
        public string KeyId { get; set; }

        /// <summary>
        /// The scheduled period after which the CMK is deleted. During this period, the CMK is in the PendingDeletion state. After this period ends, you cannot cancel the key deletion task.
        /// 
        /// Valid values: 7 to 366.
        /// 
        /// Unit: days.
        /// </summary>
        [NameInMap("PendingWindowInDays")]
        [Validation(Required=false)]
        public int? PendingWindowInDays { get; set; }

    }

}
