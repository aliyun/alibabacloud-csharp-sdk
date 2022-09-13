// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ImportUserRequest : TeaModel {
        [NameInMap("authentication_display_name")]
        [Validation(Required=false)]
        public string AuthenticationDisplayName { get; set; }

        [NameInMap("authentication_type")]
        [Validation(Required=false)]
        public string AuthenticationType { get; set; }

        [NameInMap("auto_create_drive")]
        [Validation(Required=false)]
        public bool? AutoCreateDrive { get; set; }

        [NameInMap("drive_total_size")]
        [Validation(Required=false)]
        public long? DriveTotalSize { get; set; }

        [NameInMap("extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        [NameInMap("identity")]
        [Validation(Required=false)]
        public string Identity { get; set; }

        [NameInMap("nick_name")]
        [Validation(Required=false)]
        public string NickName { get; set; }

        [NameInMap("parent_group_id")]
        [Validation(Required=false)]
        public string ParentGroupId { get; set; }

    }

}
