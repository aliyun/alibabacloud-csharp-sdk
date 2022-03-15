// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeApplicationInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeApplicationInstancesResponseBodyData Data { get; set; }
        public class DescribeApplicationInstancesResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<DescribeApplicationInstancesResponseBodyDataInstances> Instances { get; set; }
            public class DescribeApplicationInstancesResponseBodyDataInstances : TeaModel {
                public long? CreateTimeStamp { get; set; }
                public string Eip { get; set; }
                public long? FinishTimeStamp { get; set; }
                public string GroupId { get; set; }
                public string ImageUrl { get; set; }
                public string InstanceContainerIp { get; set; }
                public long? InstanceContainerRestarts { get; set; }
                public string InstanceContainerStatus { get; set; }
                public string InstanceHealthStatus { get; set; }
                public string InstanceId { get; set; }
                public string PackageVersion { get; set; }
                public string VSwitchId { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }
        };

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TraceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
