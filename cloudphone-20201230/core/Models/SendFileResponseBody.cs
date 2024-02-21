// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class SendFileResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The task IDs. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public SendFileResponseBodyTaskId TaskId { get; set; }
        public class SendFileResponseBodyTaskId : TeaModel {
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public List<string> TaskId { get; set; }

        }

    }

}
