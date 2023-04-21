// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListFilePermissionResponseBody : TeaModel {
        [NameInMap("FilePermissions")]
        [Validation(Required=false)]
        public List<FilePermissionMember> FilePermissions { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
