// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CheckServiceLinkedRoleForDeletingResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Deletable")]
        [Validation(Required=false)]
        public bool? Deletable { get; set; }

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
