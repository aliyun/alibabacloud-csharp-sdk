// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeProtectionModuleModeResponseBody : TeaModel {
        [NameInMap("LearnStatus")]
        [Validation(Required=false)]
        public int? LearnStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Mode")]
        [Validation(Required=false)]
        public int? Mode { get; set; }

    }

}
