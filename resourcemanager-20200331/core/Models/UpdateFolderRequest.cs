// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateFolderRequest : TeaModel {
        [NameInMap("FolderId")]
        [Validation(Required=true)]
        public string FolderId { get; set; }

        [NameInMap("NewFolderName")]
        [Validation(Required=true)]
        public string NewFolderName { get; set; }

    }

}
