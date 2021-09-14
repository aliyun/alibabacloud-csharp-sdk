// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class DescribeDbfsSpecificationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SupportedEcsInstanceTypeFamily")]
        [Validation(Required=false)]
        public List<string> SupportedEcsInstanceTypeFamily { get; set; }

        [NameInMap("MaxDbfsNumberPerEcs")]
        [Validation(Required=false)]
        public Dictionary<string, object> MaxDbfsNumberPerEcs { get; set; }

    }

}
