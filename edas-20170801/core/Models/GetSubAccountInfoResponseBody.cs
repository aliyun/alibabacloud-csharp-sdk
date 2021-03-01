// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetSubAccountInfoResponseBody : TeaModel {
        [NameInMap("Authorization")]
        [Validation(Required=false)]
        public GetSubAccountInfoResponseBodyAuthorization Authorization { get; set; }
        public class GetSubAccountInfoResponseBodyAuthorization : TeaModel {
            [NameInMap("RoleIdData")]
            [Validation(Required=false)]
            public string RoleIdData { get; set; }
            [NameInMap("RamOperation")]
            [Validation(Required=false)]
            public bool? RamOperation { get; set; }
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }
            [NameInMap("EdasId")]
            [Validation(Required=false)]
            public string EdasId { get; set; }
            [NameInMap("IsRamDel")]
            [Validation(Required=false)]
            public bool? IsRamDel { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }
            [NameInMap("AdminEdasId")]
            [Validation(Required=false)]
            public string AdminEdasId { get; set; }
            [NameInMap("ResGroupId")]
            [Validation(Required=false)]
            public long? ResGroupId { get; set; }
            [NameInMap("IsRamSlave")]
            [Validation(Required=false)]
            public bool? IsRamSlave { get; set; }
            [NameInMap("AdminUserId")]
            [Validation(Required=false)]
            public string AdminUserId { get; set; }
            [NameInMap("SubUserKp")]
            [Validation(Required=false)]
            public string SubUserKp { get; set; }
            [NameInMap("AppIdData")]
            [Validation(Required=false)]
            public string AppIdData { get; set; }
            [NameInMap("ResGroupIdData")]
            [Validation(Required=false)]
            public string ResGroupIdData { get; set; }
            [NameInMap("Sts")]
            [Validation(Required=false)]
            public bool? Sts { get; set; }
            [NameInMap("DelegateAdmin")]
            [Validation(Required=false)]
            public bool? DelegateAdmin { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

    }

}
