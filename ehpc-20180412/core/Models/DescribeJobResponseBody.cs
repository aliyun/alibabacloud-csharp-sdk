// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeJobResponseBody : TeaModel {
        /// <summary>
        /// The list of returned job information.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public DescribeJobResponseBodyMessage Message { get; set; }
        public class DescribeJobResponseBodyMessage : TeaModel {
            /// <summary>
            /// The details of the job.
            /// </summary>
            [NameInMap("JobInfo")]
            [Validation(Required=false)]
            public string JobInfo { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
