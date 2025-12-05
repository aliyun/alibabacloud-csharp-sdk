// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200527.Models
{
    public class CheckServiceLinkedRoleForDeletingResponseBody : TeaModel {
        [NameInMap("DeleTable")]
        [Validation(Required=false)]
        public bool? DeleTable { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleUsages")]
        [Validation(Required=false)]
        public List<CheckServiceLinkedRoleForDeletingResponseBodyRoleUsages> RoleUsages { get; set; }
        public class CheckServiceLinkedRoleForDeletingResponseBodyRoleUsages : TeaModel {
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Resources")]
            [Validation(Required=false)]
            public List<string> Resources { get; set; }

        }

    }

}
