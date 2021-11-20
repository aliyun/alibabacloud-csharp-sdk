// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DeleteCompliancePacksResponseBody : TeaModel {
        [NameInMap("OperateCompliancePacksResult")]
        [Validation(Required=false)]
        public DeleteCompliancePacksResponseBodyOperateCompliancePacksResult OperateCompliancePacksResult { get; set; }
        public class DeleteCompliancePacksResponseBodyOperateCompliancePacksResult : TeaModel {
            [NameInMap("OperateCompliancePacks")]
            [Validation(Required=false)]
            public List<DeleteCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks> OperateCompliancePacks { get; set; }
            public class DeleteCompliancePacksResponseBodyOperateCompliancePacksResultOperateCompliancePacks : TeaModel {
                public string CompliancePackId { get; set; }
                public string ErrorCode { get; set; }
                public bool? Success { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
