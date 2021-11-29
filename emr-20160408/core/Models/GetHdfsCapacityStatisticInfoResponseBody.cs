// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class GetHdfsCapacityStatisticInfoResponseBody : TeaModel {
        [NameInMap("HdfsCapacityList")]
        [Validation(Required=false)]
        public GetHdfsCapacityStatisticInfoResponseBodyHdfsCapacityList HdfsCapacityList { get; set; }
        public class GetHdfsCapacityStatisticInfoResponseBodyHdfsCapacityList : TeaModel {
            [NameInMap("ClusterStatHdfsCapacity")]
            [Validation(Required=false)]
            public List<GetHdfsCapacityStatisticInfoResponseBodyHdfsCapacityListClusterStatHdfsCapacity> ClusterStatHdfsCapacity { get; set; }
            public class GetHdfsCapacityStatisticInfoResponseBodyHdfsCapacityListClusterStatHdfsCapacity : TeaModel {
                public long? CapacityRemaining { get; set; }
                public long? CapacityRemainingGB { get; set; }
                public long? CapacityTotal { get; set; }
                public long? CapacityTotalGB { get; set; }
                public long? CapacityUsed { get; set; }
                public long? CapacityUsedGB { get; set; }
                public long? CapacityUsedNonDfs { get; set; }
                public string ClusterBizId { get; set; }
                public string DateTime { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
