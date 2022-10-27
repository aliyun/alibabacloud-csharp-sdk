// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ModifySecurityIpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SecurityIpGroup")]
        [Validation(Required=false)]
        public ModifySecurityIpsResponseBodySecurityIpGroup SecurityIpGroup { get; set; }
        public class ModifySecurityIpsResponseBodySecurityIpGroup : TeaModel {
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
