// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class AddFilePermissionRequest : TeaModel {
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
        public List<AddFilePermissionRequestMemberList> MemberList { get; set; }
        public class AddFilePermissionRequestMemberList : TeaModel {
            [NameInMap("CdsIdentity")]
            [Validation(Required=false)]
            public AddFilePermissionRequestMemberListCdsIdentity CdsIdentity { get; set; }
            public class AddFilePermissionRequestMemberListCdsIdentity : TeaModel {
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
