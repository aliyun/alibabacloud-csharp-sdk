// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dplus20201216.Models
{
    public class GetTaskStatusResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTaskStatusResponseBodyData Data { get; set; }
        public class GetTaskStatusResponseBodyData : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessResponse")]
        [Validation(Required=false)]
        public bool? SuccessResponse { get; set; }

    }

}
