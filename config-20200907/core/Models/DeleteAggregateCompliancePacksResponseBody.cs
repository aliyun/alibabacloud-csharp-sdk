// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteAggregateCompliancePacksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("OperateCompliancePacksResult")]
        [Validation(Required=false)]
        public DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResult OperateCompliancePacksResult { get; set; }
        public class DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResult : TeaModel {
            [NameInMap("OperateCompliancePacks")]
            [Validation(Required=false)]
            public List<DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks> OperateCompliancePacks { get; set; }
            public class DeleteAggregateCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks : TeaModel {
                public string CompliancePackId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

    }

}
