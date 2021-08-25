// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregatorsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OperateAggregatorsResult")]
        [Validation(Required=false)]
        public DeleteAggregatorsResponseBodyOperateAggregatorsResult OperateAggregatorsResult { get; set; }
        public class DeleteAggregatorsResponseBodyOperateAggregatorsResult : TeaModel {
            [NameInMap("OperateAggregators")]
            [Validation(Required=false)]
            public List<DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators> OperateAggregators { get; set; }
            public class DeleteAggregatorsResponseBodyOperateAggregatorsResultOperateAggregators : TeaModel {
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
                public string AggregatorId { get; set; }
            }
        };

    }

}
