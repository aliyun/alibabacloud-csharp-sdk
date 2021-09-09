// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpgradeEngineVersionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpgradeEngineVersionResponseBodyResult Result { get; set; }
        public class UpgradeEngineVersionResponseBodyResult : TeaModel {
            [NameInMap("validateType")]
            [Validation(Required=false)]
            public string ValidateType { get; set; }
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("validateResult")]
            [Validation(Required=false)]
            public UpgradeEngineVersionResponseBodyResultValidateResult ValidateResult { get; set; }
            public class UpgradeEngineVersionResponseBodyResultValidateResult : TeaModel {
                [NameInMap("errorType")]
                [Validation(Required=false)]
                public string ErrorType { get; set; }

                [NameInMap("errorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("errorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

            }
        };

    }

}
