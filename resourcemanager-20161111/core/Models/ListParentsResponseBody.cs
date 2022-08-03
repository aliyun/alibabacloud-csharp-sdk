// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class ListParentsResponseBody : TeaModel {
        [NameInMap("Folders")]
        [Validation(Required=false)]
        public ListParentsResponseBodyFolders Folders { get; set; }
        public class ListParentsResponseBodyFolders : TeaModel {
            [NameInMap("Folder")]
            [Validation(Required=false)]
            public List<ListParentsResponseBodyFoldersFolder> Folder { get; set; }
            public class ListParentsResponseBodyFoldersFolder : TeaModel {
                public string CreateDate { get; set; }
                public string FolderId { get; set; }
                public string Name { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
