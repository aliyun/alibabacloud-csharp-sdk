// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class UpdateMemberRoleRequest : TeaModel {
        [NameInMap("Bid")]
        [Validation(Required=false)]
        public string Bid { get; set; }

        [NameInMap("Bizid")]
        [Validation(Required=false)]
        public string Bizid { get; set; }

        [NameInMap("Role")]
        [Validation(Required=false)]
        public int? Role { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public long? UserId { get; set; }

    }

}
