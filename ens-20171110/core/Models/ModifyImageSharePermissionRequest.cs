// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ModifyImageSharePermissionRequest : TeaModel {
        [NameInMap("AddAccounts")]
        [Validation(Required=false)]
        public string AddAccounts { get; set; }

        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("RemoveAccounts")]
        [Validation(Required=false)]
        public string RemoveAccounts { get; set; }

    }

}
