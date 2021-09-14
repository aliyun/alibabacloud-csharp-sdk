// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class DescribeDedicatedResourceAdvisorResponseBody : TeaModel {
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceAdvisors")]
        [Validation(Required=false)]
        public DescribeDedicatedResourceAdvisorResponseBodyResourceAdvisors ResourceAdvisors { get; set; }
        public class DescribeDedicatedResourceAdvisorResponseBodyResourceAdvisors : TeaModel {
            [NameInMap("ResourceAdvisors")]
            [Validation(Required=false)]
            public List<DescribeDedicatedResourceAdvisorResponseBodyResourceAdvisorsResourceAdvisors> ResourceAdvisors { get; set; }
            public class DescribeDedicatedResourceAdvisorResponseBodyResourceAdvisorsResourceAdvisors : TeaModel {
                public float? CpuUsageAfterAction { get; set; }
                public string Action { get; set; }
                public string DestinationDedicatedHostId { get; set; }
                public string SourceDedicatedInstanceId { get; set; }
                public string ActionDescription { get; set; }
                public string SourceDedicatedInstanceRole { get; set; }
                public string SourceDedicatedHostId { get; set; }
                public float? CpuUsageBeforeAction { get; set; }
            }
        };

    }

}
