// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class DescribeInstancesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long TotalCount { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public long PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public long PageSize { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=true)]
        public List<DescribeInstancesResponseInstances> Instances { get; set; }
        public class DescribeInstancesResponseInstances : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=true)]
            public string Name { get; set; }

            [NameInMap("ClusterId")]
            [Validation(Required=true)]
            public string ClusterId { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("WorkMode")]
            [Validation(Required=true)]
            public string WorkMode { get; set; }

            [NameInMap("StoppedMode")]
            [Validation(Required=true)]
            public string StoppedMode { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=true)]
            public string ImageId { get; set; }

            [NameInMap("InstanceChargeType")]
            [Validation(Required=true)]
            public string InstanceChargeType { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=true)]
            public string InstanceType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=true)]
            public string CreateTime { get; set; }

            [NameInMap("ExpireTime")]
            [Validation(Required=true)]
            public string ExpireTime { get; set; }

            [NameInMap("UserUid")]
            [Validation(Required=true)]
            public long UserUid { get; set; }

            [NameInMap("UserName")]
            [Validation(Required=true)]
            public string UserName { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }

            [NameInMap("MaxBandwidthIn")]
            [Validation(Required=true)]
            public long MaxBandwidthIn { get; set; }

            [NameInMap("MaxBandwidthOut")]
            [Validation(Required=true)]
            public long MaxBandwidthOut { get; set; }

            [NameInMap("IsBoundUser")]
            [Validation(Required=true)]
            public bool? IsBoundUser { get; set; }

            [NameInMap("AppList")]
            [Validation(Required=true)]
            public List<DescribeInstancesResponseInstancesAppList> AppList { get; set; }
            public class DescribeInstancesResponseInstancesAppList : TeaModel {
                [NameInMap("AppName")]
                [Validation(Required=true)]
                public string AppName { get; set; }

                [NameInMap("AppPath")]
                [Validation(Required=true)]
                public string AppPath { get; set; }

                [NameInMap("AppArgs")]
                [Validation(Required=true)]
                public string AppArgs { get; set; }

            }

        }

    }

}
