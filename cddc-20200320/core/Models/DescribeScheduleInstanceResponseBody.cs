// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeScheduleInstanceResponseBody : TeaModel {
        [NameInMap("ScheduleId")]
        [Validation(Required=false)]
        public string ScheduleId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceScheduleStatusList")]
        [Validation(Required=false)]
        public List<DescribeScheduleInstanceResponseBodyInstanceScheduleStatusList> InstanceScheduleStatusList { get; set; }
        public class DescribeScheduleInstanceResponseBodyInstanceScheduleStatusList : TeaModel {
            [NameInMap("ScheduleStatus")]
            [Validation(Required=false)]
            public string ScheduleStatus { get; set; }

            [NameInMap("InstanceNodeTargetHostId")]
            [Validation(Required=false)]
            public string InstanceNodeTargetHostId { get; set; }

            [NameInMap("InstanceNodeRole")]
            [Validation(Required=false)]
            public string InstanceNodeRole { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceNodeSourceHostId")]
            [Validation(Required=false)]
            public string InstanceNodeSourceHostId { get; set; }

        }

    }

}
