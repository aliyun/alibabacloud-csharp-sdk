// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20180720.Models
{
    public class DescribePackIpListResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public int? Total { get; set; }

        [NameInMap("IpList")]
        [Validation(Required=true)]
        public List<DescribePackIpListResponseIpList> IpList { get; set; }
        public class DescribePackIpListResponseIpList : TeaModel {
            [NameInMap("Ip")]
            [Validation(Required=true)]
            public string Ip { get; set; }

            [NameInMap("Product")]
            [Validation(Required=true)]
            public string Product { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=true)]
            public string Remark { get; set; }

        }

    }

}
