// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSubAccountResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubAccountList")]
        [Validation(Required=false)]
        public ListSubAccountResponseBodySubAccountList SubAccountList { get; set; }
        public class ListSubAccountResponseBodySubAccountList : TeaModel {
            [NameInMap("SubAccount")]
            [Validation(Required=false)]
            public List<ListSubAccountResponseBodySubAccountListSubAccount> SubAccount { get; set; }
            public class ListSubAccountResponseBodySubAccountListSubAccount : TeaModel {
                public string AdminEdasId { get; set; }
                public string AdminUserId { get; set; }
                public string AdminUserKp { get; set; }
                public string Email { get; set; }
                public string Phone { get; set; }
                public string SubEdasId { get; set; }
                public string SubUserId { get; set; }
                public string SubUserKp { get; set; }
            }
        };

    }

}
