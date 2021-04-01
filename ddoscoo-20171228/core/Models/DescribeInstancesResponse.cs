// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long? Total { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public List<DescribeInstancesResponseInstances> Instances { get; set; }
        public class DescribeInstancesResponseInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=true)]
            public string Remark { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public int? Status { get; set; }

            [NameInMap("DebtStatus")]
            [Validation(Required=true)]
            public int? DebtStatus { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public long? ExpireTime { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }

            [NameInMap("Edition")]
            [Validation(Required=true)]
            public int? Edition { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=true)]
            public int? Enabled { get; set; }

        }

    }

}
