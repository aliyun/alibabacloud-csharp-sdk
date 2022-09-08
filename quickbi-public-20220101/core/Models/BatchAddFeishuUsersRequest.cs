// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class BatchAddFeishuUsersRequest : TeaModel {
        [NameInMap("FeishuUsers")]
        [Validation(Required=false)]
        public string FeishuUsers { get; set; }

        [NameInMap("IsAdmin")]
        [Validation(Required=false)]
        public bool? IsAdmin { get; set; }

        [NameInMap("IsAuthAdmin")]
        [Validation(Required=false)]
        public bool? IsAuthAdmin { get; set; }

        [NameInMap("UserGroupIds")]
        [Validation(Required=false)]
        public string UserGroupIds { get; set; }

        [NameInMap("UserType")]
        [Validation(Required=false)]
        public int? UserType { get; set; }

    }

}
