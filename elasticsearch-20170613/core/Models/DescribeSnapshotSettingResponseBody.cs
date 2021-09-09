// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeSnapshotSettingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeSnapshotSettingResponseBodyResult Result { get; set; }
        public class DescribeSnapshotSettingResponseBodyResult : TeaModel {
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
            [NameInMap("QuartzRegex")]
            [Validation(Required=false)]
            public string QuartzRegex { get; set; }
        };

    }

}
