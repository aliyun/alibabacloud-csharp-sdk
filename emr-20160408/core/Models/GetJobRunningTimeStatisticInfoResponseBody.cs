// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetJobRunningTimeStatisticInfoResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        [NameInMap("RunningTimeList")]
        [Validation(Required=false)]
        public GetJobRunningTimeStatisticInfoResponseBodyRunningTimeList RunningTimeList { get; set; }
        public class GetJobRunningTimeStatisticInfoResponseBodyRunningTimeList : TeaModel {
            [NameInMap("ClusterStatJobRunningTime")]
            [Validation(Required=false)]
            public List<GetJobRunningTimeStatisticInfoResponseBodyRunningTimeListClusterStatJobRunningTime> ClusterStatJobRunningTime { get; set; }
            public class GetJobRunningTimeStatisticInfoResponseBodyRunningTimeListClusterStatJobRunningTime : TeaModel {
                public long? StartTime { get; set; }
                public long? RunningTime { get; set; }
                public long? FinishTime { get; set; }
                public string State { get; set; }
                public string JobId { get; set; }
                public string User { get; set; }
                public string Queue { get; set; }
                public string Name { get; set; }
                public string ApplicationId { get; set; }
            }
        };

    }

}
