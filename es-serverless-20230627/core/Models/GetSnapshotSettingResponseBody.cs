// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class GetSnapshotSettingResponseBody : TeaModel {
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetSnapshotSettingResponseBodyResult Result { get; set; }
        public class GetSnapshotSettingResponseBodyResult : TeaModel {
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("quartzRegex")]
            [Validation(Required=false)]
            public string QuartzRegex { get; set; }

        }

    }

}
