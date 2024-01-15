// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListFilePermissionResponseBody : TeaModel {
        /// <summary>
        /// The permissions on the shared file.
        /// </summary>
        [NameInMap("FilePermissions")]
        [Validation(Required=false)]
        public List<FilePermissionMember> FilePermissions { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
