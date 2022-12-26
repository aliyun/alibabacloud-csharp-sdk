// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageScanAuthorizationResponseBody : TeaModel {
        [NameInMap("AuthStatus")]
        [Validation(Required=false)]
        public DescribeImageScanAuthorizationResponseBodyAuthStatus AuthStatus { get; set; }
        public class DescribeImageScanAuthorizationResponseBodyAuthStatus : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
