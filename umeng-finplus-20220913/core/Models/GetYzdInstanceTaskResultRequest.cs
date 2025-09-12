// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Umeng_finplus20220913.Models
{
    public class GetYzdInstanceTaskResultRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public GetYzdInstanceTaskResultRequestBody Body { get; set; }
        public class GetYzdInstanceTaskResultRequestBody : TeaModel {
            [NameInMap("appId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("rangeTimeEndTime")]
            [Validation(Required=false)]
            public string RangeTimeEndTime { get; set; }

            [NameInMap("rangeTimeStartTime")]
            [Validation(Required=false)]
            public string RangeTimeStartTime { get; set; }

        }

    }

}
