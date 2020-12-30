// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetJobOutputStatisticInfoResponseBody : TeaModel {
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

        [NameInMap("JobOutputList")]
        [Validation(Required=false)]
        public GetJobOutputStatisticInfoResponseBodyJobOutputList JobOutputList { get; set; }
        public class GetJobOutputStatisticInfoResponseBodyJobOutputList : TeaModel {
            [NameInMap("ClusterStatJobOutput")]
            [Validation(Required=false)]
            public List<GetJobOutputStatisticInfoResponseBodyJobOutputListClusterStatJobOutput> ClusterStatJobOutput { get; set; }
            public class GetJobOutputStatisticInfoResponseBodyJobOutputListClusterStatJobOutput : TeaModel {
                public long? StartTime { get; set; }
                public long? FinishTime { get; set; }
                public string State { get; set; }
                public string JobId { get; set; }
                public string User { get; set; }
                public string Queue { get; set; }
                public long? BytesOutput { get; set; }
                public string Name { get; set; }
                public string ApplicationId { get; set; }
            }
        };

    }

}
