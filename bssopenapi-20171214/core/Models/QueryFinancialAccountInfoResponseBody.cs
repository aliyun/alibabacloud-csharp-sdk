// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryFinancialAccountInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryFinancialAccountInfoResponseBodyData Data { get; set; }
        public class QueryFinancialAccountInfoResponseBodyData : TeaModel {
            [NameInMap("MemberNickName")]
            [Validation(Required=false)]
            public string MemberNickName { get; set; }
            [NameInMap("IsFinancialAccount")]
            [Validation(Required=false)]
            public bool? IsFinancialAccount { get; set; }
            [NameInMap("MemberGroupName")]
            [Validation(Required=false)]
            public string MemberGroupName { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }
            [NameInMap("MemberGroupId")]
            [Validation(Required=false)]
            public long? MemberGroupId { get; set; }
        };

    }

}
