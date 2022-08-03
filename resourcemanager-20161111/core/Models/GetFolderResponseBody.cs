// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class GetFolderResponseBody : TeaModel {
        [NameInMap("Folder")]
        [Validation(Required=false)]
        public GetFolderResponseBodyFolder Folder { get; set; }
        public class GetFolderResponseBodyFolder : TeaModel {
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ParentFolderId")]
            [Validation(Required=false)]
            public string ParentFolderId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
