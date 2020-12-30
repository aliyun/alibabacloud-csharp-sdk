// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeClientUserDNSResponseBody : TeaModel {
        [NameInMap("AppDNS")]
        [Validation(Required=false)]
        public List<string> AppDNS { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RecoveredDNS")]
        [Validation(Required=false)]
        public List<string> RecoveredDNS { get; set; }

    }

}
