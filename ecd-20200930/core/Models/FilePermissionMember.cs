// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class FilePermissionMember : TeaModel {
        [NameInMap("CdsIdentity")]
        [Validation(Required=false)]
        public FilePermissionMemberCdsIdentity CdsIdentity { get; set; }
        public class FilePermissionMemberCdsIdentity : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("DisinheritSubGroup")]
        [Validation(Required=false)]
        public bool? DisinheritSubGroup { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public long? ExpireTime { get; set; }

        [NameInMap("RoleId")]
        [Validation(Required=false)]
        public string RoleId { get; set; }

    }

}
