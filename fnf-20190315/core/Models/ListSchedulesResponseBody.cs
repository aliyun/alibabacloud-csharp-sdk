// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListSchedulesResponseBody : TeaModel {
        [NameInMap("Schedules")]
        [Validation(Required=false)]
        public List<ListSchedulesResponseBodySchedules> Schedules { get; set; }
        public class ListSchedulesResponseBodySchedules : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ScheduleId")]
            [Validation(Required=false)]
            public string ScheduleId { get; set; }

            [NameInMap("Payload")]
            [Validation(Required=false)]
            public string Payload { get; set; }

            [NameInMap("ScheduleName")]
            [Validation(Required=false)]
            public string ScheduleName { get; set; }

            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
