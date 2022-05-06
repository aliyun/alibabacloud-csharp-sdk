// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeHASwitchConfigResponseBody : TeaModel {
        [NameInMap("HAConfig")]
        [Validation(Required=false)]
        public string HAConfig { get; set; }

        [NameInMap("ManualHATime")]
        [Validation(Required=false)]
        public string ManualHATime { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
