// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class DeleteQueuesShrinkRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The queues that you want to delete.
        /// </summary>
        [NameInMap("QueueNames")]
        [Validation(Required=false)]
        public string QueueNamesShrink { get; set; }

    }

}
