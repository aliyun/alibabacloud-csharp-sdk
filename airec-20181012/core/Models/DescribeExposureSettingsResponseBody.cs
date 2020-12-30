// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20181012.Models
{
    public class DescribeExposureSettingsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeExposureSettingsResponseBodyResult Result { get; set; }
        public class DescribeExposureSettingsResponseBodyResult : TeaModel {
            [NameInMap("DurationSeconds")]
            [Validation(Required=false)]
            public int? DurationSeconds { get; set; }
            [NameInMap("ScenarioBased")]
            [Validation(Required=false)]
            public bool? ScenarioBased { get; set; }
        };

    }

}
