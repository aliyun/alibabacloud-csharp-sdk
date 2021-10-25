// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeTaskInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskInfo")]
        [Validation(Required=false)]
        public DescribeTaskInfoResponseBodyTaskInfo TaskInfo { get; set; }
        public class DescribeTaskInfoResponseBodyTaskInfo : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public string FinishTime { get; set; }
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }
            [NameInMap("BeginTime")]
            [Validation(Required=false)]
            public string BeginTime { get; set; }
        };

    }

}
