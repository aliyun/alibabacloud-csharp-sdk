// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListOtaTaskResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<ListOtaTaskResponseBodyTaskList> TaskList { get; set; }
        public class ListOtaTaskResponseBodyTaskList : TeaModel {
            [NameInMap("OtaVersion")]
            [Validation(Required=false)]
            public string OtaVersion { get; set; }

            [NameInMap("TaskDisplayStatus")]
            [Validation(Required=false)]
            public string TaskDisplayStatus { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskStartTime")]
            [Validation(Required=false)]
            public string TaskStartTime { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
