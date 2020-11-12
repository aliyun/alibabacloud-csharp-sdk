// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ResendPromoteResourceAccountEmailResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Account")]
        [Validation(Required=true)]
        public ResendPromoteResourceAccountEmailResponseAccount Account { get; set; }
        public class ResendPromoteResourceAccountEmailResponseAccount : TeaModel {
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=true)]
            public string ResourceDirectoryId { get; set; }
            [NameInMap("AccountId")]
            [Validation(Required=true)]
            public string AccountId { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=true)]
            public string DisplayName { get; set; }
            [NameInMap("FolderId")]
            [Validation(Required=true)]
            public string FolderId { get; set; }
            [NameInMap("JoinMethod")]
            [Validation(Required=true)]
            public string JoinMethod { get; set; }
            [NameInMap("JoinTime")]
            [Validation(Required=true)]
            public string JoinTime { get; set; }
            [NameInMap("Type")]
            [Validation(Required=true)]
            public string Type { get; set; }
            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }
            [NameInMap("RecordId")]
            [Validation(Required=true)]
            public string RecordId { get; set; }
            [NameInMap("ModifyTime")]
            [Validation(Required=true)]
            public string ModifyTime { get; set; }
            [NameInMap("AccountName")]
            [Validation(Required=true)]
            public string AccountName { get; set; }
        };

    }

}
