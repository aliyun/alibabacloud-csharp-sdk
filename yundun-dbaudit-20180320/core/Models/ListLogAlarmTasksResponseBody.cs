// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20180320.Models
{
    public class ListLogAlarmTasksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TaskList")]
        [Validation(Required=false)]
        public List<ListLogAlarmTasksResponseBodyTaskList> TaskList { get; set; }
        public class ListLogAlarmTasksResponseBodyTaskList : TeaModel {
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("ToMailList")]
            [Validation(Required=false)]
            public List<string> ToMailList { get; set; }

            [NameInMap("RiskLevelList")]
            [Validation(Required=false)]
            public List<string> RiskLevelList { get; set; }

            [NameInMap("DbIdList")]
            [Validation(Required=false)]
            public List<string> DbIdList { get; set; }

        }

    }

}
