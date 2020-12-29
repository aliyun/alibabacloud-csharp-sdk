// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksFullStatusResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("DiskFullStatusSet")]
        [Validation(Required=false)]
        public DescribeDisksFullStatusResponseBodyDiskFullStatusSet DiskFullStatusSet { get; set; }
        public class DescribeDisksFullStatusResponseBodyDiskFullStatusSet : TeaModel {
            [NameInMap("DiskFullStatusType")]
            [Validation(Required=false)]
            public List<DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType> DiskFullStatusType { get; set; }
            public class DescribeDisksFullStatusResponseBodyDiskFullStatusSetDiskFullStatusType : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public int? Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }
        };

    }

}
