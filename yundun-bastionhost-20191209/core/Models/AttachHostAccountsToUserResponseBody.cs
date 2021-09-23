// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachHostAccountsToUserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachHostAccountsToUserResponseBodyResults> Results { get; set; }
        public class AttachHostAccountsToUserResponseBodyResults : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("HostAccounts")]
            [Validation(Required=false)]
            public List<AttachHostAccountsToUserResponseBodyResultsHostAccounts> HostAccounts { get; set; }
            public class AttachHostAccountsToUserResponseBodyResultsHostAccounts : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("HostAccountId")]
                [Validation(Required=false)]
                public string HostAccountId { get; set; }

            }

        }

    }

}
