// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class CreateUserRequest : TeaModel {
        [NameInMap("AliyunUserId")]
        [Validation(Required=false)]
        public string AliyunUserId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public List<int?> GroupIdList { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RoleIdList")]
        [Validation(Required=false)]
        public List<int?> RoleIdList { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("UserAccountParamList")]
        [Validation(Required=false)]
        public List<CreateUserRequestUserAccountParamList> UserAccountParamList { get; set; }
        public class CreateUserRequestUserAccountParamList : TeaModel {
            [NameInMap("AccountPassword")]
            [Validation(Required=false)]
            public string AccountPassword { get; set; }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

        }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
