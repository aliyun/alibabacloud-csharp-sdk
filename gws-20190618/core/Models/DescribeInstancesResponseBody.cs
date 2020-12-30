// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("WorkMode")]
            [Validation(Required=false)]
            public string WorkMode { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("StoppedMode")]
            [Validation(Required=false)]
            public string StoppedMode { get; set; }

            [NameInMap("UserUid")]
            [Validation(Required=false)]
            public long? UserUid { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=false)]
            public string InstanceChargeType { get; set; }

            [NameInMap("AppList")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesAppList> AppList { get; set; }
            public class DescribeInstancesResponseBodyInstancesAppList : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                [NameInMap("AppPath")]
                [Validation(Required=false)]
                public string AppPath { get; set; }

                [NameInMap("AppArgs")]
                [Validation(Required=false)]
                public string AppArgs { get; set; }

            }

            [NameInMap("MaxBandwidthIn")]
            [Validation(Required=false)]
            public long? MaxBandwidthIn { get; set; }

            [NameInMap("IsBoundUser")]
            [Validation(Required=false)]
            public bool? IsBoundUser { get; set; }

            [NameInMap("MaxBandwidthOut")]
            [Validation(Required=false)]
            public long? MaxBandwidthOut { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

    }

}
