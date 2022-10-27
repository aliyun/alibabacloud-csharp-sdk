// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class CreateSecurityIpGroupResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public CreateSecurityIpGroupResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class CreateSecurityIpGroupResponseBodySecurityIpGroup : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("SecurityIpGroupName")]
            [Validation(Required=false)]
            public string SecurityIpGroupName { get; set; }

            [NameInMap("SecurityIps")]
            [Validation(Required=false)]
            public string SecurityIps { get; set; }

        }

    }

}
