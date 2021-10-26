// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCloudMetricProfilingsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Profilings")]
        [Validation(Required=false)]
        public ListCloudMetricProfilingsResponseBodyProfilings Profilings { get; set; }
        public class ListCloudMetricProfilingsResponseBodyProfilings : TeaModel {
            [NameInMap("ProfilingInfo")]
            [Validation(Required=false)]
            public List<ListCloudMetricProfilingsResponseBodyProfilingsProfilingInfo> ProfilingInfo { get; set; }
            public class ListCloudMetricProfilingsResponseBodyProfilingsProfilingInfo : TeaModel {
                public int? Duration { get; set; }
                public int? Freq { get; set; }
                public string HostName { get; set; }
                public string InstanceId { get; set; }
                public int? Pid { get; set; }
                public string ProfilingId { get; set; }
                public string TriggerTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
