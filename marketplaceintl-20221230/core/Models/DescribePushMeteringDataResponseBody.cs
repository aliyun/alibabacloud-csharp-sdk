// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MarketplaceIntl20221230.Models
{
    public class DescribePushMeteringDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ForceFatal")]
        [Validation(Required=false)]
        public bool? ForceFatal { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePushMeteringDataResponseBodyResult Result { get; set; }
        public class DescribePushMeteringDataResponseBodyResult : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IsPushBilling")]
            [Validation(Required=false)]
            public bool? IsPushBilling { get; set; }

            [NameInMap("MeteringAssist")]
            [Validation(Required=false)]
            public string MeteringAssist { get; set; }

            [NameInMap("MeteringEntity")]
            [Validation(Required=false)]
            public string MeteringEntity { get; set; }

            [NameInMap("PushOrderBizId")]
            [Validation(Required=false)]
            public string PushOrderBizId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
