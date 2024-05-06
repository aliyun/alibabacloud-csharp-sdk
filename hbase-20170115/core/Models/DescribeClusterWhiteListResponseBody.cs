// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class DescribeClusterWhiteListResponseBody : TeaModel {
        [NameInMap("GroupItems")]
        [Validation(Required=false)]
        public DescribeClusterWhiteListResponseBodyGroupItems GroupItems { get; set; }
        public class DescribeClusterWhiteListResponseBodyGroupItems : TeaModel {
            [NameInMap("WhiteIp")]
            [Validation(Required=false)]
            public List<string> WhiteIp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
