// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class GetResourceDirectoryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDirectory")]
        [Validation(Required=false)]
        public GetResourceDirectoryResponseBodyResourceDirectory ResourceDirectory { get; set; }
        public class GetResourceDirectoryResponseBodyResourceDirectory : TeaModel {
            [NameInMap("RootFolderId")]
            [Validation(Required=false)]
            public string RootFolderId { get; set; }
            [NameInMap("ResourceDirectoryId")]
            [Validation(Required=false)]
            public string ResourceDirectoryId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }
            [NameInMap("MasterAccountId")]
            [Validation(Required=false)]
            public string MasterAccountId { get; set; }
            [NameInMap("MasterAccountName")]
            [Validation(Required=false)]
            public string MasterAccountName { get; set; }
            [NameInMap("ControlPolicyStatus")]
            [Validation(Required=false)]
            public string ControlPolicyStatus { get; set; }
            [NameInMap("MemberDeletionStatus")]
            [Validation(Required=false)]
            public string MemberDeletionStatus { get; set; }
        };

    }

}
