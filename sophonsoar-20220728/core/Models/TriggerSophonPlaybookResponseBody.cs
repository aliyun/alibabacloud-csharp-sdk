// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerSophonPlaybookResponseBody : TeaModel {
        /// <summary>
        /// The details that is returned after the command or playbook is triggered.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TriggerSophonPlaybookResponseBodyData Data { get; set; }
        public class TriggerSophonPlaybookResponseBodyData : TeaModel {
            /// <summary>
            /// The custom ID. If you do not specify this parameter when the playbook is triggered, a random ID is generated for fault locating and troubleshooting.
            /// </summary>
            [NameInMap("SophonTaskId")]
            [Validation(Required=false)]
            public string SophonTaskId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
