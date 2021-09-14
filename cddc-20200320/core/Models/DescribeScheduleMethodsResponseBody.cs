// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeScheduleMethodsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScheduleMethodList")]
        [Validation(Required=false)]
        public List<DescribeScheduleMethodsResponseBodyScheduleMethodList> ScheduleMethodList { get; set; }
        public class DescribeScheduleMethodsResponseBodyScheduleMethodList : TeaModel {
            [NameInMap("ZonesOrder")]
            [Validation(Required=false)]
            public string ZonesOrder { get; set; }

            [NameInMap("ZoneDistribution")]
            [Validation(Required=false)]
            public string ZoneDistribution { get; set; }

            [NameInMap("CPUUtilityThreshold")]
            [Validation(Required=false)]
            public int? CPUUtilityThreshold { get; set; }

            [NameInMap("DedicatedHostGroupDesc")]
            [Validation(Required=false)]
            public string DedicatedHostGroupDesc { get; set; }

            [NameInMap("MemoryUtilityThreshold")]
            [Validation(Required=false)]
            public int? MemoryUtilityThreshold { get; set; }

            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("InstanceDistribution")]
            [Validation(Required=false)]
            public string InstanceDistribution { get; set; }

            [NameInMap("LocalDiskUtilityThreshold")]
            [Validation(Required=false)]
            public int? LocalDiskUtilityThreshold { get; set; }

            [NameInMap("DedicatedHostGroupId")]
            [Validation(Required=false)]
            public string DedicatedHostGroupId { get; set; }

        }

    }

}
