// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListApmApplicationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ApmAppInfoList")]
        [Validation(Required=false)]
        public ListApmApplicationResponseBodyApmAppInfoList ApmAppInfoList { get; set; }
        public class ListApmApplicationResponseBodyApmAppInfoList : TeaModel {
            [NameInMap("ApmAppInfo")]
            [Validation(Required=false)]
            public List<ListApmApplicationResponseBodyApmAppInfoListApmAppInfo> ApmAppInfo { get; set; }
            public class ListApmApplicationResponseBodyApmAppInfoListApmAppInfo : TeaModel {
                public long? VcoreSeconds { get; set; }
                public string Diagnostics { get; set; }
                public string Queue { get; set; }
                public string DiagnoseCode { get; set; }
                public string FinalStatus { get; set; }
                public long? AllocatedVcore { get; set; }
                public float? QueueUsagePercent { get; set; }
                public string Name { get; set; }
                public string ResourceRequests { get; set; }
                public float? Progress { get; set; }
                public string State { get; set; }
                public float? ClusterUsagePercent { get; set; }
                public int? RunningContainers { get; set; }
                public string ApplicationType { get; set; }
                public string User { get; set; }
                public long? AllocatedMemory { get; set; }
                public int? RunningDuration { get; set; }
                public long? MemorySeconds { get; set; }
                public long? StartTime { get; set; }
                public string DiagnoseResult { get; set; }
                public long? FinishedTime { get; set; }
                public int? Duration { get; set; }
                public string ClusterBizId { get; set; }
                public string ApplicationId { get; set; }
                public long? SubmitTime { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
