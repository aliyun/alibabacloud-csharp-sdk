// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeSecurityGroupAttributeResponseBody : TeaModel {
        [NameInMap("EgressPermissions")]
        [Validation(Required=false)]
        public List<Permission> EgressPermissions { get; set; }

        [NameInMap("IngressPermissions")]
        [Validation(Required=false)]
        public List<Permission> IngressPermissions { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
