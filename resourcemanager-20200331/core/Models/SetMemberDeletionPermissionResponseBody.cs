// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class SetMemberDeletionPermissionResponseBody : TeaModel {
        [NameInMap("ManagementAccountId")]
        [Validation(Required=false)]
        public string ManagementAccountId { get; set; }

        [NameInMap("MemberDeletionStatus")]
        [Validation(Required=false)]
        public string MemberDeletionStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDirectoryId")]
        [Validation(Required=false)]
        public string ResourceDirectoryId { get; set; }

    }

}
