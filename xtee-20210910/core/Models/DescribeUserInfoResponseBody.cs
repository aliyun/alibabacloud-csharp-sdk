// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeUserInfoResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeUserInfoResponseBodyResultObject ResultObject { get; set; }
        public class DescribeUserInfoResponseBodyResultObject : TeaModel {
            [NameInMap("clientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("subId")]
            [Validation(Required=false)]
            public string SubId { get; set; }

            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            [NameInMap("userName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
