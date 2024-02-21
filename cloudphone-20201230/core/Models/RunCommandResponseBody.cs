// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class RunCommandResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The task IDs.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public RunCommandResponseBodyTaskId TaskId { get; set; }
        public class RunCommandResponseBodyTaskId : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public List<string> TaskId { get; set; }

        }

    }

}
