// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ApplyTripTaskExecuteRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("action_from")]
        [Validation(Required=false)]
        public string ActionFrom { get; set; }

        [NameInMap("comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("task_action")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("task_id")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
