// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20190910.Models
{
    public class DescribeProtectionModuleStatusResponseBody : TeaModel {
        [NameInMap("ModuleStatus")]
        [Validation(Required=false)]
        public int? ModuleStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
