// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgUserGroupQueryUserListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DsgUserGroupQueryUserListResponseBodyData> Data { get; set; }
        public class DsgUserGroupQueryUserListResponseBodyData : TeaModel {
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public int? AccountType { get; set; }

            [NameInMap("BaseId")]
            [Validation(Required=false)]
            public string BaseId { get; set; }

            [NameInMap("ParentAccountId")]
            [Validation(Required=false)]
            public string ParentAccountId { get; set; }

            [NameInMap("YunAccount")]
            [Validation(Required=false)]
            public string YunAccount { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
