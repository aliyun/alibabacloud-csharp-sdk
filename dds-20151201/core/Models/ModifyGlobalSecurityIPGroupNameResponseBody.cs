// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifyGlobalSecurityIPGroupNameResponseBody : TeaModel {
        [NameInMap("GlobalSecurityIPGroup")]
        [Validation(Required=false)]
        public List<ModifyGlobalSecurityIPGroupNameResponseBodyGlobalSecurityIPGroup> GlobalSecurityIPGroup { get; set; }
        public class ModifyGlobalSecurityIPGroupNameResponseBodyGlobalSecurityIPGroup : TeaModel {
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
