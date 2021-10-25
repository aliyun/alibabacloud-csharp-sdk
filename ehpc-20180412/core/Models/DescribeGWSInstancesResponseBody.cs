// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeGWSInstancesResponseBody : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeGWSInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeGWSInstancesResponseBodyInstances : TeaModel {
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public List<DescribeGWSInstancesResponseBodyInstancesInstanceInfo> InstanceInfo { get; set; }
            public class DescribeGWSInstancesResponseBodyInstancesInstanceInfo : TeaModel {
                public string Status { get; set; }
                public string WorkMode { get; set; }
                public string ExpireTime { get; set; }
                public string CreateTime { get; set; }
                public string InstanceId { get; set; }
                public string Name { get; set; }
                public string InstanceType { get; set; }
                public string UserName { get; set; }
                public string ClusterId { get; set; }
                public DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList AppList { get; set; }
                public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppList : TeaModel {
                    [NameInMap("AppInfo")]
                    [Validation(Required=false)]
                    public List<DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo> AppInfo { get; set; }
                    public class DescribeGWSInstancesResponseBodyInstancesInstanceInfoAppListAppInfo : TeaModel {
                        [NameInMap("AppName")]
                        [Validation(Required=false)]
                        public string AppName { get; set; }

                        [NameInMap("AppArgs")]
                        [Validation(Required=false)]
                        public string AppArgs { get; set; }

                        [NameInMap("AppPath")]
                        [Validation(Required=false)]
                        public string AppPath { get; set; }

                    }

                }
            }
        };

    }

}
