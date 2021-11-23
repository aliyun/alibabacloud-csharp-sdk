// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeRecordTasksResponseBody : TeaModel {
        [NameInMap("RecordTasks")]
        [Validation(Required=false)]
        public List<DescribeRecordTasksResponseBodyRecordTasks> RecordTasks { get; set; }
        public class DescribeRecordTasksResponseBodyRecordTasks : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("SubSpecUsers")]
            [Validation(Required=false)]
            public List<string> SubSpecUsers { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("UserPanes")]
            [Validation(Required=false)]
            public List<DescribeRecordTasksResponseBodyRecordTasksUserPanes> UserPanes { get; set; }
            public class DescribeRecordTasksResponseBodyRecordTasksUserPanes : TeaModel {
                [NameInMap("PaneId")]
                [Validation(Required=false)]
                public int? PaneId { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public long? TotalPage { get; set; }

    }

}
