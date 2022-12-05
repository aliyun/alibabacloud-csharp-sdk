// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreateGlobalSecurityIPGroupResponseBody : TeaModel {
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class CreateGlobalSecurityIPGroupResponseBodyGlobalSecurityIPGroup : TeaModel {
            [NameInMap("GIpList")]
            [Validation(Required=false)]
            public string GIpList { get; set; }

            [NameInMap("GlobalIgName")]
            [Validation(Required=false)]
            public string GlobalIgName { get; set; }

            [NameInMap("GlobalSecurityGroupId")]
            [Validation(Required=false)]
            public string GlobalSecurityGroupId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
