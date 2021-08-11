// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class PromoteResourceAccountResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Account")]
        [Validation(Required=false)]
        public PromoteResourceAccountResponseBodyAccount Account { get; set; }
        public class PromoteResourceAccountResponseBodyAccount : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("FolderId")]
            [Validation(Required=false)]
            public string FolderId { get; set; }
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }
            [NameInMap("RecordId")]
            [Validation(Required=false)]
            public string RecordId { get; set; }
            [NameInMap("JoinTime")]
            [Validation(Required=false)]
            public string JoinTime { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }
            [NameInMap("JoinMethod")]
            [Validation(Required=false)]
            public string JoinMethod { get; set; }
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }
        };

    }

}
