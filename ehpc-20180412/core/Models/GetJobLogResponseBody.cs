// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class GetJobLogResponseBody : TeaModel {
        /// <summary>
        /// The content of the error logs. The content is encoded in Base64.
        /// </summary>
        [NameInMap("ErrorLog")]
        [Validation(Required=false)]
        public string ErrorLog { get; set; }

        /// <summary>
        /// The ID of the job.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The content of the output logs. The content is encoded in Base64.
        /// </summary>
        [NameInMap("OutputLog")]
        [Validation(Required=false)]
        public string OutputLog { get; set; }

        /// <summary>
        /// The ID of the task.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
