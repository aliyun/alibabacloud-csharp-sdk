// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetJobInputStatisticInfoResponseBody : TeaModel {
        [NameInMap("JobInputList")]
        [Validation(Required=false)]
        public GetJobInputStatisticInfoResponseBodyJobInputList JobInputList { get; set; }
        public class GetJobInputStatisticInfoResponseBodyJobInputList : TeaModel {
            [NameInMap("ClusterStatJobInput")]
            [Validation(Required=false)]
            public List<GetJobInputStatisticInfoResponseBodyJobInputListClusterStatJobInput> ClusterStatJobInput { get; set; }
            public class GetJobInputStatisticInfoResponseBodyJobInputListClusterStatJobInput : TeaModel {
                public string ApplicationId { get; set; }
                public long? BytesInput { get; set; }
                public long? FinishTime { get; set; }
                public string JobId { get; set; }
                public string Name { get; set; }
                public string Queue { get; set; }
                public long? StartTime { get; set; }
                public string State { get; set; }
                public string User { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
