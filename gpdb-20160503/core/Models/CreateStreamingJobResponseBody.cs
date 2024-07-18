// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateStreamingJobResponseBody : TeaModel {
        /// <summary>
        /// The job ID.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
