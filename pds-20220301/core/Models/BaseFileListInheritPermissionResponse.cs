// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class BaseFileListInheritPermissionResponse : TeaModel {
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("member")]
        [Validation(Required=false)]
        public FilePermissionMember Member { get; set; }

    }

}
