// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceIdsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<DescribeInstanceIdsResponseBodyInstanceIds> InstanceIds { get; set; }
        public class DescribeInstanceIdsResponseBodyInstanceIds : TeaModel {
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public int? Edition { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

        }

    }

}
