// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetDDLJobStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public GetDDLJobStatusResponseData Data { get; set; }
        public class GetDDLJobStatusResponseData : TeaModel {
            [NameInMap("NextTaskId")]
            [Validation(Required=true)]
            public string NextTaskId { get; set; }
            [NameInMap("Content")]
            [Validation(Required=true)]
            public string Content { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=true)]
            public string TaskId { get; set; }
        };

    }

}
