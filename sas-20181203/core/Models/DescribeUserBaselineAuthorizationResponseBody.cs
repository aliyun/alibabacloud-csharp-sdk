// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUserBaselineAuthorizationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserBaselineAuthorization")]
        [Validation(Required=false)]
        public DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization UserBaselineAuthorization { get; set; }
        public class DescribeUserBaselineAuthorizationResponseBodyUserBaselineAuthorization : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
        };

    }

}
