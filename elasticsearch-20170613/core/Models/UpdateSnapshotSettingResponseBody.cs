// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class UpdateSnapshotSettingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public UpdateSnapshotSettingResponseBodyResult Result { get; set; }
        public class UpdateSnapshotSettingResponseBodyResult : TeaModel {
            [NameInMap("quartzRegex")]
            [Validation(Required=false)]
            public string QuartzRegex { get; set; }
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
        };

    }

}
