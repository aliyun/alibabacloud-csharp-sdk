// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDBClusterSSLResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SSLAutoRotate")]
        [Validation(Required=false)]
        public string SSLAutoRotate { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDBClusterSSLResponseBodyItems> Items { get; set; }
        public class DescribeDBClusterSSLResponseBodyItems : TeaModel {
            [NameInMap("SSLExpireTime")]
            [Validation(Required=false)]
            public string SSLExpireTime { get; set; }

            [NameInMap("SSLEnabled")]
            [Validation(Required=false)]
            public string SSLEnabled { get; set; }

            [NameInMap("SSLConnectionString")]
            [Validation(Required=false)]
            public string SSLConnectionString { get; set; }

            [NameInMap("DBEndpointId")]
            [Validation(Required=false)]
            public string DBEndpointId { get; set; }

        }

    }

}
