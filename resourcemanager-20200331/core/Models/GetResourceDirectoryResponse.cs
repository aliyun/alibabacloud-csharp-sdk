// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceDirectoryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDirectory")]
        [Validation(Required=true)]
        public GetResourceDirectoryResponseResourceDirectory ResourceDirectory { get; set; }
        public class GetResourceDirectoryResponseResourceDirectory : TeaModel {
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=true)]
            public string ResourceDirectoryId { get; set; }
            [NameInMap("MasterAccountName")]
            [Validation(Required=true)]
            public string MasterAccountName { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }
            [NameInMap("RootFolderId")]
            [Validation(Required=true)]
            public string RootFolderId { get; set; }
            [NameInMap("MasterAccountId")]
            [Validation(Required=true)]
            public string MasterAccountId { get; set; }
        };

    }

}
