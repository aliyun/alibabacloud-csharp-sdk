// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachHostGroupAccountsFromUserResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DetachHostGroupAccountsFromUserResponseBodyResults> Results { get; set; }
        public class DetachHostGroupAccountsFromUserResponseBodyResults : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("HostGroupId")]
            [Validation(Required=false)]
            public string HostGroupId { get; set; }

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("HostAccountNames")]
            [Validation(Required=false)]
            public List<DetachHostGroupAccountsFromUserResponseBodyResultsHostAccountNames> HostAccountNames { get; set; }
            public class DetachHostGroupAccountsFromUserResponseBodyResultsHostAccountNames : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("HostAccountName")]
                [Validation(Required=false)]
                public string HostAccountName { get; set; }

            }

        }

    }

}
