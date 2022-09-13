// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class FileRemovePermissionRequest : TeaModel {
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        [NameInMap("member_list")]
        [Validation(Required=false)]
        public List<FileRemovePermissionRequestMemberList> MemberList { get; set; }
        public class FileRemovePermissionRequestMemberList : TeaModel {
            [NameInMap("identity")]
            [Validation(Required=false)]
            public Identity Identity { get; set; }

            [NameInMap("role_id")]
            [Validation(Required=false)]
            public string RoleId { get; set; }

        }

    }

}
