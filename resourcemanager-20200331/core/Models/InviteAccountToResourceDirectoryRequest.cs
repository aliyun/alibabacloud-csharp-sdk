// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class InviteAccountToResourceDirectoryRequest : TeaModel {
        [NameInMap("TargetEntity")]
        [Validation(Required=true)]
        public string TargetEntity { get; set; }

        [NameInMap("TargetType")]
        [Validation(Required=true)]
        public string TargetType { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

    }

}
