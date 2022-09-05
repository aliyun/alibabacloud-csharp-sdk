// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserVipsByDomainResponseBody : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Vips")]
        [Validation(Required=false)]
        public DescribeUserVipsByDomainResponseBodyVips Vips { get; set; }
        public class DescribeUserVipsByDomainResponseBodyVips : TeaModel {
            [NameInMap("Vip")]
            [Validation(Required=false)]
            public List<string> Vip { get; set; }

        }

    }

}
