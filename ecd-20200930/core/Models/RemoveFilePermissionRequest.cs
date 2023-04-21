// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RemoveFilePermissionRequest : TeaModel {
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public string CdsId { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("FileId")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("MemberList")]
        [Validation(Required=false)]
        public List<RemoveFilePermissionRequestMemberList> MemberList { get; set; }
        public class RemoveFilePermissionRequestMemberList : TeaModel {
            [NameInMap("CdsIdentity")]
            [Validation(Required=false)]
            public RemoveFilePermissionRequestMemberListCdsIdentity CdsIdentity { get; set; }
            public class RemoveFilePermissionRequestMemberListCdsIdentity : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("RoleId")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
