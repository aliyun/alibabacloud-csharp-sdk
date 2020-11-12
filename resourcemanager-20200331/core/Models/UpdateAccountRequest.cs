// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAccountRequest : TeaModel {
        [NameInMap("NewDisplayName")]
        [Validation(Required=true)]
        public string NewDisplayName { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=true)]
        public string AccountId { get; set; }

    }

}
