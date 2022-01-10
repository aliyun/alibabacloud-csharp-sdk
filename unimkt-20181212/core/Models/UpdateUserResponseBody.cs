// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class UpdateUserResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public UpdateUserResponseBodyModel Model { get; set; }
        public class UpdateUserResponseBodyModel : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public long? GmtCreateTime { get; set; }
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public long? GmtModifiedTime { get; set; }
            [NameInMap("IsDeleteTag")]
            [Validation(Required=false)]
            public string IsDeleteTag { get; set; }
            [NameInMap("MobilePhone")]
            [Validation(Required=false)]
            public string MobilePhone { get; set; }
            [NameInMap("RoleCode")]
            [Validation(Required=false)]
            public string RoleCode { get; set; }
            [NameInMap("SspUserId")]
            [Validation(Required=false)]
            public string SspUserId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("TenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }
            [NameInMap("TenantUserId")]
            [Validation(Required=false)]
            public string TenantUserId { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("YunPersonsId")]
            [Validation(Required=false)]
            public string YunPersonsId { get; set; }
            [NameInMap("YunUid")]
            [Validation(Required=false)]
            public string YunUid { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
