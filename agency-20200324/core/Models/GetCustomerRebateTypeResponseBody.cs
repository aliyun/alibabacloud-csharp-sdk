// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20200324.Models
{
    public class GetCustomerRebateTypeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("FxUserInfoExt")]
        [Validation(Required=false)]
        public GetCustomerRebateTypeResponseBodyFxUserInfoExt FxUserInfoExt { get; set; }
        public class GetCustomerRebateTypeResponseBodyFxUserInfoExt : TeaModel {
            [NameInMap("CustomerRebateType")]
            [Validation(Required=false)]
            public int? CustomerRebateType { get; set; }

            [NameInMap("DistributionRebateType")]
            [Validation(Required=false)]
            public int? DistributionRebateType { get; set; }

            [NameInMap("IsSub")]
            [Validation(Required=false)]
            public int? IsSub { get; set; }

            [NameInMap("KpId")]
            [Validation(Required=false)]
            public long? KpId { get; set; }

            [NameInMap("Level")]
            [Validation(Required=false)]
            public int? Level { get; set; }

            [NameInMap("ParentUid")]
            [Validation(Required=false)]
            public long? ParentUid { get; set; }

            [NameInMap("SubUserCount")]
            [Validation(Required=false)]
            public int? SubUserCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
