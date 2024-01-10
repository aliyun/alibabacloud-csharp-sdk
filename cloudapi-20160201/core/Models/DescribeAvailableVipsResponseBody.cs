// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160201.Models
{
    public class DescribeAvailableVipsResponseBody : TeaModel {
        [NameInMap("AvailableVips")]
        [Validation(Required=false)]
        public DescribeAvailableVipsResponseBodyAvailableVips AvailableVips { get; set; }
        public class DescribeAvailableVipsResponseBodyAvailableVips : TeaModel {
            [NameInMap("AvailableVip")]
            [Validation(Required=false)]
            public List<string> AvailableVip { get; set; }

        }

    }

}
