// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetPermissionResponseBody : TeaModel {
        [NameInMap("PermissionCode")]
        [Validation(Required=false)]
        public string PermissionCode { get; set; }

        [NameInMap("PermissionRules")]
        [Validation(Required=false)]
        public List<GetPermissionResponseBodyPermissionRules> PermissionRules { get; set; }
        public class GetPermissionResponseBodyPermissionRules : TeaModel {
            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            [NameInMap("EntityAccessType")]
            [Validation(Required=false)]
            public string EntityAccessType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
