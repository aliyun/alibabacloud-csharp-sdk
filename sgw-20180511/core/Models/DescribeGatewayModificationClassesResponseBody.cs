// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sgw20180511.Models
{
    public class DescribeGatewayModificationClassesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TargetGatewayClasses")]
        [Validation(Required=false)]
        public DescribeGatewayModificationClassesResponseBodyTargetGatewayClasses TargetGatewayClasses { get; set; }
        public class DescribeGatewayModificationClassesResponseBodyTargetGatewayClasses : TeaModel {
            [NameInMap("TargetGatewayClass")]
            [Validation(Required=false)]
            public List<DescribeGatewayModificationClassesResponseBodyTargetGatewayClassesTargetGatewayClass> TargetGatewayClass { get; set; }
            public class DescribeGatewayModificationClassesResponseBodyTargetGatewayClassesTargetGatewayClass : TeaModel {
                public string GatewayClass { get; set; }
                public bool? IsAvailable { get; set; }
            }
        };

    }

}
