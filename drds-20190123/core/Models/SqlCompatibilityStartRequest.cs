// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SqlCompatibilityStartRequest : TeaModel {
        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("PerformanceTest")]
        [Validation(Required=false)]
        public bool? PerformanceTest { get; set; }

        [NameInMap("TargetVersion")]
        [Validation(Required=false)]
        public string TargetVersion { get; set; }

    }

}
