// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class DescribeOpenAccountResponseBody : TeaModel {
        [NameInMap("OpenAccount")]
        [Validation(Required=false)]
        public DescribeOpenAccountResponseBodyOpenAccount OpenAccount { get; set; }
        public class DescribeOpenAccountResponseBodyOpenAccount : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("CreateAccessKey")]
            [Validation(Required=false)]
            public string CreateAccessKey { get; set; }
            [NameInMap("OpenId")]
            [Validation(Required=false)]
            public string OpenId { get; set; }
            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("IdentityId")]
            [Validation(Required=false)]
            public string IdentityId { get; set; }
            [NameInMap("LoginId")]
            [Validation(Required=false)]
            public string LoginId { get; set; }
            [NameInMap("Idp")]
            [Validation(Required=false)]
            public string Idp { get; set; }
            [NameInMap("AliyunId")]
            [Validation(Required=false)]
            public string AliyunId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
