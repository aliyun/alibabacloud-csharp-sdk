// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class DescribeInstanceTenantModesResponseBody : TeaModel {
        [NameInMap("InstanceModes")]
        [Validation(Required=false)]
        public List<string> InstanceModes { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
