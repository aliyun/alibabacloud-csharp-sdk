// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeEventOnStageResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityEventStageResponse")]
        [Validation(Required=false)]
        public DescribeEventOnStageResponseBodySecurityEventStageResponse SecurityEventStageResponse { get; set; }
        public class DescribeEventOnStageResponseBodySecurityEventStageResponse : TeaModel {
            [NameInMap("SecurityEventOnStag")]
            [Validation(Required=false)]
            public Dictionary<string, object> SecurityEventOnStag { get; set; }

        }

    }

}
