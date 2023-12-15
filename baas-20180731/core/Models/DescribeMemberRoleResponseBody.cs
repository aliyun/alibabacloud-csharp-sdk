// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeMemberRoleResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeMemberRoleResponseBodyResult Result { get; set; }
        public class DescribeMemberRoleResponseBodyResult : TeaModel {
            [NameInMap("Role")]
            [Validation(Required=false)]
            public int? Role { get; set; }

        }

    }

}
