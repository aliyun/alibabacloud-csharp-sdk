// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeScheduleHostResponseBody : TeaModel {
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("HostScheduleStatusList")]
        [Validation(Required=false)]
        public List<DescribeScheduleHostResponseBodyHostScheduleStatusList> HostScheduleStatusList { get; set; }
        public class DescribeScheduleHostResponseBodyHostScheduleStatusList : TeaModel {
            [NameInMap("ScheduleStatus")]
            [Validation(Required=false)]
            public string ScheduleStatus { get; set; }

            [NameInMap("DedicatedHostId")]
            [Validation(Required=false)]
            public string DedicatedHostId { get; set; }

            [NameInMap("InstanceOutId")]
            [Validation(Required=false)]
            public string InstanceOutId { get; set; }

            [NameInMap("InstanceInId")]
            [Validation(Required=false)]
            public string InstanceInId { get; set; }

        }

    }

}
